namespace Calendar
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PanelSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCount = new Guna.UI2.WinForms.Guna2Button();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.ButtonDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalendar = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChangeDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonWeatherForecast = new Guna.UI2.WinForms.Guna2Button();
            this.PanelIcon = new Guna.UI2.WinForms.Guna2Panel();
            this.xuiClock1 = new XanderUI.XUIClock();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.PanelControl = new Guna.UI2.WinForms.Guna2Panel();
            this.ControlMinimum = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ControlClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.PanelDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.displayDate1 = new Calendar.DisplayDate();
            this.PanelSetting.SuspendLayout();
            this.PanelIcon.SuspendLayout();
            this.PanelControl.SuspendLayout();
            this.PanelDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.ButtonHistory);
            this.PanelSetting.Controls.Add(this.ButtonCount);
            this.PanelSetting.Controls.Add(this.iconButtonClose);
            this.PanelSetting.Controls.Add(this.ButtonDate);
            this.PanelSetting.Controls.Add(this.ButtonCalendar);
            this.PanelSetting.Controls.Add(this.ButtonChangeDate);
            this.PanelSetting.Controls.Add(this.ButtonWeatherForecast);
            this.PanelSetting.Controls.Add(this.PanelIcon);
            this.PanelSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelSetting.Location = new System.Drawing.Point(0, 0);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.ShadowDecoration.Parent = this.PanelSetting;
            this.PanelSetting.Size = new System.Drawing.Size(140, 640);
            this.PanelSetting.TabIndex = 1;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHistory.CheckedState.Parent = this.ButtonHistory;
            this.ButtonHistory.CustomImages.Parent = this.ButtonHistory;
            this.ButtonHistory.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonHistory.ForeColor = System.Drawing.Color.Black;
            this.ButtonHistory.HoverState.Parent = this.ButtonHistory;
            this.ButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHistory.Image")));
            this.ButtonHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHistory.Location = new System.Drawing.Point(0, 399);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.ShadowDecoration.Parent = this.ButtonHistory;
            this.ButtonHistory.Size = new System.Drawing.Size(140, 45);
            this.ButtonHistory.TabIndex = 9;
            this.ButtonHistory.Text = "Sự Kiện Lịch Sử";
            this.ButtonHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonCount
            // 
            this.ButtonCount.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCount.CheckedState.Parent = this.ButtonCount;
            this.ButtonCount.CustomImages.Parent = this.ButtonCount;
            this.ButtonCount.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCount.ForeColor = System.Drawing.Color.Black;
            this.ButtonCount.HoverState.Parent = this.ButtonCount;
            this.ButtonCount.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCount.Image")));
            this.ButtonCount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCount.Location = new System.Drawing.Point(0, 348);
            this.ButtonCount.Name = "ButtonCount";
            this.ButtonCount.ShadowDecoration.Parent = this.ButtonCount;
            this.ButtonCount.Size = new System.Drawing.Size(140, 45);
            this.ButtonCount.TabIndex = 8;
            this.ButtonCount.Text = "Đếm Ngày";
            this.ButtonCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonCount.Click += new System.EventHandler(this.ButtonCount_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonClose.FlatAppearance.BorderSize = 10;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonClose.IconColor = System.Drawing.Color.Black;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 60;
            this.iconButtonClose.Location = new System.Drawing.Point(0, 565);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(140, 75);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // ButtonDate
            // 
            this.ButtonDate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDate.CheckedState.Parent = this.ButtonDate;
            this.ButtonDate.CustomImages.Parent = this.ButtonDate;
            this.ButtonDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonDate.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDate.ForeColor = System.Drawing.Color.Black;
            this.ButtonDate.HoverState.Parent = this.ButtonDate;
            this.ButtonDate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDate.Image")));
            this.ButtonDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDate.Location = new System.Drawing.Point(0, 195);
            this.ButtonDate.Name = "ButtonDate";
            this.ButtonDate.ShadowDecoration.Parent = this.ButtonDate;
            this.ButtonDate.Size = new System.Drawing.Size(140, 45);
            this.ButtonDate.TabIndex = 6;
            this.ButtonDate.Text = "Lịch Ngày";
            this.ButtonDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonDate.Click += new System.EventHandler(this.ButtonDate_Click);
            // 
            // ButtonCalendar
            // 
            this.ButtonCalendar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCalendar.CheckedState.Parent = this.ButtonCalendar;
            this.ButtonCalendar.CustomImages.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonCalendar.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalendar.ForeColor = System.Drawing.Color.Black;
            this.ButtonCalendar.HoverState.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCalendar.Image")));
            this.ButtonCalendar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCalendar.Location = new System.Drawing.Point(0, 150);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.ShadowDecoration.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Size = new System.Drawing.Size(140, 45);
            this.ButtonCalendar.TabIndex = 5;
            this.ButtonCalendar.Text = "Lịch Tháng";
            this.ButtonCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonCalendar.Click += new System.EventHandler(this.ButtonCalendar_Click);
            // 
            // ButtonChangeDate
            // 
            this.ButtonChangeDate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChangeDate.CheckedState.Parent = this.ButtonChangeDate;
            this.ButtonChangeDate.CustomImages.Parent = this.ButtonChangeDate;
            this.ButtonChangeDate.FillColor = System.Drawing.Color.Transparent;
            this.ButtonChangeDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeDate.ForeColor = System.Drawing.Color.Black;
            this.ButtonChangeDate.HoverState.Parent = this.ButtonChangeDate;
            this.ButtonChangeDate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChangeDate.Image")));
            this.ButtonChangeDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonChangeDate.Location = new System.Drawing.Point(0, 297);
            this.ButtonChangeDate.Name = "ButtonChangeDate";
            this.ButtonChangeDate.ShadowDecoration.Parent = this.ButtonChangeDate;
            this.ButtonChangeDate.Size = new System.Drawing.Size(140, 45);
            this.ButtonChangeDate.TabIndex = 4;
            this.ButtonChangeDate.Text = "Đổi Ngày";
            this.ButtonChangeDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonChangeDate.Click += new System.EventHandler(this.ButtonChangeDate_Click);
            // 
            // ButtonWeatherForecast
            // 
            this.ButtonWeatherForecast.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWeatherForecast.CheckedState.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.CustomImages.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.FillColor = System.Drawing.Color.Transparent;
            this.ButtonWeatherForecast.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonWeatherForecast.ForeColor = System.Drawing.Color.Black;
            this.ButtonWeatherForecast.HoverState.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.Image = ((System.Drawing.Image)(resources.GetObject("ButtonWeatherForecast.Image")));
            this.ButtonWeatherForecast.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonWeatherForecast.Location = new System.Drawing.Point(0, 246);
            this.ButtonWeatherForecast.Name = "ButtonWeatherForecast";
            this.ButtonWeatherForecast.ShadowDecoration.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.Size = new System.Drawing.Size(140, 45);
            this.ButtonWeatherForecast.TabIndex = 3;
            this.ButtonWeatherForecast.Text = "Thời Tiết";
            this.ButtonWeatherForecast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonWeatherForecast.Click += new System.EventHandler(this.ButtonWeatherForecast_Click);
            // 
            // PanelIcon
            // 
            this.PanelIcon.BorderColor = System.Drawing.Color.White;
            this.PanelIcon.Controls.Add(this.xuiClock1);
            this.PanelIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.ShadowDecoration.Parent = this.PanelIcon;
            this.PanelIcon.Size = new System.Drawing.Size(140, 150);
            this.PanelIcon.TabIndex = 0;
            // 
            // xuiClock1
            // 
            this.xuiClock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.xuiClock1.CircleThickness = 7;
            this.xuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour;
            this.xuiClock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiClock1.FilledHourColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(190)))), ((int)(((byte)(155)))));
            this.xuiClock1.FilledMinuteColor = System.Drawing.Color.White;
            this.xuiClock1.FilledSecondColor = System.Drawing.Color.Red;
            this.xuiClock1.Font = new System.Drawing.Font("Impact", 15F);
            this.xuiClock1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xuiClock1.HexagonColor = System.Drawing.Color.Black;
            this.xuiClock1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xuiClock1.Location = new System.Drawing.Point(0, 0);
            this.xuiClock1.Name = "xuiClock1";
            this.xuiClock1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xuiClock1.ShowAmPm = true;
            this.xuiClock1.ShowHexagon = true;
            this.xuiClock1.ShowMinutesCircle = true;
            this.xuiClock1.ShowSecondsCircle = true;
            this.xuiClock1.Size = new System.Drawing.Size(140, 150);
            this.xuiClock1.TabIndex = 0;
            this.xuiClock1.Text = "xuiClock1";
            this.xuiClock1.UnfilledHourColor = System.Drawing.Color.White;
            this.xuiClock1.UnfilledMinuteColor = System.Drawing.Color.White;
            this.xuiClock1.UnfilledSecondColor = System.Drawing.Color.White;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 10;
            this.guna2VSeparator1.Location = new System.Drawing.Point(140, 30);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 610);
            this.guna2VSeparator1.TabIndex = 1;
            // 
            // PanelControl
            // 
            this.PanelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PanelControl.Controls.Add(this.ControlMinimum);
            this.PanelControl.Controls.Add(this.ControlClose);
            this.PanelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelControl.ForeColor = System.Drawing.Color.White;
            this.PanelControl.Location = new System.Drawing.Point(140, 0);
            this.PanelControl.Name = "PanelControl";
            this.PanelControl.ShadowDecoration.Parent = this.PanelControl;
            this.PanelControl.Size = new System.Drawing.Size(550, 30);
            this.PanelControl.TabIndex = 3;
            // 
            // ControlMinimum
            // 
            this.ControlMinimum.BorderThickness = 2;
            this.ControlMinimum.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ControlMinimum.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlMinimum.FillColor = System.Drawing.Color.Transparent;
            this.ControlMinimum.HoverState.Parent = this.ControlMinimum;
            this.ControlMinimum.IconColor = System.Drawing.Color.Black;
            this.ControlMinimum.Location = new System.Drawing.Point(460, 0);
            this.ControlMinimum.Name = "ControlMinimum";
            this.ControlMinimum.ShadowDecoration.Parent = this.ControlMinimum;
            this.ControlMinimum.Size = new System.Drawing.Size(45, 30);
            this.ControlMinimum.TabIndex = 1;
            // 
            // ControlClose
            // 
            this.ControlClose.BorderThickness = 2;
            this.ControlClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlClose.FillColor = System.Drawing.Color.Transparent;
            this.ControlClose.HoverState.Parent = this.ControlClose;
            this.ControlClose.IconColor = System.Drawing.Color.Black;
            this.ControlClose.Location = new System.Drawing.Point(505, 0);
            this.ControlClose.Name = "ControlClose";
            this.ControlClose.ShadowDecoration.Parent = this.ControlClose;
            this.ControlClose.Size = new System.Drawing.Size(45, 30);
            this.ControlClose.TabIndex = 0;
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.Controls.Add(this.displayDate1);
            this.PanelDisplay.Location = new System.Drawing.Point(150, 40);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.ShadowDecoration.Parent = this.PanelDisplay;
            this.PanelDisplay.Size = new System.Drawing.Size(530, 590);
            this.PanelDisplay.TabIndex = 4;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2VSeparator2.FillThickness = 10;
            this.guna2VSeparator2.Location = new System.Drawing.Point(680, 30);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 610);
            this.guna2VSeparator2.TabIndex = 5;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 10;
            this.guna2Separator1.Location = new System.Drawing.Point(150, 630);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(530, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.FillThickness = 10;
            this.guna2Separator2.Location = new System.Drawing.Point(150, 30);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(530, 10);
            this.guna2Separator2.TabIndex = 7;
            // 
            // displayDate1
            // 
            this.displayDate1.ColorHourLunnar = System.Drawing.Color.Empty;
            this.displayDate1.ColorLunnar = System.Drawing.Color.Empty;
            this.displayDate1.ColorSolar = System.Drawing.Color.Empty;
            this.displayDate1.Location = new System.Drawing.Point(0, 0);
            this.displayDate1.Name = "displayDate1";
            this.displayDate1.Size = new System.Drawing.Size(530, 590);
            this.displayDate1.TabIndex = 0;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 640);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2VSeparator2);
            this.Controls.Add(this.PanelControl);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.PanelSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.PanelSetting.ResumeLayout(false);
            this.PanelIcon.ResumeLayout(false);
            this.PanelControl.ResumeLayout(false);
            this.PanelDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel PanelSetting;
        private Guna.UI2.WinForms.Guna2Panel PanelIcon;
        private XanderUI.XUIClock xuiClock1;
        private Guna.UI2.WinForms.Guna2Button ButtonWeatherForecast;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeDate;
        private Guna.UI2.WinForms.Guna2Button ButtonCalendar;
        private Guna.UI2.WinForms.Guna2Button ButtonDate;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonCount;
        private Guna.UI2.WinForms.Guna2Panel PanelControl;
        private Guna.UI2.WinForms.Guna2ControlBox ControlMinimum;
        private Guna.UI2.WinForms.Guna2ControlBox ControlClose;
        private Guna.UI2.WinForms.Guna2Panel PanelDisplay;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Button ButtonHistory;
        private DisplayDate displayDate1;
    }
}