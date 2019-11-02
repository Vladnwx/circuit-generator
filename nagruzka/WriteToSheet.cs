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
            //NagruzkaList.Add(Constants.Fider.Row.Phase, Convert.ToString(NumbersOfPhases));
            //NagruzkaList.Add(Constants.Fider.Row.Power, Convert.ToString(Power));
           // NagruzkaList.Add(Constants.Fider.Row.Voltage, Convert.ToString(Voltage));
           // NagruzkaList.Add(Constants.Fider.Row.Cosphi, Convert.ToString(Cosphi));
           // NagruzkaList.Add(Constants.Fider.Row.Current, Convert.ToString(Current));
           // NagruzkaList.Add(Constants.Fider.Row.Start, Convert.ToString(Start));    
           // NagruzkaList.Add(Constants.Fider.Row.Destenation, Convert.ToString(Destenation));     
           // NagruzkaList.TrimExcess();
                ICollection<int> keys = listsorted.Keys;

                foreach (int c in keys)
            {
                Worksheet.Cells[c, ActiveColuumn].Value = listsorted[c];
               // Console.WriteLine("User: {0}, Password: {1}", c, NagruzkaList[c]);
            }
               
               /*  Worksheet.Cells[Constants.Fider.Row.Phase, ActiveColuumn].Value = Convert.ToDouble(NumbersOfPhases);
                Worksheet.Cells[Constants.Fider.Row.Power, ActiveColuumn].Value = Convert.ToDouble(Power);
                Worksheet.Cells[Constants.Fider.Row.Voltage, ActiveColuumn].Value = Convert.ToDouble(Voltage);
                Worksheet.Cells[Constants.Fider.Row.Cosphi, ActiveColuumn].Value = Convert.ToDouble(Cosphi);
                Worksheet.Cells[Constants.Fider.Row.Current, ActiveColuumn].Value = Convert.ToDouble(Current);
                Worksheet.Cells[Constants.Fider.Row.Start, ActiveColuumn].Value = Start;
                Worksheet.Cells[Constants.Fider.Row.Destenation, ActiveColuumn].Value = Desstenation;
                */
               // var l1 = new List<int> { Constants.Fider.Row.Id, Constants.Fider.Row.Image, Constants.Fider.Row.Id, Constants.Fider.Row.Phase, Constants.Fider.Row.Power, Constants.Fider.Row.Voltage, Constants.Fider.Row.Cosphi, Constants.Fider.Row.Current, Constants.Fider.Row.Start, Constants.Fider.Row.Destenation };

                foreach (int element in Constants.Fider.Row.listInt)
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
