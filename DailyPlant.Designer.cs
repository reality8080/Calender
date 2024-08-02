namespace Lich
{
    partial class DailyPlant
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tomorrow = new System.Windows.Forms.Button();
            this.Yesterday = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thêmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hômToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 756);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Tomorrow);
            this.panel4.Controls.Add(this.Yesterday);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 45);
            this.panel4.TabIndex = 2;
            // 
            // Tomorrow
            // 
            this.Tomorrow.Location = new System.Drawing.Point(615, 4);
            this.Tomorrow.Name = "Tomorrow";
            this.Tomorrow.Size = new System.Drawing.Size(117, 38);
            this.Tomorrow.TabIndex = 2;
            this.Tomorrow.Text = "Ngày mai";
            this.Tomorrow.UseVisualStyleBackColor = true;
            // 
            // Yesterday
            // 
            this.Yesterday.Location = new System.Drawing.Point(99, 4);
            this.Yesterday.Name = "Yesterday";
            this.Yesterday.Size = new System.Drawing.Size(117, 38);
            this.Yesterday.TabIndex = 1;
            this.Yesterday.Text = "Hôm qua";
            this.Yesterday.UseVisualStyleBackColor = true;
            this.Yesterday.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(822, 32);
            this.panel3.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmViệcToolStripMenuItem,
            this.hômToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(822, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thêmViệcToolStripMenuItem
            // 
            this.thêmViệcToolStripMenuItem.Name = "thêmViệcToolStripMenuItem";
            this.thêmViệcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.thêmViệcToolStripMenuItem.Text = "Thêm việc";
            // 
            // hômToolStripMenuItem
            // 
            this.hômToolStripMenuItem.Name = "hômToolStripMenuItem";
            this.hômToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.hômToolStripMenuItem.Text = "Hôm nay ";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 663);
            this.panel2.TabIndex = 0;
            // 
            // DailyPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 757);
            this.Controls.Add(this.panel1);
            this.Name = "DailyPlant";
            this.Text = "DailyPlant";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmViệcToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem hômToolStripMenuItem;
        private System.Windows.Forms.Button Tomorrow;
        private System.Windows.Forms.Button Yesterday;
    }
}