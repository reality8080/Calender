namespace Lich
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonToDay = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btton_Previous_Week = new System.Windows.Forms.Button();
            this.Btton_Next_Week = new System.Windows.Forms.Button();
            this.BttonSun = new System.Windows.Forms.Button();
            this.BttonSat = new System.Windows.Forms.Button();
            this.BttonFri = new System.Windows.Forms.Button();
            this.BttonThurs = new System.Windows.Forms.Button();
            this.BttonWe = new System.Windows.Forms.Button();
            this.BttonTues = new System.Windows.Forms.Button();
            this.BttonMon = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBoxNotify = new System.Windows.Forms.CheckBox();
            this.numericUpDownNotify = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 479);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.ButtonToDay);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 38);
            this.panel3.TabIndex = 1;
            // 
            // ButtonToDay
            // 
            this.ButtonToDay.Location = new System.Drawing.Point(543, 9);
            this.ButtonToDay.Name = "ButtonToDay";
            this.ButtonToDay.Size = new System.Drawing.Size(75, 23);
            this.ButtonToDay.TabIndex = 1;
            this.ButtonToDay.Text = "Hom nay";
            this.ButtonToDay.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(290, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 438);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(142, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(517, 349);
            this.panel5.TabIndex = 1;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Btton_Previous_Week);
            this.panel4.Controls.Add(this.Btton_Next_Week);
            this.panel4.Controls.Add(this.BttonSun);
            this.panel4.Controls.Add(this.BttonSat);
            this.panel4.Controls.Add(this.BttonFri);
            this.panel4.Controls.Add(this.BttonThurs);
            this.panel4.Controls.Add(this.BttonWe);
            this.panel4.Controls.Add(this.BttonTues);
            this.panel4.Controls.Add(this.BttonMon);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(807, 77);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // Btton_Previous_Week
            // 
            this.Btton_Previous_Week.Location = new System.Drawing.Point(60, 8);
            this.Btton_Previous_Week.Name = "Btton_Previous_Week";
            this.Btton_Previous_Week.Size = new System.Drawing.Size(73, 66);
            this.Btton_Previous_Week.TabIndex = 8;
            this.Btton_Previous_Week.Text = "Tháng Trước";
            this.Btton_Previous_Week.UseVisualStyleBackColor = true;
            // 
            // Btton_Next_Week
            // 
            this.Btton_Next_Week.Location = new System.Drawing.Point(662, 8);
            this.Btton_Next_Week.Name = "Btton_Next_Week";
            this.Btton_Next_Week.Size = new System.Drawing.Size(73, 66);
            this.Btton_Next_Week.TabIndex = 7;
            this.Btton_Next_Week.Text = "Tháng sau";
            this.Btton_Next_Week.UseVisualStyleBackColor = true;
            // 
            // BttonSun
            // 
            this.BttonSun.Location = new System.Drawing.Point(583, 8);
            this.BttonSun.Name = "BttonSun";
            this.BttonSun.Size = new System.Drawing.Size(73, 66);
            this.BttonSun.TabIndex = 6;
            this.BttonSun.Text = "CN";
            this.BttonSun.UseVisualStyleBackColor = true;
            // 
            // BttonSat
            // 
            this.BttonSat.Location = new System.Drawing.Point(509, 8);
            this.BttonSat.Name = "BttonSat";
            this.BttonSat.Size = new System.Drawing.Size(73, 66);
            this.BttonSat.TabIndex = 5;
            this.BttonSat.Text = "Thứ 7";
            this.BttonSat.UseVisualStyleBackColor = true;
            // 
            // BttonFri
            // 
            this.BttonFri.Location = new System.Drawing.Point(435, 8);
            this.BttonFri.Name = "BttonFri";
            this.BttonFri.Size = new System.Drawing.Size(73, 66);
            this.BttonFri.TabIndex = 4;
            this.BttonFri.Text = "Thứ 6";
            this.BttonFri.UseVisualStyleBackColor = true;
            // 
            // BttonThurs
            // 
            this.BttonThurs.Location = new System.Drawing.Point(361, 8);
            this.BttonThurs.Name = "BttonThurs";
            this.BttonThurs.Size = new System.Drawing.Size(73, 66);
            this.BttonThurs.TabIndex = 3;
            this.BttonThurs.Text = "Thứ 5";
            this.BttonThurs.UseVisualStyleBackColor = true;
            // 
            // BttonWe
            // 
            this.BttonWe.Location = new System.Drawing.Point(287, 8);
            this.BttonWe.Name = "BttonWe";
            this.BttonWe.Size = new System.Drawing.Size(73, 66);
            this.BttonWe.TabIndex = 2;
            this.BttonWe.Text = "Thứ 4";
            this.BttonWe.UseVisualStyleBackColor = true;
            // 
            // BttonTues
            // 
            this.BttonTues.Location = new System.Drawing.Point(213, 8);
            this.BttonTues.Name = "BttonTues";
            this.BttonTues.Size = new System.Drawing.Size(73, 66);
            this.BttonTues.TabIndex = 1;
            this.BttonTues.Text = "Thứ 3";
            this.BttonTues.UseVisualStyleBackColor = true;
            // 
            // BttonMon
            // 
            this.BttonMon.Location = new System.Drawing.Point(139, 8);
            this.BttonMon.Name = "BttonMon";
            this.BttonMon.Size = new System.Drawing.Size(73, 66);
            this.BttonMon.TabIndex = 0;
            this.BttonMon.Text = "Thứ 2";
            this.BttonMon.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.numericUpDownNotify);
            this.panel6.Controls.Add(this.checkBoxNotify);
            this.panel6.Location = new System.Drawing.Point(11, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(204, 38);
            this.panel6.TabIndex = 2;
            // 
            // checkBoxNotify
            // 
            this.checkBoxNotify.AutoSize = true;
            this.checkBoxNotify.Location = new System.Drawing.Point(3, 9);
            this.checkBoxNotify.Name = "checkBoxNotify";
            this.checkBoxNotify.Size = new System.Drawing.Size(63, 20);
            this.checkBoxNotify.TabIndex = 0;
            this.checkBoxNotify.Text = "Notify";
            this.checkBoxNotify.UseVisualStyleBackColor = true;
            // 
            // numericUpDownNotify
            // 
            this.numericUpDownNotify.Location = new System.Drawing.Point(89, 9);
            this.numericUpDownNotify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numericUpDownNotify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNotify.Name = "numericUpDownNotify";
            this.numericUpDownNotify.Size = new System.Drawing.Size(104, 22);
            this.numericUpDownNotify.TabIndex = 1;
            this.numericUpDownNotify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 528);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNotify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButtonToDay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button BttonMon;
        private System.Windows.Forms.Button BttonWe;
        private System.Windows.Forms.Button BttonTues;
        private System.Windows.Forms.Button BttonSat;
        private System.Windows.Forms.Button BttonFri;
        private System.Windows.Forms.Button BttonThurs;
        private System.Windows.Forms.Button BttonSun;
        private System.Windows.Forms.Button Btton_Previous_Week;
        private System.Windows.Forms.Button Btton_Next_Week;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox checkBoxNotify;
        private System.Windows.Forms.NumericUpDown numericUpDownNotify;
    }
}

