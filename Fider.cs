using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    public class Fider
    {
        static const int First_fider_column = 15; // Номер стобца, с которого начинается фидер
        static const int fider_width_column = 2; // Число столбцо, которое занимает фидер
        static const int First_fider_row = 15; // Номер строки, с которой начинается фидер
        static const int Last_fider_row = 64; // Номер строки, которой заканчивается фидер
        static const int QF_fider_row = 15; // Номер строки, в которую пишется нумерация автоматов
        static const int QF_type_fider_row = 16; // Номер строки, в которую пишется тип автоматов
        static const int QF_setpoint_fider_row = 17; // Номер строки, в которую пишется уставка автоматов
        static const int QF_p_fider_row = 18; // Номер строки, в которую пишется количество полюсов автоматов
        static const int Fider_info_row = 25; // Номер строки, в которую пишется сборная информация по фидеру
        static const int Fider_phase_row = 27; // Номер строки, в которую пишется номер фазы фидера L1, L2, L3 или L1 L2 L3 (3-х фазная)
        static const int Fider_id_row = 28; // Номер строки, в которую пишется обозначение фидера на планах расположения
        static const int Fider_u_row = 29; // Номер строки, в которую пишется выбранное напряжение на фидере
        static const int Fider_p_row = 30; // Номер строки, в которую пишется мощность на фидере, кВт
        static const int Fider_cos_row = 31; // Номер строки, в которую пишется cos(fi) на фидере
        static const int Fider_i_row = 32; // Номер строки, в которую пишется Ток на фидере
        static const int Fider_name_potr_row = 33; // Номер строки, в которую пишется наименование потребителя фидере
        static const int Fider_lenght_row = 37; // Номер строки, в которую пишется длина фидера
        static const int Fider_poteri_row = 39; // Номер строки, в которую пишется потери фидера
        static const int Fider_cabel_row = 41; // Номер строки, в которую пишется выбранный кабель фидера
        static const int Fider_start_row = 47; // Номер строки, в которую пишется начало фидера
        static const int Fider_finish_row = 48; // Номер строки, в которую пишется конец фидера
        static const int Fider_cable_marka_row = 50; // Номер строки, в которую пишется марка выбранного кабеля фидера
        static const int Fider_cable_metal_type_row = 52; // Номер строки, в которую пишется материал жил выбранного кабеля фидера
        static const int Fider_prokladka_type_row = 54; // Номер строки, в которую пишется способ прокладки кабеля фидера
        static const int Fider_cabel_jila_row = 54; // Номер строки, в которую пишется жильность выбранного кабеля фидера
        static const int Fider_truba_type_row = 60; // Номер строки, в которую пишется тип трубы кабеля фидера
        static const int Fider_truba_lenght_row = 62; // Номер строки, в которую пишется длина трубы кабеля фидера
        static const int Fider_truba_diam_row = 64; // Номер строки, в которую пишется диаметр трубы кабеля фидера
        
        public string Source { get; set; } // Источник (начало фидера)
        public string Destination { get; set; } // Место назначения (конец фидера)
        public double Lenght { get; set; } // Длина кабельной линии

        public Fider() : this("Неизвестно") // Конструктор без параметров
        {
        }
        public Fider(string Source) : this(Source, "Неизвестно") // Конструктор с указанием только источника
        {
        }
        public Fider(string Source, string destination) : this(Source, destination, 10) // Конструктор без длины
        {
        }
        public Fider(string Source, string destination, double lenght) // Конструктор полный
        {
            this.Source = Source;
            this.destination = destination;
            this.lenght = lenght;
        }
        public void GetInfo() //Информация о фидере в консоль
        {
            Console.WriteLine($"Источник: {Source}  Место назначения: {destination} Длина кабельной линии: {lenght}");
        }
    }
}
