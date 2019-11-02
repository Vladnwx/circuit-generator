using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        public void WriteToSheet() // Добавляет нагрузку на лист
        {
            Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            int ActiveColuumn = Constants.Fider.Column.First;
            while (Check(ref ActiveColuumn))
            {
                ActiveColuumn += 2;
            }
            try
            {
            NagruzkaList.Add(Constants.Fider.Row.Phase, Convert.ToString(NumbersOfPhases));
            NagruzkaList.Add(Constants.Fider.Row.P, Convert.ToString(Power));
            NagruzkaList.Add(Constants.Fider.Row.U, Convert.ToString(Voltage));
            NagruzkaList.Add(Constants.Fider.Row.Cos, Convert.ToString(Cosphi));
            NagruzkaList.Add(Constants.Fider.Row.I, Convert.ToString(Current));
            NagruzkaList.Add(Constants.Fider.Row.Start, Convert.ToString(Start));    
            NagruzkaList.Add(Constants.Fider.Row.Finish, Convert.ToString(Destenation));     
            NagruzkaList.TrimExcess();
            ICollection<int> keys = NagruzkaList.Keys;
            foreach (int c in keys)
            {
                Worksheet.Cells[c, ActiveColuumn].Value = NagruzkaList[c];
               // Console.WriteLine("User: {0}, Password: {1}", c, NagruzkaList[c]);
            }
               
               /*  Worksheet.Cells[Constants.Fider.Row.Phase, ActiveColuumn].Value = Convert.ToDouble(NumbersOfPhases);
                Worksheet.Cells[Constants.Fider.Row.P, ActiveColuumn].Value = Convert.ToDouble(Power);
                Worksheet.Cells[Constants.Fider.Row.U, ActiveColuumn].Value = Convert.ToDouble(Voltage);
                Worksheet.Cells[Constants.Fider.Row.Cos, ActiveColuumn].Value = Convert.ToDouble(Cosphi);
                Worksheet.Cells[Constants.Fider.Row.I, ActiveColuumn].Value = Convert.ToDouble(Current);
                Worksheet.Cells[Constants.Fider.Row.Start, ActiveColuumn].Value = Start;
                Worksheet.Cells[Constants.Fider.Row.Finish, ActiveColuumn].Value = Desstenation;
                */
                var l1 = new List<int> { Constants.Fider.Row.Id, Constants.Fider.Row.Image, Constants.Fider.Row.Id, Constants.Fider.Row.Phase, Constants.Fider.Row.P, Constants.Fider.Row.U, Constants.Fider.Row.Cos, Constants.Fider.Row.I, Constants.Fider.Row.Start, Constants.Fider.Row.Finish };
                foreach (int element in l1)
                {
                    FormatCell f1 = new FormatCell();
                    f1.MergeFormat(element, ActiveColuumn, 0, 1);
                }
                //return count == l1.Count;
            }
            catch (FormatException)
            {
                MessageBox.Show(Constants.Exeption.Value1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Globals.ThisAddIn.Application.ActiveWorkbook.Save();
        }
    }
}
