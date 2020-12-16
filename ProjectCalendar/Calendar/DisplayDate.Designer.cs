﻿
namespace Calendar
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
            this.PanelMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonMonth = new Guna.UI2.WinForms.Guna2Button();
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonNext = new FontAwesome.Sharp.IconButton();
            this.ButtonPre = new FontAwesome.Sharp.IconButton();
            this.ButtonToday = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelLunnarDate = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelLunnarDay = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.PictureZodiac = new FontAwesome.Sharp.IconPictureBox();
            this.labelLunnarDay = new System.Windows.Forms.Label();
            this.PanelLunnarMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.labelLunnarDayName = new System.Windows.Forms.Label();
            this.labelLunnarYearName = new System.Windows.Forms.Label();
            this.labelLunnarMonthName = new System.Windows.Forms.Label();
            this.PanelHourLunnar = new Guna.UI2.WinForms.Guna2Panel();
            this.labelZodiac2 = new System.Windows.Forms.Label();
            this.labelZodiac1 = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelHourLunnar = new System.Windows.Forms.Label();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonLunnarMonth = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLunnarName = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNameHour = new Guna.UI2.WinForms.Guna2Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.PanelImage = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelEvent = new Guna.UI2.WinForms.Guna2Panel();
            this.TextboxEvent = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonNote = new FontAwesome.Sharp.IconButton();
            this.PanelQuote = new Guna.UI2.WinForms.Guna2Panel();
            this.TextboxAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextboxQuote = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelDay = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDOW = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.PanelMonth.SuspendLayout();
            this.PanelLunnarDate.SuspendLayout();
            this.PanelLunnarDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).BeginInit();
            this.PanelLunnarMonth.SuspendLayout();
            this.PanelHourLunnar.SuspendLayout();
            this.PanelName.SuspendLayout();
            this.PanelImage.SuspendLayout();
            this.PanelEvent.SuspendLayout();
            this.PanelQuote.SuspendLayout();
            this.PanelDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMonth
            // 
            this.PanelMonth.Controls.Add(this.ButtonMonth);
            this.PanelMonth.Controls.Add(this.dtpk);
            this.PanelMonth.Controls.Add(this.ButtonNext);
            this.PanelMonth.Controls.Add(this.ButtonPre);
            this.PanelMonth.Controls.Add(this.ButtonToday);
            this.PanelMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelMonth.Location = new System.Drawing.Point(0, 0);
            this.PanelMonth.Name = "PanelMonth";
            this.PanelMonth.ShadowDecoration.Parent = this.PanelMonth;
            this.PanelMonth.Size = new System.Drawing.Size(530, 60);
            this.PanelMonth.TabIndex = 0;
            // 
            // ButtonMonth
            // 
            this.ButtonMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMonth.BorderColor = System.Drawing.Color.White;
            this.ButtonMonth.BorderRadius = 15;
            this.ButtonMonth.BorderThickness = 4;
            this.ButtonMonth.CheckedState.Parent = this.ButtonMonth;
            this.ButtonMonth.CustomImages.Parent = this.ButtonMonth;
            this.ButtonMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonMonth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonMonth.HoverState.Parent = this.ButtonMonth;
            this.ButtonMonth.Location = new System.Drawing.Point(122, 3);
            this.ButtonMonth.Name = "ButtonMonth";
            this.ButtonMonth.ShadowDecoration.Parent = this.ButtonMonth;
            this.ButtonMonth.Size = new System.Drawing.Size(238, 56);
            this.ButtonMonth.TabIndex = 0;
            this.ButtonMonth.Text = "THÁNG 11 - 2020";
            this.ButtonMonth.Click += new System.EventHandler(this.ButtonMonth_Click);
            // 
            // dtpk
            // 
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(160, 14);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(10, 10);
            this.dtpk.TabIndex = 9;
            this.dtpk.Value = new System.DateTime(2020, 12, 15, 10, 43, 21, 676);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ButtonNext.IconColor = System.Drawing.Color.Black;
            this.ButtonNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonNext.Location = new System.Drawing.Point(364, 3);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(51, 56);
            this.ButtonNext.TabIndex = 6;
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPre
            // 
            this.ButtonPre.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPre.FlatAppearance.BorderSize = 0;
            this.ButtonPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPre.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ButtonPre.IconColor = System.Drawing.Color.Black;
            this.ButtonPre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonPre.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonPre.Location = new System.Drawing.Point(65, 4);
            this.ButtonPre.Name = "ButtonPre";
            this.ButtonPre.Size = new System.Drawing.Size(51, 56);
            this.ButtonPre.TabIndex = 5;
            this.ButtonPre.UseVisualStyleBackColor = false;
            this.ButtonPre.Click += new System.EventHandler(this.ButtonPre_Click);
            // 
            // ButtonToday
            // 
            this.ButtonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonToday.BorderColor = System.Drawing.Color.White;
            this.ButtonToday.BorderThickness = 4;
            this.ButtonToday.CheckedState.Parent = this.ButtonToday;
            this.ButtonToday.CustomImages.Parent = this.ButtonToday;
            this.ButtonToday.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ButtonToday.ForeColor = System.Drawing.Color.White;
            this.ButtonToday.HoverState.Parent = this.ButtonToday;
            this.ButtonToday.Location = new System.Drawing.Point(460, 0);
            this.ButtonToday.Name = "ButtonToday";
            this.ButtonToday.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonToday.ShadowDecoration.Parent = this.ButtonToday;
            this.ButtonToday.Size = new System.Drawing.Size(70, 60);
            this.ButtonToday.TabIndex = 1;
            this.ButtonToday.Text = "6";
            this.ButtonToday.Click += new System.EventHandler(this.ButtonToday_Click);
            // 
            // PanelLunnarDate
            // 
            this.PanelLunnarDate.Controls.Add(this.PanelLunnarDay);
            this.PanelLunnarDate.Controls.Add(this.PanelLunnarMonth);
            this.PanelLunnarDate.Controls.Add(this.PanelHourLunnar);
            this.PanelLunnarDate.Controls.Add(this.PanelName);
            this.PanelLunnarDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelLunnarDate.Location = new System.Drawing.Point(0, 450);
            this.PanelLunnarDate.Name = "PanelLunnarDate";
            this.PanelLunnarDate.ShadowDecoration.Parent = this.PanelLunnarDate;
            this.PanelLunnarDate.Size = new System.Drawing.Size(530, 140);
            this.PanelLunnarDate.TabIndex = 1;
            // 
            // PanelLunnarDay
            // 
            this.PanelLunnarDay.Controls.Add(this.guna2VSeparator2);
            this.PanelLunnarDay.Controls.Add(this.guna2VSeparator1);
            this.PanelLunnarDay.Controls.Add(this.PictureZodiac);
            this.PanelLunnarDay.Controls.Add(this.labelLunnarDay);
            this.PanelLunnarDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLunnarDay.FillColor = System.Drawing.Color.LightGreen;
            this.PanelLunnarDay.Location = new System.Drawing.Point(170, 40);
            this.PanelLunnarDay.Name = "PanelLunnarDay";
            this.PanelLunnarDay.ShadowDecoration.Parent = this.PanelLunnarDay;
            this.PanelLunnarDay.Size = new System.Drawing.Size(190, 100);
            this.PanelLunnarDay.TabIndex = 3;
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.BackColor = System.Drawing.Color.LightGreen;
            this.guna2VSeparator2.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator2.Location = new System.Drawing.Point(180, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 98);
            this.guna2VSeparator2.TabIndex = 5;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.LightGreen;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator1.Location = new System.Drawing.Point(0, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 98);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // PictureZodiac
            // 
            this.PictureZodiac.BackColor = System.Drawing.Color.LightGreen;
            this.PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.PictureZodiac.IconColor = System.Drawing.Color.White;
            this.PictureZodiac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureZodiac.IconSize = 31;
            this.PictureZodiac.Location = new System.Drawing.Point(82, 3);
            this.PictureZodiac.Name = "PictureZodiac";
            this.PictureZodiac.Size = new System.Drawing.Size(32, 31);
            this.PictureZodiac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureZodiac.TabIndex = 1;
            this.PictureZodiac.TabStop = false;
            // 
            // labelLunnarDay
            // 
            this.labelLunnarDay.AutoSize = true;
            this.labelLunnarDay.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarDay.ForeColor = System.Drawing.Color.Red;
            this.labelLunnarDay.Location = new System.Drawing.Point(43, 28);
            this.labelLunnarDay.Name = "labelLunnarDay";
            this.labelLunnarDay.Size = new System.Drawing.Size(109, 76);
            this.labelLunnarDay.TabIndex = 0;
            this.labelLunnarDay.Text = "30";
            // 
            // PanelLunnarMonth
            // 
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarDayName);
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarYearName);
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarMonthName);
            this.PanelLunnarMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelLunnarMonth.FillColor = System.Drawing.Color.LightGreen;
            this.PanelLunnarMonth.Location = new System.Drawing.Point(360, 40);
            this.PanelLunnarMonth.Name = "PanelLunnarMonth";
            this.PanelLunnarMonth.ShadowDecoration.Parent = this.PanelLunnarMonth;
            this.PanelLunnarMonth.Size = new System.Drawing.Size(170, 100);
            this.PanelLunnarMonth.TabIndex = 2;
            // 
            // labelLunnarDayName
            // 
            this.labelLunnarDayName.AutoSize = true;
            this.labelLunnarDayName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarDayName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarDayName.ForeColor = System.Drawing.Color.White;
            this.labelLunnarDayName.Location = new System.Drawing.Point(28, 75);
            this.labelLunnarDayName.Name = "labelLunnarDayName";
            this.labelLunnarDayName.Size = new System.Drawing.Size(115, 19);
            this.labelLunnarDayName.TabIndex = 6;
            this.labelLunnarDayName.Text = "Ngày Quý Mùi";
            // 
            // labelLunnarYearName
            // 
            this.labelLunnarYearName.AutoSize = true;
            this.labelLunnarYearName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarYearName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarYearName.ForeColor = System.Drawing.Color.White;
            this.labelLunnarYearName.Location = new System.Drawing.Point(35, 15);
            this.labelLunnarYearName.Name = "labelLunnarYearName";
            this.labelLunnarYearName.Size = new System.Drawing.Size(112, 19);
            this.labelLunnarYearName.TabIndex = 4;
            this.labelLunnarYearName.Text = "Năm Canh Tý";
            // 
            // labelLunnarMonthName
            // 
            this.labelLunnarMonthName.AutoSize = true;
            this.labelLunnarMonthName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarMonthName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarMonthName.ForeColor = System.Drawing.Color.White;
            this.labelLunnarMonthName.Location = new System.Drawing.Point(25, 45);
            this.labelLunnarMonthName.Name = "labelLunnarMonthName";
            this.labelLunnarMonthName.Size = new System.Drawing.Size(129, 19);
            this.labelLunnarMonthName.TabIndex = 5;
            this.labelLunnarMonthName.Text = "Tháng Đinh Hợi";
            // 
            // PanelHourLunnar
            // 
            this.PanelHourLunnar.Controls.Add(this.labelZodiac2);
            this.PanelHourLunnar.Controls.Add(this.labelZodiac1);
            this.PanelHourLunnar.Controls.Add(this.labelHour);
            this.PanelHourLunnar.Controls.Add(this.labelHourLunnar);
            this.PanelHourLunnar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelHourLunnar.FillColor = System.Drawing.Color.LightGreen;
            this.PanelHourLunnar.Location = new System.Drawing.Point(0, 40);
            this.PanelHourLunnar.Name = "PanelHourLunnar";
            this.PanelHourLunnar.ShadowDecoration.Parent = this.PanelHourLunnar;
            this.PanelHourLunnar.Size = new System.Drawing.Size(170, 100);
            this.PanelHourLunnar.TabIndex = 1;
            // 
            // labelZodiac2
            // 
            this.labelZodiac2.AutoSize = true;
            this.labelZodiac2.BackColor = System.Drawing.Color.Transparent;
            this.labelZodiac2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiac2.ForeColor = System.Drawing.Color.Yellow;
            this.labelZodiac2.Location = new System.Drawing.Point(30, 79);
            this.labelZodiac2.Name = "labelZodiac2";
            this.labelZodiac2.Size = new System.Drawing.Size(124, 19);
            this.labelZodiac2.TabIndex = 3;
            this.labelZodiac2.Text = "Thân, Tuất, Hợi";
            // 
            // labelZodiac1
            // 
            this.labelZodiac1.AutoSize = true;
            this.labelZodiac1.BackColor = System.Drawing.Color.Transparent;
            this.labelZodiac1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZodiac1.ForeColor = System.Drawing.Color.Yellow;
            this.labelZodiac1.Location = new System.Drawing.Point(30, 59);
            this.labelZodiac1.Name = "labelZodiac1";
            this.labelZodiac1.Size = new System.Drawing.Size(103, 19);
            this.labelZodiac1.TabIndex = 2;
            this.labelZodiac1.Text = "Dần,Mão,Tỵ,";
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.Transparent;
            this.labelHour.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.White;
            this.labelHour.Location = new System.Drawing.Point(30, 35);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(51, 24);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Giờ ";
            // 
            // labelHourLunnar
            // 
            this.labelHourLunnar.AutoSize = true;
            this.labelHourLunnar.BackColor = System.Drawing.Color.Transparent;
            this.labelHourLunnar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourLunnar.ForeColor = System.Drawing.Color.Yellow;
            this.labelHourLunnar.Location = new System.Drawing.Point(50, 15);
            this.labelHourLunnar.Name = "labelHourLunnar";
            this.labelHourLunnar.Size = new System.Drawing.Size(59, 19);
            this.labelHourLunnar.TabIndex = 0;
            this.labelHourLunnar.Text = "Giờ Tỵ";
            // 
            // PanelName
            // 
            this.PanelName.BackColor = System.Drawing.Color.LightGreen;
            this.PanelName.Controls.Add(this.ButtonLunnarMonth);
            this.PanelName.Controls.Add(this.ButtonLunnarName);
            this.PanelName.Controls.Add(this.ButtonNameHour);
            this.PanelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelName.FillColor = System.Drawing.Color.LightGreen;
            this.PanelName.Location = new System.Drawing.Point(0, 0);
            this.PanelName.Name = "PanelName";
            this.PanelName.ShadowDecoration.Parent = this.PanelName;
            this.PanelName.Size = new System.Drawing.Size(530, 40);
            this.PanelName.TabIndex = 0;
            // 
            // ButtonLunnarMonth
            // 
            this.ButtonLunnarMonth.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonLunnarMonth.BorderColor = System.Drawing.Color.White;
            this.ButtonLunnarMonth.BorderRadius = 15;
            this.ButtonLunnarMonth.BorderThickness = 2;
            this.ButtonLunnarMonth.CheckedState.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.CustomImages.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.FillColor = System.Drawing.Color.Red;
            this.ButtonLunnarMonth.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonLunnarMonth.ForeColor = System.Drawing.Color.White;
            this.ButtonLunnarMonth.HoverState.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.Location = new System.Drawing.Point(170, 0);
            this.ButtonLunnarMonth.Name = "ButtonLunnarMonth";
            this.ButtonLunnarMonth.ShadowDecoration.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.Size = new System.Drawing.Size(190, 40);
            this.ButtonLunnarMonth.TabIndex = 6;
            this.ButtonLunnarMonth.Text = "THÁNG MƯỜI MỘT";
            // 
            // ButtonLunnarName
            // 
            this.ButtonLunnarName.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonLunnarName.BorderColor = System.Drawing.Color.White;
            this.ButtonLunnarName.BorderRadius = 15;
            this.ButtonLunnarName.BorderThickness = 2;
            this.ButtonLunnarName.CheckedState.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.CustomImages.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLunnarName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonLunnarName.ForeColor = System.Drawing.Color.White;
            this.ButtonLunnarName.HoverState.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.Location = new System.Drawing.Point(360, 0);
            this.ButtonLunnarName.Name = "ButtonLunnarName";
            this.ButtonLunnarName.ShadowDecoration.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.Size = new System.Drawing.Size(170, 40);
            this.ButtonLunnarName.TabIndex = 5;
            this.ButtonLunnarName.Text = "ÂM LỊCH";
            // 
            // ButtonNameHour
            // 
            this.ButtonNameHour.BackColor = System.Drawing.Color.LightGreen;
            this.ButtonNameHour.BorderColor = System.Drawing.Color.White;
            this.ButtonNameHour.BorderRadius = 15;
            this.ButtonNameHour.BorderThickness = 2;
            this.ButtonNameHour.CheckedState.Parent = this.ButtonNameHour;
            this.ButtonNameHour.CustomImages.Parent = this.ButtonNameHour;
            this.ButtonNameHour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonNameHour.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonNameHour.ForeColor = System.Drawing.Color.White;
            this.ButtonNameHour.HoverState.Parent = this.ButtonNameHour;
            this.ButtonNameHour.Location = new System.Drawing.Point(0, 0);
            this.ButtonNameHour.Name = "ButtonNameHour";
            this.ButtonNameHour.ShadowDecoration.Parent = this.ButtonNameHour;
            this.ButtonNameHour.Size = new System.Drawing.Size(170, 40);
            this.ButtonNameHour.TabIndex = 4;
            this.ButtonNameHour.Text = "GIỜ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // PanelImage
            // 
            this.PanelImage.Controls.Add(this.PanelEvent);
            this.PanelImage.Controls.Add(this.ButtonNote);
            this.PanelImage.Controls.Add(this.PanelQuote);
            this.PanelImage.Controls.Add(this.PanelDay);
            this.PanelImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelImage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PanelImage.Location = new System.Drawing.Point(0, 60);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.ShadowDecoration.Parent = this.PanelImage;
            this.PanelImage.Size = new System.Drawing.Size(530, 390);
            this.PanelImage.TabIndex = 8;
            // 
            // PanelEvent
            // 
            this.PanelEvent.BackColor = System.Drawing.Color.Transparent;
            this.PanelEvent.Controls.Add(this.TextboxEvent);
            this.PanelEvent.Location = new System.Drawing.Point(33, 181);
            this.PanelEvent.Name = "PanelEvent";
            this.PanelEvent.ShadowDecoration.Parent = this.PanelEvent;
            this.PanelEvent.Size = new System.Drawing.Size(481, 57);
            this.PanelEvent.TabIndex = 8;
            // 
            // TextboxEvent
            // 
            this.TextboxEvent.AcceptsReturn = true;
            this.TextboxEvent.BorderThickness = 0;
            this.TextboxEvent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxEvent.DefaultText = "";
            this.TextboxEvent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxEvent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxEvent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxEvent.DisabledState.Parent = this.TextboxEvent;
            this.TextboxEvent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextboxEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextboxEvent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxEvent.FocusedState.Parent = this.TextboxEvent;
            this.TextboxEvent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxEvent.HoverState.Parent = this.TextboxEvent;
            this.TextboxEvent.Location = new System.Drawing.Point(0, 0);
            this.TextboxEvent.Multiline = true;
            this.TextboxEvent.Name = "TextboxEvent";
            this.TextboxEvent.PasswordChar = '\0';
            this.TextboxEvent.PlaceholderText = "";
            this.TextboxEvent.ReadOnly = true;
            this.TextboxEvent.SelectedText = "";
            this.TextboxEvent.ShadowDecoration.Parent = this.TextboxEvent;
            this.TextboxEvent.Size = new System.Drawing.Size(481, 57);
            this.TextboxEvent.TabIndex = 0;
            this.TextboxEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonNote
            // 
            this.ButtonNote.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNote.FlatAppearance.BorderSize = 0;
            this.ButtonNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNote.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.ButtonNote.IconColor = System.Drawing.Color.Black;
            this.ButtonNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonNote.Location = new System.Drawing.Point(476, 0);
            this.ButtonNote.Name = "ButtonNote";
            this.ButtonNote.Size = new System.Drawing.Size(51, 56);
            this.ButtonNote.TabIndex = 7;
            this.ButtonNote.UseVisualStyleBackColor = false;
            // 
            // PanelQuote
            // 
            this.PanelQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelQuote.Controls.Add(this.TextboxAuthor);
            this.PanelQuote.Controls.Add(this.TextboxQuote);
            this.PanelQuote.ForeColor = System.Drawing.Color.Red;
            this.PanelQuote.Location = new System.Drawing.Point(26, 252);
            this.PanelQuote.Name = "PanelQuote";
            this.PanelQuote.ShadowDecoration.Parent = this.PanelQuote;
            this.PanelQuote.Size = new System.Drawing.Size(481, 126);
            this.PanelQuote.TabIndex = 6;
            // 
            // TextboxAuthor
            // 
            this.TextboxAuthor.BackColor = System.Drawing.Color.Transparent;
            this.TextboxAuthor.BorderThickness = 0;
            this.TextboxAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxAuthor.DefaultText = "";
            this.TextboxAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxAuthor.DisabledState.Parent = this.TextboxAuthor;
            this.TextboxAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxAuthor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextboxAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextboxAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxAuthor.FocusedState.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextboxAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxAuthor.HoverState.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Location = new System.Drawing.Point(0, 96);
            this.TextboxAuthor.Name = "TextboxAuthor";
            this.TextboxAuthor.PasswordChar = '\0';
            this.TextboxAuthor.PlaceholderText = "";
            this.TextboxAuthor.ReadOnly = true;
            this.TextboxAuthor.SelectedText = "";
            this.TextboxAuthor.ShadowDecoration.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Size = new System.Drawing.Size(481, 30);
            this.TextboxAuthor.TabIndex = 2;
            this.TextboxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextboxQuote
            // 
            this.TextboxQuote.BackColor = System.Drawing.Color.Transparent;
            this.TextboxQuote.BorderThickness = 0;
            this.TextboxQuote.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextboxQuote.DefaultText = "adsfdds\r\ndsafd\r\nadsfads\r\n";
            this.TextboxQuote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxQuote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxQuote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxQuote.DisabledState.Parent = this.TextboxQuote;
            this.TextboxQuote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxQuote.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextboxQuote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextboxQuote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxQuote.FocusedState.Parent = this.TextboxQuote;
            this.TextboxQuote.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextboxQuote.HideSelection = false;
            this.TextboxQuote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxQuote.HoverState.Parent = this.TextboxQuote;
            this.TextboxQuote.Location = new System.Drawing.Point(0, 0);
            this.TextboxQuote.Multiline = true;
            this.TextboxQuote.Name = "TextboxQuote";
            this.TextboxQuote.PasswordChar = '\0';
            this.TextboxQuote.PlaceholderText = "";
            this.TextboxQuote.ReadOnly = true;
            this.TextboxQuote.SelectedText = "";
            this.TextboxQuote.SelectionStart = 25;
            this.TextboxQuote.ShadowDecoration.Parent = this.TextboxQuote;
            this.TextboxQuote.Size = new System.Drawing.Size(481, 89);
            this.TextboxQuote.TabIndex = 1;
            this.TextboxQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelDay
            // 
            this.PanelDay.Controls.Add(this.labelDOW);
            this.PanelDay.Controls.Add(this.labelDay);
            this.PanelDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelDay.ForeColor = System.Drawing.Color.Red;
            this.PanelDay.Location = new System.Drawing.Point(170, 0);
            this.PanelDay.Name = "PanelDay";
            this.PanelDay.ShadowDecoration.Parent = this.PanelDay;
            this.PanelDay.Size = new System.Drawing.Size(190, 187);
            this.PanelDay.TabIndex = 5;
            // 
            // labelDOW
            // 
            this.labelDOW.AutoSize = true;
            this.labelDOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOW.ForeColor = System.Drawing.Color.Red;
            this.labelDOW.Location = new System.Drawing.Point(-6, 132);
            this.labelDOW.Name = "labelDOW";
            this.labelDOW.Size = new System.Drawing.Size(196, 46);
            this.labelDOW.TabIndex = 1;
            this.labelDOW.Text = "Chủ Nhật";
            this.labelDOW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 87.6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Red;
            this.labelDay.Location = new System.Drawing.Point(34, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(121, 132);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "6";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMonth);
            this.Controls.Add(this.PanelImage);
            this.Controls.Add(this.PanelLunnarDate);
            this.Name = "DisplayDate";
            this.Size = new System.Drawing.Size(530, 590);
            this.Load += new System.EventHandler(this.DisplayDate_Load);
            this.PanelMonth.ResumeLayout(false);
            this.PanelLunnarDate.ResumeLayout(false);
            this.PanelLunnarDay.ResumeLayout(false);
            this.PanelLunnarDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).EndInit();
            this.PanelLunnarMonth.ResumeLayout(false);
            this.PanelLunnarMonth.PerformLayout();
            this.PanelHourLunnar.ResumeLayout(false);
            this.PanelHourLunnar.PerformLayout();
            this.PanelName.ResumeLayout(false);
            this.PanelImage.ResumeLayout(false);
            this.PanelEvent.ResumeLayout(false);
            this.PanelQuote.ResumeLayout(false);
            this.PanelDay.ResumeLayout(false);
            this.PanelDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMonth;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarDate;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarDay;
        private System.Windows.Forms.Label labelLunnarDay;
        private Guna.UI2.WinForms.Guna2Panel PanelHourLunnar;
        private System.Windows.Forms.Label labelZodiac2;
        private System.Windows.Forms.Label labelZodiac1;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelHourLunnar;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private FontAwesome.Sharp.IconPictureBox PictureZodiac;
        private System.Windows.Forms.Label labelLunnarDayName;
        private System.Windows.Forms.Label labelLunnarMonthName;
        private System.Windows.Forms.Label labelLunnarYearName;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarMonth;
        private Guna.UI2.WinForms.Guna2Button ButtonLunnarMonth;
        private Guna.UI2.WinForms.Guna2Button ButtonLunnarName;
        private Guna.UI2.WinForms.Guna2Button ButtonNameHour;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonToday;
        private Guna.UI2.WinForms.Guna2Button ButtonMonth;
        private FontAwesome.Sharp.IconButton ButtonNext;
        private FontAwesome.Sharp.IconButton ButtonPre;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Panel PanelImage;
        private FontAwesome.Sharp.IconButton ButtonNote;
        private Guna.UI2.WinForms.Guna2Panel PanelQuote;
        private Guna.UI2.WinForms.Guna2Panel PanelDay;
        private System.Windows.Forms.Label labelDOW;
        private System.Windows.Forms.Label labelDay;
        private Guna.UI2.WinForms.Guna2Panel PanelEvent;
        private Guna.UI2.WinForms.Guna2TextBox TextboxEvent;
        private Guna.UI2.WinForms.Guna2TextBox TextboxAuthor;
        private Guna.UI2.WinForms.Guna2TextBox TextboxQuote;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
    }
}
