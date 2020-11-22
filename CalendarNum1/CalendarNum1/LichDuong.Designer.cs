namespace CalendarNum1
{
    partial class LichDuong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichDuong));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GeneralPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clock = new System.Windows.Forms.Label();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.TodayBtn = new System.Windows.Forms.Button();
            this.MatrixPanel = new System.Windows.Forms.Panel();
            this.DaysPanel = new System.Windows.Forms.Panel();
            this.SunBtn = new System.Windows.Forms.Button();
            this.TueBtn = new System.Windows.Forms.Button();
            this.SatBtn = new System.Windows.Forms.Button();
            this.WedBtn = new System.Windows.Forms.Button();
            this.FriBtn = new System.Windows.Forms.Button();
            this.ThuBtn = new System.Windows.Forms.Button();
            this.Monbtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.GeneralPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DaysPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewAllToolStripMenuItem
            // 
            this.viewAllToolStripMenuItem.Name = "viewAllToolStripMenuItem";
            this.viewAllToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.viewAllToolStripMenuItem.Text = "ViewAll";
            this.viewAllToolStripMenuItem.Click += new System.EventHandler(this.fullViewToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(467, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GeneralPanel
            // 
            this.GeneralPanel.Controls.Add(this.panel1);
            this.GeneralPanel.Controls.Add(this.MatrixPanel);
            this.GeneralPanel.Controls.Add(this.DaysPanel);
            this.GeneralPanel.Location = new System.Drawing.Point(0, 31);
            this.GeneralPanel.Name = "GeneralPanel";
            this.GeneralPanel.Size = new System.Drawing.Size(467, 412);
            this.GeneralPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Controls.Add(this.dtpk);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.PreviousBtn);
            this.panel1.Controls.Add(this.TodayBtn);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 62);
            this.panel1.TabIndex = 0;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.Location = new System.Drawing.Point(279, 13);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(202, 44);
            this.Clock.TabIndex = 2;
            this.Clock.Text = "00:00 A.M";
            // 
            // dtpk
            // 
            this.dtpk.Location = new System.Drawing.Point(10, 4);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(252, 24);
            this.dtpk.TabIndex = 1;
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(152, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousBtn.Location = new System.Drawing.Point(10, 34);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(55, 23);
            this.PreviousBtn.TabIndex = 0;
            this.PreviousBtn.Text = "<";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // TodayBtn
            // 
            this.TodayBtn.BackColor = System.Drawing.Color.Honeydew;
            this.TodayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TodayBtn.Location = new System.Drawing.Point(71, 34);
            this.TodayBtn.Name = "TodayBtn";
            this.TodayBtn.Size = new System.Drawing.Size(75, 23);
            this.TodayBtn.TabIndex = 0;
            this.TodayBtn.Text = "Today";
            this.TodayBtn.UseVisualStyleBackColor = false;
            this.TodayBtn.Click += new System.EventHandler(this.TodayBtn_Click);
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Location = new System.Drawing.Point(8, 109);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(445, 291);
            this.MatrixPanel.TabIndex = 1;
            // 
            // DaysPanel
            // 
            this.DaysPanel.Controls.Add(this.SunBtn);
            this.DaysPanel.Controls.Add(this.TueBtn);
            this.DaysPanel.Controls.Add(this.SatBtn);
            this.DaysPanel.Controls.Add(this.WedBtn);
            this.DaysPanel.Controls.Add(this.FriBtn);
            this.DaysPanel.Controls.Add(this.ThuBtn);
            this.DaysPanel.Controls.Add(this.Monbtn);
            this.DaysPanel.Location = new System.Drawing.Point(3, 71);
            this.DaysPanel.Name = "DaysPanel";
            this.DaysPanel.Size = new System.Drawing.Size(461, 32);
            this.DaysPanel.TabIndex = 0;
            // 
            // SunBtn
            // 
            this.SunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SunBtn.Location = new System.Drawing.Point(395, 4);
            this.SunBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SunBtn.Name = "SunBtn";
            this.SunBtn.Size = new System.Drawing.Size(55, 25);
            this.SunBtn.TabIndex = 1;
            this.SunBtn.Text = "CN";
            this.SunBtn.UseVisualStyleBackColor = true;
            // 
            // TueBtn
            // 
            this.TueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TueBtn.Location = new System.Drawing.Point(70, 4);
            this.TueBtn.Margin = new System.Windows.Forms.Padding(5);
            this.TueBtn.Name = "TueBtn";
            this.TueBtn.Size = new System.Drawing.Size(55, 25);
            this.TueBtn.TabIndex = 1;
            this.TueBtn.Text = "T3";
            this.TueBtn.UseVisualStyleBackColor = true;
            // 
            // SatBtn
            // 
            this.SatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SatBtn.Location = new System.Drawing.Point(330, 4);
            this.SatBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SatBtn.Name = "SatBtn";
            this.SatBtn.Size = new System.Drawing.Size(55, 25);
            this.SatBtn.TabIndex = 1;
            this.SatBtn.Text = "T7";
            this.SatBtn.UseVisualStyleBackColor = true;
            // 
            // WedBtn
            // 
            this.WedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WedBtn.Location = new System.Drawing.Point(135, 4);
            this.WedBtn.Margin = new System.Windows.Forms.Padding(5);
            this.WedBtn.Name = "WedBtn";
            this.WedBtn.Size = new System.Drawing.Size(55, 25);
            this.WedBtn.TabIndex = 1;
            this.WedBtn.Text = "T4";
            this.WedBtn.UseVisualStyleBackColor = true;
            // 
            // FriBtn
            // 
            this.FriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FriBtn.Location = new System.Drawing.Point(265, 4);
            this.FriBtn.Margin = new System.Windows.Forms.Padding(5);
            this.FriBtn.Name = "FriBtn";
            this.FriBtn.Size = new System.Drawing.Size(55, 25);
            this.FriBtn.TabIndex = 1;
            this.FriBtn.Text = "T6";
            this.FriBtn.UseVisualStyleBackColor = true;
            // 
            // ThuBtn
            // 
            this.ThuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ThuBtn.Location = new System.Drawing.Point(200, 4);
            this.ThuBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ThuBtn.Name = "ThuBtn";
            this.ThuBtn.Size = new System.Drawing.Size(55, 25);
            this.ThuBtn.TabIndex = 1;
            this.ThuBtn.Text = "T5";
            this.ThuBtn.UseVisualStyleBackColor = true;
            // 
            // Monbtn
            // 
            this.Monbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Monbtn.Location = new System.Drawing.Point(5, 4);
            this.Monbtn.Margin = new System.Windows.Forms.Padding(5);
            this.Monbtn.Name = "Monbtn";
            this.Monbtn.Size = new System.Drawing.Size(55, 24);
            this.Monbtn.TabIndex = 1;
            this.Monbtn.Text = "T2";
            this.Monbtn.UseVisualStyleBackColor = true;
            // 
            // LichDuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(467, 443);
            this.Controls.Add(this.GeneralPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LichDuong";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "LichDuong";
            this.Load += new System.EventHandler(this.LichDuong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GeneralPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DaysPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel GeneralPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MatrixPanel;
        private System.Windows.Forms.Panel DaysPanel;
        private System.Windows.Forms.Button SatBtn;
        private System.Windows.Forms.Button ThuBtn;
        private System.Windows.Forms.Button WedBtn;
        private System.Windows.Forms.Button TueBtn;
        private System.Windows.Forms.Button Monbtn;
        private System.Windows.Forms.Button SunBtn;
        private System.Windows.Forms.Button FriBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button TodayBtn;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label Clock;
    }
}