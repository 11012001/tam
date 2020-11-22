namespace Project
{
    partial class DisplayDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonToday = new XanderUI.XUIButton();
            this.buttonNote = new XanderUI.XUIButton();
            this.Weather = new XanderUI.XUIWeatherClient();
            this.buttonMY = new XanderUI.XUIButton();
            this.buttonDay = new XanderUI.XUIButton();
            this.buttonPre = new XanderUI.XUIButton();
            this.buttonNext = new XanderUI.XUIButton();
            this.ButtonQuote = new XanderUI.XUIButton();
            this.ButtonWeather = new XanderUI.XUIButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelDay = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelLunnarDay = new System.Windows.Forms.Label();
            this.labelMonthLunnar = new System.Windows.Forms.Label();
            this.labelYearLunnar = new System.Windows.Forms.Label();
            this.labelZodiacTime = new System.Windows.Forms.Label();
            this.labelDOW = new System.Windows.Forms.Label();
            this.buttonLunnarDate = new Project.DisplayButton();
            this.SuspendLayout();
            // 
            // buttonToday
            // 
            this.buttonToday.BackgroundColor = System.Drawing.Color.White;
            this.buttonToday.ButtonImage = null;
            this.buttonToday.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.buttonToday.ButtonText = "Hôm nay";
            this.buttonToday.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.buttonToday.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.buttonToday.CornerRadius = 5;
            this.buttonToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonToday.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonToday.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.buttonToday.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.buttonToday.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonToday.Location = new System.Drawing.Point(65, 10);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(70, 65);
            this.buttonToday.TabIndex = 0;
            this.buttonToday.TextColor = System.Drawing.Color.Black;
            this.buttonToday.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonToday.Click += new System.EventHandler(this.buttonToday_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.BackgroundColor = System.Drawing.Color.White;
            this.buttonNote.ButtonImage = null;
            this.buttonNote.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            this.buttonNote.ButtonText = "Ghi chú";
            this.buttonNote.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.buttonNote.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.buttonNote.CornerRadius = 5;
            this.buttonNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonNote.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonNote.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.buttonNote.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.buttonNote.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonNote.Location = new System.Drawing.Point(440, 10);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(70, 65);
            this.buttonNote.TabIndex = 1;
            this.buttonNote.TextColor = System.Drawing.Color.Black;
            this.buttonNote.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonMY
            // 
            this.buttonMY.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMY.ButtonImage = null;
            this.buttonMY.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonMY.ButtonText = "Tháng Năm";
            this.buttonMY.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonMY.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonMY.CornerRadius = 5;
            this.buttonMY.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMY.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonMY.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonMY.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonMY.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonMY.Location = new System.Drawing.Point(165, 35);
            this.buttonMY.Name = "buttonMY";
            this.buttonMY.Size = new System.Drawing.Size(200, 70);
            this.buttonMY.TabIndex = 3;
            this.buttonMY.TextColor = System.Drawing.Color.DodgerBlue;
            this.buttonMY.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonDay
            // 
            this.buttonDay.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDay.ButtonImage = null;
            this.buttonDay.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonDay.ButtonText = "Ngày";
            this.buttonDay.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonDay.ClickTextColor = System.Drawing.Color.Cyan;
            this.buttonDay.CornerRadius = 5;
            this.buttonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDay.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonDay.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonDay.HoverTextColor = System.Drawing.Color.Azure;
            this.buttonDay.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonDay.Location = new System.Drawing.Point(165, 110);
            this.buttonDay.Name = "buttonDay";
            this.buttonDay.Size = new System.Drawing.Size(200, 170);
            this.buttonDay.TabIndex = 4;
            this.buttonDay.TextColor = System.Drawing.Color.DodgerBlue;
            this.buttonDay.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // buttonPre
            // 
            this.buttonPre.BackgroundColor = System.Drawing.Color.White;
            this.buttonPre.ButtonImage = null;
            this.buttonPre.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonPre.ButtonText = "Previous";
            this.buttonPre.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonPre.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonPre.CornerRadius = 5;
            this.buttonPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonPre.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonPre.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonPre.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonPre.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonPre.Location = new System.Drawing.Point(10, 350);
            this.buttonPre.Name = "buttonPre";
            this.buttonPre.Size = new System.Drawing.Size(90, 90);
            this.buttonPre.TabIndex = 10;
            this.buttonPre.TextColor = System.Drawing.Color.Black;
            this.buttonPre.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonPre.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackgroundColor = System.Drawing.Color.White;
            this.buttonNext.ButtonImage = null;
            this.buttonNext.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.buttonNext.ButtonText = "Next";
            this.buttonNext.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonNext.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonNext.CornerRadius = 5;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonNext.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonNext.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonNext.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonNext.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonNext.Location = new System.Drawing.Point(440, 350);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(90, 92);
            this.buttonNext.TabIndex = 11;
            this.buttonNext.TextColor = System.Drawing.Color.Black;
            this.buttonNext.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // ButtonQuote
            // 
            this.ButtonQuote.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonQuote.ButtonImage = null;
            this.ButtonQuote.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.ButtonQuote.ButtonText = "Quote";
            this.ButtonQuote.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ButtonQuote.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonQuote.CornerRadius = 5;
            this.ButtonQuote.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ButtonQuote.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ButtonQuote.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonQuote.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ButtonQuote.Location = new System.Drawing.Point(110, 310);
            this.ButtonQuote.Name = "ButtonQuote";
            this.ButtonQuote.Size = new System.Drawing.Size(320, 140);
            this.ButtonQuote.TabIndex = 12;
            this.ButtonQuote.TextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonQuote.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // ButtonWeather
            // 
            this.ButtonWeather.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ButtonWeather.ButtonImage = null;
            this.ButtonWeather.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.ButtonWeather.ButtonText = "Nhiệt độ";
            this.ButtonWeather.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ButtonWeather.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonWeather.CornerRadius = 45;
            this.ButtonWeather.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.ButtonWeather.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ButtonWeather.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonWeather.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.ButtonWeather.Location = new System.Drawing.Point(420, 115);
            this.ButtonWeather.Name = "ButtonWeather";
            this.ButtonWeather.Size = new System.Drawing.Size(105, 80);
            this.ButtonWeather.TabIndex = 13;
            this.ButtonWeather.TextColor = System.Drawing.Color.DodgerBlue;
            this.ButtonWeather.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.Location = new System.Drawing.Point(60, 520);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(42, 18);
            this.labelDay.TabIndex = 18;
            this.labelDay.Text = "Ngày";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonth.Location = new System.Drawing.Point(430, 520);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(49, 18);
            this.labelMonth.TabIndex = 19;
            this.labelMonth.Text = "Tháng";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(7, 662);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(32, 18);
            this.labelTime.TabIndex = 20;
            this.labelTime.Text = "Giờ";
            // 
            // dtpk
            // 
            this.dtpk.Location = new System.Drawing.Point(0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(1, 22);
            this.dtpk.TabIndex = 0;
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(10, 615);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 2);
            this.label1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(372, 613);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 2);
            this.label2.TabIndex = 23;
            // 
            // labelLunnarDay
            // 
            this.labelLunnarDay.AutoSize = true;
            this.labelLunnarDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarDay.Location = new System.Drawing.Point(60, 570);
            this.labelLunnarDay.Name = "labelLunnarDay";
            this.labelLunnarDay.Size = new System.Drawing.Size(68, 18);
            this.labelLunnarDay.TabIndex = 24;
            this.labelLunnarDay.Text = "Ngày Âm";
            // 
            // labelMonthLunnar
            // 
            this.labelMonthLunnar.AutoSize = true;
            this.labelMonthLunnar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthLunnar.Location = new System.Drawing.Point(417, 570);
            this.labelMonthLunnar.Name = "labelMonthLunnar";
            this.labelMonthLunnar.Size = new System.Drawing.Size(75, 18);
            this.labelMonthLunnar.TabIndex = 25;
            this.labelMonthLunnar.Text = "Tháng Âm";
            // 
            // labelYearLunnar
            // 
            this.labelYearLunnar.AutoSize = true;
            this.labelYearLunnar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearLunnar.Location = new System.Drawing.Point(417, 662);
            this.labelYearLunnar.Name = "labelYearLunnar";
            this.labelYearLunnar.Size = new System.Drawing.Size(66, 18);
            this.labelYearLunnar.TabIndex = 26;
            this.labelYearLunnar.Text = "Năm Âm";
            // 
            // labelZodiacTime
            // 
            this.labelZodiacTime.AutoSize = true;
            this.labelZodiacTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiacTime.Location = new System.Drawing.Point(60, 708);
            this.labelZodiacTime.Name = "labelZodiacTime";
            this.labelZodiacTime.Size = new System.Drawing.Size(106, 18);
            this.labelZodiacTime.TabIndex = 27;
            this.labelZodiacTime.Text = "Giờ hoàng đạo";
            // 
            // labelDOW
            // 
            this.labelDOW.AutoSize = true;
            this.labelDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOW.Location = new System.Drawing.Point(208, 470);
            this.labelDOW.Name = "labelDOW";
            this.labelDOW.Size = new System.Drawing.Size(42, 18);
            this.labelDOW.TabIndex = 28;
            this.labelDOW.Text = "Ngày";
            // 
            // buttonLunnarDate
            // 
            this.buttonLunnarDate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLunnarDate.ButtonImage = null;
            this.buttonLunnarDate.ButtonStyle = XanderUI.XUIButton.Style.MaterialEllipse;
            this.buttonLunnarDate.ButtonText = "ngày";
            this.buttonLunnarDate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.buttonLunnarDate.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonLunnarDate.ColorLine = System.Drawing.Color.Empty;
            this.buttonLunnarDate.ColorMonth = System.Drawing.Color.Empty;
            this.buttonLunnarDate.CornerRadius = 5;
            this.buttonLunnarDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLunnarDate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.buttonLunnarDate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.buttonLunnarDate.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.buttonLunnarDate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.buttonLunnarDate.IMonth = 0;
            this.buttonLunnarDate.Location = new System.Drawing.Point(165, 530);
            this.buttonLunnarDate.Name = "buttonLunnarDate";
            this.buttonLunnarDate.Size = new System.Drawing.Size(200, 150);
            this.buttonLunnarDate.TabIndex = 21;
            this.buttonLunnarDate.TextColor = System.Drawing.Color.DodgerBlue;
            this.buttonLunnarDate.Vertical_Alignment = System.Drawing.StringAlignment.Near;
            // 
            // DisplayDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDOW);
            this.Controls.Add(this.labelZodiacTime);
            this.Controls.Add(this.labelYearLunnar);
            this.Controls.Add(this.labelMonthLunnar);
            this.Controls.Add(this.labelLunnarDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLunnarDate);
            this.Controls.Add(this.dtpk);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.ButtonWeather);
            this.Controls.Add(this.ButtonQuote);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPre);
            this.Controls.Add(this.buttonDay);
            this.Controls.Add(this.buttonMY);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonToday);
            this.Name = "DisplayDate";
            this.Size = new System.Drawing.Size(540, 740);
            this.Load += new System.EventHandler(this.DisplayDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton buttonToday;
        private XanderUI.XUIButton buttonNote;
        private XanderUI.XUIWeatherClient Weather;
        private XanderUI.XUIButton buttonMY;
        private XanderUI.XUIButton buttonDay;
        private XanderUI.XUIButton buttonPre;
        private XanderUI.XUIButton buttonNext;
        private XanderUI.XUIButton ButtonQuote;
        private XanderUI.XUIButton ButtonWeather;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dtpk;
        private DisplayButton buttonLunnarDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelLunnarDay;
        private System.Windows.Forms.Label labelMonthLunnar;
        private System.Windows.Forms.Label labelYearLunnar;
        private System.Windows.Forms.Label labelZodiacTime;
        private System.Windows.Forms.Label labelDOW;
    }
}
