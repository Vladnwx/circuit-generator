namespace circuit_generator
{
    partial class Form_load
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
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.listView4 = new System.Windows.Forms.ListView();
            this.listView5 = new System.Windows.Forms.ListView();
            this.listView6 = new System.Windows.Forms.ListView();
            this.listView7 = new System.Windows.Forms.ListView();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.listView8 = new System.Windows.Forms.ListView();
            this.listView9 = new System.Windows.Forms.ListView();
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
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(1, 55);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 фазы";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoEllipsis = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(1, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 фаза";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(220, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Добавить нагрузку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1, 35);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 фазы";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 80);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество фаз";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(184, 287);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(204, 17);
            this.checkBox2.TabIndex = 25;
            this.checkBox2.Text = "Расширенный вариант добавления";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView1);
            this.groupBox2.Location = new System.Drawing.Point(110, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 80);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Мощность,  кВт";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView2);
            this.groupBox3.Location = new System.Drawing.Point(220, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(110, 80);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Косинус нагрузки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listView3);
            this.groupBox4.Location = new System.Drawing.Point(330, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(110, 80);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Начало нагрузки";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listView4);
            this.groupBox5.Location = new System.Drawing.Point(330, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(110, 80);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Местоположение нагрузки";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listView5);
            this.groupBox6.Location = new System.Drawing.Point(110, 86);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(110, 80);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Характер нагрузки";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listView6);
            this.groupBox7.Location = new System.Drawing.Point(110, 172);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(110, 80);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Тип нагрузки";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.listView7);
            this.groupBox8.Location = new System.Drawing.Point(226, 172);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(276, 80);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Тип применяемой сети на комплексную нагрузку";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(104, 61);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 16);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(104, 61);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
            // 
            // listView3
            // 
            this.listView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView3.Enabled = false;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(3, 16);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(104, 61);
            this.listView3.TabIndex = 0;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged_1);
            // 
            // listView4
            // 
            this.listView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(3, 16);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(104, 61);
            this.listView4.TabIndex = 0;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = System.Windows.Forms.View.List;
            // 
            // listView5
            // 
            this.listView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView5.HideSelection = false;
            this.listView5.Location = new System.Drawing.Point(3, 16);
            this.listView5.Name = "listView5";
            this.listView5.Size = new System.Drawing.Size(104, 61);
            this.listView5.TabIndex = 0;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = System.Windows.Forms.View.List;
            // 
            // listView6
            // 
            this.listView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView6.HideSelection = false;
            this.listView6.Location = new System.Drawing.Point(3, 16);
            this.listView6.Name = "listView6";
            this.listView6.Size = new System.Drawing.Size(104, 61);
            this.listView6.TabIndex = 0;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = System.Windows.Forms.View.List;
            // 
            // listView7
            // 
            this.listView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView7.HideSelection = false;
            this.listView7.Location = new System.Drawing.Point(3, 16);
            this.listView7.Name = "listView7";
            this.listView7.Size = new System.Drawing.Size(270, 61);
            this.listView7.TabIndex = 0;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = System.Windows.Forms.View.List;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.listView8);
            this.groupBox9.Location = new System.Drawing.Point(1, 86);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(110, 80);
            this.groupBox9.TabIndex = 25;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Напряжение";
            this.groupBox9.Visible = false;
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.listView9);
            this.groupBox10.Location = new System.Drawing.Point(1, 172);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(110, 80);
            this.groupBox10.TabIndex = 26;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ток";
            this.groupBox10.Visible = false;
            this.groupBox10.Enter += new System.EventHandler(this.groupBox10_Enter);
            // 
            // listView8
            // 
            this.listView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView8.HideSelection = false;
            this.listView8.Location = new System.Drawing.Point(3, 16);
            this.listView8.Name = "listView8";
            this.listView8.Size = new System.Drawing.Size(104, 61);
            this.listView8.TabIndex = 0;
            this.listView8.UseCompatibleStateImageBehavior = false;
            this.listView8.View = System.Windows.Forms.View.List;
            // 
            // listView9
            // 
            this.listView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView9.HideSelection = false;
            this.listView9.Location = new System.Drawing.Point(3, 16);
            this.listView9.Name = "listView9";
            this.listView9.Size = new System.Drawing.Size(104, 61);
            this.listView9.TabIndex = 0;
            this.listView9.UseCompatibleStateImageBehavior = false;
            this.listView9.View = System.Windows.Forms.View.List;
            // 
            // Form_load
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
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form_load";
            this.Text = "Добавление нагрузки";
            this.Load += new System.EventHandler(this.Form_load_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.ListView listView5;
        private System.Windows.Forms.ListView listView6;
        private System.Windows.Forms.ListView listView7;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListView listView8;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListView listView9;
    }
}