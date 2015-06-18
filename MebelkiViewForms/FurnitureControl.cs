using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MebelkiLogic;

namespace MebelkiViewForms
{
    public partial class FurnitureControl : UserControl
    {
        private int _index;

        public FurnitureControl(int index)
        {
            this._index = index;
            InitializeComponent();
            LoadContent(index);
        }

        private void SetLocalization()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            lblName.Text = resMen.GetString("name", ci);
            lblBoards.Text = resMen.GetString("boards", ci);
        }

        private void FurnitureControl_Load(object sender, EventArgs e)
        {
            SetLocalization();
        }

        private void LoadContent(int index)
        {
            List<string> boardList;
            string text;
            Order.LoadFurniture(index, out text, out boardList);
            tbName.Text = text;
            lvBoards.Items.AddRange(boardList.Select(b => new ListViewItem(b)).ToArray());
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            var test = e.ToString();
            Order.FurnitureList[_index].Name = ((Control) sender).Text;
            ((MainForm) this.ParentForm)?.PopulateData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvBoards.SelectedIndices.Count == 0) return;
            foreach (int selectedIndex in lvBoards.SelectedIndices)
            {
                Order.FurnitureList[_index].Boards.RemoveAt(selectedIndex);
                lvBoards.Items.RemoveAt(selectedIndex);
            }
            ((MainForm)this.ParentForm)?.PopulateData();
        }

        private void lvBoards_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            btnRemove.Enabled = e.IsSelected;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Order.BoardAddNew(_index);
            ((MainForm)this.ParentForm)?.PopulateData(true);
        }
    }
}
