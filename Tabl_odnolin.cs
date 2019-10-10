using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
//using Autodesk.AutoCAD.ApplicationServices;
//using Autodesk.AutoCAD.DatabaseServices;
//using Autodesk.AutoCAD.Geometry;
//using Autodesk.AutoCAD.Runtime;
//using Autodesk.AutoCAD.EditorInput;

namespace circuit_generator
{
    class Tabl_odnolin  // Таблица для рисования схемы
    {
        public Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; } // Таблица над которрой мы выполняем действия
        //Нужно добавить перегрузку в зависимости от типа передаваемого аргумента. Сейчас передается таблица Excel. Нужно добавить тот же способ для передачи приложения или листа Autocad
        public void Draw(Microsoft.Office.Interop.Excel.Worksheet worksheet1)
        {
            this.Worksheet = worksheet1;
            Draw_left();
            Draw_vvod();
            Draw_nagr();
            Draw_potr();
        }
              
        public void Draw_left() // Таблица слева для однолинейной схемы
        {
            for ( int i=1; i<Constants.Tabl.Left.Column.Start; i++) //Тут скрываются столбцы до начала вставки таблицы
            {
             Worksheet.Columns[i].Hidden = true;
            }

            Worksheet.Cells[Constants.Tabl.Left.Row.Start, Constants.Tabl.Left.Column.Start + 2].Select();
            Globals.ThisAddIn.Application.ActiveWindow.FreezePanes = true; //зафиксировать столбец и строку

            Set_excel_and_union("ИСТОЧНИК ПИТАНИЯ", Constants.Tabl.Left.Row.Start, Constants.Tabl.Left.Column.Start, 3, 1);

            Set_excel_and_union("Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А", Constants.Tabl.Left.Row.Start+4, Constants.Tabl.Left.Column.Start, 10, 1);

            Set_excel_and_union("Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А", Constants.Tabl.Left.Row.Start + 11, Constants.Tabl.Left.Column.Start, 5, 1);

            Set_excel_and_union("Пускатель магнитный: тип; ток нагревательного элемента, А", Constants.Tabl.Left.Row.Start + 17, Constants.Tabl.Left.Column.Start, 3, 1);

            
            Worksheet.Cells[Constants.Fider.Row.Info, Constants.Tabl.Left.Column.Start].Orientation = 90;//Тут нужно сделать текст снизу вверх [25, "E"]
            Worksheet.Cells[Constants.Fider.Row.Info, (Constants.Tabl.Left.Column.Start + 1)].Orientation = 90; //Тут нужно сделать текст снизу вверх [25, "F"]

            Set_excel_and_union("Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м", Constants.Fider.Row.Info, Constants.Tabl.Left.Column.Start, 0, 0);

            Set_excel_and_union("потеря напряжения, %;- марка, сечение проводника", Constants.Fider.Row.Info, Constants.Tabl.Left.Column.Start + 1, 0, 0);

            Worksheet.Cells[Constants.Fider.Row.Info, Constants.Tabl.Left.Column.Start].RowHeight = 189; // Высота столбца

            Set_excel_and_union("Условное обозначение на плане", Constants.Fider.Row.Image);

            Worksheet.Cells[Constants.Fider.Row.Image, Constants.Tabl.Left.Column.Start].RowHeight = 45; // Высота столбца


            Set_excel_and_union("Распределение по фазам", Constants.Fider.Row.Phase);

            Worksheet.Cells[Constants.Fider.Row.Phase, Constants.Tabl.Left.Column.Start].RowHeight = 30; // Высота столбца

            Set_excel_and_union("Номер по плану", Constants.Fider.Row.Id);

            Set_excel_and_union("U, В", Constants.Fider.Row.U);

            Set_excel_and_union("Ррасч., кВт", Constants.Fider.Row.P);

            Set_excel_and_union("cos f", Constants.Fider.Row.Cos);

            Set_excel_and_union("Ток Iрасч., А", Constants.Fider.Row.I);

            Set_excel_and_union("Наименование потребителя", Constants.Fider.Row.Name_potr);

            Worksheet.Cells[Constants.Fider.Row.Name_potr, Constants.Tabl.Left.Column.Start].RowHeight = 100; // Высота столбца

            Set_excel_and_union("Длинна кабельной трассы, м.", Constants.Fider.Row.Lenght);

            Worksheet.Cells[Constants.Fider.Row.Lenght, Constants.Tabl.Left.Column.Start].RowHeight = 30; // Высота столбца

            Set_excel_and_union("Потери, %", Constants.Fider.Row.Poteri);

            Set_excel_and_union("кабель, мм.кв.", Constants.Fider.Row.Cabel);

            Set_excel_and_union("Начало кабельной линии", Constants.Fider.Row.Start);
            Worksheet.Cells[Constants.Fider.Row.Start, Constants.Tabl.Left.Column.Start].RowHeight = 30; // Высота столбца

            Set_excel_and_union("Конец кабельной линии", Constants.Fider.Row.Finish);
            Worksheet.Cells[Constants.Fider.Row.Finish, Constants.Tabl.Left.Column.Start].RowHeight = 30; // Высота столбца

            Set_excel_and_union("марка кабеля", Constants.Fider.Row.Cable_marka);

            Set_excel_and_union("CU / Al", Constants.Fider.Row.Cable_metal_type);

            Set_excel_and_union("Способ прокладки", Constants.Fider.Row.Prokladka_type);

            Set_excel_and_union("Жильность", Constants.Fider.Row.Cabel_jila);

            Set_excel_and_union("Тип трубы", Constants.Fider.Row.Truba_type);

            Set_excel_and_union("Длинна трубы, м", Constants.Fider.Row.Truba_lenght);

            Set_excel_and_union("Диаметр трубы", Constants.Fider.Row.Truba_diam);
        }
        public void Draw_vvod() // Таблица ввода
        {
            //Тут нужно вставить название шкафа из названия листа в ячейку [M6]
            int i = Constants.Tabl.vvod.Row.Start;
            int j = Constants.Tabl.vvod.Column.Start;
            Set_excel_and_union(Worksheet.Name, i , j, 0, 2);
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
            Set_excel_and_union("Потребность труб и кабелей, м", i , j, 1, 0);
            Set_excel_and_union("Тип/Марка", i, j + 1, 0, 0);
            Set_excel_and_union("Длина, м", i + 1, j + 1, 0, 0);
        }

        public void Set_excel_and_union(string s, int i , int j, int k, int l) // worksheet - таблица, s-строка для записи ,  i - номер строки для записи , j - номер столбца для записи, k - число строк для объединения,  l - число столбцов для объединения
        {
           
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i, j + l]].Font.Size = 10;
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i, j + l]].Font.Name = "Arial";
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i, j + l]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i, j + l]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i, j + l]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            Worksheet.Cells[i, j].Value = s;
            Worksheet.Range[Worksheet.Cells[i, j], Worksheet.Cells[i+k,j + l]].Merge();
            
            Worksheet.Rows[i].AutoFit();
            Worksheet.Range[this.Worksheet.Cells[i, j], this.Worksheet.Cells[i, j + l]].WrapText = true; // перенос текста
        }

        public void Set_excel_and_union(string s, int Row_Start) // worksheet - таблица, s-строка для записи ,  int Row_Start - номер строки для записи. Упрощенный оператор для записи таблицы слева
        {
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].Font.Size = 10;
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].Font.Name = "Arial";
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start].Value = s;
            Worksheet.Range[Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].Merge();

            Worksheet.Rows[Row_Start].AutoFit();
            Worksheet.Range[this.Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start], this.Worksheet.Cells[Row_Start, Constants.Tabl.Left.Column.Start + 1]].WrapText = true; // перенос текста
        }

    }

}
