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
        //Нужно добавить перегрузку в зависимости от типа передаваемого аргумента. Сейчас передается таблица Excel. Нужно добавить тот же способ для передачи приложения или листа Autocad
        public void Draw_excel(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            Draw_excel_left(worksheet);
            Draw_excel_vvod(worksheet);
            Draw_excel_nagr(worksheet);
            Draw_excel_potr(worksheet);
        }
        public void Draw_excel_left(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица слева для однолинейной схемы
        {

            worksheet.Columns[Constants.Tabl_start_column-3].Hidden = true;
            worksheet.Columns[Constants.Tabl_start_column - 2].Hidden = true;
            worksheet.Columns[Constants.Tabl_start_column - 1].Hidden = true;//Тут нужно скрыть столбцы A, B, C

            worksheet.Cells[Constants.Tabl_start_row, Constants.Tabl_start_column + 2].Select();
            Globals.ThisAddIn.Application.ActiveWindow.FreezePanes = true; //зафиксировать столбец и строку

            Set_excel_and_union(worksheet, "ИСТОЧНИК ПИТАНИЯ", Constants.Tabl_start_row, Constants.Tabl_start_column, 3, 1);

            Set_excel_and_union(worksheet, "Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А", Constants.Tabl_start_row+4, Constants.Tabl_start_column, 10, 1);

            Set_excel_and_union(worksheet, "Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А", Constants.Tabl_start_row + 11, Constants.Tabl_start_column, 5, 1);

            Set_excel_and_union(worksheet, "Пускатель магнитный: тип; ток нагревательного элемента, А", Constants.Tabl_start_row + 17, Constants.Tabl_start_column, 3, 1);

            
            worksheet.Cells[Constants.Fider_info_row, Constants.Tabl_start_column].Orientation = 90;//Тут нужно сделать текст снизу вверх [25, "E"]
            worksheet.Cells[Constants.Fider_info_row, (Constants.Tabl_start_column + 1)].Orientation = 90; //Тут нужно сделать текст снизу вверх [25, "F"]

            Set_excel_and_union(worksheet, "Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м", Constants.Fider_info_row, Constants.Tabl_start_column, 0, 0);

            Set_excel_and_union(worksheet, "потеря напряжения, %;- марка, сечение проводника", Constants.Fider_info_row, Constants.Tabl_start_column+1, 0, 0);

            worksheet.Cells[Constants.Fider_info_row, Constants.Tabl_start_column].RowHeight = 189; // Высота столбца

            Set_excel_and_union(worksheet, "Условное обозначение на плане", Constants.Fider_image_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Распределение по фазам", Constants.Fider_phase_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Номер по плану", Constants.Fider_id_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "U, В", Constants.Fider_u_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Ррасч., кВт", Constants.Fider_p_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "cos f", Constants.Fider_cos_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Ток Iрасч., А", Constants.Fider_i_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Наименование потребителя", Constants.Fider_name_potr_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Длинна кабельной трассы, м.", Constants.Fider_lenght_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Потери, %", Constants.Fider_poteri_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "кабель, мм.кв.", Constants.Fider_cabel_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Начало кабельной линии", Constants.Fider_start_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Конец кабельной линии", Constants.Fider_finish_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "марка кабеля", Constants.Fider_cable_marka_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "CU / Al", Constants.Fider_cable_metal_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Способ прокладки", Constants.Fider_prokladka_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Жильность", Constants.Fider_cabel_jila_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Тип трубы", Constants.Fider_truba_type_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Длинна трубы, м", Constants.Fider_truba_lenght_row, Constants.Tabl_start_column, 0, 1);

            Set_excel_and_union(worksheet, "Диаметр трубы", Constants.Fider_truba_diam_row, Constants.Tabl_start_column, 0, 1);
                                    
        }
        public void Draw_excel_vvod(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица ввода
        {
            //Тут нужно вставить название шкафа из названия листа в ячейку [M6]
            Set_excel_and_union(worksheet, worksheet.Name, Constants.Tabl_start_row , Constants.Tabl_vvod_column, 0, 2);
            Set_excel_and_union(worksheet, "Руст,кВт", Constants.Tabl_start_row + 1, Constants.Tabl_vvod_column, 0, 2);
            Set_excel_and_union(worksheet, "Kc", Constants.Tabl_start_row + 2, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union(worksheet, "Рр,кВт", Constants.Tabl_start_row + 3, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union(worksheet, "Ip,A", Constants.Tabl_start_row + 4, Constants.Tabl_vvod_column, 0, 0);
            Set_excel_and_union(worksheet, "cos f", Constants.Tabl_start_row + 5, Constants.Tabl_vvod_column, 0, 0);

        }
        public void Draw_excel_nagr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица нагрузка по фазам, кВт
        {
            Set_excel_and_union(worksheet, "нагрузка по фазам, кВт", Constants.Tabl_start_row, Constants.Tabl_nagr_column, 0, 2);

            Set_excel_and_union(worksheet, "L1", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column, 0, 0);
            Set_excel_and_union(worksheet, "L2", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column + 1, 0, 0);
            Set_excel_and_union(worksheet, "L3", Constants.Tabl_start_row + 1, Constants.Tabl_nagr_column + 2, 0, 0);

            Set_excel_and_union(worksheet, "Перекос по фазам:", Constants.Tabl_start_row + 3, Constants.Tabl_nagr_column, 0, 2);

            Set_excel_and_union(worksheet, "Принять утроенную нагрузку", Constants.Tabl_start_row + 5, Constants.Tabl_nagr_column, 0, 2);

            //Тут нужно добавить условие появления надписи утроенная нагрузка или симметричная нагрузка [S10:U10]
        }
        public void Draw_excel_potr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица потребности кабелей и труб
        {
            Set_excel_and_union(worksheet, "Потребность труб и кабелей, м", Constants.Tabl_start_row , Constants.Tabl_potreb_column, 1, 0);

            Set_excel_and_union(worksheet, "Тип/Марка", Constants.Tabl_start_row, Constants.Tabl_potreb_column + 1, 0, 0);
            Set_excel_and_union(worksheet, "Длина, м", Constants.Tabl_start_row + 1, Constants.Tabl_potreb_column + 1, 0, 0);
           
        }

        public void Set_excel_and_union(Microsoft.Office.Interop.Excel.Worksheet worksheet, string s, int i , int j, int k, int l) // worksheet - таблица, s-строка для записи ,  i - номер строки для записи , j - номер столбца для записи, k - число строк для объединения,  l - число столбцов для объединения
        {
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].Font.Size = 10;
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].Font.Name = "Arial";
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter; // выравнивание по центру по горизонтали
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; //Тут нужно нарисовать все границы для ячеек
            worksheet.Cells[i, j].Value = s;
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i+k,j + l]].Merge();
            worksheet.Rows[i].AutoFit();
            worksheet.Range[worksheet.Cells[i, j], worksheet.Cells[i, j + l]].WrapText = true; // перенос текста
        }

    }

}
