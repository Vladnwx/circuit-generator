using Microsoft.Office.Tools.Ribbon;

namespace circuit_generator
{
    public partial class Ribbon1
    {
        // public event Action ButtonClicked;
        public void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //MessageBox.Show("Hello, world!");
        }
        private void Button1_Click_1(object sender, RibbonControlEventArgs e)
        {
            Tabl_odnolin t1 = new Tabl_odnolin();
            t1.Check(Globals.ThisAddIn.Application.ActiveSheet);
            // t1.Draw(Globals.ThisAddIn.Application.ActiveSheet);
        }
        private void button2_Click(object sender, RibbonControlEventArgs e)
        {
            Form_nagruzka f1 = new Form_nagruzka();
            f1.Show();
        }

        private void button3_Click(object sender, RibbonControlEventArgs e)
        {

        }
    }


}
