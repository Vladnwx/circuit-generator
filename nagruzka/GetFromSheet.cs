using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        public void GetFromSheet() // Получает данные из ячейки
        {
            this.Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            this.ActiveColuumn = Globals.ThisAddIn.Application.ActiveCell.Column;
            try
            {
                //StandartNumbersOfPhases = Worksheet.Cells[Constants.Fider.Row.Phase, ActiveColuumn].Value;
                NagruzkaList.Add(Constants.Fider.Row.Phase, Convert.ToString(NumbersOfPhases));
                NagruzkaList.Add(Constants.Fider.Row.Power, Convert.ToString(Power));
                NagruzkaList.Add(Constants.Fider.Row.Voltage, Convert.ToString(Voltage));
                NagruzkaList.Add(Constants.Fider.Row.Cosphi, Convert.ToString(Cosphi));
                NagruzkaList.Add(Constants.Fider.Row.Current, Convert.ToString(Current));
                NagruzkaList.Add(Constants.Fider.Row.Start, Convert.ToString(Start));
                NagruzkaList.Add(Constants.Fider.Row.Destenation, Convert.ToString(Destenation));
                NagruzkaList.TrimExcess();
            ICollection<int> keys = NagruzkaList.Keys;
            foreach (int c in keys)
            {
                NagruzkaList[c] = Worksheet.Cells[c, ActiveColuumn].Value;
            }
               /*  Power = this.Worksheet.Cells[Constants.Fider.Row.Power, this.ActiveColuumn].Value;

                Cosphi = this.Worksheet.Cells[Constants.Fider.Row.Cosphi, this.ActiveColuumn].Value;

                Start = this.Worksheet.Cells[Constants.Fider.Row.Start, this.ActiveColuumn].Value;

                Desstenation = this.Worksheet.Cells[Constants.Fider.Row.Destenation, this.ActiveColuumn].Value;
           */
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
