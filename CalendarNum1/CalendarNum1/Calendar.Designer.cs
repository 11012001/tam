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
            this.xuiButton8 = new XanderUI.XUIButton();
            this.xuiButton7 = new XanderUI.XUIButton();
            this.xuiButton6 = new XanderUI.XUIButton();
            this.xuiButton5 = new XanderUI.XUIButton();
            this.xuiButton4 = new XanderUI.XUIButton();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.MonBtn = new XanderUI.XUIButton();
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
            this.panel1.Controls.Add(this.xuiButton8);
            this.panel1.Controls.Add(this.xuiButton7);
            this.panel1.Controls.Add(this.xuiButton6);
            this.panel1.Controls.Add(this.xuiButton5);
            this.panel1.Controls.Add(this.xuiButton4);
            this.panel1.Controls.Add(this.xuiButton3);
            this.panel1.Controls.Add(this.MonBtn);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 36);
            this.panel1.TabIndex = 2;
            // 
            // xuiButton8
            // 
            this.xuiButton8.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton8.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton8.ButtonImage")));
            this.xuiButton8.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton8.ButtonText = "Chủ Nhật";
            this.xuiButton8.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton8.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton8.CornerRadius = 5;
            this.xuiButton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton8.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton8.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton8.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton8.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton8.Location = new System.Drawing.Point(597, 3);
            this.xuiButton8.Name = "xuiButton8";
            this.xuiButton8.Size = new System.Drawing.Size(93, 30);
            this.xuiButton8.TabIndex = 1;
            this.xuiButton8.TextColor = System.Drawing.Color.Black;
            this.xuiButton8.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton7
            // 
            this.xuiButton7.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton7.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton7.ButtonImage")));
            this.xuiButton7.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton7.ButtonText = "Thứ 7";
            this.xuiButton7.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton7.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton7.CornerRadius = 5;
            this.xuiButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton7.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton7.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton7.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton7.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton7.Location = new System.Drawing.Point(498, 3);
            this.xuiButton7.Name = "xuiButton7";
            this.xuiButton7.Size = new System.Drawing.Size(93, 30);
            this.xuiButton7.TabIndex = 1;
            this.xuiButton7.TextColor = System.Drawing.Color.Black;
            this.xuiButton7.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton6
            // 
            this.xuiButton6.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton6.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton6.ButtonImage")));
            this.xuiButton6.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton6.ButtonText = "Thứ 6";
            this.xuiButton6.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton6.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton6.CornerRadius = 5;
            this.xuiButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton6.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton6.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton6.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton6.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton6.Location = new System.Drawing.Point(399, 3);
            this.xuiButton6.Name = "xuiButton6";
            this.xuiButton6.Size = new System.Drawing.Size(93, 30);
            this.xuiButton6.TabIndex = 3;
            this.xuiButton6.TextColor = System.Drawing.Color.Black;
            this.xuiButton6.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton5
            // 
            this.xuiButton5.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton5.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton5.ButtonImage")));
            this.xuiButton5.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton5.ButtonText = "Thứ 5";
            this.xuiButton5.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton5.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton5.CornerRadius = 5;
            this.xuiButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton5.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton5.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton5.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton5.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton5.Location = new System.Drawing.Point(300, 3);
            this.xuiButton5.Name = "xuiButton5";
            this.xuiButton5.Size = new System.Drawing.Size(93, 30);
            this.xuiButton5.TabIndex = 1;
            this.xuiButton5.TextColor = System.Drawing.Color.Black;
            this.xuiButton5.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton4
            // 
            this.xuiButton4.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton4.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton4.ButtonImage")));
            this.xuiButton4.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton4.ButtonText = "Thứ 4";
            this.xuiButton4.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.xuiButton4.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.xuiButton4.CornerRadius = 5;
            this.xuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton4.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.xuiButton4.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.xuiButton4.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton4.Location = new System.Drawing.Point(201, 3);
            this.xuiButton4.Name = "xuiButton4";
            this.xuiButton4.Size = new System.Drawing.Size(93, 30);
            this.xuiButton4.TabIndex = 2;
            this.xuiButton4.TextColor = System.Drawing.Color.Black;
            this.xuiButton4.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.White;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.xuiButton3.ButtonText = "Thứ 3";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton3.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.xuiButton3.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(102, 3);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(93, 30);
            this.xuiButton3.TabIndex = 1;
            this.xuiButton3.TextColor = System.Drawing.Color.Black;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // MonBtn
            // 
            this.MonBtn.BackgroundColor = System.Drawing.Color.White;
            this.MonBtn.ButtonImage = ((System.Drawing.Image)(resources.GetObject("MonBtn.ButtonImage")));
            this.MonBtn.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.MonBtn.ButtonText = "Thứ 2";
            this.MonBtn.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.MonBtn.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.MonBtn.CornerRadius = 5;
            this.MonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MonBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.MonBtn.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.MonBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.MonBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.MonBtn.Location = new System.Drawing.Point(3, 3);
            this.MonBtn.Name = "MonBtn";
            this.MonBtn.Size = new System.Drawing.Size(93, 30);
            this.MonBtn.TabIndex = 0;
            this.MonBtn.TextColor = System.Drawing.Color.Black;
            this.MonBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
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
            this.buttonEvent.BackColor = System.Drawing.Color.Transparent;
            this.buttonEvent.FlatAppearance.BorderColor = System.Drawing.Color.Turquoise;
            this.buttonEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEvent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvent.Location = new System.Drawing.Point(1, 0);
            this.buttonEvent.Name = "buttonEvent";
            this.buttonEvent.Size = new System.Drawing.Size(535, 38);
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
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.DigitalClock);
            this.panel2.Controls.Add(this.BackToDateBttn);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PreviousBttn);
            this.panel2.Controls.Add(this.EventPanel);
            this.panel2.Controls.Add(this.NextBttn);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.MatrixPanel);
            this.panel2.Location = new System.Drawing.Point(0, 30);
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
            this.menuStrip2.Size = new System.Drawing.Size(1266, 27);
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
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1266, 495);
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
        private System.Windows.Forms.Button buttonEvent;
        private System.Windows.Forms.Button BackToDateBttn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSV;
        private System.Windows.Forms.Timer timer1;
        private XanderUI.XUIButton xuiButton8;
        private XanderUI.XUIButton xuiButton7;
        private XanderUI.XUIButton xuiButton6;
        private XanderUI.XUIButton xuiButton5;
        private XanderUI.XUIButton xuiButton4;
        private XanderUI.XUIButton xuiButton3;
        private XanderUI.XUIButton MonBtn;
    }
}

