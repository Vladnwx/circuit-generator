using Microsoft.Office.Interop.Excel;

namespace circuit_generator
{
    public class FormatCell
    {
        private Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;

        public void StandartFormat(int row, int column)
        {
            this.Worksheet.Cells[row, column].Font.Size = 10;
            this.Worksheet.Cells[row, column].Font.Name = "Arial";
            this.Worksheet.Cells[row, column].HorizontalAlignment = XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            Worksheet.Cells[row, column].VerticalAlignment = XlHAlign.xlHAlignCenter;
            Worksheet.Cells[row, column].Borders.LineStyle = XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            this.Worksheet.Cells[row, column].WrapText = true; // перенос текста
        }
        public void StandartFormat(int row, int column, int rowMerge, int columnMerge)
        {
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].Font.Size = 10;
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].Font.Name = "Arial";
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].HorizontalAlignment = XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].VerticalAlignment = XlHAlign.xlHAlignCenter;
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].Borders.LineStyle = XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].WrapText = true; // перенос текста
        }

        public void StandartFormat(int row, int column, string s)
        {
            this.Worksheet.Cells[row, column].Value = s;
            StandartFormat(row, column);

        }
        public void MergeFormat(int row, int column, int rowMerge, int columnMerge)
        {
            this.Worksheet.Range[this.Worksheet.Cells[row, column], this.Worksheet.Cells[row + rowMerge, column + columnMerge]].Merge();
            StandartFormat(row, column, rowMerge, columnMerge);
        }

        public void MergeFormat(int row, int column, int rowMerge, int columnMerge, string s)
        {
            this.Worksheet.Cells[row, column].Value = s;
            MergeFormat(row, column, rowMerge, columnMerge);
        }

    }
}
