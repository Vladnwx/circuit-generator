using Microsoft.Office.Tools.Ribbon;

namespace circuit_generator
{
    public partial class Ribbon1
    {
        // public event Action ButtonClicked;
        public void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //MessageBox.Show("Hello, world!");

            bool b = CheckCircuitGenerator();
            if (b)
            {
                Tabl_odnolin t1 = new Tabl_odnolin();
                t1.Check();
            }
        }
        private void Button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Tabl_odnolin t1 = new Tabl_odnolin();
            t1.Draw();
            // t1.Draw(Globals.ThisAddIn.Application.ActiveSheet);
        }
        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Form_nagruzka f1 = new Form_nagruzka();
            f1.Show();
            // f1.Dispose();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {
            SetCircuitGenerator();

        }

        public bool CheckCircuitGenerator()
        {
            //Microsoft.Office.Core.DocumentProperties properties;

            // string properties = Globals.ThisAddIn.Application.ActiveWorkbook.Author.ToString();
            //properties = Globals.ThisAddIn.Application.ActiveWorkbook.BuiltinDocumentProperties();



            //  Microsoft.Office.Core.DocumentProperty prop;

            //   MessageBox.Show(properties);

            //prop = properties["Revision Number"];


            // Тут нужно указать тег в активной книге. Данный тег будет давать информацию что мы работаем с файлом кабельного журнала и будем выполнять циклы по пересчету кабельных линий


            // Microsoft.Office.Core.DocumentProperty prop;
            //prop = properties["Revision Number"];

            // if (prop.Value == "CircuitGenerator")
            //  {
            //  return true;
            // } 
            // else return false;
            return true;
        }

        public void SetCircuitGenerator()
        {
            if (!CheckCircuitGenerator())
            {
                Microsoft.Office.Core.DocumentProperties properties = Globals.ThisAddIn.Application.ActiveWorkbook.BuiltinDocumentProperties;
                Microsoft.Office.Core.DocumentProperty prop;
                prop = properties["Tag"];

                prop.Value = "CircuitGenerator";

            }
        }



    }


}
