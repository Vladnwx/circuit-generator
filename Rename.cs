using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Rename : Form
    {
        public Rename()
        {
            InitializeComponent();
            maskedTextBox1.Text = Globals.ThisAddIn.Application.ActiveSheet.name;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Globals.ThisAddIn.Application.ActiveSheet.Name = maskedTextBox1.Text;
                this.Close();
                Globals.ThisAddIn.Application.ActiveWorkbook.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Rename_Load(object sender, EventArgs e)
        {

        }

        private void Rename_FormClosed(object sender, FormClosedEventArgs e)
        {
            Tabl_odnolin t1 = new Tabl_odnolin();
            t1.Check(Globals.ThisAddIn.Application.ActiveSheet);
        }
    }
}
