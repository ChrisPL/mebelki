using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MebelkiLogic;
using MebelkiModel;
using MebelkiModel.Basic;
using MebelkiModel.Basic.Enums;

namespace MebelkiViewForms
{
    public partial class MaterialsDialog : Form
    {
        private string _addNew;
        public MaterialsDialog()
        {
            InitializeComponent();
            SetLocalization();
            LoadList();
            LoadContent();
        }

        private void SetLocalization()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            lblPrice.Text = resMen.GetString("pricesm", ci);
            lblName.Text = resMen.GetString("name", ci);
            lblCurrency.Text = resMen.GetString("currency", ci);
            lblThick.Text = resMen.GetString("thickness", ci);

            _addNew = resMen.GetString("_addNew", ci);
        }

        private void LoadList()
        {
            if (Order.MaterialList.All(m => m.Name != _addNew))
                Order.MaterialList.Add(new Material(_addNew, new LengthMeasure(0), 0));

            var index = lvMaterials.SelectedIndices.Count > 0 ? lvMaterials.SelectedIndices[0] : 0;
            lvMaterials.Items.Clear();
            lvMaterials.Items.AddRange(Order.MaterialList.Select(m => new ListViewItem(m.Name)).ToArray());
            lvMaterials.SelectedIndices.Add(index);
        }

        private void LoadContent()
        {
            var index = lvMaterials.SelectedIndices.Count > 0 ? lvMaterials.SelectedIndices[0] : 0;
            cbUnit.Items.Clear();
            cbUnit.Items.AddRange(new object[]
            {LengthUnit.km, LengthUnit.dm, LengthUnit.m, LengthUnit.cm, LengthUnit.mm});
            cbUnit.SelectedItem = Order.MaterialList[index].Thick.Unit;
            tbName.Text = Order.MaterialList[index].Name;
            tbPrice.Text = Order.MaterialList[index].PriceSm.ToString(Thread.CurrentThread.CurrentCulture);
            nudThick.Value = (decimal)Order.MaterialList[index].Thick.Value;
        }

        private void SaveMaterial()
        {
            if (lvMaterials.SelectedIndices.Count == 0) return;
            var mat = Order.MaterialList[lvMaterials.SelectedIndices[0]];
            mat.Name = tbName.Text;
            try
            {
                mat.PriceSm = double.Parse(tbPrice.Text, Thread.CurrentThread.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mat.Thick.Unit = (LengthUnit)cbUnit.SelectedItem;
            mat.Thick.Value = (double)nudThick.Value;

            if (Order.MaterialList.All(m => m.Name != _addNew))
                Order.MaterialList.Add(new Material(_addNew, new LengthMeasure(0), 0));
        }


        private void MaterialsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            Order.MaterialList.RemoveAll(m => m.Name == _addNew);
        }

        private void lvMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveMaterial();
            LoadList();
        }
    }
}
