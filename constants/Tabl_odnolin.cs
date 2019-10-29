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
        public void Draw()
        {
            this.Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            DrawLeft();
            DrawVvod();
            DrawNagr();
            DrawPotr();


        }
        /*  public void Draw(Autodesk.AutoCAD.ApplicationServices.Application acad)
          {
              this.Acad = acad;
          }*/

        public void Check()
        {
            this.Worksheet = Globals.ThisAddIn.Application.ActiveSheet;

            /* if (Worksheet.Name.ToString().Contains("Лист") == true || Worksheet.Name.ToString().Contains("Sheet") == true)
             {
                 const string Text = "Шкаф не может называться как лист, может быть как нибудь назовем шкаф?";
                 MessageBox.Show(Text);

                 Rename r1 = new Rename();
                 r1.Show();

             }
             else Draw();
             */
        }
        public void DrawLeft() // Таблица слева для однолинейной схемы
        {
            for (int i = 1; i < tlc.Start; i++) //Тут скрываются столбцы до начала вставки таблицы
            {
                this.Worksheet.Columns[i].Hidden = true;
            }

            Worksheet.Cells[tlr.Start, tlc.Start + 2].Select();
            Globals.ThisAddIn.Application.ActiveWindow.FreezePanes = true; //зафиксировать столбец и строку

            new FormatCell().MergeFormat(tlr.Start, tlc.Start, 3, 1, tlr.StartValue1);
            new FormatCell().MergeFormat(tlr.Start + 4, tlc.Start, 10, 1, tlr.StartValue2);
            new FormatCell().MergeFormat(tlr.Start + 11, tlc.Start, 5, 1, tlr.StartValue3);
            new FormatCell().MergeFormat(tlr.Start + 17, tlc.Start, 3, 1, tlr.StartValue4);
            Worksheet.Cells[fr.Info, tlc.Start].Orientation = 90;//Делается текст снизу вверх [25, "E"]
            Worksheet.Cells[fr.Info, (tlc.Start + 1)].Orientation = 90; //Делается текст  снизу вверх [25, "F"]
            new FormatCell().StandartFormat(fr.Info, tlc.Start, fr.InfoValue1);
            new FormatCell().StandartFormat(fr.Info, tlc.Start + 1, fr.InfoValue2);
            Worksheet.Cells[fr.Info, tlc.Start].RowHeight = 189; // Высота столбца
            new FormatCell().MergeFormat(fr.Image, tlc.Start, 0, 1, fr.ImageValue);
            Worksheet.Cells[fr.Image, tlc.Start].RowHeight = 45; // Высота столбца
            new FormatCell().MergeFormat(fr.Phase, tlc.Start, 0, 1, fr.PhaseValue);
            Worksheet.Cells[fr.Phase, tlc.Start].RowHeight = 30; // Высота столбца
            new FormatCell().MergeFormat(fr.Id, tlc.Start, 0, 1, fr.IdValue);
            new FormatCell().MergeFormat(fr.U, tlc.Start, 0, 1, fr.UValue);
            new FormatCell().MergeFormat(fr.P, tlc.Start, 0, 1, fr.PValue);
            new FormatCell().MergeFormat(fr.Cos, tlc.Start, 0, 1, fr.CosValue);
            new FormatCell().MergeFormat(fr.I, tlc.Start, 0, 1, fr.IValue);
            new FormatCell().MergeFormat(fr.Name_potr, tlc.Start, 0, 1, fr.Name_potrValue);
            Worksheet.Cells[fr.Name_potr, tlc.Start].RowHeight = 100; // Высота столбца
            new FormatCell().MergeFormat(fr.Lenght, tlc.Start, 0, 1, fr.LenghtValue);
            Worksheet.Cells[fr.Lenght, tlc.Start].RowHeight = 30; // Высота столбца
            new FormatCell().MergeFormat(fr.Poteri, tlc.Start, 0, 1, fr.PoteriValue);
            new FormatCell().MergeFormat(fr.Cabel, tlc.Start, 0, 1, fr.CabelValue);
            new FormatCell().MergeFormat(fr.Start, tlc.Start, 0, 1, fr.StartValue);
            Worksheet.Cells[fr.Start, tlc.Start].RowHeight = 30; // Высота столбца
            new FormatCell().MergeFormat(fr.Finish, tlc.Start, 0, 1, fr.FinishValue);
            Worksheet.Cells[fr.Finish, tlc.Start].RowHeight = 30; // Высота столбца
            new FormatCell().MergeFormat(fr.Cable_marka, tlc.Start, 0, 1, fr.Cable_markaValue);
            new FormatCell().MergeFormat(fr.Cable_metal_type, tlc.Start, 0, 1, fr.Cable_metal_typeValue);
            new FormatCell().MergeFormat(fr.Prokladka_type, tlc.Start, 0, 1, fr.Prokladka_typeValue);
            new FormatCell().MergeFormat(fr.Cabel_jila, tlc.Start, 0, 1, fr.Cabel_jilaValue);
            new FormatCell().MergeFormat(fr.Truba_type, tlc.Start, 0, 1, fr.Truba_typeValue);
            new FormatCell().MergeFormat(fr.Truba_lenght, tlc.Start, 0, 1, fr.Truba_lenghtValue);
            new FormatCell().MergeFormat(fr.Truba_diam, tlc.Start, 0, 1, fr.Truba_diamValue);
        }
        private void DrawVvod() // Таблица ввода
        {
            int i = Constants.Tabl.Vvod.Row.Start;
            int j = Constants.Tabl.Vvod.Column.Start;
            new FormatCell().MergeFormat(i, j, 0, 1, Worksheet.Name);
            new FormatCell().StandartFormat(i + 1, j, Constants.Tabl.Vvod.Value1);
            new FormatCell().StandartFormat(i + 2, j, Constants.Tabl.Vvod.Value2);
            new FormatCell().StandartFormat(i + 3, j, Constants.Tabl.Vvod.Value3);
            new FormatCell().StandartFormat(i + 4, j, Constants.Tabl.Vvod.Value4);
            new FormatCell().StandartFormat(i + 5, j, Constants.Tabl.Vvod.Value5);
        }
        private static void DrawNagr() // Таблица нагрузка по фазам, кВт
        {
            int i = Constants.Tabl.Nagr.Row.Start;
            int j = Constants.Tabl.Nagr.Column.Start;
            new FormatCell().MergeFormat(i, j, 0, 2, Constants.Tabl.Nagr.Value1);
            new FormatCell().StandartFormat(i + 1, j, Constants.Tabl.Nagr.Value2);
            new FormatCell().StandartFormat(i + 1, j + 1, Constants.Tabl.Nagr.Value3);
            new FormatCell().StandartFormat(i + 1, j + 2, Constants.Tabl.Nagr.Value4);
            new FormatCell().MergeFormat(i + 3, j, 0, 2, Constants.Tabl.Nagr.Value5);
        }

        private static void DrawPotr() // Таблица потребности кабелей и труб
        {
            int i = Constants.Tabl.Potreb.Row.Start;
            int j = Constants.Tabl.Potreb.Column.Start;
            new FormatCell().MergeFormat(i, j, 1, 0, Constants.Tabl.Potreb.Value1);
            new FormatCell().StandartFormat(i, j + 1, Constants.Tabl.Potreb.Value2);
            new FormatCell().StandartFormat(i + 1, j + 1, Constants.Tabl.Potreb.Value3);
        }
    }

}
