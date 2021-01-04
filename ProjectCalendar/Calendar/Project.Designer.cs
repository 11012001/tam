namespace Calendar
{
    partial class CalendarProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarProject));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.PanelDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelIcon = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PanelSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonHDSD = new Guna.UI2.WinForms.Guna2Button();
            this.buttonTuVi = new Guna.UI2.WinForms.Guna2Button();
            this.buttonVanKhan = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDetailDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDay = new Guna.UI2.WinForms.Guna2Button();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.ButtonDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalendar = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonWeatherForecast = new Guna.UI2.WinForms.Guna2Button();
            this.PanelIcon.SuspendLayout();
            this.PanelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.Location = new System.Drawing.Point(190, 0);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.ShadowDecoration.Parent = this.PanelDisplay;
            this.PanelDisplay.Size = new System.Drawing.Size(1009, 620);
            this.PanelDisplay.TabIndex = 8;
            // 
            // PanelIcon
            // 
            this.PanelIcon.BorderColor = System.Drawing.Color.White;
            this.PanelIcon.Controls.Add(this.dtpk);
            this.PanelIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.ShadowDecoration.Parent = this.PanelIcon;
            this.PanelIcon.Size = new System.Drawing.Size(190, 81);
            this.PanelIcon.TabIndex = 0;
            // 
            // dtpk
            // 
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.CustomFormat = "dd/MM/yyyy";
            this.dtpk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(0, 0);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(190, 81);
            this.dtpk.TabIndex = 1;
            this.dtpk.Value = new System.DateTime(2020, 12, 15, 10, 42, 52, 648);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.buttonHDSD);
            this.PanelSetting.Controls.Add(this.buttonTuVi);
            this.PanelSetting.Controls.Add(this.buttonVanKhan);
            this.PanelSetting.Controls.Add(this.buttonDetailDate);
            this.PanelSetting.Controls.Add(this.ButtonHistory);
            this.PanelSetting.Controls.Add(this.ButtonDay);
            this.PanelSetting.Controls.Add(this.iconButtonClose);
            this.PanelSetting.Controls.Add(this.ButtonDate);
            this.PanelSetting.Controls.Add(this.ButtonCalendar);
            this.PanelSetting.Controls.Add(this.ButtonWeatherForecast);
            this.PanelSetting.Controls.Add(this.PanelIcon);
            this.PanelSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PanelSetting.Location = new System.Drawing.Point(0, 0);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.ShadowDecoration.Parent = this.PanelSetting;
            this.PanelSetting.Size = new System.Drawing.Size(190, 621);
            this.PanelSetting.TabIndex = 1;
            // 
            // buttonHDSD
            // 
            this.buttonHDSD.Animated = true;
            this.buttonHDSD.BackColor = System.Drawing.Color.Transparent;
            this.buttonHDSD.CheckedState.Parent = this.buttonHDSD;
            this.buttonHDSD.CustomImages.Parent = this.buttonHDSD;
            this.buttonHDSD.FillColor = System.Drawing.Color.Transparent;
            this.buttonHDSD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonHDSD.ForeColor = System.Drawing.Color.Black;
            this.buttonHDSD.HoverState.Parent = this.buttonHDSD;
            this.buttonHDSD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHDSD.Image")));
            this.buttonHDSD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonHDSD.Location = new System.Drawing.Point(3, 495);
            this.buttonHDSD.Name = "buttonHDSD";
            this.buttonHDSD.ShadowDecoration.Parent = this.buttonHDSD;
            this.buttonHDSD.Size = new System.Drawing.Size(187, 45);
            this.buttonHDSD.TabIndex = 14;
            this.buttonHDSD.Text = "Hướng Dẫn Sử Dụng";
            this.buttonHDSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonHDSD.Click += new System.EventHandler(this.buttonHDSD_Click);
            // 
            // buttonTuVi
            // 
            this.buttonTuVi.Animated = true;
            this.buttonTuVi.BackColor = System.Drawing.Color.Transparent;
            this.buttonTuVi.CheckedState.Parent = this.buttonTuVi;
            this.buttonTuVi.CustomImages.Parent = this.buttonTuVi;
            this.buttonTuVi.FillColor = System.Drawing.Color.Transparent;
            this.buttonTuVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonTuVi.ForeColor = System.Drawing.Color.Black;
            this.buttonTuVi.HoverState.Parent = this.buttonTuVi;
            this.buttonTuVi.Image = ((System.Drawing.Image)(resources.GetObject("buttonTuVi.Image")));
            this.buttonTuVi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonTuVi.Location = new System.Drawing.Point(0, 291);
            this.buttonTuVi.Name = "buttonTuVi";
            this.buttonTuVi.ShadowDecoration.Parent = this.buttonTuVi;
            this.buttonTuVi.Size = new System.Drawing.Size(190, 45);
            this.buttonTuVi.TabIndex = 12;
            this.buttonTuVi.Text = "Tử Vi";
            this.buttonTuVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonTuVi.Click += new System.EventHandler(this.buttonTuVi_Click);
            // 
            // buttonVanKhan
            // 
            this.buttonVanKhan.Animated = true;
            this.buttonVanKhan.BackColor = System.Drawing.Color.Transparent;
            this.buttonVanKhan.CheckedState.Parent = this.buttonVanKhan;
            this.buttonVanKhan.CustomImages.Parent = this.buttonVanKhan;
            this.buttonVanKhan.FillColor = System.Drawing.Color.Transparent;
            this.buttonVanKhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonVanKhan.ForeColor = System.Drawing.Color.Black;
            this.buttonVanKhan.HoverState.Parent = this.buttonVanKhan;
            this.buttonVanKhan.Image = ((System.Drawing.Image)(resources.GetObject("buttonVanKhan.Image")));
            this.buttonVanKhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonVanKhan.Location = new System.Drawing.Point(0, 444);
            this.buttonVanKhan.Name = "buttonVanKhan";
            this.buttonVanKhan.ShadowDecoration.Parent = this.buttonVanKhan;
            this.buttonVanKhan.Size = new System.Drawing.Size(190, 45);
            this.buttonVanKhan.TabIndex = 11;
            this.buttonVanKhan.Text = "Văn Khấn";
            this.buttonVanKhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonVanKhan.Click += new System.EventHandler(this.buttonVanKhan_Click);
            // 
            // buttonDetailDate
            // 
            this.buttonDetailDate.Animated = true;
            this.buttonDetailDate.BackColor = System.Drawing.Color.Transparent;
            this.buttonDetailDate.CheckedState.Parent = this.buttonDetailDate;
            this.buttonDetailDate.CustomImages.Parent = this.buttonDetailDate;
            this.buttonDetailDate.FillColor = System.Drawing.Color.Transparent;
            this.buttonDetailDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonDetailDate.ForeColor = System.Drawing.Color.Black;
            this.buttonDetailDate.HoverState.Parent = this.buttonDetailDate;
            this.buttonDetailDate.Image = ((System.Drawing.Image)(resources.GetObject("buttonDetailDate.Image")));
            this.buttonDetailDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonDetailDate.Location = new System.Drawing.Point(0, 189);
            this.buttonDetailDate.Name = "buttonDetailDate";
            this.buttonDetailDate.ShadowDecoration.Parent = this.buttonDetailDate;
            this.buttonDetailDate.Size = new System.Drawing.Size(190, 45);
            this.buttonDetailDate.TabIndex = 10;
            this.buttonDetailDate.Text = "Lịch Chi Tiết";
            this.buttonDetailDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonDetailDate.Click += new System.EventHandler(this.buttonDetailDate_Click);
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.Animated = true;
            this.ButtonHistory.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHistory.CheckedState.Parent = this.ButtonHistory;
            this.ButtonHistory.CustomImages.Parent = this.ButtonHistory;
            this.ButtonHistory.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonHistory.ForeColor = System.Drawing.Color.Black;
            this.ButtonHistory.HoverState.Parent = this.ButtonHistory;
            this.ButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHistory.Image")));
            this.ButtonHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHistory.Location = new System.Drawing.Point(0, 240);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.ShadowDecoration.Parent = this.ButtonHistory;
            this.ButtonHistory.Size = new System.Drawing.Size(190, 45);
            this.ButtonHistory.TabIndex = 9;
            this.ButtonHistory.Text = "Sự Kiện Lịch Sử";
            this.ButtonHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonDay
            // 
            this.ButtonDay.Animated = true;
            this.ButtonDay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDay.CheckedState.Parent = this.ButtonDay;
            this.ButtonDay.CustomImages.Parent = this.ButtonDay;
            this.ButtonDay.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonDay.ForeColor = System.Drawing.Color.Black;
            this.ButtonDay.HoverState.Parent = this.ButtonDay;
            this.ButtonDay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDay.Image")));
            this.ButtonDay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDay.Location = new System.Drawing.Point(0, 342);
            this.ButtonDay.Name = "ButtonDay";
            this.ButtonDay.ShadowDecoration.Parent = this.ButtonDay;
            this.ButtonDay.Size = new System.Drawing.Size(190, 45);
            this.ButtonDay.TabIndex = 8;
            this.ButtonDay.Text = "Đổi Ngày";
            this.ButtonDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonDay.Click += new System.EventHandler(this.ButtonDay_Click);
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
            this.iconButtonClose.Location = new System.Drawing.Point(0, 546);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(190, 75);
            this.iconButtonClose.TabIndex = 7;
            this.iconButtonClose.UseVisualStyleBackColor = false;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // ButtonDate
            // 
            this.ButtonDate.Animated = true;
            this.ButtonDate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDate.CheckedState.Parent = this.ButtonDate;
            this.ButtonDate.CustomImages.Parent = this.ButtonDate;
            this.ButtonDate.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonDate.ForeColor = System.Drawing.Color.Black;
            this.ButtonDate.HoverState.Parent = this.ButtonDate;
            this.ButtonDate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDate.Image")));
            this.ButtonDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDate.Location = new System.Drawing.Point(0, 138);
            this.ButtonDate.Name = "ButtonDate";
            this.ButtonDate.ShadowDecoration.Parent = this.ButtonDate;
            this.ButtonDate.Size = new System.Drawing.Size(190, 45);
            this.ButtonDate.TabIndex = 6;
            this.ButtonDate.Text = "Lịch Ngày";
            this.ButtonDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonDate.Click += new System.EventHandler(this.ButtonDate_Click);
            // 
            // ButtonCalendar
            // 
            this.ButtonCalendar.Animated = true;
            this.ButtonCalendar.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCalendar.CheckedState.Parent = this.ButtonCalendar;
            this.ButtonCalendar.CustomImages.Parent = this.ButtonCalendar;
            this.ButtonCalendar.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCalendar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCalendar.ForeColor = System.Drawing.Color.Black;
            this.ButtonCalendar.HoverState.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCalendar.Image")));
            this.ButtonCalendar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCalendar.Location = new System.Drawing.Point(0, 87);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.ShadowDecoration.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Size = new System.Drawing.Size(190, 45);
            this.ButtonCalendar.TabIndex = 5;
            this.ButtonCalendar.Text = "Lịch Âm";
            this.ButtonCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonCalendar.Click += new System.EventHandler(this.ButtonCalendar_Click);
            // 
            // ButtonWeatherForecast
            // 
            this.ButtonWeatherForecast.Animated = true;
            this.ButtonWeatherForecast.BackColor = System.Drawing.Color.Transparent;
            this.ButtonWeatherForecast.CheckedState.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.CustomImages.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.FillColor = System.Drawing.Color.Transparent;
            this.ButtonWeatherForecast.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonWeatherForecast.ForeColor = System.Drawing.Color.Black;
            this.ButtonWeatherForecast.HoverState.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.Image = ((System.Drawing.Image)(resources.GetObject("ButtonWeatherForecast.Image")));
            this.ButtonWeatherForecast.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonWeatherForecast.Location = new System.Drawing.Point(0, 393);
            this.ButtonWeatherForecast.Name = "ButtonWeatherForecast";
            this.ButtonWeatherForecast.ShadowDecoration.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.Size = new System.Drawing.Size(190, 45);
            this.ButtonWeatherForecast.TabIndex = 3;
            this.ButtonWeatherForecast.Text = "Thời Tiết";
            this.ButtonWeatherForecast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ButtonWeatherForecast.Click += new System.EventHandler(this.ButtonWeatherForecast_Click);
            // 
            // CalendarProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1199, 621);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.PanelSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarProject_Load);
            this.PanelIcon.ResumeLayout(false);
            this.PanelSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel PanelDisplay;
        private Guna.UI2.WinForms.Guna2Panel PanelSetting;
        private Guna.UI2.WinForms.Guna2Button ButtonHistory;
        private Guna.UI2.WinForms.Guna2Button ButtonDay;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonDate;
        private Guna.UI2.WinForms.Guna2Button ButtonCalendar;
        private Guna.UI2.WinForms.Guna2Button ButtonWeatherForecast;
        private Guna.UI2.WinForms.Guna2Panel PanelIcon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
        private Guna.UI2.WinForms.Guna2Button buttonVanKhan;
        private Guna.UI2.WinForms.Guna2Button buttonDetailDate;
        private Guna.UI2.WinForms.Guna2Button buttonTuVi;
        private Guna.UI2.WinForms.Guna2Button buttonHDSD;
    }
}