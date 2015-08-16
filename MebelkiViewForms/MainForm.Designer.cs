using System.Windows.Forms;

namespace MebelkiViewForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblFurniture = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFurniture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNewFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCopyFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDelFurniture = new System.Windows.Forms.ToolStripMenuItem();
            this.ssFurnititure = new System.Windows.Forms.ToolStripSeparator();
            this.cmiAddBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.cmBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiNewBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiCopyBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiDelBoard = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.tlpMain.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.cmFurniture.SuspendLayout();
            this.cmBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.44828F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.55172F));
            this.tlpMain.Controls.Add(this.treeView1, 0, 2);
            this.tlpMain.Controls.Add(this.lblFurniture, 0, 1);
            this.tlpMain.Controls.Add(this.lblDetails, 1, 1);
            this.tlpMain.Controls.Add(this.lblClient, 0, 0);
            this.tlpMain.Controls.Add(this.tbClient, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 24);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.835165F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.16483F));
            this.tlpMain.Size = new System.Drawing.Size(870, 431);
            this.tlpMain.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 47);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(285, 381);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // lblFurniture
            // 
            this.lblFurniture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFurniture.AutoSize = true;
            this.lblFurniture.Location = new System.Drawing.Point(3, 31);
            this.lblFurniture.Name = "lblFurniture";
            this.lblFurniture.Size = new System.Drawing.Size(48, 13);
            this.lblFurniture.TabIndex = 1;
            this.lblFurniture.Text = "Furniture";
            // 
            // lblDetails
            // 
            this.lblDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(294, 31);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(39, 13);
            this.lblDetails.TabIndex = 2;
            this.lblDetails.Text = "Details";
            // 
            // lblClient
            // 
            this.lblClient.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(3, 6);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 1;
            this.lblClient.Text = "Client";
            // 
            // tbClient
            // 
            this.tbClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClient.Location = new System.Drawing.Point(294, 3);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(573, 20);
            this.tbClient.TabIndex = 3;
            this.tbClient.Leave += new System.EventHandler(this.tbClient_Leave);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.materialsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(870, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printReportToolStripMenuItem,
            this.previewToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printReportToolStripMenuItem
            // 
            this.printReportToolStripMenuItem.Name = "printReportToolStripMenuItem";
            this.printReportToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.printReportToolStripMenuItem.Text = "Print Report";
            this.printReportToolStripMenuItem.Click += new System.EventHandler(this.printReportToolStripMenuItem_Click);
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.previewToolStripMenuItem.Text = "Preview";
            this.previewToolStripMenuItem.Click += new System.EventHandler(this.previewToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Checked = true;
            this.polishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.polishToolStripMenuItem.Text = "Polish";
            // 
            // materialsToolStripMenuItem
            // 
            this.materialsToolStripMenuItem.Name = "materialsToolStripMenuItem";
            this.materialsToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.materialsToolStripMenuItem.Text = "Edit Materials";
            this.materialsToolStripMenuItem.Click += new System.EventHandler(this.materialsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // cmFurniture
            // 
            this.cmFurniture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNewFurniture,
            this.cmiCopyFurniture,
            this.cmiDelFurniture,
            this.ssFurnititure,
            this.cmiAddBoard});
            this.cmFurniture.Name = "cmFurniture";
            this.cmFurniture.Size = new System.Drawing.Size(171, 98);
            // 
            // cmiNewFurniture
            // 
            this.cmiNewFurniture.Name = "cmiNewFurniture";
            this.cmiNewFurniture.Size = new System.Drawing.Size(170, 22);
            this.cmiNewFurniture.Text = "Add new furniture";
            this.cmiNewFurniture.Click += new System.EventHandler(this.cmiNewFurniture_Click);
            // 
            // cmiCopyFurniture
            // 
            this.cmiCopyFurniture.Name = "cmiCopyFurniture";
            this.cmiCopyFurniture.Size = new System.Drawing.Size(170, 22);
            this.cmiCopyFurniture.Text = "Copy furniture";
            this.cmiCopyFurniture.Click += new System.EventHandler(this.cmiCopyFurniture_Click);
            // 
            // cmiDelFurniture
            // 
            this.cmiDelFurniture.Name = "cmiDelFurniture";
            this.cmiDelFurniture.Size = new System.Drawing.Size(170, 22);
            this.cmiDelFurniture.Text = "Delete furniture";
            this.cmiDelFurniture.Click += new System.EventHandler(this.cmiDelFurniture_Click);
            // 
            // ssFurnititure
            // 
            this.ssFurnititure.Name = "ssFurnititure";
            this.ssFurnititure.Size = new System.Drawing.Size(167, 6);
            // 
            // cmiAddBoard
            // 
            this.cmiAddBoard.Name = "cmiAddBoard";
            this.cmiAddBoard.Size = new System.Drawing.Size(170, 22);
            this.cmiAddBoard.Text = "Add new board";
            this.cmiAddBoard.Click += new System.EventHandler(this.cmiAddBoard_Click);
            // 
            // cmBoard
            // 
            this.cmBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiNewBoard,
            this.cmiCopyBoard,
            this.cmiDelBoard});
            this.cmBoard.Name = "cmBoard";
            this.cmBoard.Size = new System.Drawing.Size(156, 70);
            // 
            // cmiNewBoard
            // 
            this.cmiNewBoard.Name = "cmiNewBoard";
            this.cmiNewBoard.Size = new System.Drawing.Size(155, 22);
            this.cmiNewBoard.Text = "Add new board";
            this.cmiNewBoard.Click += new System.EventHandler(this.cmiAddBoard_Click);
            // 
            // cmiCopyBoard
            // 
            this.cmiCopyBoard.Name = "cmiCopyBoard";
            this.cmiCopyBoard.Size = new System.Drawing.Size(155, 22);
            this.cmiCopyBoard.Text = "Copy board";
            this.cmiCopyBoard.Click += new System.EventHandler(this.cmiCopyBoard_Click);
            // 
            // cmiDelBoard
            // 
            this.cmiDelBoard.Name = "cmiDelBoard";
            this.cmiDelBoard.Size = new System.Drawing.Size(155, 22);
            this.cmiDelBoard.Text = "Delete board";
            this.cmiDelBoard.Click += new System.EventHandler(this.cmiDelBoard_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "Extensible Markup Language (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Extensible Markup Language (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.MainMenuStrip = this.menuStrip;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 455);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Mebelki";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.cmFurniture.ResumeLayout(false);
            this.cmBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblFurniture;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblDetails;
        private ToolStripMenuItem materialsToolStripMenuItem;
        private Label lblClient;
        private TextBox tbClient;
        private ContextMenuStrip cmFurniture;
        private ToolStripMenuItem cmiNewFurniture;
        private ToolStripMenuItem cmiCopyFurniture;
        private ToolStripMenuItem cmiDelFurniture;
        private ToolStripSeparator ssFurnititure;
        private ToolStripMenuItem cmiAddBoard;
        private ContextMenuStrip cmBoard;
        private ToolStripMenuItem cmiNewBoard;
        private ToolStripMenuItem cmiCopyBoard;
        private ToolStripMenuItem cmiDelBoard;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private ToolStripMenuItem printToolStripMenuItem;
        private PrintDialog printDialog1;
        private ToolStripMenuItem printReportToolStripMenuItem;
        private PrintPreviewDialog printPreviewDialog1;
        private ToolStripMenuItem previewToolStripMenuItem;
    }
}

