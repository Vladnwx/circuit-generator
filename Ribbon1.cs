using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace circuit_generator
{

    public partial class Ribbon1
    {
        
        // public event Action ButtonClicked;


        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //MessageBox.Show("Hello, world!");
        }

        private void Button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Workbook nativeWorkbook =
    Globals.ThisAddIn.Application.ActiveWorkbook; // Переменная nativeWorkbook - текущая открытая книга
            if (nativeWorkbook != null)
            {
                Microsoft.Office.Tools.Excel.Workbook vstoWorkbook =
                    Globals.Factory.GetVstoObject(nativeWorkbook);
            }
            Microsoft.Office.Interop.Excel.Worksheet nativeWorksheet =
                      Globals.ThisAddIn.Application.ActiveSheet; // Переменная nativeWorksheet - текущий открытый лист

            if (nativeWorksheet != null)
            {
                Microsoft.Office.Tools.Excel.Worksheet vstoSheet =
                   Globals.Factory.GetVstoObject(nativeWorksheet);
            }
            Tabl_odnolin_left t1 = new Tabl_odnolin_left();
            Tabl_odnolin_vvod t2 = new Tabl_odnolin_vvod();
            Tabl_odnolin_nagr t3 = new Tabl_odnolin_nagr();
            Tabl_odnolin_potr t4 = new Tabl_odnolin_potr();


            t1.Draw_excel(nativeWorksheet);
            t2.Draw_excel(nativeWorksheet);
            t3.Draw_excel(nativeWorksheet);
            t4.Draw_excel(nativeWorksheet);

            MessageBox.Show(nativeWorkbook.Name); //Вывод названия текущей книги
            MessageBox.Show(nativeWorksheet.Name); //Вывод названия текущего листа
        }

        private void ToggleButton1_Click(object sender, RibbonControlEventArgs e)
        {
            Microsoft.Office.Interop.Excel.Worksheet nativeWorksheet =
           Globals.ThisAddIn.Application.ActiveSheet; // Переменная nativeWorksheet - текущий открытый лист

            if (nativeWorksheet != null)
            {
                Microsoft.Office.Tools.Excel.Worksheet vstoSheet =
                   Globals.Factory.GetVstoObject(nativeWorksheet);
            }

           

            MessageBox.Show(nativeWorksheet.Name); //Вывод названия текущего листа
        }
    }

        
}
