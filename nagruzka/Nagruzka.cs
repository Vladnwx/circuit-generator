using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; } // Лист, с которым мы работаем
        public double NumbersOfPhases { get; set; } // Число фаз
        public double NumberPhase { get; set; } // Номер фазы
        public double Voltage { get; set; } // Напряжение в Вольтах
        public double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)
        public double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        public double Current { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        public bool StartInBox { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита
        public string Start { get; set; } // начало нагрузки
        public string Destenation { get; set; } // Местоположение нагрузки
        public string Harakter { get; set; } // Характер нагрузки
        public string TypeNetwork { get; set; } // Тип сети
        public string Type { get; set; } // Тип нагрузки промежуточная/конечная
        public int ActiveColuumn { get; set; } // Номер столбца для нагрузки

       // public SortedList<int, string> NagruzkaList = new SortedList<int, string>(); // Лист значений и соответствующих им строк записи в таблице 
        public SortedList<int, string> listsorted = new SortedList<int, string>(); // Лист значений и соответствующих им строк записи в таблице
        


    }
}
