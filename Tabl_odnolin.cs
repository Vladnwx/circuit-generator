using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace circuit_generator {    
    class Tabl_odnolin  // Таблица для рисования схемы
    {
        public Microsoft.Office.Interop.Excel.Worksheet worksheet { get; set; } // Таблица над которрой мы выполняем действия
        //Нужно добавить перегрузку в зависимости от типа передаваемого аргумента. Сейчас передается таблица Excel. Нужно добавить тот же способ для передачи приложения или листа Autocad
        public void Draw(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            this.worksheet = worksheet;
            Draw_excel_left();
            Draw_excel_vvod();
            Draw_excel_nagr();
            Draw_excel_potr();
        }
              
        public void Draw_excel_left() // Таблица слева для однолинейной схемы
        {
            for ( int i=0; i<Constants.Tabl_start_column; i++) //Тут скрываются столбцы до начала вставки таблицы
            {
             this.worksheet.Columns[i].Hidden = true;
            }
           
            this.worksheet.Cells[Constants.Tabl_start_row, Constants.Tabl_start_column + 2].Select();
            Globals.ThisAddIn.Application.ActiveWindow.FreezePanes = true; //зафиксировать столбец и строку

            Set_excel_and_union("ИСТОЧНИК ПИТАНИЯ", Constants.Tabl_start_row, Constants.Tabl_start_column, 3, 1);

            Set_excel_and_union("Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А", Constants.Tabl_start_row+4, Constants.Tabl_start_column, 10, 1);

            Set_excel_and_union("Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А", Constants.Tabl_start_row + 11, Constants.Tabl_start_column, 5, 1);

            Set_excel_and_union("Пускатель магнитный: тип; ток нагревательного элемента, А", Constants.Tabl_start_row + 17, Constants.Tabl_start_column, 3, 1);

            
            this.worksheet.Cells[Constants.Fider_info_row, Constants.Tabl_start_column].Orientation = 90;//Тут нужно сделать текст снизу вверх [25, "E"]
            this.worksheet.Cells[Constants.Fider_info_row, (Constants.Tabl_start_column + 1)].Orientation = 90; //Тут нужно сделать текст снизу вверх [25, "F"]

            Set_excel_and_union("Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м", Constants.Fider_info_row, Constants.Tabl_start_column, 0, 0);

            Set_excel_and_union("потеря напряжения, %;- марка, сечение проводника", Constants.Fider_info_row, Constants.Tabl_start_column+1, 0, 0);

            this.worksheet.Cells[Constants.Fider_info_row, Constants.Tabl_start_column].RowHeight = 189; // Высота столбца

            Set_excel_and_union("Условное обозначение на плане", Constants.Fider_image_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Распределение по фазам", Constants.Fider_phase_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Номер по плану", Constants.Fider_id_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("U, В", Constants.Fider_u_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Ррасч., кВт", Constants.Fider_p_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("cos f", Constants.Fider_cos_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Ток Iрасч., А", Constants.Fider_i_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Наименование потребителя", Constants.Fider_name_potr_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Длинна кабельной трассы, м.", Constants.Fider_lenght_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Потери, %", Constants.Fider_poteri_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("кабель, мм.кв.", Constants.Fider_cabel_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Начало кабельной линии", Constants.Fider_start_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Конец кабельной линии", Constants.Fider_finish_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("марка кабеля", Constants.Fider_cable_marka_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("CU / Al", Constants.Fider_cable_metal_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Способ прокладки", Constants.Fider_prokladka_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Жильность", Constants.Fider_cabel_jila_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Тип трубы", Constants.Fider_truba_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Длинна трубы, м", Constants.Fider_truba_lenght_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union("Диаметр трубы", Constants.Fider_truba_diam_row, Constants.Tabl_start_column, 0, 1);
                                    
        }
        public void Draw_excel_vvod() // Таблица ввода
        {
            //Тут нужно вставить название шкафа из названия листа в ячейку [M6]
            Set_excel_and_union(this.worksheet.Name, Constants.Tabl_start_row , Constants.Tabl_vvod_column, 0, 2);
            Set_excel_and_union("Руст,кВт", Constants.Tabl_start_row + 1, Constants.Tabl_vvod_column, 0, 2);
            Set_excel_and_union("Kc", Constants.Tabl_start_row + 2, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union("Рр,кВт", Constants.Tabl_start_row + 3, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union("Ip,A", Constants.Tabl_start_row + 4, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union("cos f", Constants.Tabl_start_row + 5, Constants.Tabl_vvod_column, 0, 0);

        }
        public void Draw_excel_nagr() // Таблица нагрузка по фазам, кВт
        {
            Set_excel_and_union("нагрузка по фазам, кВт", Constants.Tabl_start_row, Constants.Tabl_nagr_column, 0, 2);

            Set_excel_and_union("L1", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column, 0, 0);
            Set_excel_and_union("L2", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column + 1, 0, 0);
            Set_excel_and_union("L3", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column + 2, 0, 0);

            Set_excel_and_union("Перекос по фазам:", Constants.Tabl_start_row + 3, Constants.Tabl_nagr_column, 0, 2);

            Set_excel_and_union("Принять утроенную нагрузку", Constants.Tabl_start_row + 5, Constants.Tabl_nagr_column, 0, 2);

            //Тут нужно добавить условие появления надписи утроенная нагрузка или симметричная нагрузка [S10:U10]
        }
        public void Draw_excel_potr() // Таблица потребности кабелей и труб
        {
            Set_excel_and_union("Потребность труб и кабелей, м", Constants.Tabl_start_row , Constants.Tabl_potreb_column, 1, 0);

            Set_excel_and_union("Тип/Марка", Constants.Tabl_start_row, Constants.Tabl_potreb_column + 1, 0, 0);
            Set_excel_and_union("Длина, м", Constants.Tabl_start_row + 1, Constants.Tabl_potreb_column + 1, 0, 0);
           
        }

        public void Set_excel_and_union(string s, int i , int j, int k, int l) // worksheet - таблица, s-строка для записи ,  i - номер строки для записи , j - номер столбца для записи, k - число строк для объединения,  l - число столбцов для объединения
        {
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].Font.Size = 10;
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].Font.Name = "Arial";
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            this.worksheet.Cells[i, j].Value = s;
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i+k,j + l]].Merge();
            this.worksheet.Rows[i].AutoFit();
            this.worksheet.Range[this.worksheet.Cells[i, j], this.worksheet.Cells[i, j + l]].WrapText = true; // перенос текста
        }

    }

}
