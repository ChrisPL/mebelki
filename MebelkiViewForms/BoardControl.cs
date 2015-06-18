using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Windows.Forms;
using MebelkiLogic;
using MebelkiModel;
using MebelkiModel.Basic.Enums;

namespace MebelkiViewForms
{
    public partial class BoardControl : UserControl
    {
        private int _fIndex;
        private int _bIndex;
        public BoardControl(int fIndex, int bIndex)
        {
            _fIndex = fIndex;
            _bIndex = bIndex;
            InitializeComponent();
            LoadContent();
        }

        private void LoadContent()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            string name;
            string position;
            object[] units;
            object wUnit;
            object hUnit;
            decimal wValue;
            decimal hValue;
            object material;
            List<string> vList;
            string color;
            double price;
            Order.LoadBoard(
                _fIndex
                , _bIndex
                , out name
                , out position
                , out units
                , out wUnit
                , out hUnit
                , out wValue
                , out hValue
                , out material
                , out color
                , out vList
                , out price);
            lblName.Text = name;
            tbPosition.Text = position;
            cbHUnit.Items.AddRange(units);
            cbWUnit.Items.AddRange(units);
            cbWUnit.SelectedItem = wUnit;
            cbHUnit.SelectedItem = hUnit;
            nudHigh.Value = hValue;
            nudWidth.Value = wValue;
            cbMaterial.Items.AddRange(Order.MaterialList.ToArray());
            cbMaterial.SelectedItem = material;
            tbColor.Text = color;
            lvVaneers.Items.Clear();
            lvVaneers.Items.AddRange(vList.Select(v => new ListViewItem(v)).ToArray());
            while (lvVaneers.Items.Count < 4)
                lvVaneers.Items.Add(resMen.GetString("_addNew", ci));
            lblPriceValue.Text = price.ToString(Thread.CurrentThread.CurrentCulture);
        }

        private void SetLocalization()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            lblDisplayName.Text = resMen.GetString("displayName", ci);
            lblHigh.Text = resMen.GetString("high", ci);
            lblWidth.Text = resMen.GetString("width", ci);
            lblMaterial.Text = resMen.GetString("material", ci);
            lblPosition.Text = resMen.GetString("position", ci);
            lblVaneers.Text = resMen.GetString("vaneers", ci);
            btnSave.Text = resMen.GetString("save", ci);
            lblColor.Text = resMen.GetString("color", ci);
            lblPrice.Text = resMen.GetString("price", ci);
        }

        private void BoardControl_Load(object sender, EventArgs e)
        {
            SetLocalization();
        }

        private void BoardControl_Paint(object sender, PaintEventArgs e)
        {
            cbMaterial.SelectionLength = 0;
            cbHUnit.SelectionLength = 0;
            cbWUnit.SelectionLength = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var board = Order.FurnitureList[_fIndex].Boards[_bIndex];
            board.Position = tbPosition.Text;
            board.High.Unit = (LengthUnit) cbHUnit.SelectedItem;
            board.Width.Unit = (LengthUnit) cbWUnit.SelectedItem;
            board.High.Value = (double) nudHigh.Value;
            board.Width.Value = (double) nudWidth.Value;
            board.Material = (Material) cbMaterial.SelectedItem;
            board.FrontColor = tbColor.Text;
            var tmpV = board.GetVaneers();
            tmpV.ForEach(
                v => v.Length = (v.Side == Side.Height1 || v.Side == Side.Height2)
                ? Order.FurnitureList[_fIndex].Boards[_bIndex].High.ValueMeter
                : Order.FurnitureList[_fIndex].Boards[_bIndex].Width.ValueMeter);
            board.ClearVaneers();
            board.VaneersAddRange(tmpV);
            lblPriceValue.Text = board.GetPrice().ToString(Thread.CurrentThread.CurrentCulture);

            ((MainForm) this.ParentForm)?.PopulateData(true);
            
        }

        private void lvVaneers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowVaneerDialog();
        }

        private void lvVaneers_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            ShowVaneerDialog();
        }

        private void ShowVaneerDialog()
        {
            if (lvVaneers.SelectedIndices.Count == 0) return;
            int vindex = lvVaneers.SelectedIndices[0];
            var vaneer = vindex >= Order.FurnitureList[_fIndex].Boards[_bIndex].GetVaneers().Count
                ? new Vaneer()
                : new Vaneer(Order.FurnitureList[_fIndex].Boards[_bIndex].GetVaneers()[vindex]);

            using (VaneerDialog vDialog = new VaneerDialog(vaneer))
            {
                var result = vDialog.ShowDialog();
                if (result != DialogResult.OK) return;

                vaneer = vDialog.Van;
                vaneer.Length = (vaneer.Side == Side.Height1 || vaneer.Side == Side.Height2)
                    ? Order.FurnitureList[_fIndex].Boards[_bIndex].High.ValueMeter
                    : Order.FurnitureList[_fIndex].Boards[_bIndex].Width.ValueMeter;

                try
                {
                    if (vindex >= Order.FurnitureList[_fIndex].Boards[_bIndex].GetVaneers().Count)
                        Order.FurnitureList[_fIndex].Boards[_bIndex].VaneersAdd(vaneer);
                    else
                        Order.FurnitureList[_fIndex].Boards[_bIndex].VaneersReplace(vindex, vaneer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                this.UseWaitCursor = true;
                LoadContent();
                this.Refresh();
                this.UseWaitCursor = false;
            }
        }
    }
}
