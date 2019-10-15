using System;
using System.Windows.Forms;

namespace circuit_generator
{
    public partial class Form_nagruzka : Form
    {
        public Form_nagruzka()
        {
            InitializeComponent();
           

        }
        protected void Form_nagruzka_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = Nagruzka.GetNumberOfPhases();
            comboBox1.DataSource = Nagruzka.GetStandartPower();
            comboBox5.DataSource = Nagruzka.GetStandartVoltage();
            listBox2.DataSource = Nagruzka.GetType();
            listBox3.DataSource = Nagruzka.GetHarakter();
            listBox4.DataSource = Nagruzka.GetTypeNetwork();

            label1.Text = Convert.ToString(Convert.ToDouble(comboBox1.Text.ToString()) * 1000 / Convert.ToDouble(comboBox5.Text.ToString()));

           

        }
        private void Form_nagruzka_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
           // listBox3.Enabled = !checkBox.Checked;


            if (checkBox.Checked == true)
            {
                MessageBox.Show("Флажок " + checkBox.Text + "  теперь отмечен");
            }
            else
            {
                MessageBox.Show("Флажок " + checkBox.Text + "  теперь не отмечен");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Nagruzka nagruzka = new Nagruzka();

            //nagruzka.Power = 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox

          //  groupBox9.Visible = checkBox.Checked;
           // groupBox10.Visible = checkBox.Checked;

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
