namespace circuit_generator
{
    public partial class Nagruzka
    {
        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; } // Лист, с которым мы работаем
        protected double NumbersOfPhases { get; set; } // Число фаз
        protected double NumberPhase { get; set; } // Номер фазы
        protected double Voltage { get; set; } // Напряжение в Вольтах
        protected double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)
        protected double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        protected double Current { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        protected bool StartInBox { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита
        protected string Start { get; set; } // начало нагрузки
        protected string Source { get; set; } // Местоположение нагрузки
        protected string Harakter1 { get; set; } // Характер нагрузки
        protected string TypeNetwork1 { get; set; } // Тип сети
        protected string Type1 { get; set; } // Тип нагрузки промежуточная/конечная
        protected int ActiveColuumn { get; set; } // Номер столбца для нагрузки
    }
}
