using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using MebelkiLogic;
using MebelkiModel;

namespace MebelkiViewForms
{
    public partial class MainForm : Form
    {
        private readonly int _changableControlIndex;
        private TreeNode _lastSelectedNode;

        public MainForm()
        {
            InitializeComponent();
            _changableControlIndex = tlpMain.Controls.Count;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetLanguage();

            Order.OrderReset();

            PopulateData();

            //prepare dialogs
            saveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }

        private void SetLanguage()
        {
            var ci = CultureInfo.GetCultureInfo("en-GB");
            if (englishToolStripMenuItem.Checked)
                ci = CultureInfo.GetCultureInfo("en-GB");
            if (polishToolStripMenuItem.Checked)
                ci = CultureInfo.GetCultureInfo("pl-PL");
            SetLocalization(ci);
        }

        private void SetLocalization(CultureInfo ci)
        {
            Thread.CurrentThread.CurrentCulture = ci;
            var resMen = new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly);

            //File
            lblFurniture.Text = resMen.GetString("lblFurniture", ci);
            fileToolStripMenuItem.Text = resMen.GetString("file", ci);
            newToolStripMenuItem.Text = resMen.GetString("_new", ci);
            openToolStripMenuItem.Text = resMen.GetString("open", ci);
            saveToolStripMenuItem.Text = resMen.GetString("save", ci);
            exitToolStripMenuItem.Text = resMen.GetString("exit", ci);

            //Print
            printToolStripMenuItem.Text = resMen.GetString("print", ci);
            printReportToolStripMenuItem.Text = resMen.GetString("printReport", ci);
            previewToolStripMenuItem.Text = resMen.GetString("preview", ci);

            //Langauge
            languageToolStripMenuItem.Text = resMen.GetString("language", ci);
            englishToolStripMenuItem.Text = resMen.GetString("english", ci);
            polishToolStripMenuItem.Text = resMen.GetString("polish", ci);
            
            //Help
            helpToolStripMenuItem.Text = resMen.GetString("help", ci);
            helpToolStripMenuItem1.Text = resMen.GetString("help", ci);
            aboutToolStripMenuItem.Text = resMen.GetString("about", ci);

            //Labels
            lblFurniture.Text = resMen.GetString("lblFurniture", ci);
            lblDetails.Text = resMen.GetString("details", ci);
            lblClient.Text = resMen.GetString("client", ci);

            //ContextMenu
            cmiNewFurniture.Text = resMen.GetString("addNewFurniture", ci);
            cmiCopyFurniture.Text = resMen.GetString("copyFurniture", ci);
            cmiDelFurniture.Text = resMen.GetString("deleteFurniture", ci);
            cmiAddBoard.Text = resMen.GetString("addNewBoard", ci);
            cmiNewBoard.Text = resMen.GetString("addNewBoard", ci);
            cmiCopyBoard.Text = resMen.GetString("copyBoard", ci);
            cmiDelBoard.Text = resMen.GetString("deleteBoard", ci);

            //Control
            if (tlpMain.Controls.Count > _changableControlIndex) tlpMain.Controls[_changableControlIndex].Refresh();
        }

        public void PopulateData(bool isReselect = false)
        {
            TreeNode selectedNode = null;
            if (isReselect && treeView1.SelectedNode != null)
                selectedNode = treeView1.SelectedNode;

            tbClient.Text = Order.Client;

            treeView1.UseWaitCursor = true;
            treeView1.Cursor = Cursors.WaitCursor;

            treeView1.BeginUpdate();
            treeView1.Nodes.Clear();

            treeView1.Nodes.AddRange(
                Order.FurnitureList.Select(
                    n => new TreeNode(n.Name, n.Boards.Select(b => new TreeNode(b.ToString())).ToArray())).ToArray());

            treeView1.Cursor = DefaultCursor;
            treeView1.UseWaitCursor = false;

            if (selectedNode != null)
                treeView1.SelectedNode = selectedNode.Parent == null
                    ? treeView1.Nodes[selectedNode.Index]
                    : treeView1.Nodes[selectedNode.Parent.Index].Nodes[selectedNode.Index];
            treeView1.EndUpdate();

            foreach (TreeNode node in treeView1.Nodes)
            {
                node.ContextMenuStrip = cmFurniture;
                foreach (TreeNode childNode in node.Nodes)
                {
                    childNode.ContextMenuStrip = cmBoard;
                }
            }
        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order.FurnitureList.Clear();
            Order.MaterialList.Clear();
            
            //Order.Test();
            //Order.OrderReset();

            PopulateData();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _lastSelectedNode = e.Node;
            LoadControl(e.Node);
        }

        private void LoadControl(TreeNode node)
        {
            if (tlpMain.Controls.Count > _changableControlIndex) tlpMain.Controls.RemoveAt(_changableControlIndex);

            if (node.Level == 0)
            {
                var ctrl = new FurnitureControl(node.Index)
                {
                    Dock = DockStyle.Fill,
                    Name = typeof(FurnitureControl).ToString()
                };
                
                tlpMain.Controls.Add(ctrl);
            }
            else if (node.Level == 1)
            {
                var ctrl = new BoardControl(node.Parent.Index, node.Index)
                {
                    Dock = DockStyle.Fill,
                    Name = typeof(BoardControl).ToString()
                };
                tlpMain.Controls.Add(ctrl);
            }
        }

        private void materialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MaterialsDialog().ShowDialog();
        }

        private void tbClient_Leave(object sender, EventArgs e)
        {
            Order.Client = tbClient.Text;
        }

        private void cmiNewFurniture_Click(object sender, EventArgs e)
        {
            Order.FurnitureAddNew();
            treeView1.SelectedNode = _lastSelectedNode;
            PopulateData(true);
        }

        private void cmiAddBoard_Click(object sender, EventArgs e)
        {
            var index = _lastSelectedNode.Level == 0
                ? _lastSelectedNode.Index
                : _lastSelectedNode.Parent.Index;
            Order.BoardAddNew(index);
            treeView1.SelectedNode = _lastSelectedNode;
            PopulateData(true);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                _lastSelectedNode = e.Node;
        }

        private void cmiDelFurniture_Click(object sender, EventArgs e)
        {
            if (Order.FurnitureList.Count == 1) return;
            Order.FurnitureList.RemoveAt(_lastSelectedNode.Index);
            PopulateData();
        }

        private void cmiDelBoard_Click(object sender, EventArgs e)
        {
            Order.FurnitureList[_lastSelectedNode.Parent.Index].Boards.RemoveAt(_lastSelectedNode.Index);
            PopulateData();
        }

        private void cmiCopyFurniture_Click(object sender, EventArgs e)
        {
            Order.FurnitureList.Add(new Furniture(Order.FurnitureList[_lastSelectedNode.Index]));
            PopulateData(true);
        }

        private void cmiCopyBoard_Click(object sender, EventArgs e)
        {
            Order.FurnitureList[_lastSelectedNode.Parent.Index].Boards.Add(
                new Board(Order.FurnitureList[_lastSelectedNode.Parent.Index].Boards[_lastSelectedNode.Index]));
            PopulateData(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Order.Client + ".xml";

            try
            {
                var result = saveFileDialog1.ShowDialog();
                if (result != DialogResult.OK) return;
                FileManager.SaveFile(Order.GetSingleton(),saveFileDialog1.OpenFile());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = openFileDialog1.ShowDialog();
                if (result != DialogResult.OK) return;
                OrderSingleton o = FileManager.OpenFile(openFileDialog1.OpenFile());
                if (o == null) return;
                Order.ReadSingleton(o);
                PopulateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            var reportDoc = new ReportDocument(Order.GetSingleton(), new ResourceManager("MebelkiViewForms.Resource.res", typeof(MainForm).Assembly));
            printPreviewDialog1.Document = reportDoc;
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                reportDoc.Print();
            }
            
        }
    }
}
