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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
            Me.treeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.spreadsheetNameBoxControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.spreadsheetFormulaBarControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'spreadsheetControl1
            '
            Me.spreadsheetControl1.Location = New System.Drawing.Point(341, 40)
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Culture = New System.Globalization.CultureInfo("en-US")
            Me.spreadsheetControl1.Options.Export.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Export.Txt.ValueSeparator = Global.Microsoft.VisualBasic.ChrW(44)
            Me.spreadsheetControl1.Options.Import.Csv.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Import.Csv.Encoding = CType(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding)
            Me.spreadsheetControl1.Options.Import.Txt.Culture = New System.Globalization.CultureInfo("")
            Me.spreadsheetControl1.Options.Import.Txt.Encoding = CType(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding)
            Me.spreadsheetControl1.Size = New System.Drawing.Size(1012, 834)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            '
            'treeList1
            '
            Me.treeList1.Appearance.FocusedCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
            Me.treeList1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Blue
            Me.treeList1.Appearance.FocusedCell.Options.UseFont = True
            Me.treeList1.Appearance.FocusedCell.Options.UseForeColor = True
            Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.treeListColumn1})
            Me.treeList1.Location = New System.Drawing.Point(12, 12)
            Me.treeList1.Name = "treeList1"
            Me.treeList1.OptionsBehavior.Editable = False
            Me.treeList1.OptionsView.ShowColumns = False
            Me.treeList1.OptionsView.ShowIndicator = False
            Me.treeList1.Size = New System.Drawing.Size(315, 795)
            Me.treeList1.TabIndex = 1
            '
            'treeListColumn1
            '
            Me.treeListColumn1.Caption = "Name"
            Me.treeListColumn1.FieldName = "Name"
            Me.treeListColumn1.Name = "treeListColumn1"
            Me.treeListColumn1.Visible = True
            Me.treeListColumn1.VisibleIndex = 0
            Me.treeListColumn1.Width = 92
            '
            'spreadsheetNameBoxControl1
            '
            Me.spreadsheetNameBoxControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.spreadsheetNameBoxControl1.EditValue = "A1"
            Me.spreadsheetNameBoxControl1.Location = New System.Drawing.Point(341, 12)
            Me.spreadsheetNameBoxControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.spreadsheetNameBoxControl1.Name = "spreadsheetNameBoxControl1"
            Me.spreadsheetNameBoxControl1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.0!)
            Me.spreadsheetNameBoxControl1.Properties.Appearance.Options.UseFont = True
            Me.spreadsheetNameBoxControl1.Properties.AutoHeight = False
            Me.spreadsheetNameBoxControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Down)})
            Me.spreadsheetNameBoxControl1.Size = New System.Drawing.Size(750, 24)
            Me.spreadsheetNameBoxControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetNameBoxControl1.StyleController = Me.LayoutControl1
            Me.spreadsheetNameBoxControl1.TabIndex = 0
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
            Me.LayoutControl1.Controls.Add(Me.spreadsheetControl1)
            Me.LayoutControl1.Controls.Add(Me.spreadsheetFormulaBarControl1)
            Me.LayoutControl1.Controls.Add(Me.spreadsheetNameBoxControl1)
            Me.LayoutControl1.Controls.Add(Me.treeList1)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(641, 158, 650, 400)
            Me.LayoutControl1.Root = Me.Root
            Me.LayoutControl1.Size = New System.Drawing.Size(1365, 886)
            Me.LayoutControl1.TabIndex = 4
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Location = New System.Drawing.Point(12, 811)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(315, 63)
            Me.SimpleButton1.StyleController = Me.LayoutControl1
            Me.SimpleButton1.TabIndex = 4
            Me.SimpleButton1.Text = "Run"
            '
            'spreadsheetFormulaBarControl1
            '
            Me.spreadsheetFormulaBarControl1.Location = New System.Drawing.Point(1095, 12)
            Me.spreadsheetFormulaBarControl1.MinimumSize = New System.Drawing.Size(0, 24)
            Me.spreadsheetFormulaBarControl1.Name = "spreadsheetFormulaBarControl1"
            Me.spreadsheetFormulaBarControl1.Size = New System.Drawing.Size(258, 24)
            Me.spreadsheetFormulaBarControl1.SpreadsheetControl = Me.spreadsheetControl1
            Me.spreadsheetFormulaBarControl1.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem2, Me.SplitterItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(1365, 886)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.treeList1
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(319, 799)
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.spreadsheetNameBoxControl1
            Me.LayoutControlItem3.Location = New System.Drawing.Point(329, 0)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 28)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(162, 28)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(754, 28)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextVisible = False
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.spreadsheetFormulaBarControl1
            Me.LayoutControlItem4.Location = New System.Drawing.Point(1083, 0)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(262, 28)
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.spreadsheetControl1
            Me.LayoutControlItem5.Location = New System.Drawing.Point(329, 28)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(1016, 838)
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.SimpleButton1
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 799)
            Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 67)
            Me.LayoutControlItem2.MinSize = New System.Drawing.Size(187, 67)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(319, 67)
            Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(319, 0)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(10, 866)
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1365, 886)
            Me.Controls.Add(Me.LayoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.spreadsheetNameBoxControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
        Private treeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Private spreadsheetNameBoxControl1 As DevExpress.XtraSpreadsheet.SpreadsheetNameBoxControl
        Private spreadsheetFormulaBarControl1 As DevExpress.XtraSpreadsheet.SpreadsheetFormulaBarControl
        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace

