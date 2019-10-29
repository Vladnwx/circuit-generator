using Microsoft.Office.Interop.Excel;
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
        public void WriteToSheet(string NumberOfPhases, string Power, string Voltage, string Cosphi, string Start, string Source) // Добавляет нагрузку на лист
        {
            Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
           int ActiveColuumn = Constants.Fider.Column.First;
            while (Check(ref ActiveColuumn))
            {
                ActiveColuumn += 2;
            }
            try
            {
                Worksheet.Cells[Constants.Fider.Row.Phase, ActiveColuumn].Value = Convert.ToString(NumbersOfPhases);
                Worksheet.Cells[Constants.Fider.Row.P, ActiveColuumn].Value = Convert.ToDouble(Power);
                Worksheet.Cells[Constants.Fider.Row.U, ActiveColuumn].Value = Convert.ToDouble(Voltage);
                Worksheet.Cells[Constants.Fider.Row.Cos, ActiveColuumn].Value = Convert.ToDouble(Cosphi);
                Worksheet.Cells[Constants.Fider.Row.I, ActiveColuumn].Value = Convert.ToDouble(Current);
                Worksheet.Cells[Constants.Fider.Row.Start, ActiveColuumn].Value = Start;
                Worksheet.Cells[Constants.Fider.Row.Finish, ActiveColuumn].Value = Source;
                var l1 = new List<int> { Constants.Fider.Row.Phase, Constants.Fider.Row.P, Constants.Fider.Row.U, Constants.Fider.Row.Cos, Constants.Fider.Row.Start, Constants.Fider.Row.Finish };
                foreach (int element in l1)
                {
                    FormatCell f1 = new FormatCell();
                    f1.MergeFormat(element, ActiveColuumn, 0, 1);
                }
                //return count == l1.Count;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Передаваемые значения мощности, напряжения и косинуса должны быть числом");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Globals.ThisAddIn.Application.ActiveWorkbook.Save();
        }
    }
}
