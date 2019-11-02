using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        public Nagruzka() : this(Constants.StandartNagruzka.NumberPhases.Value1) //Конструктор по умолчанию
        { }
          public Nagruzka(double NumbersOfPhases) : this(NumbersOfPhases, Constants.StandartNagruzka.StandartPower.Value1) // Конструктор с указанием числа фаз
        { }
        public Nagruzka(string NumbersOfPhases) : this(Convert.ToDouble(NumbersOfPhases), Constants.StandartNagruzka.StandartPower.Value1) // Конструктор с указанием числа фаз
        { }
        public Nagruzka(double NumbersOfPhases, double Power) : this(NumbersOfPhases, Power, Constants.StandartNagruzka.StandartCosf.Value1) // Конструктор с указанием числа фаз и мощности
        { }
        public Nagruzka(string NumbersOfPhases, string Power) : this(Convert.ToDouble(NumbersOfPhases), Convert.ToDouble(Power), Constants.StandartNagruzka.StandartCosf.Value1) // Конструктор с указанием числа фаз и мощности
        { }
        public Nagruzka(double NumbersOfPhases, double Power, double Cosphi) : this(NumbersOfPhases, Power, Cosphi, true, "Неизвестно", "Неизвестно") // Конструктор с указанием числа фаз, мощности и косинуса и началом в щите
        { }
        public Nagruzka(string NumbersOfPhases, string Power, string Cosphi) : this(Convert.ToDouble(NumbersOfPhases), Convert.ToDouble(Power), Convert.ToDouble(Cosphi), true, "Неизвестно", "Неизвестно") // Конструктор с указанием числа фаз, мощности и косинуса и началом в щите
        { }
       /* public Nagruzka(double NumbersOfPhases, double Power, double Cosphi, bool StartInBox) : this(
            NumbersOfPhases, Power, Cosphi, StartInBox, Worksheet.Name) // Конструктор с указанием числа фаз, мощности и косинуса, началом в щите
        {  }*/

      /*  public Nagruzka(double NumbersOfPhases, double Power, double Cosphi, bool StartInBox, string Start) : this (NumbersOfPhases, Power, Cosphi, StartInBox, Start, Destenation) // Конструктор с указанием числа фаз, мощности и косинуса
        {  }*/


        public Nagruzka(double NumbersOfPhases, double Power, double Cosphi, bool StartInBox, string Start, string Destenation) // Конструктор с указанием числа фаз, мощности и косинуса
        {
            Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            this.NumbersOfPhases = NumbersOfPhases;
            SelectNumberPhase();
            SelectVoltage();
            this.Power = Power;
            this.Cosphi = Cosphi;
            this.StartInBox = StartInBox;
            this.Start = Start;
            this.Destenation = Destenation;
            CalculateCurrent();
        }
        public Nagruzka(string NumbersOfPhases, string Power, string Cosphi, bool StartInBox, string Start, string Destenation) // Конструктор с указанием числа фаз, мощности и косинуса
        {
            try
            {
                Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
                this.NumbersOfPhases = Convert.ToDouble(NumbersOfPhases);
                SelectNumberPhase();
                SelectVoltage();
                this.Power = Convert.ToDouble(Power);
                this.Cosphi = Convert.ToDouble(Cosphi);
                this.StartInBox = StartInBox;
                this.Start = Start;
                this.Destenation = Destenation;
                CalculateCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    /* public Nagruzka(string StandartNumbersOfPhases, string Power, string Cosphi, bool Start_load_in_box, string Start_load, string Source_load, string TypeNetwork) // Конструктор полный
     {
         this.StandartNumbersOfPhases = StandartNumbersOfPhases;
         this.Power = Convert.ToDouble(Power);
         this.Cosphi = Convert.ToDouble(Cosphi);
         this.StartInBox = Convert.ToBoolean(Start_load_in_box);
         this.Start = Start_load;
         this.Desstenation = Source_load;
         this.TypeNetwork = TypeNetwork;
     }*/
   
}
