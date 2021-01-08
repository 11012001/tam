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
            this.ClockLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PanelSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.HideBtn = new FontAwesome.Sharp.IconButton();
            this.ButtonCountDay = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHDSD = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonTuVi = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonVanKhan = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonDetailDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonHistory = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonChangeDay = new Guna.UI2.WinForms.Guna2Button();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.ButtonDate = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonCalendar = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonWeatherForecast = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.thêmCôngViệcTrongNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmDeadlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệnGhiChúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệnLịchNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelIcon.SuspendLayout();
            this.PanelSetting.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.Location = new System.Drawing.Point(210, 0);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.ShadowDecoration.Parent = this.PanelDisplay;
            this.PanelDisplay.Size = new System.Drawing.Size(1009, 620);
            this.PanelDisplay.TabIndex = 8;
            // 
            // PanelIcon
            // 
            this.PanelIcon.BorderColor = System.Drawing.Color.White;
            this.PanelIcon.Controls.Add(this.ClockLB);
            this.PanelIcon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PanelIcon.Location = new System.Drawing.Point(0, 0);
            this.PanelIcon.Name = "PanelIcon";
            this.PanelIcon.ShadowDecoration.Parent = this.PanelIcon;
            this.PanelIcon.Size = new System.Drawing.Size(210, 65);
            this.PanelIcon.TabIndex = 0;
            // 
            // ClockLB
            // 
            this.ClockLB.BackColor = System.Drawing.Color.Transparent;
            this.ClockLB.Font = new System.Drawing.Font("DS-Digital", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockLB.Location = new System.Drawing.Point(12, 12);
            this.ClockLB.Name = "ClockLB";
            this.ClockLB.Size = new System.Drawing.Size(141, 42);
            this.ClockLB.TabIndex = 2;
            this.ClockLB.Text = "00:00:00";
            // 
            // dtpk
            // 
            this.dtpk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.CustomFormat = "dd/MM/yyyy";
            this.dtpk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(0, 65);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(210, 41);
            this.dtpk.TabIndex = 1;
            this.dtpk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpk.Value = new System.DateTime(2020, 12, 15, 10, 42, 52, 648);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.HideBtn);
            this.PanelSetting.Controls.Add(this.ButtonCountDay);
            this.PanelSetting.Controls.Add(this.dtpk);
            this.PanelSetting.Controls.Add(this.ButtonHDSD);
            this.PanelSetting.Controls.Add(this.ButtonTuVi);
            this.PanelSetting.Controls.Add(this.ButtonVanKhan);
            this.PanelSetting.Controls.Add(this.ButtonDetailDate);
            this.PanelSetting.Controls.Add(this.ButtonHistory);
            this.PanelSetting.Controls.Add(this.ButtonChangeDay);
            this.PanelSetting.Controls.Add(this.iconButtonClose);
            this.PanelSetting.Controls.Add(this.ButtonDate);
            this.PanelSetting.Controls.Add(this.ButtonCalendar);
            this.PanelSetting.Controls.Add(this.ButtonWeatherForecast);
            this.PanelSetting.Controls.Add(this.PanelIcon);
            this.PanelSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelSetting.Location = new System.Drawing.Point(0, 0);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.ShadowDecoration.Parent = this.PanelSetting;
            this.PanelSetting.Size = new System.Drawing.Size(210, 621);
            this.PanelSetting.TabIndex = 1;
            // 
            // HideBtn
            // 
            this.HideBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.HideBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HideBtn.FlatAppearance.BorderSize = 10;
            this.HideBtn.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.HideBtn.IconColor = System.Drawing.Color.Black;
            this.HideBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideBtn.IconSize = 40;
            this.HideBtn.Location = new System.Drawing.Point(105, 572);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.Size = new System.Drawing.Size(105, 49);
            this.HideBtn.TabIndex = 16;
            this.HideBtn.UseVisualStyleBackColor = false;
            this.HideBtn.Click += new System.EventHandler(this.HideBtn_Click);
            // 
            // ButtonCountDay
            // 
            this.ButtonCountDay.Animated = true;
            this.ButtonCountDay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCountDay.CheckedState.Parent = this.ButtonCountDay;
            this.ButtonCountDay.CustomImages.Parent = this.ButtonCountDay;
            this.ButtonCountDay.FillColor = System.Drawing.Color.Transparent;
            this.ButtonCountDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonCountDay.ForeColor = System.Drawing.Color.Black;
            this.ButtonCountDay.HoverState.Parent = this.ButtonCountDay;
            this.ButtonCountDay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCountDay.Image")));
            this.ButtonCountDay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCountDay.Location = new System.Drawing.Point(0, 289);
            this.ButtonCountDay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCountDay.Name = "ButtonCountDay";
            this.ButtonCountDay.PressedColor = System.Drawing.Color.Gray;
            this.ButtonCountDay.ShadowDecoration.Parent = this.ButtonCountDay;
            this.ButtonCountDay.Size = new System.Drawing.Size(210, 45);
            this.ButtonCountDay.TabIndex = 15;
            this.ButtonCountDay.Text = "ĐẾM NGÀY";
            this.ButtonCountDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonCountDay.Click += new System.EventHandler(this.buttonCountDay_Click);
            // 
            // ButtonHDSD
            // 
            this.ButtonHDSD.Animated = true;
            this.ButtonHDSD.BackColor = System.Drawing.Color.Transparent;
            this.ButtonHDSD.CheckedState.Parent = this.ButtonHDSD;
            this.ButtonHDSD.CustomImages.Parent = this.ButtonHDSD;
            this.ButtonHDSD.FillColor = System.Drawing.Color.Transparent;
            this.ButtonHDSD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonHDSD.ForeColor = System.Drawing.Color.Black;
            this.ButtonHDSD.HoverState.Parent = this.ButtonHDSD;
            this.ButtonHDSD.Image = ((System.Drawing.Image)(resources.GetObject("ButtonHDSD.Image")));
            this.ButtonHDSD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHDSD.Location = new System.Drawing.Point(3, 514);
            this.ButtonHDSD.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHDSD.Name = "ButtonHDSD";
            this.ButtonHDSD.PressedColor = System.Drawing.Color.Gray;
            this.ButtonHDSD.ShadowDecoration.Parent = this.ButtonHDSD;
            this.ButtonHDSD.Size = new System.Drawing.Size(210, 45);
            this.ButtonHDSD.TabIndex = 14;
            this.ButtonHDSD.Text = "HƯỚNG DẪN SỬ DỤNG";
            this.ButtonHDSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHDSD.Click += new System.EventHandler(this.buttonHDSD_Click);
            // 
            // ButtonTuVi
            // 
            this.ButtonTuVi.Animated = true;
            this.ButtonTuVi.BackColor = System.Drawing.Color.Transparent;
            this.ButtonTuVi.CheckedState.Parent = this.ButtonTuVi;
            this.ButtonTuVi.CustomImages.Parent = this.ButtonTuVi;
            this.ButtonTuVi.FillColor = System.Drawing.Color.Transparent;
            this.ButtonTuVi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonTuVi.ForeColor = System.Drawing.Color.Black;
            this.ButtonTuVi.HoverState.Parent = this.ButtonTuVi;
            this.ButtonTuVi.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTuVi.Image")));
            this.ButtonTuVi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonTuVi.Location = new System.Drawing.Point(0, 469);
            this.ButtonTuVi.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonTuVi.Name = "ButtonTuVi";
            this.ButtonTuVi.PressedColor = System.Drawing.Color.Gray;
            this.ButtonTuVi.ShadowDecoration.Parent = this.ButtonTuVi;
            this.ButtonTuVi.Size = new System.Drawing.Size(210, 45);
            this.ButtonTuVi.TabIndex = 12;
            this.ButtonTuVi.Text = "TỬ VI";
            this.ButtonTuVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonTuVi.Click += new System.EventHandler(this.buttonTuVi_Click);
            // 
            // ButtonVanKhan
            // 
            this.ButtonVanKhan.Animated = true;
            this.ButtonVanKhan.BackColor = System.Drawing.Color.Transparent;
            this.ButtonVanKhan.CheckedState.Parent = this.ButtonVanKhan;
            this.ButtonVanKhan.CustomImages.Parent = this.ButtonVanKhan;
            this.ButtonVanKhan.FillColor = System.Drawing.Color.Transparent;
            this.ButtonVanKhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonVanKhan.ForeColor = System.Drawing.Color.Black;
            this.ButtonVanKhan.HoverState.Parent = this.ButtonVanKhan;
            this.ButtonVanKhan.Image = ((System.Drawing.Image)(resources.GetObject("ButtonVanKhan.Image")));
            this.ButtonVanKhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonVanKhan.Location = new System.Drawing.Point(3, 424);
            this.ButtonVanKhan.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonVanKhan.Name = "ButtonVanKhan";
            this.ButtonVanKhan.PressedColor = System.Drawing.Color.Gray;
            this.ButtonVanKhan.ShadowDecoration.Parent = this.ButtonVanKhan;
            this.ButtonVanKhan.Size = new System.Drawing.Size(210, 45);
            this.ButtonVanKhan.TabIndex = 11;
            this.ButtonVanKhan.Text = "VĂN KHẤN";
            this.ButtonVanKhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonVanKhan.Click += new System.EventHandler(this.buttonVanKhan_Click);
            // 
            // ButtonDetailDate
            // 
            this.ButtonDetailDate.Animated = true;
            this.ButtonDetailDate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDetailDate.CheckedState.Parent = this.ButtonDetailDate;
            this.ButtonDetailDate.CustomImages.Parent = this.ButtonDetailDate;
            this.ButtonDetailDate.FillColor = System.Drawing.Color.Transparent;
            this.ButtonDetailDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonDetailDate.ForeColor = System.Drawing.Color.Black;
            this.ButtonDetailDate.HoverState.Parent = this.ButtonDetailDate;
            this.ButtonDetailDate.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDetailDate.Image")));
            this.ButtonDetailDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDetailDate.Location = new System.Drawing.Point(0, 199);
            this.ButtonDetailDate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDetailDate.Name = "ButtonDetailDate";
            this.ButtonDetailDate.PressedColor = System.Drawing.Color.Gray;
            this.ButtonDetailDate.ShadowDecoration.Parent = this.ButtonDetailDate;
            this.ButtonDetailDate.Size = new System.Drawing.Size(210, 45);
            this.ButtonDetailDate.TabIndex = 10;
            this.ButtonDetailDate.Text = "LỊCH CHI TIẾT";
            this.ButtonDetailDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonDetailDate.Click += new System.EventHandler(this.buttonDetailDate_Click);
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
            this.ButtonHistory.Location = new System.Drawing.Point(0, 244);
            this.ButtonHistory.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.PressedColor = System.Drawing.Color.Gray;
            this.ButtonHistory.ShadowDecoration.Parent = this.ButtonHistory;
            this.ButtonHistory.Size = new System.Drawing.Size(210, 45);
            this.ButtonHistory.TabIndex = 9;
            this.ButtonHistory.Text = "SỰ KIỆN LỊCH SỬ";
            this.ButtonHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // ButtonChangeDay
            // 
            this.ButtonChangeDay.Animated = true;
            this.ButtonChangeDay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonChangeDay.CheckedState.Parent = this.ButtonChangeDay;
            this.ButtonChangeDay.CustomImages.Parent = this.ButtonChangeDay;
            this.ButtonChangeDay.FillColor = System.Drawing.Color.Transparent;
            this.ButtonChangeDay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ButtonChangeDay.ForeColor = System.Drawing.Color.Black;
            this.ButtonChangeDay.HoverState.Parent = this.ButtonChangeDay;
            this.ButtonChangeDay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonChangeDay.Image")));
            this.ButtonChangeDay.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonChangeDay.Location = new System.Drawing.Point(3, 379);
            this.ButtonChangeDay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonChangeDay.Name = "ButtonChangeDay";
            this.ButtonChangeDay.PressedColor = System.Drawing.Color.Gray;
            this.ButtonChangeDay.ShadowDecoration.Parent = this.ButtonChangeDay;
            this.ButtonChangeDay.Size = new System.Drawing.Size(210, 45);
            this.ButtonChangeDay.TabIndex = 8;
            this.ButtonChangeDay.Text = "ĐỔI NGÀY ÂM DƯƠNG";
            this.ButtonChangeDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonChangeDay.Click += new System.EventHandler(this.ButtonDay_Click);
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackColor = System.Drawing.Color.DarkKhaki;
            this.iconButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButtonClose.FlatAppearance.BorderSize = 10;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonClose.IconColor = System.Drawing.Color.Black;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 40;
            this.iconButtonClose.Location = new System.Drawing.Point(0, 572);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(105, 49);
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
            this.ButtonDate.Location = new System.Drawing.Point(0, 109);
            this.ButtonDate.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonDate.Name = "ButtonDate";
            this.ButtonDate.PressedColor = System.Drawing.SystemColors.GrayText;
            this.ButtonDate.ShadowDecoration.Parent = this.ButtonDate;
            this.ButtonDate.Size = new System.Drawing.Size(210, 45);
            this.ButtonDate.TabIndex = 6;
            this.ButtonDate.Text = "LỊCH NGÀY";
            this.ButtonDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.ButtonCalendar.Location = new System.Drawing.Point(0, 154);
            this.ButtonCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonCalendar.Name = "ButtonCalendar";
            this.ButtonCalendar.PressedColor = System.Drawing.Color.Gray;
            this.ButtonCalendar.ShadowDecoration.Parent = this.ButtonCalendar;
            this.ButtonCalendar.Size = new System.Drawing.Size(210, 45);
            this.ButtonCalendar.TabIndex = 5;
            this.ButtonCalendar.Text = "LỊCH TỔNG QUÁT";
            this.ButtonCalendar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.ButtonWeatherForecast.Location = new System.Drawing.Point(0, 334);
            this.ButtonWeatherForecast.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonWeatherForecast.Name = "ButtonWeatherForecast";
            this.ButtonWeatherForecast.PressedColor = System.Drawing.Color.Gray;
            this.ButtonWeatherForecast.ShadowDecoration.Parent = this.ButtonWeatherForecast;
            this.ButtonWeatherForecast.Size = new System.Drawing.Size(210, 45);
            this.ButtonWeatherForecast.TabIndex = 3;
            this.ButtonWeatherForecast.Text = "THỜI TIẾT";
            this.ButtonWeatherForecast.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButtonWeatherForecast.Click += new System.EventHandler(this.ButtonWeatherForecast_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmCôngViệcTrongNgàyToolStripMenuItem,
            this.thêmDeadlineToolStripMenuItem,
            this.hiệnGhiChúToolStripMenuItem,
            this.hiệnLịchNgàyToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(220, 114);
            // 
            // thêmCôngViệcTrongNgàyToolStripMenuItem
            // 
            this.thêmCôngViệcTrongNgàyToolStripMenuItem.Name = "thêmCôngViệcTrongNgàyToolStripMenuItem";
            this.thêmCôngViệcTrongNgàyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thêmCôngViệcTrongNgàyToolStripMenuItem.Text = "Thêm công việc trong ngày";
            this.thêmCôngViệcTrongNgàyToolStripMenuItem.Click += new System.EventHandler(this.thêmCôngViệcTrongNgàyToolStripMenuItem_Click_1);
            // 
            // thêmDeadlineToolStripMenuItem
            // 
            this.thêmDeadlineToolStripMenuItem.Name = "thêmDeadlineToolStripMenuItem";
            this.thêmDeadlineToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thêmDeadlineToolStripMenuItem.Text = "Thêm deadline";
            this.thêmDeadlineToolStripMenuItem.Click += new System.EventHandler(this.thêmDeadlineToolStripMenuItem_Click_1);
            // 
            // hiệnGhiChúToolStripMenuItem
            // 
            this.hiệnGhiChúToolStripMenuItem.Name = "hiệnGhiChúToolStripMenuItem";
            this.hiệnGhiChúToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hiệnGhiChúToolStripMenuItem.Text = "Hiện ghi chú";
            this.hiệnGhiChúToolStripMenuItem.Click += new System.EventHandler(this.hiệnGhiChúToolStripMenuItem_Click);
            // 
            // hiệnLịchNgàyToolStripMenuItem
            // 
            this.hiệnLịchNgàyToolStripMenuItem.Name = "hiệnLịchNgàyToolStripMenuItem";
            this.hiệnLịchNgàyToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.hiệnLịchNgàyToolStripMenuItem.Text = "Hiện lịch ngày";
            this.hiệnLịchNgàyToolStripMenuItem.Click += new System.EventHandler(this.hiệnLịchNgàyToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // NotifyIcon1
            // 
            this.NotifyIcon1.ContextMenuStrip = this.guna2ContextMenuStrip1;
            this.NotifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon1.Icon")));
            this.NotifyIcon1.Text = "Calendar";
            this.NotifyIcon1.Visible = true;
            this.NotifyIcon1.DoubleClick += new System.EventHandler(this.NotifyIcon1_DoubleClick);
            // 
            // CalendarProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 621);
            this.Controls.Add(this.PanelDisplay);
            this.Controls.Add(this.PanelSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalendarProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.CalendarProject_Load);
            this.PanelIcon.ResumeLayout(false);
            this.PanelIcon.PerformLayout();
            this.PanelSetting.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel PanelDisplay;
        private Guna.UI2.WinForms.Guna2Panel PanelSetting;
        private Guna.UI2.WinForms.Guna2Button ButtonHistory;
        private Guna.UI2.WinForms.Guna2Button ButtonChangeDay;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private Guna.UI2.WinForms.Guna2Button ButtonDate;
        private Guna.UI2.WinForms.Guna2Button ButtonCalendar;
        private Guna.UI2.WinForms.Guna2Button ButtonWeatherForecast;
        private Guna.UI2.WinForms.Guna2Panel PanelIcon;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
        private Guna.UI2.WinForms.Guna2Button ButtonVanKhan;
        private Guna.UI2.WinForms.Guna2Button ButtonDetailDate;
        private Guna.UI2.WinForms.Guna2Button ButtonTuVi;
        private Guna.UI2.WinForms.Guna2Button ButtonHDSD;
        private Guna.UI2.WinForms.Guna2Button ButtonCountDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel ClockLB;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton HideBtn;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmCôngViệcTrongNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmDeadlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệnGhiChúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệnLịchNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon1;
    }
}