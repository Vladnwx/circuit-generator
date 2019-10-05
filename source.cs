namespace circuit_generator
{
    

    class Tabl_odnolin  // Таблица для рисования схемы
    {
        public void Draw_excel(Microsoft.Office.Interop.Excel.Worksheet worksheet)
        {
            Draw_excel_left(worksheet);
            Draw_excel_vvod(worksheet);
            Draw_excel_nagr(worksheet);
            Draw_excel_potr(worksheet);

        }
        public void Draw_excel_left(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица слева для однолинейной схемы
        {
            worksheet.Cells[1, "A"].RowHeight = 100;
            worksheet.Cells[1, "A"].Value = "ИСТОЧНИК ПИТАНИЯ";
            worksheet.Cells[2, "A"].Value = "Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А"; // Свойство №2
            worksheet.Cells[3, "A"].Value = "Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А"; // Свойство №3
            worksheet.Cells[4, "A"].Value = "Пускатель магнитный: тип; ток нагревательного элемента, А"; // Свойство №4
            worksheet.Cells[5, "A"].Value = "- Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м"; // Свойство №5
            worksheet.Cells[6, "A"].Value = "- потеря напряжения, %;- марка, сечение проводника"; // Свойство №6
            worksheet.Cells[7, "A"].Value = "УСЛОВНОЕ ОБОЗНАЧЕНИЕ НА ПЛАНЕ"; // Свойство №7
            worksheet.Cells[8, "A"].Value = "РАСПРЕДЕЛЕНИЕ ПО ФАЗАМ"; // Свойство №8
            worksheet.Cells[9, "A"].Value = "НОМЕР ПО ПЛАНУ"; // Свойство №9
            worksheet.Cells[10, "A"].Value = "U, В"; // Свойство №10
            worksheet.Cells[11, "A"].Value = "Ррасч. кВт"; // Свойство №11
            worksheet.Cells[12, "A"].Value = "cos f"; // Свойство №12
            worksheet.Cells[13, "A"].Value = "Ток Iрасч., А"; // Свойство №13
            worksheet.Cells[14, "A"].Value = "Наименование потребителя"; // Свойство №14
            worksheet.Cells[15, "A"].Value = "Длинна кабельной трассы, м."; // Свойство №15 
            worksheet.Cells[16, "A"].Value = "Потери, %"; // Свойство №16 
            worksheet.Cells[17, "A"].Value = "кабель, мм.кв."; // Свойство №17 
            worksheet.Cells[18, "A"].Value = "Начало кабельной линии"; // Свойство №18 
            worksheet.Cells[19, "A"].Value = "Конец кабельной линии"; // Свойство №19 
            worksheet.Cells[20, "A"].Value = "марка кабеля"; // Свойство №20 
            worksheet.Cells[21, "A"].Value = "Способ прокладки"; // Свойство №21 
            worksheet.Cells[22, "A"].Value = "Тип трубы"; // Свойство №22
            worksheet.Cells[23, "A"].Value = "Длинна трубы, м"; // Свойство №23 
            worksheet.Cells[24, "A"].Value = "Диаметр трубы"; // Свойство №24 
            worksheet.Cells[25, "A"].Value = "жильность"; // Свойство №25 
            worksheet.Cells[26, "A"].Value = "жильность"; // Свойство №26 
            worksheet.Cells[27, "A"].Value = "жильность"; // Свойство №27 
            worksheet.Cells[28, "A"].Value = "жильность"; // Свойство №28 
            worksheet.Cells[29, "A"].Value = "жильность"; // Свойство №29
            worksheet.Cells[30, "A"].Value = "жильность"; // Свойство №30 
        }
        public void Draw_excel_vvod(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица ввода
        {
            worksheet.Cells[1, "B"].Value = "Руст,кВт"; // Свойство №1
            worksheet.Cells[2, "B"].Value = "Kc"; // Свойство №2
            worksheet.Cells[3, "B"].Value = "Рр,кВт"; // Свойство №3
            worksheet.Cells[4, "B"].Value = "Ip,A"; // Свойство №4
            worksheet.Cells[5, "B"].Value = "cosф"; // Свойство №5}
        }
        public void Draw_excel_nagr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица нагрузка по фазам, кВт
        {
            worksheet.Cells[1, "C"].Value = "нагрузка по фазам, кВт"; // Свойство №1
            worksheet.Cells[2, "C"].Value = "L1"; // Свойство №2
            worksheet.Cells[3, "C"].Value = "L2"; // Свойство №3
            worksheet.Cells[4, "C"].Value = "L3"; // Свойство №4
            worksheet.Cells[5, "C"].Value = "Перекос по фазам:"; // Свойство №5
            worksheet.Cells[6, "C"].Value = "Принять утроенную нагрузку"; // Свойство №6
        }
        public void Draw_excel_potr(Microsoft.Office.Interop.Excel.Worksheet worksheet) // Таблица потребности кабелей и труб
        {
            worksheet.Cells[1, "D"].Value = "Тип/Марка"; // Свойство №1
            worksheet.Cells[2, "D"].Value = "Длина, м"; // Свойство №2
        }
    }

}
