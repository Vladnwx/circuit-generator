using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;

namespace circuit_generator

{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {

        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region Код, автоматически созданный VSTO

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        protected override Microsoft.Office.Core.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            var ribbon = new Ribbon1();
          //  ribbon.ButtonClicked += ribbon_ButtonClicked;
            return Globals.Factory.GetRibbonFactory().CreateRibbonManager(new IRibbonExtension[] { ribbon });
        }

       // private void ribbon_ButtonClicked()
      //  {
      //      MessageBox.Show("Hello, world!");
      //  }

        #endregion
    }
}
