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
           // Nagruzka nagruzka = new Nagruzka();

            listBoxNumberOfPhases.DataSource = Constants.StandartNagruzka.StandartNumbersOfPhases.list;
            comboBoxStandartPower.DataSource = Constants.StandartNagruzka.StandartPower.list;
                       

            
            comboBoxStandartCosf.DataSource = Constants.StandartNagruzka.StandartCosf.list;
            comboBoxStandartVoltage.DataSource = Constants.StandartNagruzka.StandartVoltage.list;
            checkBoxStartinbox.Checked = true;
            comboBoxStart.Enabled = !checkBoxStartinbox.Checked;

           // comboBoxStart.DataSource = ;

            listBoxType.DataSource = Constants.StandartNagruzka.StandartType.list;
            listBoxHarakter.DataSource = Constants.StandartNagruzka.StandartHarakter.list;
            listBoxTypeNetwork.DataSource = Constants.StandartNagruzka.StandartTypeNetwork.list;
        }
        private void Form_nagruzka_FormClosed(object sender, FormClosedEventArgs e)
        {
           Dispose();
        }
        private void checkBoxStartinbox_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxStart.Enabled = !checkBoxStartinbox.Checked;

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
            //Nagruzka n1 = new Nagruzka();

            Nagruzka n1 = new Nagruzka(NumbersOfPhases: listBoxNumberOfPhases.Text, Power: comboBoxStandartPower.Text, Cosphi: comboBoxStandartCosf.Text, StartInBox: false, Start: comboBoxStart.Text, Destenation: comboBoxSource.Text);
            n1.WriteToSheet();
            
                //Voltage: comboBoxStandartVoltage.Text,
            Dispose();

        }

        private void listBoxNumberOfPhases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
