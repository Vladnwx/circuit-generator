using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        private string Harakter { get; set; } // Характер нагрузки
        private string TypeNetwork { get; set; } // Тип сети
        private string Type{ get; set; } // Тип нагрузки промежуточная/конечная
        private int ActiveColuumn { get; set; } // Номер столбца для нагрузки

        public Nagruzka() // Конструктор по умолчанию
         {
             NumbersOfPhases = Constants.StandartNagruzka.NumberPhases.Value1;
             SelectNumberPhase();
             SelectVoltage();
             Power = Constants.StandartNagruzka.StandartPower.Value1;
             Cosphi = Constants.StandartNagruzka.StandartCosf.Value1;
             StartInBox = true;
             Start = Worksheet.Name;
             CalculateCurrent();
         }
private void SelectNumberPhase() // Выбирает фазу, в зависимости от количества фаз
{
    switch (NumbersOfPhases)
    {
        case 1:
        NumberPhase = Constants.StandartNagruzka.NumberPhases.Value1;
        break;
        case 2:
        NumberPhase = Constants.StandartNagruzka.NumberPhases.Value5;
        break;
        case 3:
        NumberPhase = Constants.StandartNagruzka.NumberPhases.Value4;
        break;
        default:
        MessageBox.Show("Количество фаз неверно");
        NumberPhase = Constants.StandartNagruzka.NumberPhases.Value1;
        break;
    }
}
private void SelectVoltage() // Выбирает напряжение в зависимости от количества фаз
{
    switch (NumbersOfPhases)
    {
        case 1:
        Voltage = Constants.StandartNagruzka.StandartVoltage.Value1;
        break;
        case 2:
        Voltage = Constants.StandartNagruzka.StandartVoltage.Value2;
        break;
        case 3:
        Voltage = Constants.StandartNagruzka.StandartVoltage.Value2;
        break;
        default:
        MessageBox.Show("Выбрано неверное напряжение");
        Voltage = Constants.StandartNagruzka.StandartVoltage.Value1;
        break;
    }
}
private void CalculateCurrent() //Рассчитывает ток в нагрузке
{
    try {
            Current = (Power*1000)/(1.73D*Voltage*Cosphi);
        }
    catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
private void SelectCosphi() // Выбирает cos phi
{
    switch (Harakter)
    {
        case Constants.StandartNagruzka.StandartHarakter.Value1:
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value2;
        break;
        case Constants.StandartNagruzka.StandartHarakter.Value2:
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value1;
        break;
        case Constants.StandartNagruzka.StandartHarakter.Value3:
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value3;
        break;
        case Constants.StandartNagruzka.StandartHarakter.Value4:
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value2;
        break;
        case Constants.StandartNagruzka.StandartHarakter.Value5:
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value5;
        break;
        default:
        MessageBox.Show("Выбран неверный характер нагрузки");
        Cosphi = Constants.StandartNagruzka.StandartCosf.Value5;
        break;
    }
}
public void  AutoSortPhase() // выбирает  номер фазы для нагрузки
        {
            this.Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            int ActiveColuumn = Constants.Fider.Column.First;
            //Worksheet.Cells[Constants.Fider.Row.Phase, column]

            while (Check(ref ActiveColuumn))
            {
                ActiveColuumn += 2;
            }
            try
            {
                
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Передаваемые значения мощности, напряжения и косинуса должны быть числом");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static readonly List<string> StandartNumbersOfPhases = new List<string>() { Constants.StandartNagruzka.StandartNumbersOfPhases.Value1, Constants.StandartNagruzka.StandartNumbersOfPhases.Value2, Constants.StandartNagruzka.StandartNumbersOfPhases.Value3 }; //число фаз
        //private static readonly List<string> NumberPhases = new List<string>() { "L1", "L2", "L3", "L1 L2 L3" }; // номер фазы
        
        public static List<string> GetNumberOfPhases()
        {
            return StandartNumbersOfPhases;
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

        private static readonly List<string> TypeNetwork = new List<string>() { "трехфазная разводка с ответвлением в коробке пофазно", "однофазная прямо от щита" }; // Тип применяемой сети на комплексную нагрузку
        public static List<string> GetTypeNetwork()
        {
            return TypeNetwork;
        }
        private static readonly List<double> StandartCosf = new List<double>() { 0.8, 0.85, 0.9, 0.95, 1 }; // Тип нагрузки
        public static List<double> GetStandartCosf()
        {
            return StandartCosf;
        }
        private static readonly List<string> Type = new List<string>() { "конечная", "промежуточная" }; // Тип нагрузки
        public static List<string> GetType()
        {
            return Type;
        }
        
        
        /*   public Nagruzka() : this("Неизвестно") // Конструктор без параметров
           {
           }
           public Nagruzka(string StandartNumbersOfPhases) : this(StandartNumbersOfPhases, "Неизвестно") // Конструктор с указанием только числа фаз
           {
           }
           public Nagruzka(string StandartNumbersOfPhases, string Power) : this(Source, Power, "Неизвестно") // Конструктор c мощностью
           {
           }*/
        /*  public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi) : this(Source, Power, Cosphi, "Неизвестно") // Конструктор с косинусом
          {
          }*/
        /*   public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi, bool StartInBox) : this(Source, Power, Cosphi, bool StartInBox, "Неизвестно") // Конструктор с указанием начала в щите
           {
           }*/
        /*  public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi, bool StartInBox, string Start) : this(Source, Power, Cosphi, bool StartInBox, string Start, "Неизвестно") // Конструктор с указанием начала нагрузки
          {
          }
          public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi, bool StartInBox, string Start, string Source) : this(Source, Power, Cosphi, bool StartInBox, string Start, string Source, "Неизвестно") // Конструктор с указанием конца нагрузки
          {
          }*/
        /* public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load, string TypeNetwork) // Конструктор полный
         {
             this.StandartNumbersOfPhases = StandartNumbersOfPhases;
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
