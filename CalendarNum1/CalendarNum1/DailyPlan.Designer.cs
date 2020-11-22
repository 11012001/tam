namespace CalendarNum1
{
    partial class DailyPlan
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
            this.btBefday = new System.Windows.Forms.Button();
            this.btNextday = new System.Windows.Forms.Button();
            this.DTPKdate = new System.Windows.Forms.DateTimePicker();
            this.pnJob = new System.Windows.Forms.Panel();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuAddjob = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pnJob);
            this.panel1.Location = new System.Drawing.Point(4, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 380);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btBefday);
            this.panel3.Controls.Add(this.btNextday);
            this.panel3.Controls.Add(this.DTPKdate);
            this.panel3.Location = new System.Drawing.Point(4, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(893, 28);
            this.panel3.TabIndex = 1;
            // 
            // btBefday
            // 
            this.btBefday.Location = new System.Drawing.Point(0, 0);
            this.btBefday.Margin = new System.Windows.Forms.Padding(4);
            this.btBefday.Name = "btBefday";
            this.btBefday.Size = new System.Drawing.Size(100, 28);
            this.btBefday.TabIndex = 0;
            this.btBefday.Text = "Hôm qua";
            this.btBefday.UseVisualStyleBackColor = true;
            // 
            // btNextday
            // 
            this.btNextday.Location = new System.Drawing.Point(792, 0);
            this.btNextday.Margin = new System.Windows.Forms.Padding(4);
            this.btNextday.Name = "btNextday";
            this.btNextday.Size = new System.Drawing.Size(100, 28);
            this.btNextday.TabIndex = 2;
            this.btNextday.Text = "Ngày mai";
            this.btNextday.UseVisualStyleBackColor = true;
            // 
            // DTPKdate
            // 
            this.DTPKdate.Location = new System.Drawing.Point(333, 4);
            this.DTPKdate.Margin = new System.Windows.Forms.Padding(4);
            this.DTPKdate.Name = "DTPKdate";
            this.DTPKdate.Size = new System.Drawing.Size(265, 22);
            this.DTPKdate.TabIndex = 1;
            this.DTPKdate.ValueChanged += new System.EventHandler(this.DTPKdate_ValueChanged);
            // 
            // pnJob
            // 
            this.pnJob.Location = new System.Drawing.Point(4, 26);
            this.pnJob.Margin = new System.Windows.Forms.Padding(4);
            this.pnJob.Name = "pnJob";
            this.pnJob.Size = new System.Drawing.Size(936, 351);
            this.pnJob.TabIndex = 0;
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddjob,
            this.menuToday});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(944, 28);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // menuAddjob
            // 
            this.menuAddjob.Name = "menuAddjob";
            this.menuAddjob.Size = new System.Drawing.Size(127, 24);
            this.menuAddjob.Text = "Thêm công việc";
            // 
            // menuToday
            // 
            this.menuToday.Name = "menuToday";
            this.menuToday.Size = new System.Drawing.Size(83, 24);
            this.menuToday.Text = "Hôm nay";
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 425);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DailyPlan";
            this.Text = "Lịch trong ngày";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btNextday;
        private System.Windows.Forms.DateTimePicker DTPKdate;
        private System.Windows.Forms.Panel pnJob;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuAddjob;
        private System.Windows.Forms.ToolStripMenuItem menuToday;
        private System.Windows.Forms.Button btBefday;
    }
}