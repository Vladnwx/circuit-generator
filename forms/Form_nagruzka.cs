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
            listBoxNumberOfPhases.DataSource = Nagruzka.GetNumberOfPhases();
            comboBoxStandartPower.DataSource = Nagruzka.GetStandartPower();
            comboBoxStandartVoltage.DataSource = Nagruzka.GetStandartVoltage();
            listBoxType.DataSource = Nagruzka.GetType();
            listBoxHarakter.DataSource = Nagruzka.GetHarakter();
            listBoxTypeNetwork.DataSource = Nagruzka.GetTypeNetwork();
            comboBoxStandartCosf.DataSource = Nagruzka.GetStandartCosf();

            //label1.Text = Convert.ToString(Convert.ToDouble(comboBoxStandartPower.Text.ToString()) * 1000 / Convert.ToDouble(comboBoxStandartVoltage.Text.ToString()));



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
 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void buttonAddNagruzka_Click(object sender, EventArgs e)
        {
            Nagruzka n1 = new Nagruzka();

            n1.WriteToSheet(
                NumberOfPhases: listBoxNumberOfPhases.Text,
                Power: comboBoxStandartPower.Text,
                Voltage: comboBoxStandartVoltage.Text,
                Cosphi: comboBoxStandartCosf.Text,
                Start: comboBoxStart.Text,
                Source: comboBoxSource.Text);
            Dispose();

        }

        private void listBoxNumberOfPhases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
