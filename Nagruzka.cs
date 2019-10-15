using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace circuit_generator
{
    public class Nagruzka
    {

        Microsoft.Office.Interop.Excel.Worksheet Worksheet { get; set; }
        //Worksheet = Globals.ThisAddIn.Application.ActiveSheet;


        public static List<double> Standart_voltage = new List<double>() { 220D, 380D, 24D, 12D, 230D, 400D };

        public static List<double> Standart_power = new List<double>() { 1, 1.5D, 2D, 2.5D, 3D, 0.5D, 0.1D };
        
        public static List<string> Harakter_load = new List<string>() { "Светильники", "Розетки", "Двигатель", "Шкаф", "Комплексная нагрузка" };
        // Характер нагрузки (двигатель, розетка, светильник, шкафчик), добавить рекомендации по ограничению одной группы освещения не более 10А. 
                                                  //Елси нагрузка комплексная то давать возможность ввести косинус. Если розетка, то давать ввести количество розеток. 
                                                  //Если светильники, то давать ввести количество светильников и мощность одного. 
                                                  //Если двигатель, то запрашивать данные об установленном выключаетел в шкафу управления двигателем.

        public static List<string> Number_of_phases = new List<string>() { "1", "2", "3" };
        
        public static List<string> Type_network = new List<string>() { "трехфазная разводка с ответвлением в коробке пофазно", "однофазная прямо от щита", "3" }; // Тип применяемой сети на комплексную нагрузку

        public static List<string> Type_load = new List<string>() { "конечная", "промежуточная"}; // Тип нагрузки
       
        //добавить список типовых мощностей в зависимости от выбранных характеров
        public double Power { get; set; } // Мощность в кВт, добавить проверку мощности (она не может быть отрицательной)

        //добавить список типовых косинусов в зависимости от выбранных характеров
        public double Cosphi { get; set; } // Косинус нагрузки , добавить проверку косинуса (он не может быть больше+-1)

        public bool Start_load_in_box { get; set; } // Начало нагрузки в щите или ответвление от фидера, добавить проверку, что при отсутствии фидера невозможно поставить нагрузку как начинающуюся не от щита

        public string Start_load { get; set; } // начало нагрузки

        public string Source_load { get; set; } // Местоположение нагрузки

        public int Load_number_coluumn { get; set; } // Номер столбца для нагрузки


        public void Add_to_list() // Добавляет нагрузку на лист
        {
            Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            
            Worksheet.Cells[Constants.Fider.Row.Phase, Load_number_coluumn].Value = Number_of_phases;

            Worksheet.Cells[Constants.Fider.Row.P, Load_number_coluumn].Value = Power;

            Worksheet.Cells[Constants.Fider.Row.Cos, Load_number_coluumn].Value = Cosphi;

            Worksheet.Cells[Constants.Fider.Row.Start, Load_number_coluumn].Value = Start_load;

            Worksheet.Cells[Constants.Fider.Row.Finish, Load_number_coluumn].Value = Source_load;

        }
        /*   public Nagruzka() : this("Неизвестно") // Конструктор без параметров
           {
           }
           public Nagruzka(string Number_of_phases) : this(Number_of_phases, "Неизвестно") // Конструктор с указанием только числа фаз
           {
           }
           public Nagruzka(string Number_of_phases, string Power) : this(Source, Power, "Неизвестно") // Конструктор c мощностью
           {
           }*/
        /*  public Nagruzka(string Number_of_phases, string Power, string Cosphi) : this(Source, Power, Cosphi, "Неизвестно") // Конструктор с косинусом
          {
          }*/
        /*   public Nagruzka(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box) : this(Source, Power, Cosphi, bool Start_load_in_box, "Неизвестно") // Конструктор с указанием начала в щите
           {
           }*/
        /*  public Nagruzka(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load) : this(Source, Power, Cosphi, bool Start_load_in_box, string Start_load, "Неизвестно") // Конструктор с указанием начала нагрузки
          {
          }
          public Nagruzka(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load) : this(Source, Power, Cosphi, bool Start_load_in_box, string Start_load, string Source_load, "Неизвестно") // Конструктор с указанием конца нагрузки
          {
          }*/
        public Nagruzka(string Number_of_phases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load, string Type_network) // Конструктор полный
        {
            this.Number_of_phases = Number_of_phases;
            this.Power = Convert.ToDouble(Power);
            this.Cosphi = Convert.ToDouble(Cosphi);
            this.Start_load_in_box = Convert.ToBoolean(Start_load_in_box);
            this.Start_load = Start_load;
            this.Source_load = Source_load;
            this.Type_network = Type_network;
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
