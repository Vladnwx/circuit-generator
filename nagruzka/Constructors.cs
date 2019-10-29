namespace circuit_generator
{
    public partial class Nagruzka
    {
        public Nagruzka() // Конструктор по умолчанию
        {
            Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            NumbersOfPhases = Constants.StandartNagruzka.NumberPhases.Value1;
            SelectNumberPhase();
            SelectVoltage();
            Power = Constants.StandartNagruzka.StandartPower.Value1;
            Cosphi = Constants.StandartNagruzka.StandartCosf.Value1;
            StartInBox = true;
            Start = Worksheet.Name;
            CalculateCurrent();
        }
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
