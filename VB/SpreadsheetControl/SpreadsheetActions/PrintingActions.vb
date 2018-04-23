Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.Spreadsheet
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Control

Namespace SpreadsheetControl_API
	Public NotInheritable Class PrintingActions

        Public Shared PrintAction As Action(Of IWorkbook) = AddressOf Print

		Private Sub New()
		End Sub
		Private Shared Sub Print(ByVal workbook As IWorkbook)

			Dim worksheet As Worksheet = workbook.Worksheets(0)

			' Generate worksheet content - the simple multiplication table.
			worksheet.Range("B1:K1").Formula = "=COLUMN() - 1"
			worksheet.Range("A2:A11").Formula = "=ROW() - 1"
			Dim range As Range = worksheet.Range("B2:K11")
			range.Formula = "=(ROW()-1)*(COLUMN()-1)"

			' Format headers of the multiplication table.
			Dim rangeFormatting As Formatting = worksheet.Range("A1:K1").BeginUpdateFormatting()
			rangeFormatting.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin
			rangeFormatting.Borders.BottomBorder.Color = Color.Black
			worksheet.Range("A1:K1").EndUpdateFormatting(rangeFormatting)

			rangeFormatting = worksheet.Range("A1:A11").BeginUpdateFormatting()
			rangeFormatting.Borders.RightBorder.LineStyle = BorderLineStyle.Thin
			rangeFormatting.Borders.RightBorder.Color = Color.Black
			worksheet.Range("A1:A11").EndUpdateFormatting(rangeFormatting)

'			#Region "#WorksheetPrintOptions"
			' Access an object providing print options.
			Dim printOptions As WorksheetPrintOptions = worksheet.PrintOptions

			' TODO
'			#End Region ' #WorksheetPrintOptions

'			#Region "#PrintWorkbook"
			' Invoke the Print Preview dialog for the workbook.
			Using printingSystem As New PrintingSystem()
				Using link As New PrintableComponentLink(printingSystem)
					link.Component = workbook
					link.CreateDocument()
					link.PrintingSystem.PreviewFormEx.ShowDialog()
				End Using
			End Using
'			#End Region ' #PrintWorkbook
		End Sub

	End Class
End Namespace
