Namespace SpreadsheetControl_API
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.button1 = New System.Windows.Forms.Button()
			Me.splitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
			Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
			Me.splitContainerControl3 = New DevExpress.XtraEditors.SplitContainerControl()
			Me.splitterControl1 = New DevExpress.XtraEditors.SplitterControl()
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			DirectCast(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl2.SuspendLayout()
			DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainerControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl3.SuspendLayout()
			Me.SuspendLayout()
			' 
			' spreadsheetControl1
			' 
			Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 29)
			Me.spreadsheetControl1.Name = "spreadsheetControl1"
			Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
			Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = ","c
			Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.Csv.Encoding = (DirectCast(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding))
			Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
			Me.spreadsheetControl1.Options.Import.Txt.Encoding = (DirectCast(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding))
			Me.spreadsheetControl1.Size = New System.Drawing.Size(1053, 857)
			Me.spreadsheetControl1.TabIndex = 0
			Me.spreadsheetControl1.Text = "spreadsheetControl1"
			' 
			' treeList1
			' 
			Me.treeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
			Me.treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue
			Me.treeList1.Appearance.FocusedCell.Options.UseFont = True
			Me.treeList1.Appearance.FocusedCell.Options.UseForeColor = True
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.treeListColumn1})
			Me.treeList1.DataSource = Nothing
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.OptionsView.ShowColumns = False
			Me.treeList1.OptionsView.ShowIndicator = False
			Me.treeList1.Size = New System.Drawing.Size(307, 819)
			Me.treeList1.TabIndex = 1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.treeList1.DoubleClick += new System.EventHandler(this.treeList1_DoubleClick);
			' 
			' treeListColumn1
			' 
			Me.treeListColumn1.Caption = "Name"
			Me.treeListColumn1.FieldName = "Name"
			Me.treeListColumn1.Name = "treeListColumn1"
			Me.treeListColumn1.Visible = True
			Me.treeListColumn1.VisibleIndex = 0
			Me.treeListColumn1.Width = 92
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.Horizontal = False
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.treeList1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.Controls.Add(Me.button1)
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(307, 886)
			Me.splitContainerControl1.SplitterPosition = 819
			Me.splitContainerControl1.TabIndex = 2
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' button1
			' 
			Me.button1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.button1.Location = New System.Drawing.Point(0, 0)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(307, 62)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Run"
			Me.button1.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.button1.Click += new System.EventHandler(this.button1_Click);
			' 
			' splitContainerControl2
			' 
			Me.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl2.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl2.Name = "splitContainerControl2"
			Me.splitContainerControl2.Panel1.Controls.Add(Me.splitContainerControl1)
			Me.splitContainerControl2.Panel1.Text = "Panel1"
			Me.splitContainerControl2.Panel2.Controls.Add(Me.spreadsheetControl1)
			Me.splitContainerControl2.Panel2.Controls.Add(Me.splitterControl1)
			Me.splitContainerControl2.Panel2.Controls.Add(Me.splitContainerControl3)
			Me.splitContainerControl2.Panel2.Text = "Panel2"
			Me.splitContainerControl2.Size = New System.Drawing.Size(1365, 886)
			Me.splitContainerControl2.SplitterPosition = 307
			Me.splitContainerControl2.TabIndex = 3
			Me.splitContainerControl2.Text = "splitContainerControl2"
			' 
			' spreadsheetFormulaBarControl1
			' 
			Me.spreadsheetFormulaBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 24)
			Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
			Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(903, 24)
			Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetFormulaBarControl1.TabIndex = 0
			' 
			' spreadsheetNameBoxControl1
			' 
			Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.spreadsheetNameBoxControl1.EditValue = "A1"
			Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
			Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
			Me.spreadsheetNameBoxControl1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11F)
			Me.spreadsheetNameBoxControl1.Properties.Appearance.Options.UseFont = True
			Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(145, 24)
			Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
			Me.spreadsheetNameBoxControl1.TabIndex = 0
			' 
			' splitContainerControl3
			' 
			Me.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitContainerControl3.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl3.MinimumSize = New System.Drawing.Size(0, 24)
			Me.splitContainerControl3.Name = "splitContainerControl3"
			Me.splitContainerControl3.Panel1.Controls.Add(Me.spreadsheetNameBoxControl1)
			Me.splitContainerControl3.Panel2.Controls.Add(Me.spreadsheetFormulaBarControl1)
			Me.splitContainerControl3.Size = New System.Drawing.Size(1053, 24)
			Me.splitContainerControl3.SplitterPosition = 145
			Me.splitContainerControl3.TabIndex = 2
			' 
			' splitterControl1
			' 
			Me.splitterControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.splitterControl1.Location = New System.Drawing.Point(0, 24)
			Me.splitterControl1.MinSize = 20
			Me.splitterControl1.Name = "splitterControl1"
			Me.splitterControl1.Size = New System.Drawing.Size(1053, 5)
			Me.splitterControl1.TabIndex = 1
			Me.splitterControl1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1365, 886)
			Me.Controls.Add(Me.splitContainerControl2)
			Me.Name = "Form1"
			Me.Text = "Form1"
			DirectCast(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			DirectCast(Me.splitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl2.ResumeLayout(False)
			DirectCast(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitContainerControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl3.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private WithEvents button1 As System.Windows.Forms.Button
		Private splitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
		Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private splitterControl1 As DevExpress.XtraEditors.SplitterControl
		Private splitContainerControl3 As DevExpress.XtraEditors.SplitContainerControl
		Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
		Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
	End Class
End Namespace

