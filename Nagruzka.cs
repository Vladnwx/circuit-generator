using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace circuit_generator
{
    public class Nagruzka
    {

        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; }
       
        private static readonly List<string> NumberOfPhases = new List<string>() { "1", "2", "3" };
        public static List<string> GetNumberOfPhases()
        {
            return NumberOfPhases;
        }
        private static readonly List<double> StandartVoltage = new List<double>() { 220D, 380D, 24D, 12D, 230D, 400D };
        public static List<double> GetStandartVoltage()
        {
            return StandartVoltage;
        }
        private static readonly List<double> StandartPower = new List<double>() { 1, 1.5D, 2D, 2.5D, 3D, 0.5D, 0.1D }; //добавить список типовых мощностей в зависимости от выбранных характеров
        public static List<double> GetStandartPower()
        {
            return StandartPower;
        }
        private static readonly List<string> Harakter = new List<string>() { "Светильники", "Розетки", "Двигатель", "Шкаф", "Комплексная нагрузка" };
        public static List<string> GetHarakter()
        {
            return Harakter;
        }
        // Характер нагрузки (двигатель, розетка, светильник, шкафчик), добавить рекомендации по ограничению одной группы освещения не более 10А. 
        //Елси нагрузка комплексная то давать возможность ввести косинус. Если розетка, то давать ввести количество розеток. 
        //Если светильники, то давать ввести количество светильников и мощность одного. 
        //Если двигатель, то запрашивать данные об установленном выключаетел в шкафу управления двигателем.

        private static readonly List<string> TypeNetwork = new List<string>() { "трехфазная разводка с ответвлением в коробке пофазно", "однофазная прямо от щита", "3" }; // Тип применяемой сети на комплексную нагрузку
        public static List<string> GetTypeNetwork()
        {
            return TypeNetwork;
        }

        private static readonly List<string> Type = new List<string>() { "конечная", "промежуточная" }; // Тип нагрузки
        public static List<string> GetType()
        {
            return Type;
        }

        private double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)

        //добавить список типовых косинусов в зависимости от выбранных характеров
        double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)

        bool StartInBox { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита

        string Start { get; set; } // начало нагрузки

        string Source { get; set; } // Местоположение нагрузки

        int ActiveColuumn { get; set; } // Номер столбца для нагрузки


        public void AddToSheet() // Добавляет нагрузку на лист
        {
            Worksheet = Globals.ThisAddIn.Application.ActiveSheet;

            ActiveColuumn = Globals.ThisAddIn.Application.ActiveCell.Column;

            Worksheet.Cells[Constants.Fider.Row.Phase, ActiveColuumn].Value = NumberOfPhases;

            Worksheet.Cells[Constants.Fider.Row.P, ActiveColuumn].Value = Power;

            Worksheet.Cells[Constants.Fider.Row.Cos, ActiveColuumn].Value = Cosphi;

            Worksheet.Cells[Constants.Fider.Row.Start, ActiveColuumn].Value = Start;

            Worksheet.Cells[Constants.Fider.Row.Finish, ActiveColuumn].Value = Source;

            Globals.ThisAddIn.Application.ActiveWorkbook.Save();
        }



        /*   public Nagruzka() : this("Неизвестно") // Конструктор без параметров
           {
           }
           public Nagruzka(string NumberOfPhases) : this(NumberOfPhases, "Неизвестно") // Конструктор с указанием только числа фаз
           {
           }
           public Nagruzka(string NumberOfPhases, string Power) : this(Source, Power, "Неизвестно") // Конструктор c мощностью
           {
           }*/
        /*  public Nagruzka(string NumberOfPhases, string Power, string Cosphi) : this(Source, Power, Cosphi, "Неизвестно") // Конструктор с косинусом
          {
          }*/
        /*   public Nagruzka(string NumberOfPhases, string Power, string Cosphi, bool StartInBox) : this(Source, Power, Cosphi, bool StartInBox, "Неизвестно") // Конструктор с указанием начала в щите
           {
           }*/
        /*  public Nagruzka(string NumberOfPhases, string Power, string Cosphi, bool StartInBox, string Start) : this(Source, Power, Cosphi, bool StartInBox, string Start, "Неизвестно") // Конструктор с указанием начала нагрузки
          {
          }
          public Nagruzka(string NumberOfPhases, string Power, string Cosphi, bool StartInBox, string Start, string Source) : this(Source, Power, Cosphi, bool StartInBox, string Start, string Source, "Неизвестно") // Конструктор с указанием конца нагрузки
          {
          }*/
       /* public Nagruzka(string NumberOfPhases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load, string TypeNetwork) // Конструктор полный
        {
            this.NumberOfPhases = NumberOfPhases;
            this.Power = Convert.ToDouble(Power);
            this.Cosphi = Convert.ToDouble(Cosphi);
            this.StartInBox = Convert.ToBoolean(Start_load_in_box);
            this.Start = Start_load;
            this.Source = Source_load;
            this.TypeNetwork = TypeNetwork;
        }

        public Nagruzka()
        {
        }
        /*  public Double Chek_double ( string s) //Проверяет передачу дробного числа с символом запятой, преобразует запятую в точку и проверяет возможность преобразования в Double
 {
     char ch_find = ','; // Символ, который мы ищем для замены
     char ch_change = '.'; // Символ, который на который мы заменяем
     s = s.Replace(ch_find, ch_change); // Тут мы меняем символы
     //Тут мы ловим возможну ошибку преобразования в Double
     try 
     {
         return Convert.ToDouble(s);
     }

     catch (Exception ex) 
     {
        MessageBox.Show($"Исключение: {ex.Message}"); // Тут мы выдаем сообщение о возникновении исключения
        s = s.Remove (s.Length); //Тут мы очищаем строку
     }

 }*/
    }
}
