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
using MebelkiModel;
using MebelkiModel.Basic.Enums;

namespace MebelkiViewForms
{
    public partial class VaneerDialog : Form
    {
        public Vaneer Van;

        public VaneerDialog(Vaneer van)
        {
            Van = van;
            InitializeComponent();
            SetLocalization();
            LoadContent();
        }

        private void LoadContent()
        {
            tbPrice.Text = Van.PriceLm.ToString(Thread.CurrentThread.CurrentCulture);
            cbSide.Items.AddRange(new object[] {Side.Height1, Side.Height2, Side.Width1, Side.Width2});
            cbSide.SelectedItem = Van.Side;
            Text = Van.ToString();
        }

        private void SetLocalization()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            lblPrice.Text = resMen.GetString("pricelm", ci);
            lblSide.Text = resMen.GetString("side", ci);
            lblCurrency.Text = resMen.GetString("currency", ci);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Van.Side = (Side) cbSide.SelectedItem;
            try
            {
                Van.PriceLm = double.Parse(tbPrice.Text,Thread.CurrentThread.CurrentCulture);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.Close();
        }

        private void VaneerDialog_Paint(object sender, PaintEventArgs e)
        {
            cbSide.SelectionLength = 0;
        }

        private void VaneerDialog_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    DialogResult = DialogResult.OK;
                    btnOK_Click(sender, e);
                    break;
                case Keys.Escape:
                    DialogResult = DialogResult.Cancel;
                    this.Close();
                    break;
            }
        }
    }
}
