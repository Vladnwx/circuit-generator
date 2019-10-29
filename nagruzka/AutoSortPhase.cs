using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        public void AutoSortPhase() // выбирает  номер фазы для нагрузки
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
    }
}
