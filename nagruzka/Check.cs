using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;

namespace circuit_generator
{
    public partial class Nagruzka
    {
        public static bool Check(ref int ActiveColuumn) //Проверяет есть ли данные в выбранном столбце
        {
            Microsoft.Office.Interop.Excel.Worksheet Worksheet = Globals.ThisAddIn.Application.ActiveSheet;
            // int ActiveColuumn = Constants.Fider.Column.First;

            var l1 = new List<int> { Constants.Fider.Row.Power, Constants.Fider.Row.Voltage, Constants.Fider.Row.Cosphi, Constants.Fider.Row.Start, Constants.Fider.Row.Destenation };

            int count = 0;
            foreach (int element in l1)
            {
                if (!(string.IsNullOrEmpty(Convert.ToString(Worksheet.Cells[element, ActiveColuumn].Value))))
                {
                    count++;
                }
                //else Worksheet.Cells[element, ActiveColuumn].Interior.ColorIndex = 3;

            }

            return count > 0;

        }
    }
}
