using System;
using System.Drawing;
using DevExpress.Spreadsheet;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Control;

namespace SpreadsheetControl_API {
    public static class PrintingActions {

        public static Action<IWorkbook> PrintAction = Print;

        static void Print(IWorkbook workbook) {

            Worksheet worksheet = workbook.Worksheets[0];

            // Generate worksheet content - the simple multiplication table.
            worksheet.Range["B1:K1"].Formula = "=COLUMN() - 1";
            worksheet.Range["A2:A11"].Formula = "=ROW() - 1";
            Range range = worksheet.Range["B2:K11"];
            range.Formula = "=(ROW()-1)*(COLUMN()-1)";

            // Format headers of the multiplication table.
            Formatting rangeFormatting = worksheet.Range["A1:K1"].BeginUpdateFormatting();
            rangeFormatting.Borders.BottomBorder.LineStyle = BorderLineStyle.Thin;
            rangeFormatting.Borders.BottomBorder.Color = Color.Black;
            worksheet.Range["A1:K1"].EndUpdateFormatting(rangeFormatting);

            rangeFormatting = worksheet.Range["A1:A11"].BeginUpdateFormatting();
            rangeFormatting.Borders.RightBorder.LineStyle = BorderLineStyle.Thin;
            rangeFormatting.Borders.RightBorder.Color = Color.Black;
            worksheet.Range["A1:A11"].EndUpdateFormatting(rangeFormatting);

            #region #WorksheetPrintOptions
            // Access an object providing print options.
            WorksheetPrintOptions printOptions = worksheet.PrintOptions;

            // TODO
            #endregion #WorksheetPrintOptions

            #region #PrintWorkbook
            // Invoke the Print Preview dialog for the workbook.
            using (PrintingSystem printingSystem = new PrintingSystem()) {
                using (PrintableComponentLink link = new PrintableComponentLink(printingSystem)) {
                    link.Component = workbook;
                    link.CreateDocument();
                    link.PrintingSystem.PreviewFormEx.ShowDialog();
                }
            }
            #endregion #PrintWorkbook
        }

    }
}
