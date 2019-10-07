﻿using System;
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
            Excel_fix_row(worksheet);
        }
        public void Draw_excel_left(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица слева для однолинейной схемы
        {
            //Тут нужно изменить стиль обычный на шрифт типа Arial размер 10 или вынести в отдельный модуль
            //Тут нужно скрыть столбцы A, B, C
            worksheet.Cells[4, "E"].Value = "ИСТОЧНИК ПИТАНИЯ";
            //Тут нужно обединить ячеки [E4:F7]
            worksheet.Cells[8, "E"].Value = "Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А"; 
           //Тут нужно обединить ячеки [E8:F14]
            worksheet.Cells[15, "E"].Value = "Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А"; 
            //Тут нужно обединить ячеки [E15:F20]
            worksheet.Cells[21, "E"].Value = "Пускатель магнитный: тип; ток нагревательного элемента, А"; 
            //Тут нужно обединить ячеки [E21:F24]
            worksheet.Cells[25, "E"].Value = "- Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м";
            //Тут нужно сделать текст снизу вверх [25, "E"]
            worksheet.Cells[25, "E"].RowHeight = 189;
            worksheet.Cells[25, "F"].Value = "- потеря напряжения, %;- марка, сечение проводника"; 
            //Тут нужно сделать текст снизу вверх [25, "F"]
            worksheet.Cells[26, "E"].Value = "УСЛОВНОЕ ОБОЗНАЧЕНИЕ НА ПЛАНЕ";
            //Тут нужно обединить ячеки [E26:F26]
            worksheet.Cells[27, "E"].Value = "РАСПРЕДЕЛЕНИЕ ПО ФАЗАМ";
            //Тут нужно обединить ячеки [E27:F27]
            worksheet.Cells[28, "E"].Value = "НОМЕР ПО ПЛАНУ";
            //Тут нужно обединить ячеки [E28:F28]
            worksheet.Cells[29, "E"].Value = "U, В";
            //Тут нужно обединить ячеки [E29:F29]
            //Тут нужно выделить синим ячеки [E29:F29]
            worksheet.Cells[30, "E"].Value = "Ррасч. кВт";
            //Тут нужно обединить ячеки [E30:F30]
            //Тут нужно выделить синим ячеки [E30:F30]
            worksheet.Cells[31, "E"].Value = "cos f";
            //Тут нужно обединить ячеки [E31:F31]
            //Тут нужно выделить синим ячеки [E31:F31]
            worksheet.Cells[32, "E"].Value = "Ток Iрасч., А";
            //Тут нужно обединить ячеки [E32:F32]
            worksheet.Cells[33, "E"].Value = "Наименование потребителя";
            //Тут нужно обединить ячеки [E33:F33]
            //Тут нужно выделить синим ячеки [E33:F33]
            //Тут нужно нарисовать все границы для ячеек [E4:F33]
            worksheet.Cells[37, "E"].Value = "Длинна кабельной трассы, м."; 
            //Тут нужно обединить ячеки [E37:F37]
            //Тут нужно выделить синим ячеки [E37:F37]
            worksheet.Cells[39, "E"].Value = "Потери, %"; 
            worksheet.Cells[41, "E"].Value = "кабель, мм.кв.";  
            worksheet.Cells[47, "E"].Value = "Начало кабельной линии";
            //Тут нужно обединить ячеки [E47:F47]
            //Тут нужно выделить синим ячеки [E47:F47]
            worksheet.Cells[48, "E"].Value = "Конец кабельной линии";
            //Тут нужно обединить ячеки [E48:F48]
            //Тут нужно выделить синим ячеки [E48:F48]
            worksheet.Cells[50, "E"].Value = "марка кабеля";
            //Тут нужно обединить ячеки [E50:F50]
            //Тут нужно выделить синим ячеки [E49:F49]
            worksheet.Cells[52, "E"].Value = "CU / Al";
            //Тут нужно обединить ячеки [E52:F52]
            //Тут нужно выделить синим ячеки [E52:F52]
            worksheet.Cells[54, "E"].Value = "Способ прокладки";
            //Тут нужно обединить ячеки [E54:F54]
            //Тут нужно выделить синим ячеки [E54:F54]
            worksheet.Cells[56, "E"].Value = "Жильность";
            //Тут нужно обединить ячеки [E56:F56]
            //Тут нужно выделить синим ячеки [E56:F56]
            worksheet.Cells[60, "E"].Value = "Тип трубы";
            //Тут нужно обединить ячеки [E60:F60]
            //Тут нужно выделить синим ячеки [E60:F60]
            worksheet.Cells[62, "E"].Value = "Длинна трубы, м";
            //Тут нужно обединить ячеки [E62:F62]
            //Тут нужно выделить синим ячеки [E62:F62]
            worksheet.Cells[64, "E"].Value = "Диаметр трубы";
            //Тут нужно обединить ячеки [E64:F64]
        }
        public void Draw_excel_vvod(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица ввода
        {
            //Тут нужно вставить название шкафа из названия листа в ячейку [M6]
            //Тут нужно объеденить ячейки [M6:N6]
            worksheet.Cells[7, "M"].Value = "Руст,кВт"; 
            worksheet.Cells[8, "M"].Value = "Kc"; 
            worksheet.Cells[9, "M"].Value = "Рр,кВт"; 
            worksheet.Cells[10, "M"].Value = "Ip,A"; 
            worksheet.Cells[11, "M"].Value = "cosф"; 
            //Тут нарисовать границы ячейкам [M6:N11]
        }
        public void Draw_excel_nagr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица нагрузка по фазам, кВт
        {
            worksheet.Cells[5, "S"].Value = "нагрузка по фазам, кВт"; 
            //Тут нужно объеденить ячейки [S5:U6]
            worksheet.Cells[6, "S"].Value = "L1"; 
            worksheet.Cells[6, "T"].Value = "L2"; 
            worksheet.Cells[6, "U"].Value = "L3"; 
            worksheet.Cells[8, "S"].Value = "Перекос по фазам:";
            //Тут нужно объеденить ячейки [S7:U7]
            //Тут нужно объеденить ячейки [S9:U9]
            //Тут нужно добавить условие появления надписи утроенная нагрузка или симметричная нагрузка [S10:U10]
            worksheet.Cells[10, "S"].Value = "Принять утроенную нагрузку";
            //Тут нужно объеденить ячейки [S10:U10]
            //Тут нарисовать границы ячейкам [S5:U10]
            
        }
        public void Draw_excel_potr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица потребности кабелей и труб
        {
            worksheet.Cells[3, "Y"].Value = "Потребность труб и кабелей, м"; 
            //Тут нужно объеденить ячейки [Y3:Z3]
            worksheet.Cells[4, "Y"].Value = "Тип/Марка"; 
            worksheet.Cells[4, "Z"].Value = "Длина, м";
            //Тут нарисовать границы ячейкам [Y3:Z4]
        }

        public void Excel_fix_row(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Закрепляет строку
        {
            // Fix first row
            // Тут нужно убрать фильтрацию и закрепить строку начиная со второй и столбец начиная с F
            worksheet.Activate();
            worksheet.Application.ActiveWindow.SplitRow = 2;
            worksheet.Application.ActiveWindow.FreezePanes = true;
            // Now apply autofilter
            Excel.Range firstRow = (Excel.Range)worksheet.Rows[1];
            firstRow.AutoFilter(1,
                                Type.Missing,
                                Excel.XlAutoFilterOperator.xlAnd,
                                Type.Missing,
                                true);

       }
    }

}
