namespace MebelkiViewForms
{
    partial class BoardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblVaneers = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.cbWUnit = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudHigh = new System.Windows.Forms.NumericUpDown();
            this.cbHUnit = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.lvVaneers = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblDisplayName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPosition, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWidth, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblHigh, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMaterial, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblVaneers, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbPosition, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbMaterial, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lvVaneers, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblColor, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPriceValue, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbColor, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 428);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(3, 6);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(72, 13);
            this.lblDisplayName.TabIndex = 0;
            this.lblDisplayName.Text = "Display Name";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(22, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "[...]";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(3, 31);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position";
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(3, 60);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // lblHigh
            // 
            this.lblHigh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(3, 93);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(29, 13);
            this.lblHigh.TabIndex = 0;
            this.lblHigh.Text = "High";
            // 
            // lblMaterial
            // 
            this.lblMaterial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(3, 122);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material";
            // 
            // lblVaneers
            // 
            this.lblVaneers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblVaneers.AutoSize = true;
            this.lblVaneers.Location = new System.Drawing.Point(3, 286);
            this.lblVaneers.Name = "lblVaneers";
            this.lblVaneers.Size = new System.Drawing.Size(46, 13);
            this.lblVaneers.TabIndex = 0;
            this.lblVaneers.Text = "Vaneers";
            // 
            // tbPosition
            // 
            this.tbPosition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbPosition.Location = new System.Drawing.Point(83, 28);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(287, 20);
            this.tbPosition.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.nudWidth, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbWUnit, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(83, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(287, 27);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // nudWidth
            // 
            this.nudWidth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudWidth.Location = new System.Drawing.Point(3, 3);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(137, 20);
            this.nudWidth.TabIndex = 3;
            // 
            // cbWUnit
            // 
            this.cbWUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbWUnit.Location = new System.Drawing.Point(146, 3);
            this.cbWUnit.Name = "cbWUnit";
            this.cbWUnit.Size = new System.Drawing.Size(138, 21);
            this.cbWUnit.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.nudHigh, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbHUnit, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(83, 86);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(287, 27);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // nudHigh
            // 
            this.nudHigh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHigh.Location = new System.Drawing.Point(3, 3);
            this.nudHigh.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHigh.Name = "nudHigh";
            this.nudHigh.Size = new System.Drawing.Size(137, 20);
            this.nudHigh.TabIndex = 3;
            // 
            // cbHUnit
            // 
            this.cbHUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbHUnit.FormattingEnabled = true;
            this.cbHUnit.Location = new System.Drawing.Point(146, 3);
            this.cbHUnit.Name = "cbHUnit";
            this.cbHUnit.Size = new System.Drawing.Size(138, 21);
            this.cbHUnit.TabIndex = 4;
            // 
            // cbMaterial
            // 
            this.cbMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(83, 119);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(287, 21);
            this.cbMaterial.TabIndex = 6;
            // 
            // lvVaneers
            // 
            this.lvVaneers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvVaneers.Location = new System.Drawing.Point(83, 194);
            this.lvVaneers.MultiSelect = false;
            this.lvVaneers.Name = "lvVaneers";
            this.lvVaneers.Size = new System.Drawing.Size(287, 198);
            this.lvVaneers.TabIndex = 7;
            this.lvVaneers.UseCompatibleStateImageBehavior = false;
            this.lvVaneers.View = System.Windows.Forms.View.List;
            this.lvVaneers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvVaneers_MouseDoubleClick);
            this.lvVaneers.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lvVaneers_PreviewKeyDown);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSave.Location = new System.Drawing.Point(270, 400);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(3, 147);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 0;
            this.lblColor.Text = "Color";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 172);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Location = new System.Drawing.Point(83, 172);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(22, 13);
            this.lblPriceValue.TabIndex = 0;
            this.lblPriceValue.Text = "[...]";
            // 
            // tbColor
            // 
            this.tbColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbColor.Location = new System.Drawing.Point(83, 144);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(287, 20);
            this.tbColor.TabIndex = 9;
            // 
            // BoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BoardControl";
            this.Size = new System.Drawing.Size(373, 428);
            this.Load += new System.EventHandler(this.BoardControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BoardControl_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHigh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblVaneers;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.ComboBox cbWUnit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown nudHigh;
        private System.Windows.Forms.ComboBox cbHUnit;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.ListView lvVaneers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.TextBox tbColor;
    }
}
