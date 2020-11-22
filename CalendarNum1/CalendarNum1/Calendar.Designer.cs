namespace CalendarNum1
{
    partial class Calendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.DigitalClock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonT3 = new System.Windows.Forms.Button();
            this.buttonT4 = new System.Windows.Forms.Button();
            this.buttonCN = new System.Windows.Forms.Button();
            this.buttonT7 = new System.Windows.Forms.Button();
            this.buttonT5 = new System.Windows.Forms.Button();
            this.buttonT2 = new System.Windows.Forms.Button();
            this.buttonT6 = new System.Windows.Forms.Button();
            this.MatrixPanel = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.NextBttn = new System.Windows.Forms.Button();
            this.PreviousBttn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.EventPanel = new System.Windows.Forms.Panel();
            this.buttonEvent = new System.Windows.Forms.Button();
            this.NumEventPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToDateBttn = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSV = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.EventPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DigitalClock
            // 
            this.DigitalClock.AutoSize = true;
            this.DigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalClock.Location = new System.Drawing.Point(12, 20);
            this.DigitalClock.Name = "DigitalClock";
            this.DigitalClock.Size = new System.Drawing.Size(212, 43);
            this.DigitalClock.TabIndex = 0;
            this.DigitalClock.Text = "00:00:00 A.M";
            this.DigitalClock.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.buttonT3);
            this.panel1.Controls.Add(this.buttonT4);
            this.panel1.Controls.Add(this.buttonCN);
            this.panel1.Controls.Add(this.buttonT7);
            this.panel1.Controls.Add(this.buttonT5);
            this.panel1.Controls.Add(this.buttonT2);
            this.panel1.Controls.Add(this.buttonT6);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 36);
            this.panel1.TabIndex = 2;
            // 
            // buttonT3
            // 
            this.buttonT3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT3.Location = new System.Drawing.Point(102, 3);
            this.buttonT3.Name = "buttonT3";
            this.buttonT3.Size = new System.Drawing.Size(93, 30);
            this.buttonT3.TabIndex = 6;
            this.buttonT3.Text = "Thứ 3";
            this.buttonT3.UseVisualStyleBackColor = true;
            this.buttonT3.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonT4
            // 
            this.buttonT4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT4.Location = new System.Drawing.Point(201, 3);
            this.buttonT4.Name = "buttonT4";
            this.buttonT4.Size = new System.Drawing.Size(93, 30);
            this.buttonT4.TabIndex = 5;
            this.buttonT4.Text = "Thứ 4";
            this.buttonT4.UseVisualStyleBackColor = true;
            this.buttonT4.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonCN
            // 
            this.buttonCN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCN.Location = new System.Drawing.Point(597, 3);
            this.buttonCN.Name = "buttonCN";
            this.buttonCN.Size = new System.Drawing.Size(93, 30);
            this.buttonCN.TabIndex = 3;
            this.buttonCN.Text = "Chủ nhật";
            this.buttonCN.UseVisualStyleBackColor = true;
            this.buttonCN.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonT7
            // 
            this.buttonT7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT7.Location = new System.Drawing.Point(498, 3);
            this.buttonT7.Name = "buttonT7";
            this.buttonT7.Size = new System.Drawing.Size(93, 30);
            this.buttonT7.TabIndex = 2;
            this.buttonT7.Text = "Thứ 7";
            this.buttonT7.UseVisualStyleBackColor = true;
            this.buttonT7.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonT5
            // 
            this.buttonT5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT5.Location = new System.Drawing.Point(300, 3);
            this.buttonT5.Name = "buttonT5";
            this.buttonT5.Size = new System.Drawing.Size(93, 30);
            this.buttonT5.TabIndex = 1;
            this.buttonT5.Text = "Thứ 5";
            this.buttonT5.UseVisualStyleBackColor = true;
            this.buttonT5.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonT2
            // 
            this.buttonT2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT2.Location = new System.Drawing.Point(3, 3);
            this.buttonT2.Name = "buttonT2";
            this.buttonT2.Size = new System.Drawing.Size(93, 30);
            this.buttonT2.TabIndex = 0;
            this.buttonT2.Text = "Thứ 2";
            this.buttonT2.UseVisualStyleBackColor = true;
            this.buttonT2.Click += new System.EventHandler(this.buttonDOW);
            // 
            // buttonT6
            // 
            this.buttonT6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonT6.Location = new System.Drawing.Point(399, 3);
            this.buttonT6.Name = "buttonT6";
            this.buttonT6.Size = new System.Drawing.Size(93, 30);
            this.buttonT6.TabIndex = 4;
            this.buttonT6.Text = "Thứ 6";
            this.buttonT6.UseVisualStyleBackColor = true;
            this.buttonT6.Click += new System.EventHandler(this.buttonDOW);
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Location = new System.Drawing.Point(15, 112);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(693, 348);
            this.MatrixPanel.TabIndex = 3;
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(188, 27);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(320, 26);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NextBttn
            // 
            this.NextBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBttn.Location = new System.Drawing.Point(650, 17);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(52, 38);
            this.NextBttn.TabIndex = 4;
            this.NextBttn.Text = ">";
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // PreviousBttn
            // 
            this.PreviousBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PreviousBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousBttn.Location = new System.Drawing.Point(514, 17);
            this.PreviousBttn.Name = "PreviousBttn";
            this.PreviousBttn.Size = new System.Drawing.Size(46, 38);
            this.PreviousBttn.TabIndex = 5;
            this.PreviousBttn.Text = "<";
            this.PreviousBttn.UseVisualStyleBackColor = true;
            this.PreviousBttn.Click += new System.EventHandler(this.PreviousBttn_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // EventPanel
            // 
            this.EventPanel.Controls.Add(this.buttonEvent);
            this.EventPanel.Controls.Add(this.NumEventPanel);
            this.EventPanel.Location = new System.Drawing.Point(728, 9);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(539, 458);
            this.EventPanel.TabIndex = 7;
            // 
            // buttonEvent
            // 
            this.buttonEvent.BackColor = System.Drawing.Color.LightCyan;
            this.buttonEvent.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvent.Location = new System.Drawing.Point(1, 0);
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.Size = new System.Drawing.Size(533, 38);
            this.buttonEvent.TabIndex = 0;
            this.buttonEvent.Text = "Các sự kiện nổi bật";
            this.buttonEvent.UseVisualStyleBackColor = false;
            // 
            // NumEventPanel
            // 
            this.NumEventPanel.Location = new System.Drawing.Point(1, 43);
            this.NumEventPanel.Name = "NumEventPanel";
            this.NumEventPanel.Size = new System.Drawing.Size(535, 413);
            this.NumEventPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.DigitalClock);
            this.panel2.Controls.Add(this.BackToDateBttn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PreviousBttn);
            this.panel2.Controls.Add(this.EventPanel);
            this.panel2.Controls.Add(this.NextBttn);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.MatrixPanel);
            this.panel2.Location = new System.Drawing.Point(4, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1270, 463);
            this.panel2.TabIndex = 8;
            // 
            // BackToDateBttn
            // 
            this.BackToDateBttn.BackColor = System.Drawing.Color.Honeydew;
            this.BackToDateBttn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToDateBttn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToDateBttn.Location = new System.Drawing.Point(566, 17);
            this.BackToDateBttn.Name = "BackToDateBttn";
            this.BackToDateBttn.Size = new System.Drawing.Size(78, 39);
            this.BackToDateBttn.TabIndex = 10;
            this.BackToDateBttn.Text = "Hôm nay";
            this.BackToDateBttn.UseVisualStyleBackColor = false;
            this.BackToDateBttn.Click += new System.EventHandler(this.BackToDateBttn_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1275, 27);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSV,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolStripMenuItemSV
            // 
            this.toolStripMenuItemSV.Name = "toolStripMenuItemSV";
            this.toolStripMenuItemSV.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItemSV.Text = "Small view";
            this.toolStripMenuItemSV.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1275, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calendar_FormClosing);
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.panel1.ResumeLayout(false);
            this.EventPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MatrixPanel;
        public System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button NextBttn;
        private System.Windows.Forms.Button PreviousBttn;
        private System.Windows.Forms.Label DigitalClock;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel EventPanel;
        private System.Windows.Forms.Panel NumEventPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonT2;
        private System.Windows.Forms.Button buttonT3;
        private System.Windows.Forms.Button buttonT4;
        private System.Windows.Forms.Button buttonCN;
        private System.Windows.Forms.Button buttonT7;
        private System.Windows.Forms.Button buttonT5;
        private System.Windows.Forms.Button buttonT6;
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.Button BackToDateBttn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSV;
        private System.Windows.Forms.Timer timer1;
    }
}

