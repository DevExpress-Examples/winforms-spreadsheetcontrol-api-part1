Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet

Namespace SpreadsheetControl_API
	Public NotInheritable Class CellActions
		#Region "Actions"
        Public Shared ChangeCellValueAction As Action(Of IWorkbook) = AddressOf ChangeCellValue
        Public Shared AddHyperlinkAction As Action(Of IWorkbook) = AddressOf AddHyperlink
        Public Shared CopyCellDataAndStyleAction As Action(Of IWorkbook) = AddressOf CopyCellDataAndStyle
        Public Shared MergeAndSplitCellsAction As Action(Of IWorkbook) = AddressOf MergeAndSplitCells
		#End Region

		Private Sub New()
		End Sub
		Private Shared Sub ChangeCellValue(ByVal workbook As IWorkbook)
			workbook.BeginUpdate()
			Try
				Dim worksheet As Worksheet = workbook.Worksheets(0)

				worksheet.Cells("A1").Value = "dateTime:"
				worksheet.Cells("A2").Value = "double:"
				worksheet.Cells("A3").Value = "string:"
				worksheet.Cells("A4").Value = "error constant:"
				worksheet.Cells("A5").Value = "boolean:"
				worksheet.Cells("A6").Value = "float:"
				worksheet.Cells("A7").Value = "char:"
				worksheet.Cells("A8").Value = "int32:"
				worksheet.Cells("A10").Value = "Fill a range of cells:"
				worksheet.Columns("A").WidthInCharacters = 20
				worksheet.Columns("B").WidthInCharacters = 20
				worksheet.Range("A1:B8").Alignment.Horizontal = HorizontalAlignment.Left

				' Add data of different types to cells.
				worksheet.Cells("B1").Value = DateTime.Now
				worksheet.Cells("B1").NumberFormat = "m/d/yy"
				worksheet.Cells("B2").Value = Math.PI
				worksheet.Cells("B3").Value = "Have a nice day!"
				worksheet.Cells("B4").Value = CellValue.ErrorReference
				worksheet.Cells("B5").Value = True
				worksheet.Cells("B6").Value = Single.MaxValue
				worksheet.Cells("B7").Value = "a"c
				worksheet.Cells("B8").Value = Int32.MaxValue

				' Fill all cells in the range with 10.
				worksheet.Range("B10:E10").Value = 10
			Finally
				workbook.EndUpdate()
			End Try

		End Sub

		Private Shared Sub AddHyperlink(ByVal workbook As IWorkbook)
			workbook.BeginUpdate()
			Try
				Dim worksheet As Worksheet = workbook.Worksheets(0)
				worksheet.Range("A:C").ColumnWidthInCharacters = 12

				' Create a hyperlink to a web page.
				Dim cell As Cell = worksheet.Cells("A1")
				worksheet.Hyperlinks.Add(cell, "http://www.devexpress.com/", True, "DevExpress")

				' Create a hyperlink to a cell range in a workbook.
				Dim range As Range = worksheet.Range("C3:D4")
				Dim cellHyperlink As Hyperlink = worksheet.Hyperlinks.Add(range, "Sheet2!B2:E7", False, "Select Range")
				cellHyperlink.TooltipText = "Click Me"
			Finally
				workbook.EndUpdate()
			End Try
		End Sub

		Private Shared Sub CopyCellDataAndStyle(ByVal workbook As IWorkbook)
			workbook.BeginUpdate()
			Try
				Dim worksheet As Worksheet = workbook.Worksheets(0)
				worksheet.Columns("A").WidthInCharacters = 32
				worksheet.Columns("B").WidthInCharacters = 20
				Dim style As Style = workbook.Styles(BuiltInStyleId.Input)

				' Specify the content and formatting for a source cell.
				worksheet.Cells("A1").Value = "Source Cell"

				Dim sourceCell As Cell = worksheet.Cells("B1")
				sourceCell.Formula = "= PI()"
				sourceCell.NumberFormat = "0.0000"
				sourceCell.Style = style
				sourceCell.Font.Color = Color.Blue
				sourceCell.Font.Bold = True
				sourceCell.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin)

				' Copy all information from the source cell to the "B3" cell. 
				worksheet.Cells("A3").Value = "Copy All"
				worksheet.Cells("B3").CopyFrom(sourceCell)

				' Copy only the source cell content (e.g., text, numbers, formula calculated values) to the "B4" cell.
				worksheet.Cells("A4").Value = "Copy Values"
				worksheet.Cells("B4").CopyFrom(sourceCell, PasteSpecial.Values)

				' Copy the source cell content (e.g., text, numbers, formula calculated values) 
				' and number formats to the "B5" cell.
				worksheet.Cells("A5").Value = "Copy Values and Number Formats"
				worksheet.Cells("B5").CopyFrom(sourceCell, PasteSpecial.Values Or PasteSpecial.NumberFormats)

				' Copy only the formatting information from the source cell to the "B6" cell.
				worksheet.Cells("A6").Value = "Copy Formats"
				worksheet.Cells("B6").CopyFrom(sourceCell, PasteSpecial.Formats)

				' Copy all information from the source cell to the "B7" cell except for border settings.
				worksheet.Cells("A7").Value = "Copy All Except Borders"
				worksheet.Cells("B7").CopyFrom(sourceCell, PasteSpecial.All And (Not PasteSpecial.Borders))

				' Copy information only about borders from the source cell to the "B8" cell.
				worksheet.Cells("A8").Value = "Copy Borders"
				worksheet.Cells("B8").CopyFrom(sourceCell, PasteSpecial.Borders)
			Finally
				workbook.EndUpdate()
			End Try
		End Sub

		Private Shared Sub MergeAndSplitCells(ByVal workbook As IWorkbook)
			workbook.BeginUpdate()
			Try
				Dim worksheet As Worksheet = workbook.Worksheets(0)

				worksheet.Cells("A1").FillColor = Color.LightGray

				worksheet.Cells("B2").Value = "B2"
				worksheet.Cells("B2").FillColor = Color.LightGreen

				worksheet.Cells("C3").Value = "C3"
				worksheet.Cells("C3").FillColor = Color.LightSalmon

				' Merge cells contained in the range.
				worksheet.MergeCells(worksheet.Range("A1:C5"))
			Finally
				workbook.EndUpdate()
			End Try
		End Sub
	End Class
End Namespace
