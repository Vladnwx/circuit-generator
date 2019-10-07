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
        
        static const int QF_vvod_row = 8; // Номер строки, в которую пишется вводной автомат
        static const int QF_type_vvod_row = 9; // Номер строки, в которую пишется тип вводного автомата
        static const int QF_setpoint_vvod_row = 10; // Номер строки, в которую пишется уставка вводного автомата
        static const int QF_p_vvod_row = 11; // Номер строки, в которую пишется количество полюсов вводного автомата
        
        
        public string Source { get; set; } // Источник (начало фидера)
        public string Destination { get; set; } // Место назначения (конец фидера)
        public double Lenght { get; set; } // Длина кабельной линии
        
        public double Power { get; set; } // Мощность фидера
        public double Current { get; set; } // Ток фидера
        public double Voltage { get; set; } // Напряжение фидера
        public double Cos_fi { get; set; } // Косинус фидера
        

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
    
    public void Calculate_Power ()  //Вычисляет мощность фидера в зависимости от нагрузки  и если нужно то суммирует
    {
        Power = 1;
    }
    
    public void Calculate_current ()  //Вычисляет ток в фидере, по мощности и количеству фаз
    {
       if Voltage<240
        Current = (Power*0.001)/(Voltage*Cos_fi)
           else if (Voltage>240 && Voltage<410)
        Current = (Power*0.001)/(Voltage*Cos_fi*1.73)
               else Msgbox("Ошибка"); // Exeption Вывод ошибки о недопустимости напряжения
    }
    
    public void Select_QF_current ()  //Выбирает автомат по мощности фидера, добавить возможность ручного выбора автомата
    {
        // Проверка что ток не равен нулю и если он равен нулю то писать резерв
        if (Current > 0)
        {
        }
        else 
            Msgbox("Ошибка"); // Exeption Вывод ошибки тока
    }
    
    public void Select_cabel_current ()  //Выбирает Кабель по мощности и току фидера фидера, добавить возможность ручного выбора кабеля
    {
        //Проверка что ток не равен нулю  
    }
    
     public void Calculate_cabel_loss ()  //Вычисляет потери по выбранному кабелю и току фидера фидера если потери кабеля превышают уставку, то выбирает следующий кабель и автомат
    {
    }
    
    public void Output_fider_info1 ()  //Объединяет информацию по фидеру в 1-ю строчку надписи кабеля
    {
    }
    
    public void Output_fider_info2 ()  //Объединяет информацию по фидеру во 2-ю строчку надписи кабеля
    {
    }
    
    public void Select_cabel_truba ()  //Выбирает сечение применяемой трубы для фидера
    {
    }
    
    public void Numeration_QF ()  //Автоматическая нумерация автоматов, добавить возможность ручного выбора номера, остальные автонумерация
    {
    }
    
    public void Sort_Fider_current ()  //Автоматическая сортировка автоматов по нагрузке и балансирование нагрузки
    {
    }
    
     public void Calculate_tkz_R ()  //Вычисляет Эквивалетное значение омического сопротивления фидера для ТКЗ
    {
    }
        
     public void Calculate_tkz_X ()  //Вычисляет Эквивалетное значение реактивного сопротивления линии для ТКЗ
    {
    }
}
