using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    public static class Constants
    {
        public const int Width_column = 11; // Ширина столбца
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
            }

            public static class NPotreb
            {
                public static class Column
                {
                    public const int Start = Constants.Tabl.Left.Column.Start + 21; // Номер столбца, в которую пишется табличка потребности в кабеле и трубах
                }
                public static class Row
                {
                    public const int Start = Constants.Tabl.Left.Row.Start; // Номер строки, с которого начинается таблица схемы (срока 4)
                }
            }
            public static class vvod
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
                public const int Image = Info+1; // Номер строки, в которую пишется изображение на плане
                public const int Phase = Image+1; // Номер строки, в которую пишется номер фазы фидера L1, L2, L3 или L1 L2 L3 (3-х фазная)
                public const int Id = Phase + 1; // Номер строки, в которую пишется обозначение фидера на планах расположения
                public const int U = Id+1; // Номер строки, в которую пишется выбранное напряжение на фидере
                public const int P = U+1; // Номер строки, в которую пишется мощность на фидере, кВт
                public const int Cos = P+1; // Номер строки, в которую пишется cos(fi) на фидере
                public const int I = Cos+1; // Номер строки, в которую пишется Ток на фидере
                public const int Name_potr = I+1; // Номер строки, в которую пишется наименование потребителя фидере
                
                public const int Lenght= Name_potr+4; // Номер строки, в которую пишется длина фидера
                public const int Poteri = Lenght+2; // Номер строки, в которую пишется потери фидера
                public const int Cabel = Poteri+2; // Номер строки, в которую пишется выбранный кабель фидера
                public const int Start = Cabel+6; // Номер строки, в которую пишется начало фидера
                public const int Finish = Start+1; // Номер строки, в которую пишется конец фидера
                public const int Cable_marka = Finish+2; // Номер строки, в которую пишется марка выбранного кабеля фидера
                public const int Cable_metal_type = Cable_marka + 2; // Номер строки, в которую пишется материал жил выбранного кабеля фидера
                public const int Prokladka_type = Cable_metal_type +2; // Номер строки, в которую пишется способ прокладки кабеля фидера
                public const int Cabel_jila = Prokladka_type + 2; // Номер строки, в которую пишется жильность выбранного кабеля фидера
                public const int Truba_type = Cabel_jila+2; // Номер строки, в которую пишется тип трубы кабеля фидера
                public const int Truba_lenght = Truba_type+2; // Номер строки, в которую пишется длина трубы кабеля фидера
                public const int Truba_diam = Truba_lenght+2; // Номер строки, в которую пишется диаметр трубы кабеля фидера

                public static class QF
                {
                    public const int First = Tabl.Left.Row.Start + 11; // Номер строки, в которую пишется нумерация автоматов
                    public const int Type = First + 1; // Номер строки, в которую пишется тип автоматов
                    public const int Setpoint = Type + 1; // Номер строки, в которую пишется уставка автоматов
                    public const int p = Setpoint + 1; // Номер строки, в которую пишется количество полюсов автоматов
                    public const int Har_type = p + 1; // Номер строки, в которую пишется характеристика автоматов
                    public const int Manufacturer = Har_type+1; // Номер строки, в которую пишется производитель автоматов
                }
            }
        }

       




            
        
        


       
        
        
        
    }
}
