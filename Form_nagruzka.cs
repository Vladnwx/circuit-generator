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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {

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
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // приводим отправителя к элементу типа RadioButton
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                MessageBox.Show("Вы выбрали " + radioButton.Text);
            }
        }
        protected void Form_load_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Nagruzka.Standart_power;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox

            groupBox9.Visible = checkBox.Checked;
            groupBox10.Visible = checkBox.Checked;

        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
