using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                Power = this.Worksheet.Cells[Constants.Fider.Row.P, this.ActiveColuumn].Value;

                Cosphi = this.Worksheet.Cells[Constants.Fider.Row.Cos, this.ActiveColuumn].Value;

                Start = this.Worksheet.Cells[Constants.Fider.Row.Start, this.ActiveColuumn].Value;

                Source = this.Worksheet.Cells[Constants.Fider.Row.Finish, this.ActiveColuumn].Value;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
