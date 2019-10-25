using Microsoft.Office.Tools.Ribbon;

namespace circuit_generator
{
    public partial class Ribbon1
    {
        // public event Action ButtonClicked;
        public void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //MessageBox.Show("Hello, world!");

            bool b = CheckOnlinegen();
            if (b)
            {
            Tabl_odnolin t1 = new Tabl_odnolin();
            t1.Check();
            }
        }
        private void Button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Tabl_odnolin t1 = new Tabl_odnolin();
            t1.Check();
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

        }

           public bool CheckCircuitGenerator()
    {
        string s = Globals.ThisAddIn.Application.ActiveWorkbook(); // Тут нужно указать тег в активной книге. Данный тег будет давать информацию что мы работаем с файлом кабельного журнала и будем выполнять циклы по пересчету кабельных линий
        if (s = "CircuitGenerator")
        {
        return true;
        } 
        else return false;
    }

public void SetCircuitGenerator()
{
    if (!CheckCircuitGenerator())
    {
       // Globals.ThisAddIn.Application.ActiveWorkbook; // Тут мы вставляем тег в активную книгу. Данный тег будет давать информацию что мы работаем с файлом кабельного журнала и будем выполнять циклы по пересчету кабельных линий
    }
}



    }


}
