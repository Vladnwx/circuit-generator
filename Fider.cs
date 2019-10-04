using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace circuit_generator
{
    public class Fider
    {
        public string Source { get; set; } // Источник (начало фидера)
        public string destination { get; set; } // Место назначения (конец фидера)
        public double lenght { get; set; } // Длина кабельной линии

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
