namespace circuit_generator
{
    partial class Form_nagruzka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAddNagruzka = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxNumberOfPhases = new System.Windows.Forms.ListBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxStandartPower = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxStandartCosf = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxSource = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.listBoxHarakter = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listBoxTypeNetwork = new System.Windows.Forms.ListBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.comboBoxStandartVoltage = new System.Windows.Forms.ComboBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(446, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Начало нагрузки в щите";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonAddNagruzka
            // 
            this.buttonAddNagruzka.AutoSize = true;
            this.buttonAddNagruzka.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNagruzka.Location = new System.Drawing.Point(368, 229);
            this.buttonAddNagruzka.Name = "buttonAddNagruzka";
            this.buttonAddNagruzka.Size = new System.Drawing.Size(115, 23);
            this.buttonAddNagruzka.TabIndex = 19;
            this.buttonAddNagruzka.Text = "Добавить нагрузку";
            this.buttonAddNagruzka.UseVisualStyleBackColor = true;
            this.buttonAddNagruzka.Click += new System.EventHandler(this.buttonAddNagruzka_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.groupBox1.Controls.Add(this.listBoxNumberOfPhases);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 80);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество фаз";
            // 
            // listBoxNumberOfPhases
            // 
            this.listBoxNumberOfPhases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxNumberOfPhases.FormattingEnabled = true;
            this.listBoxNumberOfPhases.Location = new System.Drawing.Point(3, 16);
            this.listBoxNumberOfPhases.Name = "listBoxNumberOfPhases";
            this.listBoxNumberOfPhases.Size = new System.Drawing.Size(104, 61);
            this.listBoxNumberOfPhases.TabIndex = 0;
            this.listBoxNumberOfPhases.SelectedIndexChanged += new System.EventHandler(this.listBoxNumberOfPhases_SelectedIndexChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(4, 374);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(204, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Расширенный вариант добавления";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxStandartPower);
            this.groupBox2.Location = new System.Drawing.Point(110, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 80);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мощность,  кВт";
            // 
            // comboBoxStandartPower
            // 
            this.comboBoxStandartPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStandartPower.FormattingEnabled = true;
            this.comboBoxStandartPower.Location = new System.Drawing.Point(3, 16);
            this.comboBoxStandartPower.Name = "comboBoxStandartPower";
            this.comboBoxStandartPower.Size = new System.Drawing.Size(104, 21);
            this.comboBoxStandartPower.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxStandartCosf);
            this.groupBox3.Location = new System.Drawing.Point(220, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 80);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Косинус нагрузки";
            // 
            // comboBoxStandartCosf
            // 
            this.comboBoxStandartCosf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStandartCosf.FormattingEnabled = true;
            this.comboBoxStandartCosf.Location = new System.Drawing.Point(3, 16);
            this.comboBoxStandartCosf.Name = "comboBoxStandartCosf";
            this.comboBoxStandartCosf.Size = new System.Drawing.Size(104, 21);
            this.comboBoxStandartCosf.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxStart);
            this.groupBox4.Location = new System.Drawing.Point(330, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 80);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начало нагрузки";
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStart.FormattingEnabled = true;
            this.comboBoxStart.Location = new System.Drawing.Point(3, 16);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(104, 21);
            this.comboBoxStart.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxSource);
            this.groupBox5.Location = new System.Drawing.Point(330, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 80);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Местоположение нагрузки";
            // 
            // comboBoxSource
            // 
            this.comboBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSource.FormattingEnabled = true;
            this.comboBoxSource.Location = new System.Drawing.Point(3, 16);
            this.comboBoxSource.Name = "comboBoxSource";
            this.comboBoxSource.Size = new System.Drawing.Size(104, 21);
            this.comboBoxSource.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listBoxHarakter);
            this.groupBox6.Location = new System.Drawing.Point(120, 172);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(110, 80);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Характер нагрузки";
            // 
            // listBoxHarakter
            // 
            this.listBoxHarakter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHarakter.FormattingEnabled = true;
            this.listBoxHarakter.Location = new System.Drawing.Point(3, 16);
            this.listBoxHarakter.Name = "listBoxHarakter";
            this.listBoxHarakter.Size = new System.Drawing.Size(104, 61);
            this.listBoxHarakter.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBoxType);
            this.groupBox7.Location = new System.Drawing.Point(4, 172);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(110, 80);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Тип нагрузки";
            // 
            // listBoxType
            // 
            this.listBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.Location = new System.Drawing.Point(3, 16);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(104, 61);
            this.listBoxType.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listBoxTypeNetwork);
            this.groupBox8.Location = new System.Drawing.Point(4, 258);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(276, 80);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Тип применяемой сети на комплексную нагрузку";
            // 
            // listBoxTypeNetwork
            // 
            this.listBoxTypeNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTypeNetwork.FormattingEnabled = true;
            this.listBoxTypeNetwork.Location = new System.Drawing.Point(3, 16);
            this.listBoxTypeNetwork.Name = "listBoxTypeNetwork";
            this.listBoxTypeNetwork.Size = new System.Drawing.Size(270, 61);
            this.listBoxTypeNetwork.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.comboBoxStandartVoltage);
            this.groupBox9.Location = new System.Drawing.Point(1, 83);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(110, 80);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Напряжение";
            // 
            // comboBoxStandartVoltage
            // 
            this.comboBoxStandartVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStandartVoltage.FormattingEnabled = true;
            this.comboBoxStandartVoltage.Location = new System.Drawing.Point(3, 16);
            this.comboBoxStandartVoltage.Name = "comboBoxStandartVoltage";
            this.comboBoxStandartVoltage.Size = new System.Drawing.Size(104, 21);
            this.comboBoxStandartVoltage.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Location = new System.Drawing.Point(117, 86);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(110, 80);
            this.groupBox10.TabIndex = 26;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ток";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_nagruzka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(614, 461);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAddNagruzka);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form_nagruzka";
            this.Text = "Добавление нагрузки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_nagruzka_FormClosed);
            this.Load += new System.EventHandler(this.Form_nagruzka_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAddNagruzka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBoxStandartPower;
        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.ComboBox comboBoxSource;
        private System.Windows.Forms.ComboBox comboBoxStandartVoltage;
        private System.Windows.Forms.ListBox listBoxNumberOfPhases;
        private System.Windows.Forms.ListBox listBoxHarakter;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.ListBox listBoxTypeNetwork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStandartCosf;
    }
}