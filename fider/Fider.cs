using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Fider : Nagruzka
    {
        public double Lenght { get; set; } // Длина кабельной линии
        public int Fider_number_coluumn { get; set; } // Номер столбца для фидера
        public Fider() : this("Неизвестно") // Конструктор без параметров
        {
        }
        public Fider(string Start) : this(Start, "Неизвестно") // Конструктор с указанием только источника
        {
        }
        public Fider(string Start, string Source) : this(Source, Source, 10) // Конструктор без длины
        {
        }
        public Fider(string Start, string Source, double lenght) // Конструктор полный
        {
            this.Start = Start;
            this.Source = Source;
            this.Lenght = lenght;
        }
        public void GetInfo() //Информация о фидере в консоль
        {
            Console.WriteLine($"Источник: {Start}  Место назначения: {Source} Длина кабельной линии: {Lenght}");
        }
        public void Calculate_Power()  //Вычисляет мощность фидера в зависимости от нагрузки  и если нужно то суммирует
        {
            //Power = 1;
        }
        public void Calculate_current()  //Вычисляет ток в фидере, по мощности и количеству фаз
        {
            if (this.Voltage < 240)
                Current = (Power * 0.001) / (Voltage * Cosphi);
            else if (Voltage > 240 && Voltage < 410)
                Current = (Power * 0.001) / (Voltage * Cosphi * 1.73);
            else MessageBox.Show(text: "Ошибка"); // Exeption Вывод ошибки о недопустимости напряжения
        }
        public void Select_QF_current()  //Выбирает автомат по мощности фидера, добавить возможность ручного выбора автомата
        {
            // Проверка что ток не равен нулю и если он равен нулю то писать резерв
            if (this.Current > 0)
            {
            }
            else
                MessageBox.Show("Ошибка"); // Exeption Вывод ошибки тока
        }
        public void Select_cabel_current()  //Выбирает Кабель по мощности и току фидера фидера, добавить возможность ручного выбора кабеля
        {
            //Проверка что ток не равен нулю  
        }
        public void Calculate_cabel_loss()  //Вычисляет потери по выбранному кабелю и току фидера фидера если потери кабеля превышают уставку, то выбирает следующий кабель и автомат
        {
        }
        public void Output_fider_info1()  //Объединяет информацию по фидеру в 1-ю строчку надписи кабеля
        {
            //Output_fider_info1() = 
        }
        public void Output_fider_info2()  //Объединяет информацию по фидеру во 2-ю строчку надписи кабеля
        {
            // Output_fider_info2() = 
        }
        public void Select_cabel_truba()  //Выбирает сечение применяемой трубы для фидера
        {
        }
        public void Numeration_QF()  //Автоматическая нумерация автоматов, добавить возможность ручного выбора номера, остальные автонумерация
        {
        }
        public void Sort_Fider_current()  //Автоматическая сортировка автоматов по нагрузке и балансирование нагрузки
        {
        }
        public void Calculate_tkz_R()  //Вычисляет Эквивалетное значение омического сопротивления фидера для ТКЗ
        {
        }
        public void Calculate_tkz_X()  //Вычисляет Эквивалетное значение реактивного сопротивления линии для ТКЗ
        {
        }

    }
}
