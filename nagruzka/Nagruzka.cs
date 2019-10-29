namespace circuit_generator
{
    public partial class Nagruzka
    {
        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; } // Лист, с которым мы работаем
        private double NumbersOfPhases { get; set; } // Число фаз
        private double NumberPhase { get; set; } // Номер фазы
        private double Voltage { get; set; } // Напряжение в Вольтах
        private double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)
        private double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        private double Current { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)
        private bool StartInBox { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита
        private string Start { get; set; } // начало нагрузки
        private string Source { get; set; } // Местоположение нагрузки
        private string Harakter1 { get; set; } // Характер нагрузки
        private string TypeNetwork1 { get; set; } // Тип сети
        private string Type1 { get; set; } // Тип нагрузки промежуточная/конечная
        private int ActiveColuumn { get; set; } // Номер столбца для нагрузки
    }
}
