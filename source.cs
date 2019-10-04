using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    class tabl_odnolin_left // Таблица слева для однолинейной схемы
    {        
        const string property_1 = "ИСТОЧНИК ПИТАНИЯ"; // Свойство №1
        const string property_2 = "Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А"; // Свойство №2
        const string property_3 = "Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А"; // Свойство №3
        const string property_4 = "Пускатель магнитный: тип; ток нагревательного элемента, А"; // Свойство №4
        const string property_5 = "- Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м"; // Свойство №5
        const string property_6 = "- потеря напряжения, %;- марка, сечение проводника"; // Свойство №6
        const string property_7 = "УСЛОВНОЕ ОБОЗНАЧЕНИЕ НА ПЛАНЕ"; // Свойство №7
        const string property_8 = "РАСПРЕДЕЛЕНИЕ ПО ФАЗАМ"; // Свойство №8
        const string property_9 = "НОМЕР ПО ПЛАНУ"; // Свойство №9
        const string property_10 = "U, В"; // Свойство №10
        const string property_11 = "Ррасч. кВт"; // Свойство №11
        const string property_12 = "cos f"; // Свойство №12
        const string property_13 = "Ток Iрасч., А"; // Свойство №13
        const string property_14 = "Наименование потребителя"; // Свойство №14
        const string property_15 = "Длинна кабельной трассы, м."; // Свойство №15 
        const string property_16 = "Потери, %"; // Свойство №16 
        const string property_17 = "кабель, мм.кв."; // Свойство №17 
        const string property_18 = "Начало кабельной линии"; // Свойство №18 
        const string property_19 = "Конец кабельной линии"; // Свойство №19 
        const string property_20 = "марка кабеля"; // Свойство №20 
        const string property_21 = "Способ прокладки"; // Свойство №21 
        const string property_22 = "Тип трубы"; // Свойство №22
        const string property_23 = "Длинна трубы, м"; // Свойство №23 
        const string property_24 = "Диаметр трубы"; // Свойство №24 
        const string property_25 = "жильность"; // Свойство №25 
        const string property_26 = "жильность"; // Свойство №26 
        const string property_27 = "жильность"; // Свойство №27 
        const string property_28 = "жильность"; // Свойство №28 
        const string property_29 = "жильность"; // Свойство №29
        const string property_30 = "жильность"; // Свойство №30 
    }

    class tabl_odnolin_vvod // Таблица ввода
    {
        const string property_1 = "Руст,кВт"; // Свойство №1
        const string property_2 = "Kc"; // Свойство №2
        const string property_3 = "Рр,кВт"; // Свойство №3
        const string property_4 = "Ip,A"; // Свойство №4
        const string property_5 = "cosф"; // Свойство №5
    }
    class tabl_odnolin_nagr  // Таблица нагрузка по фазам, кВт
    {
        const string property_1 = "нагрузка по фазам, кВт"; // Свойство №1
        const string property_2 = "L1"; // Свойство №2
        const string property_3 = "L2"; // Свойство №3
        const string property_4 = "L3"; // Свойство №4
        const string property_5 = "Перекос по фазам:"; // Свойство №5
        const string property_6 = "Принять утроенную нагрузку"; // Свойство №6
    }
    class tabl_odnolin_potr // Таблица потребности кабелей и труб
    {
        const string property_1 = "Тип/Марка"; // Свойство №1
        const string property_2 = "Длина, м"; // Свойство №2
    }
}
