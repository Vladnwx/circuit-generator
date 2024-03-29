﻿using System.Collections.Generic;

namespace circuit_generator
{
    public static class Constants
    {
        public const int WidthColumn = 11; // Ширина столбца
        public static class Tabl
        {

            public static class Left
            {
                public static class Column
                {
                    public const int Start = 4; // Номер стобца, с которого начинается таблица схемы (столбец Е)
                }
                public static class Row
                {
                    public const int Start = 4; // Номер строки, с которого начинается таблица схемы (срока 4)
                    public const string StartValue1 = "ИСТОЧНИК ПИТАНИЯ";
                    public const string StartValue2 = "Распределительный пункт: номер; тип; установленная и расчетная мощность, кВт. Аппарат на вводе: тип; ток, А";
                    public const string StartValue3 = "Выключатель автоматический или предохранитель: тип; ток расцепителя или плавкой вставки, А";
                    public const string StartValue4 = "Пускатель магнитный: тип; ток нагревательного элемента, А";
                }
            }

            public static class Nagr
            {
                public static class Column
                {
                    public const int Start = Constants.Tabl.Left.Column.Start + 15; // Номер столбца, в которую пишется табличка нагрузок
                }
                public static class Row
                {
                    public const int Start = Constants.Tabl.Left.Row.Start; // Номер строки, с которого начинается таблица схемы (срока 4)
                }
                public const string Value1 = "Нагрузка по фазам, кВт";
                public const string Value2 = "L1";
                public const string Value3 = "L2";
                public const string Value4 = "L3";
                public const string Value5 = "Перекос по фазам:";
            }

            public static class Potreb
            {
                public static class Column
                {
                    public const int Start = Constants.Tabl.Left.Column.Start + 21; // Номер столбца, в которую пишется табличка потребности в кабеле и трубах
                }
                public static class Row
                {
                    public const int Start = Constants.Tabl.Left.Row.Start; // Номер строки, с которого начинается таблица схемы (срока 4)
                }
                public const string Value1 = "Потребность труб и кабелей, м";
                public const string Value2 = "Тип/Марка";
                public const string Value3 = "Длина, м";
            }
            public static class Vvod
            {
                public static class Column
                {
                    public const int Start = Constants.Tabl.Left.Column.Start + 9; // Номер столбца, в которую пишется табличка ввода
                }
                public static class Row
                {
                    public const int Start = 4; // Номер строки, с которого начинается таблица схемы (срока 4)
                    public const int QF = Start + 1; // Номер строки, в которую пишется вводной автомат
                    public const int QF_type = QF + 1; // Номер строки, в которую пишется тип вводного автомата
                    public const int QF_setpoint = QF_type + 1; // Номер строки, в которую пишется уставка вводного автомата
                    public const int QF_p = QF_setpoint + 1; // Номер строки, в которую пишется количество полюсов вводного автомата
                }
                public const string Value1 = "Руст,кВт";
                public const string Value2 = "Kc";
                public const string Value3 = "Рр,кВт";
                public const string Value4 = "Ip,A";
                public const string Value5 = "cos f";

            }
        }
        public static class Fider
        {
            public static class Column
            {
                public const int First = Tabl.Left.Column.Start + 2; // Номер стобца, с которого начинается фидер
                public const int Width = 2; // Число столбцов, которое занимает фидер
            }

            public static class Row
            {
                public const int First = Tabl.Left.Row.Start + 2; // Номер строки, с которой начинается фидер
                public const int Last = Tabl.Left.Row.Start + 60; // Номер строки, которой заканчивается фидер
                public const int Info = Tabl.Left.Row.Start + 21; // Номер строки, в которую пишется сборная информация по фидеру
                public const string InfoValue1 = "Расчетная нагрузка, кВт - коэффициент мощности - расчетный ток, А - длина участка, м";
                public const string InfoValue2 = "потеря напряжения, %;- марка, сечение проводника";
                public const int Image = Info + 1; // Номер строки, в которую пишется изображение на плане
                public const string ImageValue = "Условное обозначение на плане";
                public const int Phase = Image + 1; // Номер строки, в которую пишется номер фазы фидера L1, L2, L3 или L1 L2 L3 (3-х фазная)
                public const string PhaseValue = "Распределение по фазам";
                public const int Id = Phase + 1; // Номер строки, в которую пишется обозначение фидера на планах расположения
                public const string IdValue = "Номер по плану";
                public const int Voltage = Id + 1; // Номер строки, в которую пишется выбранное напряжение на фидере
                public const string UValue = "Voltage, В";
                public const int Power = Voltage + 1; // Номер строки, в которую пишется мощность на фидере, кВт
                public const string PValue = "Ррасч., кВт";
                public const int Cosphi = Power + 1; // Номер строки, в которую пишется cos(fi) на фидере
                public const string CosValue = "cos f";
                public const int Current = Cosphi + 1; // Номер строки, в которую пишется Ток на фидере
                public const string CurrentValue = "Ток Iрасч., А";
                public const int NamePotr = Current + 1; // Номер строки, в которую пишется наименование потребителя фидере
                public const string NamePotrValue = "Наименование потребителя";
                public const int Lenght = NamePotr + 4; // Номер строки, в которую пишется длина фидера
                public const string LenghtValue = "Длинна кабельной трассы, м.";
                public const int Poteri = Lenght + 2; // Номер строки, в которую пишется потери фидера
                public const string PoteriValue = "Потери, %";
                public const int Cabel = Poteri + 2; // Номер строки, в которую пишется выбранный кабель фидера
                public const string CabelValue = "кабель, мм.кв.";
                public const int Start = Cabel + 6; // Номер строки, в которую пишется начало фидера
                public const string StartValue = "Начало кабельной линии";
                public const int Destenation = Start + 1; // Номер строки, в которую пишется конец фидера
                public const string FinishValue = "Конец кабельной линии";
                public const int CableMarka = Destenation + 2; // Номер строки, в которую пишется марка выбранного кабеля фидера
                public const string CableMarkaValue = "марка кабеля";
                public const int CableMetalType = CableMarka + 2; // Номер строки, в которую пишется материал жил выбранного кабеля фидера
                public const string CableMetalTypeValue = "CU / Al";
                public const int ProkladkaType = CableMetalType + 2; // Номер строки, в которую пишется способ прокладки кабеля фидера
                public const string ProkladkaTypeValue = "Способ прокладки";
                public const int CabelJila = ProkladkaType + 2; // Номер строки, в которую пишется жильность выбранного кабеля фидера
                public const string CabelJilaValue = "Жильность";
                public const int TrubaType = CabelJila + 2; // Номер строки, в которую пишется тип трубы кабеля фидера
                public const string TrubaTypeValue = "Тип трубы";
                public const int TrubaLenght = TrubaType + 2; // Номер строки, в которую пишется длина трубы кабеля фидера
                public const string TrubaLenghtValue = "Длинна трубы, м";
                public const int TrubaDiam = TrubaLenght + 2; // Номер строки, в которую пишется диаметр трубы кабеля фидера
                public const string TrubaDiamValue = "Диаметр трубы";

                public static readonly List<int> listInt = new List<int> { First, Last, Info, Image, Phase, Id, Voltage, Power, Cosphi, Current, NamePotr, Lenght, Cabel, Start, Destenation, CableMarka, CableMetalType, ProkladkaType, CabelJila, TrubaType, TrubaLenght, TrubaDiam};

                public static readonly List<string> listString = new List<string> {  InfoValue1, InfoValue2, ImageValue, PhaseValue, IdValue, UValue, PValue, CosValue, CurrentValue, NamePotrValue, LenghtValue, CabelValue, StartValue, FinishValue, CableMarkaValue, CableMetalTypeValue, ProkladkaTypeValue, CabelJilaValue, TrubaTypeValue, TrubaLenghtValue, TrubaDiamValue };



                public static class QF
                {
                    public const int First = Tabl.Left.Row.Start + 11; // Номер строки, в которую пишется нумерация автоматов
                    public const int Type = First + 1; // Номер строки, в которую пишется тип автоматов
                    public const int Setpoint = Type + 1; // Номер строки, в которую пишется уставка автоматов
                    public const int p = Setpoint + 1; // Номер строки, в которую пишется количество полюсов автоматов
                    public const int Har_type = p + 1; // Номер строки, в которую пишется характеристика автоматов
                    public const int Manufacturer = Har_type + 1; // Номер строки, в которую пишется производитель автоматов
                }
            }
        }
        public static class StandartNagruzka
        {
            public static class StandartNumbersOfPhases
            {
                public const double Value1 = 1D;
                public const double Value2 = 2D;
                public const double Value3 = 3D;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3 };
            }
            public static class StandartPower
            {
                public const double Value1 = 1D;
                public const double Value2 = 1.5D;
                public const double Value3 = 2D;
                public const double Value4 = 2.5D;
                public const double Value5 = 3D;
                public const double Value6 = 0.5D;
                public const double Value7 = 0.1D;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3, Value4, Value5, Value6, Value7 };
            }
            public static class StandartVoltage
            {
                public const double Value1 = 220D;
                public const double Value2 = 380D;
                public const double Value3 = 24D;
                public const double Value4 = 12D;
                public const double Value5 = 230D;
                public const double Value6 = 400D;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3, Value4, Value5, Value6 };

            }
            public static class StandartCosf
            {
                public const double Value1 = 0.9D;
                public const double Value2 = 0.95D;
                public const double Value3 = 0.85D;
                public const double Value4 = 0.8D;
                public const double Value5 = 1D;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3, Value4, Value5};
            }
           
            public static class NumberPhases
            {
                public const double Value1 = 1D;
                public const double Value2 = 2D;
                public const double Value3 = 3D;
                public const double Value4 = 123D;
                public const double Value5 = 12D;
                public const double Value6 = 23D;
                public const double Value7 = 13D;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3, Value4, Value5, Value6, Value7 };
            }

            
            public static class StandartHarakter
            {
                public const string Value1 = "Светильники";
                public const string Value2 = "Розетки";
                public const string Value3 = "Двигатель";
                public const string Value4 = "Шкаф";
                public const string Value5 = "Комплексная нагрузка";
                public static readonly List<string> list = new List<string> { Value1, Value2, Value3, Value4, Value5};
                // Характер нагрузки (двигатель, розетка, светильник, шкафчик), добавить рекомендации по ограничению одной группы освещения не более 10А. 
                //Елси нагрузка комплексная то давать возможность ввести косинус. Если розетка, то давать ввести количество розеток. 
                //Если светильники, то давать ввести количество светильников и мощность одного. 
                //Если двигатель, то запрашивать данные об установленном выключаетел в шкафу управления двигателем.
            }
            public static class StandartTypeNetwork
            {
                public const string Value1 = "трехфазная разводка с ответвлением в коробке пофазно";
                public const string Value2 = "однофазная прямо от щита";
                public static readonly List<string> list = new List<string> { Value1, Value2};
            }
            public static class StandartType
            {
                public const string Value1 = "конечная";
                public const string Value2 = "промежуточная";
                public static readonly List<string> list = new List<string> { Value1, Value2};
            }
        }

        public static class Exeption
        {
            public const string Value1 = "Передаваемые значения мощности, напряжения и косинуса должны быть числом";
            public const string Value2 = "Количество фаз неверно";
            public static readonly List<string> list = new List<string> { Value1, Value2};
        }

        public static class Cable
        {
            public static class MetalType
            {
                public const string Value1 = "медь";
                public const string Value2 = "алюминий";
                public static readonly List<string> list = new List<string> { Value1, Value2 };
            }
            public static class InsulationMaterial
            {
                public const string Value1 = "ПВХ";
                public const string Value2 = "ПЭ";
                public static readonly List<string> list = new List<string> { Value1, Value2 };
            }
            public static class Environment
            {
                public const string Value1 = "воздух";
                public const string Value2 = "земля";
                public static readonly List<string> list = new List<string> { Value1, Value2 };
            }
            public static class CurrentType
            {
                public const string Value1 = "постоянный";
                public const string Value2 = "переменный";
                public static readonly List<string> list = new List<string> { Value1, Value2 };
            }
            public static class CoreConstruction
            {
                public const string Value1 = "однопроволочный";
                public const string Value2 = "многопроволочный";
                public static readonly List<string> list = new List<string> { Value1, Value2 };
            }
        }
        public static class Avtomat

        {
            public static class Polus
            {
                public const string Value1 = "1P";
                public const string Value2 = "2P";
                public const string Value3 = "3P";
                public const string Value4 = "4P";
                public static readonly List<string> list = new List<string> { Value1, Value2, Value3, Value4 };
            }
            public static class HarType
            {
                public const string Value1 = "A";
                public const string Value2 = "B";
                public const string Value3 = "C";
                public const string Value4 = "D";
                public static readonly List<string> list = new List<string> { Value1, Value2, Value3, Value4 };
            }

            public static class Type
            {
                public const string Value1 = "Автоматический выключатель";
                public const string Value2 = "Устройство защитного отключения";
                public const string Value3 = "Выключатель нагрузки";
                public const string Value4 = "Автоматический выключатель + Устройство защитного отключения";
                public const string Value5 = "Дифференциальный автоматический выключатель";
                public static readonly List<string> list = new List<string> { Value1, Value2, Value3, Value4, Value5 };
            }
            public static class Manufacturer
            {
                public const string Value1 = "Schneider Electric";
                public const string Value2 = "Siemens";
                public const string Value3 = "ABB";
                public const string Value4 = "IEK";
                public const string Value5 = "Legrand";
                public static readonly List<string> list = new List<string> { Value1, Value2, Value3, Value4, Value5 };
            }

            public static class Series
            {
                public const string Value1 = "IC60N";
                public static readonly List<string> list = new List<string> { Value1 };
            }
            public static class Setpoint
            {
                public const double Value1 = 6;
                public const double Value2 = 10;
                public const double Value3 = 16;
                public const double Value4 = 20;
                public const double Value5 = 25;
                public const double Value6 = 32;
                public const double Value7 = 40;
                public const double Value8 = 50;
                public const double Value9 = 63;
                public const double Value10 = 80;
                public const double Value11 = Value2*10;
                public const double Value12 = 125;
                public const double Value13 = Value3 * 10;
                public const double Value14 = Value4 * 10;
                public const double Value15 = Value5 * 10;
                public const double Value16 = 315;
                public const double Value17 = 355;
                public const double Value18 = Value7 * 10;
                public const double Value19 = Value8 * 10;
                public const double Value20 = Value9 * 10;
                public const double Value21 = Value10 * 10;
                public const double Value22 = Value2 * 100;
                public const double Value23 = 1200;
                public const double Value24 = Value3 * 100;
                public const double Value25 = Value4 * 100;
                public const double Value26 = Value5 * 100;
                public const double Value27 = Value6 * 100;
                public const double Value28 = Value7 * 100;
                public const double Value29 = Value8 * 100;
                public const double Value30 = Value9 * 100;
                public static readonly List<double> list = new List<double> { Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16, Value17, Value18, Value19, Value20, Value21, Value22, Value23, Value24, Value25, Value26, Value27, Value28, Value29, Value30 };

            }



        }


    }


}
