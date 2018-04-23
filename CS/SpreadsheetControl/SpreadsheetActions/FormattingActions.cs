using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Spreadsheet;
using System.Drawing;

namespace SpreadsheetControl_API {
    class FormattingActions {
        #region Actions
        public static Action<IWorkbook> CreateModifyApplayStyleAction = CreateModifyApplayStyle;
        public static Action<IWorkbook> FormatCellAction = FormatCell;
        public static Action<IWorkbook> SetDateFormatsAction = SetDateFormats;
        public static Action<IWorkbook> SetNumberFormatsAction = SetNumberFormats;
        public static Action<IWorkbook> ChangeCellColorsAction = ChangeCellColors;
        public static Action<IWorkbook> SpecifyCellFontAction = SpecifyCellFont;
        public static Action<IWorkbook> AlignCellContentsAction = AlignCellContents;
        public static Action<IWorkbook> AddCellBordersAction = AddCellBorders;
        #endregion

        static void CreateModifyApplayStyle(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                #region #CreateNewStyle
                // Add a new style under the "My Style" name to the Styles collection of the workbook.
                Style myStyle = workbook.Styles.Add("My Style");

                // Specify formatting characteristics for the style.
                myStyle.BeginUpdate();
                try {
                    // Set the font color to Blue.
                    myStyle.Font.Color = Color.Blue;

                    // Set the font size to 12.
                    myStyle.Font.Size = 12;

                    // Set the horizontal alignment to Center.
                    myStyle.Alignment.Horizontal = DevExpress.Spreadsheet.HorizontalAlignment.Center;

                    // Set the background.
                    myStyle.Fill.BackgroundColor = Color.LightBlue;
                    myStyle.Fill.PatternType = PatternType.LightGray;
                    myStyle.Fill.PatternColor = Color.Yellow;
                }
                finally {
                    myStyle.EndUpdate();
                }
                #endregion #CreateNewStyle

                #region #DuplicateExistingStyle
                // Add a new style under the "My Good Style" name to the Styles collection.
                Style myGoodStyle = workbook.Styles.Add("My Good Style");

                // Copy all format settings from the built-in Good style.
                myGoodStyle.CopyFrom(BuiltInStyleId.Good);
                #endregion #DuplicateExistingStyle

                #region #ModifyExistingStyle
                // Change the required formatting characteristics of the style.
                myGoodStyle.BeginUpdate();
                try {
                    myGoodStyle.Fill.BackgroundColor = Color.LightYellow;
                }
                finally {
                    myGoodStyle.EndUpdate();
                }
                #endregion #ModifyExistingStyle

                #region #ApplyStyles
                // Access the built-in "Good" MS Excel style from the Styles collection of the workbook.
                Style styleGood = workbook.Styles[BuiltInStyleId.Good];

                // Apply the "Good" style to a range of cells.
                worksheet.Range["A1:C4"].Style = styleGood;

                // Apply the custom style to the cell.
                worksheet.Cells["D6"].Style = myStyle;

                // Apply the custom style to the eighth row.
                worksheet.Rows[7].Style = myGoodStyle;

                // Apply the custom style to the "H" column.
                worksheet.Columns["H"].Style = myGoodStyle;
                #endregion #ApplyStyles
                }
                finally {
                    workbook.EndUpdate();
                }
        }

        static void FormatCell(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {


                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Cells["B2"].Value = "Test";
                worksheet.Range["C3:E6"].Value = "Test";

                #region #CellFormatting
                // Access the cell to be formatted.
                Cell cell = worksheet.Cells["B2"];

                // Specify font settings (font name, color, size and style).
                cell.Font.Name = "MV Boli";
                cell.Font.Color = Color.Blue;
                cell.Font.Size = 14;
                cell.Font.FontStyle = DevExpress.Spreadsheet.FontStyle.Bold;

                // Specify cell background color.
                cell.Fill.BackgroundColor = Color.LightSkyBlue;

                // Specify text alignment in the cell. 
                cell.Alignment.Vertical = VerticalAlignment.Center;
                cell.Alignment.Horizontal = DevExpress.Spreadsheet.HorizontalAlignment.Center;
                #endregion #CellFormatting

                #region #RangeFormatting
                // Access the range of cells to be formatted.
                Range range = worksheet.Range["C3:E6"];

                // Begin updating of the range formatting. 
                Formatting rangeFormatting = range.BeginUpdateFormatting();

                // Specify font settings (font name, color, size and style).
                rangeFormatting.Font.Name = "MV Boli";
                rangeFormatting.Font.Color = Color.Blue;
                rangeFormatting.Font.Size = 14;
                rangeFormatting.Font.FontStyle = DevExpress.Spreadsheet.FontStyle.Bold;

                // Specify cell background color.
                rangeFormatting.Fill.BackgroundColor = Color.LightSkyBlue;

                // Specify text alignment in cells.
                rangeFormatting.Alignment.Vertical = VerticalAlignment.Center;
                rangeFormatting.Alignment.Horizontal = DevExpress.Spreadsheet.HorizontalAlignment.Center;

                // End updating of the range formatting.
                range.EndUpdateFormatting(rangeFormatting);
                #endregion #RangeFormatting
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void SetDateFormats(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Range["A1:F1"].ColumnWidthInCharacters = 15;
                worksheet.Range["A1:F1"].Alignment.Horizontal = HorizontalAlignment.Center;

                worksheet.Range["A1:F1"].Formula = "= Now()";

                // Apply different date display formats.
                worksheet.Cells["A1"].NumberFormat = "m/d/yy";

                worksheet.Cells["B1"].NumberFormat = "d-mmm-yy";

                worksheet.Cells["C1"].NumberFormat = "dddd";

                // Apply different time display formats.
                worksheet.Cells["D1"].NumberFormat = "m/d/yy h:mm";

                worksheet.Cells["E1"].NumberFormat = "h:mm AM/PM";

                worksheet.Cells["F1"].NumberFormat = "h:mm:ss";
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void SetNumberFormats(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {

                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Range["A1:H1"].ColumnWidthInCharacters = 12;
                worksheet.Range["A1:H1"].Alignment.Horizontal = HorizontalAlignment.Center;

                // Display 111 as 111.
                worksheet.Cells["A1"].Value = 111;
                worksheet.Cells["A1"].NumberFormat = "#####";

                // Display 222 as 00222.
                worksheet.Cells["B1"].Value = 222;
                worksheet.Cells["B1"].NumberFormat = "00000";

                // Display 12345678 as 12,345,678.
                worksheet.Cells["C1"].Value = 12345678;
                worksheet.Cells["C1"].NumberFormat = "#,#";

                // Display .126 as 0.13.
                worksheet.Cells["D1"].Value = .126;
                worksheet.Cells["D1"].NumberFormat = "0.##";

                // Display 74.4 as 74.400.
                worksheet.Cells["E1"].Value = 74.4;
                worksheet.Cells["E1"].NumberFormat = "##.000";

                // Display 1.6 as 160.0%.
                worksheet.Cells["F1"].Value = 1.6;
                worksheet.Cells["F1"].NumberFormat = "0.0%";

                // Display 4321 as $4,321.00.
                worksheet.Cells["G1"].Value = 4321;
                worksheet.Cells["G1"].NumberFormat = "$#,##0.00";

                // Display 8.75 as 8 3/4.
                worksheet.Cells["H1"].Value = 8.75;
                worksheet.Cells["H1"].NumberFormat = "# ?/?";
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void ChangeCellColors(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Range["C3:D4"].Merge();
                worksheet.Range["C3:D4"].Value = "Test";
                worksheet.Cells["A1"].Value = "Test";

                // Format an individual cell.
                worksheet.Cells["A1"].Font.Color = Color.Red;
                worksheet.Cells["A1"].FillColor = Color.Yellow;

                // Format a range of cells.
                Range range = worksheet.Range["C3:H10"];
                Formatting rangeFormatting = range.BeginUpdateFormatting();
                rangeFormatting.Font.Color = Color.Blue;
                rangeFormatting.Fill.BackgroundColor = Color.LightBlue;
                range.EndUpdateFormatting(rangeFormatting);
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void SpecifyCellFont(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Cells["A1"].Value = "Font Attributes";
                worksheet.Cells["A1"].ColumnWidthInCharacters = 20;

                // Access the Font object.
                DevExpress.Spreadsheet.Font cellFont = worksheet.Cells["A1"].Font;
                // Set the font name.
                cellFont.Name = "Times New Roman";
                // Set the font size.
                cellFont.Size = 14;
                // Set the font color.
                cellFont.Color = Color.Blue;
                // Format text as bold.
                cellFont.Bold = true;
                // Set font to be underlined.
                cellFont.UnderlineType = UnderlineType.Single;
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void AlignCellContents(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                Range range = worksheet.Range["A1:A4"];
                range.ColumnWidthInCharacters = 30;
                workbook.Unit = DevExpress.Office.DocumentUnit.Inch;
                range.RowHeight = 1;

                // Specify the alignment of cell content.
                Cell cellA1 = worksheet.Cells["A1"];
                cellA1.Value = "Right and top";
                cellA1.Alignment.Horizontal = DevExpress.Spreadsheet.HorizontalAlignment.Right;
                cellA1.Alignment.Vertical = VerticalAlignment.Top;

                Cell cellA2 = worksheet.Cells["A2"];
                cellA2.Value = "Center";
                cellA2.Alignment.Horizontal = DevExpress.Spreadsheet.HorizontalAlignment.Center;
                cellA2.Alignment.Vertical = VerticalAlignment.Center;

                Cell cellA3 = worksheet.Cells["A3"];
                cellA3.Value = "Left and bottom, indent";
                cellA3.Alignment.Indent = 2;

                Cell cellB3 = worksheet.Cells["A4"];
                cellB3.Value = "The Alignment.WrapText property is applied to wrap the text within a cell";
                cellB3.Alignment.WrapText = true;
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void AddCellBorders(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                // Set each particular border for the cell.
                Cell cellB2 = worksheet.Cells["B2"];
                Borders cellB2Borders = cellB2.Borders;
                cellB2Borders.LeftBorder.LineStyle = BorderLineStyle.MediumDashDot;
                cellB2Borders.LeftBorder.Color = Color.Pink;
                cellB2Borders.TopBorder.LineStyle = BorderLineStyle.MediumDashDotDot;
                cellB2Borders.TopBorder.Color = Color.HotPink;
                cellB2Borders.RightBorder.LineStyle = BorderLineStyle.MediumDashed;
                cellB2Borders.RightBorder.Color = Color.DeepPink;
                cellB2Borders.BottomBorder.LineStyle = BorderLineStyle.Medium;
                cellB2Borders.BottomBorder.Color = Color.Red;

                // Set all borders for cells.
                Cell cellC4 = worksheet.Cells["C4"];
                cellC4.Borders.SetAllBorders(Color.Orange, BorderLineStyle.MediumDashed);
                Cell cellD6 = worksheet.Cells["D6"];
                cellD6.Borders.SetOutsideBorders(Color.Gold, BorderLineStyle.Double);

                // Set all borders for the range of cells in one step.
                Range range1 = worksheet.Range["B8:F13"];
                range1.Borders.SetAllBorders(Color.Green, BorderLineStyle.Double);

                // Set all inside and outside borders separately for the range of cells.
                Range range2 = worksheet.Range["C15:F18"];
                range2.SetInsideBorders(Color.SkyBlue, BorderLineStyle.MediumDashed);
                range2.Borders.SetOutsideBorders(Color.DeepSkyBlue, BorderLineStyle.Medium);

                // Set all horizontal and vertical borders separately for the range of cells.
                Range range3 = worksheet.Range["D21:F23"];
                Formatting range3Formatting = range3.BeginUpdateFormatting();
                Borders range3Borders = range3Formatting.Borders;
                range3Borders.InsideHorizontalBorders.LineStyle = BorderLineStyle.MediumDashDot;
                range3Borders.InsideHorizontalBorders.Color = Color.DarkBlue;
                range3Borders.InsideVerticalBorders.LineStyle = BorderLineStyle.MediumDashDotDot;
                range3Borders.InsideVerticalBorders.Color = Color.Blue;
                range3.EndUpdateFormatting(range3Formatting);

                // Set each particular border for the range of cell. 
                Range range4 = worksheet.Range["E25:F26"];
                Formatting range4Formatting = range4.BeginUpdateFormatting();
                Borders range4Borders = range4Formatting.Borders;
                range4Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thick);
                range4Borders.LeftBorder.Color = Color.Violet;
                range4Borders.TopBorder.Color = Color.Violet;
                range4Borders.RightBorder.Color = Color.DarkViolet;
                range4Borders.BottomBorder.Color = Color.DarkViolet;
                range4.EndUpdateFormatting(range4Formatting);

            }
            finally {
                workbook.EndUpdate();
            }
        }

    }
}
