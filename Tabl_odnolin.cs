using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using fr = circuit_generator.Constants.Fider.Row;
using tlc = circuit_generator.Constants.Tabl.Left.Column;
using tlr = circuit_generator.Constants.Tabl.Left.Row;

namespace circuit_generator
{
    class Tabl_odnolin  // Таблица для рисования схемы
    {
        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; } // Таблица над которрой мы выполняем действия
                                                                                // public Autodesk.AutoCAD.ApplicationServices.Application Acad { get; set; } // Таблица над которрой мы выполняем действия
                                                                                //Нужно добавить перегрузку в зависимости от типа передаваемого аргумента. Сейчас передается таблица Excel. Нужно добавить тот же способ для передачи приложения или листа Autocad
        public void Draw(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            Worksheet = worksheet;
            Draw_left();
            Draw_vvod();
            Draw_nagr();
            Draw_potr();


        }
        /*  public void Draw(Autodesk.AutoCAD.ApplicationServices.Application acad)
          {
              this.Acad = acad;
          }*/

        public void Check(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            Worksheet = worksheet;
            //bool easy;



            string s = Globals.ThisAddIn.Application.ActiveSheet.Name;
            bool b1 = s.Contains("Лист");
            bool b2 = s.Contains("Sheet");

            if (b1 == true)
            {
                MessageBox.Show("Шкаф не может называться как лист, может быть как нибудь назовем шкаф?");
               
                Rename r1 = new Rename();
                r1.Show();
            }
            else Draw(worksheet);
            //Draw(worksheet);



        }
        public void Draw_left() // Таблица слева для однолинейной схемы
        {
            for (int i = 1; i < Constants.Tabl.Left.Column.Start; i++) //Тут скрываются столбцы до начала вставки таблицы
            {
                Worksheet.Columns[i].Hidden = true;
            }

            Worksheet.Cells[tlr.Start, tlc.Start + 2].Select();
            Globals.ThisAddIn.Application.ActiveWindow.FreezePanes = true; //зафиксировать столбец и строку

            Set_excel_and_union(tlr.StartValue1, tlr.Start, tlc.Start, 3, 1);
            Set_excel_and_union(tlr.StartValue2, tlr.Start + 4, tlc.Start, 10, 1);
            Set_excel_and_union(tlr.StartValue3, tlr.Start + 11, tlc.Start, 5, 1);
            Set_excel_and_union(tlr.StartValue4, tlr.Start + 17, tlc.Start, 3, 1);
            Worksheet.Cells[fr.Info, tlc.Start].Orientation = 90;//Делается текст снизу вверх [25, "E"]
            Worksheet.Cells[fr.Info, (tlc.Start + 1)].Orientation = 90; //Делается текст  снизу вверх [25, "F"]
            Set_excel_and_union(fr.InfoValue1, fr.Info, tlc.Start, 0, 0);
            Set_excel_and_union(fr.InfoValue2, fr.Info, tlc.Start + 1, 0, 0);
            Worksheet.Cells[fr.Info, tlc.Start].RowHeight = 189; // Высота столбца
            Set_excel_and_union(fr.ImageValue, fr.Image);
            Worksheet.Cells[fr.Image, tlc.Start].RowHeight = 45; // Высота столбца
            Set_excel_and_union(fr.PhaseValue, fr.Phase);
            Worksheet.Cells[fr.Phase, tlc.Start].RowHeight = 30; // Высота столбца
            Set_excel_and_union(fr.IdValue, fr.Id);
            Set_excel_and_union(fr.UValue, fr.U);
            Set_excel_and_union(fr.PValue, fr.P);
            Set_excel_and_union(fr.CosValue, fr.Cos);
            Set_excel_and_union(fr.IValue, fr.I);
            Set_excel_and_union(fr.Name_potrValue, fr.Name_potr);
            Worksheet.Cells[fr.Name_potr, tlc.Start].RowHeight = 100; // Высота столбца
            Set_excel_and_union(fr.LenghtValue, fr.Lenght);
            Worksheet.Cells[fr.Lenght, tlc.Start].RowHeight = 30; // Высота столбца
            Set_excel_and_union(fr.PoteriValue, fr.Poteri);
            Set_excel_and_union(fr.CabelValue, fr.Cabel);
            Set_excel_and_union(fr.StartValue, fr.Start);
            Worksheet.Cells[fr.Start, tlc.Start].RowHeight = 30; // Высота столбца
            Set_excel_and_union(fr.FinishValue, fr.Finish);
            Worksheet.Cells[fr.Finish, tlc.Start].RowHeight = 30; // Высота столбца
            Set_excel_and_union(fr.Cable_markaValue, fr.Cable_marka);
            Set_excel_and_union(fr.Cable_metal_typeValue, fr.Cable_metal_type);
            Set_excel_and_union(fr.Prokladka_typeValue, fr.Prokladka_type);
            Set_excel_and_union(fr.Cabel_jilaValue, fr.Cabel_jila);
            Set_excel_and_union(fr.Truba_typeValue, fr.Truba_type);
            Set_excel_and_union(fr.Truba_lenghtValue, fr.Truba_lenght);
            Set_excel_and_union(fr.Truba_diamValue, fr.Truba_diam);
        }
        public void Draw_vvod() // Таблица ввода
        {
            //Тут нужно вставить название шкафа из названия листа в ячейку [M6]
            int i = Constants.Tabl.vvod.Row.Start;
            int j = Constants.Tabl.vvod.Column.Start;
            Set_excel_and_union(Worksheet.Name, i, j, 0, 2);
            Set_excel_and_union("Руст,кВт", i + 1, j, 0, 2);
            Set_excel_and_union("Kc", i + 2, j, 0, 0);
            Set_excel_and_union("Рр,кВт", i + 3, j, 0, 0);
            Set_excel_and_union("Ip,A", i + 4, j, 0, 0);
            Set_excel_and_union("cos f", i + 5, j, 0, 0);

        }
        public void Draw_nagr() // Таблица нагрузка по фазам, кВт
        {
            int i = Constants.Tabl.Nagr.Row.Start;
            int j = Constants.Tabl.Nagr.Column.Start;
            Set_excel_and_union("нагрузка по фазам, кВт", i, j, 0, 2);
            Set_excel_and_union("L1", i + 1, j, 0, 0);
            Set_excel_and_union("L2", i + 1, j + 1, 0, 0);
            Set_excel_and_union("L3", i + 1, j + 2, 0, 0);
            Set_excel_and_union("Перекос по фазам:", i + 3, j, 0, 2);
            Set_excel_and_union("Принять утроенную нагрузку", i + 5, j, 0, 2);
            //Тут нужно добавить условие появления надписи утроенная нагрузка или симметричная нагрузка [S10:U10]
        }
        public void Draw_potr() // Таблица потребности кабелей и труб
        {
            int i = Constants.Tabl.NPotreb.Row.Start;
            int j = Constants.Tabl.NPotreb.Column.Start;
            Set_excel_and_union("Потребность труб и кабелей, м", i, j, 1, 0);
            Set_excel_and_union("Тип/Марка", i, j + 1, 0, 0);
            Set_excel_and_union("Длина, м", i + 1, j + 1, 0, 0);
        }

        public void Set_excel_and_union(string s, int Row_Start, int Column_Start, int Row_Finish, int ColumnFinish) // worksheet - таблица, s-строка для записи ,  Row_Start - номер строки для записи , Column_Start - номер столбца для записи, Row_Finish - число строк для объединения,  ColumnFinish - число столбцов для объединения
        {
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].Font.Size = 10;
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].Font.Name = "Arial";
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].Borders.LineStyle = Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            Worksheet.Cells[Row_Start, Column_Start].Value = s;
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start + Row_Finish, Column_Start + ColumnFinish]].Merge();

            Worksheet.Rows[Row_Start].AutoFit();
            Worksheet.Range[Worksheet.Cells[Row_Start, Column_Start], Worksheet.Cells[Row_Start, Column_Start + ColumnFinish]].WrapText = true; // перенос текста
        }
        public void Set_excel_and_union(string s, int Row_Start) // worksheet - таблица, s-строка для записи ,  int Row_Start - номер строки для записи. Упрощенный оператор для записи таблицы слева
        {
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].Font.Size = 10;
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].Font.Name = "Arial";
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            Worksheet.Cells[Row_Start, tlc.Start].Value = s;
            Worksheet.Range[Worksheet.Cells[Row_Start, tlc.Start], Worksheet.Cells[Row_Start, tlc.Start + 1]].Merge();

            Worksheet.Rows[Row_Start].AutoFit();
            Worksheet.Range[this.Worksheet.Cells[Row_Start, tlc.Start], this.Worksheet.Cells[Row_Start, tlc.Start + 1]].WrapText = true; // перенос текста
        }

    }

}
