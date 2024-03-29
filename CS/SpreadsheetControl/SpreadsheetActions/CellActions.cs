﻿using System;
using System.Drawing;
using DevExpress.Spreadsheet;

namespace SpreadsheetControl_API {
    public static class CellActions {
        #region Actions
        public static Action<IWorkbook> CreateSimpleAndComplexRangesAction = CreateSimpleAndComplexRanges;
        public static Action<IWorkbook> ChangeCellValueAction = ChangeCellValue;
        public static Action<IWorkbook> SetValueFromTextAction = SetValueFromText;
        public static Action<IWorkbook> CellValueToFromObjectAction = CellValueToFromObject;
        public static Action<IWorkbook> CellValueFromObjectViaCustomConverterAction = CellValueFromObjectViaCustomConverter;
        public static Action<IWorkbook> AddHyperlinkAction = AddHyperlink;
        public static Action<IWorkbook> AddCommentAction = AddComment;
        public static Action<IWorkbook> CopyCellDataAndStyleAction = CopyCellDataAndStyle;
        public static Action<IWorkbook> MergeAndSplitCellsAction = MergeAndSplitCells;
        public static Action<IWorkbook> ClearCellsAction = ClearCells;
        #endregion

        static void CreateSimpleAndComplexRanges(IWorkbook workbook)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets[0];
                Color myColor1 = workbook.Styles["20% - Accent1"].Fill.BackgroundColor;
                Color myColor2 = workbook.Styles["20% - Accent2"].Fill.BackgroundColor;

                #region #SimpleRange
                // A range that includes cells from the top left cell (A1) to the bottom right cell (B5).
                CellRange rangeA1B5 = worksheet["A1:B5"];

                // A rectangular range that includes cells from the top left cell (C5) to the bottom right cell (E7).
                CellRange rangeC5E7 = worksheet["C5:E7"];

                // The C4:E7 cell range located in the "Sheet3" worksheet.
                CellRange rangeSheet3C4E7 = workbook.Range["Sheet3!C4:E7"];

                // A range that contains a single cell (E7).
                CellRange rangeE7 = worksheet["E7"];

                // A range that includes the entire column A.
                CellRange rangeColumnA = worksheet["A:A"];

                // A range that includes the entire row 5.
                CellRange rangeRow5 = worksheet["5:5"];

                // A minimal rectangular range that includes all listed cells: C6, D9 and E7.
                CellRange rangeC6D9E7 = worksheet.Range.Parse("C6:D9:E7");

                // A rectangular range whose left column index is 0, top row index is 0, 
                // right column index is 3 and bottom row index is 2. This is the A1:D3 cell range.
                CellRange rangeA1D3 = worksheet.Range.FromLTRB(0, 0, 3, 2);

                // A range that includes the intersection of two ranges: C5:E10 and E9:G13. 
                // This is the E9:E10 cell range.
                CellRange rangeE9E10 = worksheet["C5:E10 E9:G13"];

                // Create a defined name for the D20:G23 cell range.
                worksheet.DefinedNames.Add("MyNamedRange", "Sheet1!$D$20:$G$23");
                // Access a range by its defined name.
                CellRange rangeD20G23 = worksheet["MyNamedRange"];
                #endregion #SimpleRange

                #region #ComplexRange
                CellRange rangeA1D4 = worksheet["A1:D4"];
                CellRange rangeD5E7 = worksheet["D5:E7"];
                CellRange rangeRow11 = worksheet["11:11"];
                CellRange rangeF7 = worksheet["F7"];

                // Create a complex range using the Range.Union method.
                CellRange complexRange1 = worksheet["A7:A9"].Union(rangeD5E7);

                // Create a complex range using the IRangeProvider.Union method.
                CellRange complexRange2 = worksheet.Range.Union(new CellRange[] { rangeRow11, rangeA1D4, rangeF7 });

                // Fill the ranges with different colors.
                complexRange1.FillColor = myColor1;
                complexRange2.FillColor = myColor2;

                // Use the Areas property to get access to a component of a complex range.
                complexRange2.Areas[2].FillColor = Color.Beige;
                #endregion #ComplexRange
            }
            finally
            {
                workbook.EndUpdate();
            }

        }

        static void ChangeCellValue(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Cells["A1"].Value = "dateTime:";
                worksheet.Cells["A2"].Value = "double:";
                worksheet.Cells["A3"].Value = "string:";
                worksheet.Cells["A4"].Value = "error constant:";
                worksheet.Cells["A5"].Value = "boolean:";
                worksheet.Cells["A6"].Value = "float:";
                worksheet.Cells["A7"].Value = "char:";
                worksheet.Cells["A8"].Value = "int32:";
                worksheet.Cells["A10"].Value = "Fill a range of cells:";
                worksheet.Columns["A"].WidthInCharacters = 20;
                worksheet.Columns["B"].WidthInCharacters = 20;
                worksheet.Range["A1:B8"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;

                #region #CellValue
                // Add data of different types to cells.
                worksheet.Cells["B1"].Value = DateTime.Now;
                worksheet.Cells["B2"].Value = Math.PI;
                worksheet.Cells["B3"].Value = "Have a nice day!";
                worksheet.Cells["B4"].Value = CellValue.ErrorReference;
                worksheet.Cells["B5"].Value = true;
                worksheet.Cells["B6"].Value = float.MaxValue;
                worksheet.Cells["B7"].Value = 'a';
                worksheet.Cells["B8"].Value = Int32.MaxValue;

                // Fill all cells in the range with 10.
                worksheet.Range["B10:E10"].Value = 10;
                #endregion #CellValue
            }
            finally {
                workbook.EndUpdate();
            }

        }


        static void SetValueFromText(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Cells["A1"].Value = "dateTime:";
                worksheet.Cells["A2"].Value = "double:";
                worksheet.Cells["A3"].Value = "string:";
                worksheet.Cells["A4"].Value = "error constant:";
                worksheet.Cells["A5"].Value = "boolean:";
                worksheet.Cells["A6"].Value = "float:";
                worksheet.Cells["A7"].Value = "int32:";
                worksheet.Cells["A8"].Value = "datetime (cell number format):";
                worksheet.Cells["A9"].Value = "formula:";
                worksheet.Cells["A11"].Value = "Fill a range of cells:";

                worksheet.Columns["A"].WidthInCharacters = 40;
                worksheet.Columns["B"].WidthInCharacters = 20;

                #region #SetValueFromText
                // Add data of different types to cells.
                worksheet.Cells["B1"].SetValueFromText("27-Jul-16 5:43PM");
                worksheet.Cells["B2"].SetValueFromText("3.1415926536");
                worksheet.Cells["B3"].SetValueFromText("Have a nice day!");
                worksheet.Cells["B4"].SetValueFromText("#REF!");
                worksheet.Cells["B5"].SetValueFromText("true");
                worksheet.Cells["B6"].SetValueFromText("3.40282E+38");
                worksheet.Cells["B7"].SetValueFromText("2147483647");
                worksheet.Cells["B8"].NumberFormat = "###.###";
                worksheet.Cells["B8"].SetValueFromText("27-Jul-16 5:43PM", true);
                worksheet.Cells["B9"].SetValueFromText("=SQRT(25)");

                // Fill all cells in the range with 10.
                worksheet.Range["C11:F11"].SetValueFromText("=B1");
                #endregion #SetValueFromText
            }
            finally {
                workbook.EndUpdate();
            }

        }

        static void CellValueToFromObject(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet["A1"].Value = "Cell values converted to objects:";
                worksheet["A5"].Value = "Cell values converted from objects:";
                worksheet.Range["A1"].ColumnWidthInCharacters= 31;
                worksheet.Range["B1:D5"].ColumnWidthInCharacters = 12;

                #region #CellValueToFromObject
                // Add data of different types to cells of the range.
                CellRange sourceRange = worksheet["B1:B3"];
                sourceRange[0].Value = "Text";
                sourceRange[1].Formula = "=PI()";
                sourceRange[2].Value = DateTime.Now;
                sourceRange[2].NumberFormat = "d-mmm-yy";
                
                // Get the number of cells in the range.
                int cellCount = sourceRange.RowCount * sourceRange.ColumnCount;

                // Declare an array to store elements of different types.
                object[] array = new object[cellCount];

                // Convert cell values to objects and add them to the array.
                for (int i = 0; i < cellCount; i++) {
                    array[i] = sourceRange[i].Value.ToObject();
                }

                // Convert array elements to cell values and assign them to cells in the fifth row. 
                for (int i = 0; i < array.Length; i++) {
                    worksheet.Rows["5"][i + 1].SetValue(array[i]);
                    // An alternative way to do this is to use the CellValue.FromObject method.
                    // worksheet.Rows["5"][i+1].Value = CellValue.FromObject(array[i]);
                }
                #endregion #CellValueToFromObject
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void CellValueFromObjectViaCustomConverter(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                #region #CustomCellValueConverter
                Worksheet worksheet = workbook.Worksheets[0];
                Cell cell = worksheet.Cells["A1"];
                cell.FillColor = Color.Orange;
                cell.Value = CellValue.FromObject(cell.FillColor, new ColorToNameConverter());
                // ...
                #endregion #CustomCellValueConverter
            }
            finally {
                workbook.EndUpdate();
            }
        }

        #region #CustomCellValueConverter
        class ColorToNameConverter : ICellValueConverter {
            object ICellValueConverter.ConvertToObject(CellValue value) {
                return null;
            }
            CellValue ICellValueConverter.TryConvertFromObject(object value) {
                bool isColor = value.GetType() == typeof(Color);
                if (!isColor)
                    return null;
                return ((Color)value).Name;
            }
        }
        #endregion #CustomCellValueConverter

        static void AddHyperlink(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Range["A:C"].ColumnWidthInCharacters = 12;

                #region #AddHyperlink
                // Create a hyperlink to a web page.
                Cell cell = worksheet.Cells["A1"];
                worksheet.Hyperlinks.Add(cell, "http://www.devexpress.com/", true, "DevExpress");

                // Create a hyperlink to a cell range in a workbook.
                CellRange range = worksheet.Range["C3:D4"];
                Hyperlink cellHyperlink = worksheet.Hyperlinks.Add(range, "Sheet2!B2:E7", false, "Select Range");
                cellHyperlink.TooltipText = "Click Me";
                #endregion #AddHyperlink
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void CopyCellDataAndStyle(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                #region #CopyCell
                Worksheet worksheet = workbook.Worksheets[0];
                worksheet.Columns["A"].WidthInCharacters = 32;
                worksheet.Columns["B"].WidthInCharacters = 20;
                Style style = workbook.Styles[BuiltInStyleId.Input];

                // Specify the content and formatting for a source cell.
                worksheet.Cells["A1"].Value = "Source Cell";

                Cell sourceCell = worksheet.Cells["B1"];
                sourceCell.Formula = "= PI()";
                sourceCell.NumberFormat = "0.0000";
                sourceCell.Style = style;
                sourceCell.Font.Color = Color.Blue;
                sourceCell.Font.Bold = true;
                sourceCell.Borders.SetOutsideBorders(Color.Black, BorderLineStyle.Thin);

                // Copy all information from the source cell to the "B3" cell. 
                worksheet.Cells["A3"].Value = "Copy All";
                worksheet.Cells["B3"].CopyFrom(sourceCell);

                // Copy only the source cell content (e.g., text, numbers, formula calculated values) to the "B4" cell.
                worksheet.Cells["A4"].Value = "Copy Values";
                worksheet.Cells["B4"].CopyFrom(sourceCell, PasteSpecial.Values);

                // Copy the source cell content (e.g., text, numbers, formula calculated values) 
                // and number formats to the "B5" cell.
                worksheet.Cells["A5"].Value = "Copy Values and Number Formats";
                worksheet.Cells["B5"].CopyFrom(sourceCell, PasteSpecial.Values | PasteSpecial.NumberFormats);

                // Copy only the formatting information from the source cell to the "B6" cell.
                worksheet.Cells["A6"].Value = "Copy Formats";
                worksheet.Cells["B6"].CopyFrom(sourceCell, PasteSpecial.Formats);

                // Copy all information from the source cell to the "B7" cell except for border settings.
                worksheet.Cells["A7"].Value = "Copy All Except Borders";
                worksheet.Cells["B7"].CopyFrom(sourceCell, PasteSpecial.All & ~PasteSpecial.Borders);

                // Copy information only about borders from the source cell to the "B8" cell.
                worksheet.Cells["A8"].Value = "Copy Borders";
                worksheet.Cells["B8"].CopyFrom(sourceCell, PasteSpecial.Borders);
                #endregion #CopyCell
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void MergeAndSplitCells(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Cells["A2"].FillColor = Color.LightGray;

                worksheet.Cells["B2"].Value = "B2";
                worksheet.Cells["B2"].FillColor = Color.LightGreen;

                worksheet.Cells["C3"].Value = "C3";
                worksheet.Cells["C3"].FillColor = Color.LightSalmon;

                #region #MergeCells
                // Merge cells contained in the range.
                worksheet.MergeCells(worksheet.Range["A1:C5"]);
                #endregion #MergeCells
            }
            finally {
                workbook.EndUpdate();
            }
        }

        static void ClearCells(IWorkbook workbook) {
            workbook.BeginUpdate();
            try {
                Worksheet worksheet = workbook.Worksheets[0];

                worksheet.Range["A:D"].ColumnWidthInCharacters = 30;
                worksheet.Range["B1:D6"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;

                worksheet["B1"].Value = "Initial Cell Content and Formatting:";
                worksheet.MergeCells(worksheet["C1:D1"]);
                worksheet["C1:D1"].Value = "Cleared Cells:";

                worksheet["A2"].Value = "Clear All:";
                worksheet["A3"].Value = "Clear Cell Content Only:";
                worksheet["A4"].Value = "Clear Cell Formatting Only:";
                worksheet["A5"].Value = "Clear Cell Hyperlinks Only:";
                worksheet["A6"].Value = "Clear Cell Comments Only:";

                // Specify initial content and formatting for cells.
                CellRange sourceCells = worksheet["B2:D6"];
                sourceCells.Value = DateTime.Now;
                sourceCells.Style = workbook.Styles[BuiltInStyleId.Accent3_40percent];
                sourceCells.Font.Color = Color.LightSeaGreen;
                sourceCells.Font.Bold = true;
                sourceCells.Borders.SetAllBorders(Color.Blue, BorderLineStyle.Dashed);
                worksheet.Hyperlinks.Add(worksheet["B5"], "http://www.devexpress.com/", true, "DevExpress");
                worksheet.Hyperlinks.Add(worksheet["C5"], "http://www.devexpress.com/", true, "DevExpress");
                worksheet.Hyperlinks.Add(worksheet["D5"], "http://www.devexpress.com/", true, "DevExpress");
                worksheet.Comments.Add(worksheet["B6"], "Author", "Cell Comment");
                worksheet.Comments.Add(worksheet["C6"], "Author", "Cell Comment");
                worksheet.Comments.Add(worksheet["D6"], "Author", "Cell Comment");


                #region #ClearCell
                // Remove all cell information (content, formatting, hyperlinks and comments).
                worksheet.Clear(worksheet["C2:D2"]);

                // Remove cell content.
                worksheet.ClearContents(worksheet["C3"]);
                worksheet["D3"].Value = null;

                // Remove cell formatting.
                worksheet.ClearFormats(worksheet["C4"]);
                worksheet["D4"].Style = workbook.Styles.DefaultStyle;

                // Remove hyperlinks from cells.
                worksheet.ClearHyperlinks(worksheet["C5"]);

                Hyperlink hyperlinkD5 = worksheet.Hyperlinks.GetHyperlinks(worksheet["D5"])[0];
                worksheet.Hyperlinks.Remove(hyperlinkD5);

                // Remove comments from cells.
                worksheet.ClearComments(worksheet["C6"]);
                #endregion #ClearCell
            }
            finally {
                workbook.EndUpdate();
            }
        }
        static void AddComment(IWorkbook workbook)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets[0];

                // Specify initial content and formatting for cells.
                worksheet.Cells["A2"].Value = "Original comment";
                worksheet.Cells["E2"].Value = "Copied comment";
                worksheet["A2"].Alignment.WrapText = true;
                worksheet["E2"].Alignment.WrapText = true;

                #region #AddComment
                // Get the system username. 
                string author = workbook.CurrentAuthor;

                // Add a comment to the "A2" cell.
                Cell commentedCell = worksheet.Cells["A2"];
                ThreadedComment commentA2 = worksheet.ThreadedComments.Add(commentedCell, author, author + ": \r\n" + "This is a comment");

                // Copy the comment to the "E2" cell.
                worksheet.Cells["E2"].CopyFrom(commentedCell, PasteSpecial.Comments);

                // Get the added comment and make it visible.
                ThreadedComment commentE2 = worksheet.ThreadedComments.GetThreadedComments(worksheet["E2"])[0];

                commentE2.Text = "This comment is copied from the cell " + commentedCell.GetReferenceA1();
                #endregion #AddComment
            }
            finally
            {
                workbook.EndUpdate();
            }
        }
    }
}
