namespace SpreadsheetControl_API
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spreadsheetControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.spreadsheetFormulaBarControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl();
            this.spreadsheetNameBoxControl1 = new DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // spreadsheetControl1
            // 
            this.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetControl1.Location = new System.Drawing.Point(0, 29);
            this.spreadsheetControl1.Name = "spreadsheetControl1";
            this.spreadsheetControl1.Options.Culture = new System.Globalization.CultureInfo("en-US");
            this.spreadsheetControl1.Options.Export.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ',';
            this.spreadsheetControl1.Options.Import.Csv.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.Csv.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding")));
            this.spreadsheetControl1.Options.Import.Txt.Culture = new System.Globalization.CultureInfo("");
            this.spreadsheetControl1.Options.Import.Txt.Encoding = ((System.Text.Encoding)(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding")));
            this.spreadsheetControl1.Size = new System.Drawing.Size(1053, 857);
            this.spreadsheetControl1.TabIndex = 0;
            this.spreadsheetControl1.Text = "spreadsheetControl1";
            // 
            // treeList1
            // 
            this.treeList1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue;
            this.treeList1.Appearance.FocusedCell.Options.UseFont = true;
            this.treeList1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.DataSource = null;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.OptionsView.ShowIndicator = false;
            this.treeList1.Size = new System.Drawing.Size(307, 819);
            this.treeList1.TabIndex = 1;
            this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "Name";
            this.treeListColumn1.FieldName = "Name";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 92;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.treeList1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.button1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(307, 886);
            this.splitContainerControl1.SplitterPosition = 819;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.splitContainerControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.spreadsheetControl1);
            this.splitContainerControl2.Panel2.Controls.Add(this.splitterControl1);
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1365, 886);
            this.splitContainerControl2.SplitterPosition = 307;
            this.splitContainerControl2.TabIndex = 3;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // spreadsheetFormulaBarControl1
            // 
            this.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetFormulaBarControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetFormulaBarControl1.MinimumSize = new System.Drawing.Size(0, 24);
            this.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1";
            this.spreadsheetFormulaBarControl1.Size = new System.Drawing.Size(903, 24);
            this.spreadsheetFormulaBarControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetFormulaBarControl1.TabIndex = 0;
            // 
            // spreadsheetNameBoxControl1
            // 
            this.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetNameBoxControl1.EditValue = "A1";
            this.spreadsheetNameBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetNameBoxControl1.MinimumSize = new System.Drawing.Size(0, 20);
            this.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1";
            this.spreadsheetNameBoxControl1.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 11F);
            this.spreadsheetNameBoxControl1.Properties.Appearance.Options.UseFont = true;
            this.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spreadsheetNameBoxControl1.Size = new System.Drawing.Size(145, 24);
            this.spreadsheetNameBoxControl1.SpreadsheetControl = this.spreadsheetControl1;
            this.spreadsheetNameBoxControl1.TabIndex = 0;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.MinimumSize = new System.Drawing.Size(0, 24);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.spreadsheetNameBoxControl1);
            this.splitContainerControl3.Panel2.Controls.Add(this.spreadsheetFormulaBarControl1);
            this.splitContainerControl3.Size = new System.Drawing.Size(1053, 24);
            this.splitContainerControl3.SplitterPosition = 145;
            this.splitContainerControl3.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl1.Location = new System.Drawing.Point(0, 24);
            this.splitterControl1.MinSize = 20;
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(1053, 5);
            this.splitterControl1.TabIndex = 1;
            this.splitterControl1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 886);
            this.Controls.Add(this.splitContainerControl2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetNameBoxControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheetControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl spreadsheetNameBoxControl1;
        private DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl spreadsheetFormulaBarControl1;
    }
}

