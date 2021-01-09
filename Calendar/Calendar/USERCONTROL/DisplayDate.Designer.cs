
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
            this.ibtnSpeech = new FontAwesome.Sharp.IconButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelLunnarMonthName = new System.Windows.Forms.Label();
            this.labelLunnarYearName = new System.Windows.Forms.Label();
            this.labelLunnarDayName = new System.Windows.Forms.Label();
            this.PanelLunnarMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonLunnarMonth = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonLunnarName = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonNameHour = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHourLunnar = new Guna.UI2.WinForms.Guna2Panel();
            this.TextboxZodiacHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelHourLunnar = new System.Windows.Forms.Label();
            this.PanelLunnarDay = new Guna.UI2.WinForms.Guna2Panel();
            this.ZodiacAnimal2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ZodiacAnimal1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.PictureZodiac = new FontAwesome.Sharp.IconPictureBox();
            this.labelLunnarDay = new System.Windows.Forms.Label();
            this.PanelLunnarDate = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonToday = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonPre = new FontAwesome.Sharp.IconButton();
            this.ButtonNext = new FontAwesome.Sharp.IconButton();
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ButtonMonth = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMonth = new Guna.UI2.WinForms.Guna2Panel();
            this.iconSetting = new FontAwesome.Sharp.IconButton();
            this.PanelDay = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDOW = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.ButtonNote = new FontAwesome.Sharp.IconButton();
            this.PanelQuote = new Guna.UI2.WinForms.Guna2Panel();
            this.TextboxAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextboxQuote = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelEvent = new Guna.UI2.WinForms.Guna2Panel();
            this.TextboxEvent = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelImage = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelLunnarMonth.SuspendLayout();
            this.PanelName.SuspendLayout();
            this.PanelHourLunnar.SuspendLayout();
            this.PanelLunnarDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZodiacAnimal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZodiacAnimal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).BeginInit();
            this.PanelLunnarDate.SuspendLayout();
            this.PanelMonth.SuspendLayout();
            this.PanelDay.SuspendLayout();
            this.PanelQuote.SuspendLayout();
            this.PanelEvent.SuspendLayout();
            this.PanelImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnSpeech
            // 
            this.ibtnSpeech.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSpeech.FlatAppearance.BorderSize = 0;
            this.ibtnSpeech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSpeech.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.ibtnSpeech.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ibtnSpeech.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSpeech.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ibtnSpeech.Location = new System.Drawing.Point(880, 6);
            this.ibtnSpeech.Name = "ibtnSpeech";
            this.ibtnSpeech.Size = new System.Drawing.Size(55, 56);
            this.ibtnSpeech.TabIndex = 9;
            this.ibtnSpeech.UseVisualStyleBackColor = false;
            this.ibtnSpeech.Click += new System.EventHandler(this.ibtnSpeech_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelLunnarMonthName
            // 
            this.labelLunnarMonthName.AutoSize = true;
            this.labelLunnarMonthName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarMonthName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarMonthName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLunnarMonthName.Location = new System.Drawing.Point(7, 51);
            this.labelLunnarMonthName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelLunnarMonthName.Name = "labelLunnarMonthName";
            this.labelLunnarMonthName.Size = new System.Drawing.Size(195, 29);
            this.labelLunnarMonthName.TabIndex = 5;
            this.labelLunnarMonthName.Text = "Tháng Đinh Hợi";
            // 
            // labelLunnarYearName
            // 
            this.labelLunnarYearName.AutoSize = true;
            this.labelLunnarYearName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarYearName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarYearName.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLunnarYearName.Location = new System.Drawing.Point(14, 96);
            this.labelLunnarYearName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelLunnarYearName.Name = "labelLunnarYearName";
            this.labelLunnarYearName.Size = new System.Drawing.Size(166, 29);
            this.labelLunnarYearName.TabIndex = 4;
            this.labelLunnarYearName.Text = "Năm Canh Tý";
            // 
            // labelLunnarDayName
            // 
            this.labelLunnarDayName.AutoSize = true;
            this.labelLunnarDayName.BackColor = System.Drawing.Color.Transparent;
            this.labelLunnarDayName.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarDayName.ForeColor = System.Drawing.Color.Maroon;
            this.labelLunnarDayName.Location = new System.Drawing.Point(14, 3);
            this.labelLunnarDayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelLunnarDayName.Name = "labelLunnarDayName";
            this.labelLunnarDayName.Size = new System.Drawing.Size(174, 29);
            this.labelLunnarDayName.TabIndex = 6;
            this.labelLunnarDayName.Text = "Ngày Quý Mùi";
            // 
            // PanelLunnarMonth
            // 
            this.PanelLunnarMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelLunnarMonth.BorderThickness = 2;
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarDayName);
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarYearName);
            this.PanelLunnarMonth.Controls.Add(this.labelLunnarMonthName);
            this.PanelLunnarMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelLunnarMonth.Location = new System.Drawing.Point(794, 40);
            this.PanelLunnarMonth.Name = "PanelLunnarMonth";
            this.PanelLunnarMonth.ShadowDecoration.Parent = this.PanelLunnarMonth;
            this.PanelLunnarMonth.Size = new System.Drawing.Size(215, 131);
            this.PanelLunnarMonth.TabIndex = 2;
            // 
            // PanelName
            // 
            this.PanelName.BackColor = System.Drawing.Color.LightGreen;
            this.PanelName.BorderColor = System.Drawing.Color.Black;
            this.PanelName.BorderThickness = 2;
            this.PanelName.Controls.Add(this.ButtonLunnarMonth);
            this.PanelName.Controls.Add(this.ButtonLunnarName);
            this.PanelName.Controls.Add(this.ButtonNameHour);
            this.PanelName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelName.Location = new System.Drawing.Point(0, 0);
            this.PanelName.Name = "PanelName";
            this.PanelName.ShadowDecoration.Parent = this.PanelName;
            this.PanelName.Size = new System.Drawing.Size(1009, 40);
            this.PanelName.TabIndex = 0;
            // 
            // ButtonLunnarMonth
            // 
            this.ButtonLunnarMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonLunnarMonth.BorderRadius = 15;
            this.ButtonLunnarMonth.BorderThickness = 2;
            this.ButtonLunnarMonth.CheckedState.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.CustomImages.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonLunnarMonth.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonLunnarMonth.ForeColor = System.Drawing.Color.Black;
            this.ButtonLunnarMonth.HoverState.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.Location = new System.Drawing.Point(414, 3);
            this.ButtonLunnarMonth.Name = "ButtonLunnarMonth";
            this.ButtonLunnarMonth.ShadowDecoration.Parent = this.ButtonLunnarMonth;
            this.ButtonLunnarMonth.Size = new System.Drawing.Size(190, 34);
            this.ButtonLunnarMonth.TabIndex = 6;
            this.ButtonLunnarMonth.Text = "THÁNG MƯỜI MỘT";
            // 
            // ButtonLunnarName
            // 
            this.ButtonLunnarName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonLunnarName.BorderRadius = 15;
            this.ButtonLunnarName.BorderThickness = 2;
            this.ButtonLunnarName.CheckedState.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.CustomImages.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLunnarName.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonLunnarName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonLunnarName.HoverState.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.Location = new System.Drawing.Point(845, 3);
            this.ButtonLunnarName.Name = "ButtonLunnarName";
            this.ButtonLunnarName.ShadowDecoration.Parent = this.ButtonLunnarName;
            this.ButtonLunnarName.Size = new System.Drawing.Size(111, 34);
            this.ButtonLunnarName.TabIndex = 5;
            this.ButtonLunnarName.Text = "ÂM LỊCH";
            // 
            // ButtonNameHour
            // 
            this.ButtonNameHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonNameHour.BorderRadius = 15;
            this.ButtonNameHour.BorderThickness = 2;
            this.ButtonNameHour.CheckedState.Parent = this.ButtonNameHour;
            this.ButtonNameHour.CustomImages.Parent = this.ButtonNameHour;
            this.ButtonNameHour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonNameHour.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.ButtonNameHour.ForeColor = System.Drawing.Color.Black;
            this.ButtonNameHour.HoverState.Parent = this.ButtonNameHour;
            this.ButtonNameHour.Location = new System.Drawing.Point(52, 3);
            this.ButtonNameHour.Name = "ButtonNameHour";
            this.ButtonNameHour.ShadowDecoration.Parent = this.ButtonNameHour;
            this.ButtonNameHour.Size = new System.Drawing.Size(99, 34);
            this.ButtonNameHour.TabIndex = 4;
            this.ButtonNameHour.Text = "GIỜ";
            // 
            // PanelHourLunnar
            // 
            this.PanelHourLunnar.BorderColor = System.Drawing.Color.Black;
            this.PanelHourLunnar.BorderThickness = 2;
            this.PanelHourLunnar.Controls.Add(this.TextboxZodiacHour);
            this.PanelHourLunnar.Controls.Add(this.labelHour);
            this.PanelHourLunnar.Controls.Add(this.labelHourLunnar);
            this.PanelHourLunnar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelHourLunnar.Location = new System.Drawing.Point(0, 40);
            this.PanelHourLunnar.Name = "PanelHourLunnar";
            this.PanelHourLunnar.ShadowDecoration.Parent = this.PanelHourLunnar;
            this.PanelHourLunnar.Size = new System.Drawing.Size(212, 130);
            this.PanelHourLunnar.TabIndex = 1;
            // 
            // TextboxZodiacHour
            // 
            this.TextboxZodiacHour.BackColor = System.Drawing.Color.Transparent;
            this.TextboxZodiacHour.BorderThickness = 0;
            this.TextboxZodiacHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxZodiacHour.DefaultText = "aaaaaaaaaaaaaaaaaaaaaâaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.TextboxZodiacHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxZodiacHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxZodiacHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxZodiacHour.DisabledState.Parent = this.TextboxZodiacHour;
            this.TextboxZodiacHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxZodiacHour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TextboxZodiacHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxZodiacHour.FocusedState.Parent = this.TextboxZodiacHour;
            this.TextboxZodiacHour.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxZodiacHour.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.TextboxZodiacHour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxZodiacHour.HoverState.Parent = this.TextboxZodiacHour;
            this.TextboxZodiacHour.Location = new System.Drawing.Point(5, 60);
            this.TextboxZodiacHour.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxZodiacHour.Multiline = true;
            this.TextboxZodiacHour.Name = "TextboxZodiacHour";
            this.TextboxZodiacHour.PasswordChar = '\0';
            this.TextboxZodiacHour.PlaceholderText = "";
            this.TextboxZodiacHour.ReadOnly = true;
            this.TextboxZodiacHour.SelectedText = "";
            this.TextboxZodiacHour.SelectionStart = 51;
            this.TextboxZodiacHour.ShadowDecoration.Parent = this.TextboxZodiacHour;
            this.TextboxZodiacHour.Size = new System.Drawing.Size(200, 66);
            this.TextboxZodiacHour.TabIndex = 3;
            this.TextboxZodiacHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.BackColor = System.Drawing.Color.Transparent;
            this.labelHour.Font = new System.Drawing.Font("Arial", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHour.ForeColor = System.Drawing.Color.DarkRed;
            this.labelHour.Location = new System.Drawing.Point(73, 34);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(59, 27);
            this.labelHour.TabIndex = 1;
            this.labelHour.Text = "Giờ ";
            // 
            // labelHourLunnar
            // 
            this.labelHourLunnar.AutoSize = true;
            this.labelHourLunnar.BackColor = System.Drawing.Color.Transparent;
            this.labelHourLunnar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourLunnar.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelHourLunnar.Location = new System.Drawing.Point(21, 3);
            this.labelHourLunnar.Name = "labelHourLunnar";
            this.labelHourLunnar.Size = new System.Drawing.Size(76, 24);
            this.labelHourLunnar.TabIndex = 0;
            this.labelHourLunnar.Text = "Giờ Tỵ";
            // 
            // PanelLunnarDay
            // 
            this.PanelLunnarDay.BorderColor = System.Drawing.Color.Black;
            this.PanelLunnarDay.BorderThickness = 2;
            this.PanelLunnarDay.Controls.Add(this.ZodiacAnimal2);
            this.PanelLunnarDay.Controls.Add(this.ZodiacAnimal1);
            this.PanelLunnarDay.Controls.Add(this.guna2VSeparator1);
            this.PanelLunnarDay.Controls.Add(this.PictureZodiac);
            this.PanelLunnarDay.Controls.Add(this.labelLunnarDay);
            this.PanelLunnarDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelLunnarDay.Location = new System.Drawing.Point(212, 40);
            this.PanelLunnarDay.Name = "PanelLunnarDay";
            this.PanelLunnarDay.ShadowDecoration.Parent = this.PanelLunnarDay;
            this.PanelLunnarDay.Size = new System.Drawing.Size(582, 130);
            this.PanelLunnarDay.TabIndex = 3;
            // 
            // ZodiacAnimal2
            // 
            this.ZodiacAnimal2.BackColor = System.Drawing.Color.Transparent;
            this.ZodiacAnimal2.Location = new System.Drawing.Point(367, -1);
            this.ZodiacAnimal2.Name = "ZodiacAnimal2";
            this.ZodiacAnimal2.ShadowDecoration.Parent = this.ZodiacAnimal2;
            this.ZodiacAnimal2.Size = new System.Drawing.Size(214, 130);
            this.ZodiacAnimal2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZodiacAnimal2.TabIndex = 6;
            this.ZodiacAnimal2.TabStop = false;
            // 
            // ZodiacAnimal1
            // 
            this.ZodiacAnimal1.BackColor = System.Drawing.Color.Transparent;
            this.ZodiacAnimal1.Location = new System.Drawing.Point(0, 0);
            this.ZodiacAnimal1.Name = "ZodiacAnimal1";
            this.ZodiacAnimal1.ShadowDecoration.Parent = this.ZodiacAnimal1;
            this.ZodiacAnimal1.Size = new System.Drawing.Size(214, 130);
            this.ZodiacAnimal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ZodiacAnimal1.TabIndex = 5;
            this.ZodiacAnimal1.TabStop = false;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.LightGreen;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Black;
            this.guna2VSeparator1.Location = new System.Drawing.Point(-10, 1);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 98);
            this.guna2VSeparator1.TabIndex = 4;
            // 
            // PictureZodiac
            // 
            this.PictureZodiac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PictureZodiac.ForeColor = System.Drawing.Color.Black;
            this.PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.PictureZodiac.IconColor = System.Drawing.Color.Black;
            this.PictureZodiac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureZodiac.IconSize = 31;
            this.PictureZodiac.Location = new System.Drawing.Point(279, 6);
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
            this.labelLunnarDay.Font = new System.Drawing.Font("Segoe UI", 52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLunnarDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLunnarDay.Location = new System.Drawing.Point(238, 32);
            this.labelLunnarDay.Name = "labelLunnarDay";
            this.labelLunnarDay.Size = new System.Drawing.Size(120, 93);
            this.labelLunnarDay.TabIndex = 0;
            this.labelLunnarDay.Text = "30";
            // 
            // PanelLunnarDate
            // 
            this.PanelLunnarDate.Controls.Add(this.PanelLunnarDay);
            this.PanelLunnarDate.Controls.Add(this.PanelLunnarMonth);
            this.PanelLunnarDate.Controls.Add(this.PanelHourLunnar);
            this.PanelLunnarDate.Controls.Add(this.PanelName);
            this.PanelLunnarDate.Location = new System.Drawing.Point(0, 451);
            this.PanelLunnarDate.Name = "PanelLunnarDate";
            this.PanelLunnarDate.ShadowDecoration.Parent = this.PanelLunnarDate;
            this.PanelLunnarDate.Size = new System.Drawing.Size(1009, 169);
            this.PanelLunnarDate.TabIndex = 1;
            // 
            // ButtonToday
            // 
            this.ButtonToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonToday.BorderColor = System.Drawing.Color.DimGray;
            this.ButtonToday.BorderThickness = 4;
            this.ButtonToday.CheckedState.Parent = this.ButtonToday;
            this.ButtonToday.CustomImages.Parent = this.ButtonToday;
            this.ButtonToday.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ButtonToday.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ButtonToday.ForeColor = System.Drawing.Color.DarkGreen;
            this.ButtonToday.HoverState.Parent = this.ButtonToday;
            this.ButtonToday.Location = new System.Drawing.Point(935, 0);
            this.ButtonToday.Name = "ButtonToday";
            this.ButtonToday.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonToday.ShadowDecoration.Parent = this.ButtonToday;
            this.ButtonToday.Size = new System.Drawing.Size(74, 65);
            this.ButtonToday.TabIndex = 1;
            this.ButtonToday.Text = "6";
            this.ButtonToday.Click += new System.EventHandler(this.ButtonToday_Click);
            // 
            // ButtonPre
            // 
            this.ButtonPre.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPre.FlatAppearance.BorderSize = 0;
            this.ButtonPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPre.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ButtonPre.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonPre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonPre.IconSize = 72;
            this.ButtonPre.Location = new System.Drawing.Point(305, 4);
            this.ButtonPre.Name = "ButtonPre";
            this.ButtonPre.Size = new System.Drawing.Size(61, 61);
            this.ButtonPre.TabIndex = 5;
            this.ButtonPre.UseVisualStyleBackColor = false;
            this.ButtonPre.Click += new System.EventHandler(this.ButtonPre_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ButtonNext.IconColor = System.Drawing.Color.DarkSlateGray;
            this.ButtonNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNext.IconSize = 72;
            this.ButtonNext.Location = new System.Drawing.Point(653, 1);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(71, 64);
            this.ButtonNext.TabIndex = 6;
            this.ButtonNext.UseVisualStyleBackColor = false;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // dtpk
            // 
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(466, 16);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(10, 10);
            this.dtpk.TabIndex = 9;
            this.dtpk.Value = new System.DateTime(2020, 12, 15, 10, 43, 21, 676);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // ButtonMonth
            // 
            this.ButtonMonth.BackColor = System.Drawing.Color.Transparent;
            this.ButtonMonth.BorderRadius = 15;
            this.ButtonMonth.BorderThickness = 4;
            this.ButtonMonth.CheckedState.Parent = this.ButtonMonth;
            this.ButtonMonth.CustomImages.Parent = this.ButtonMonth;
            this.ButtonMonth.FillColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonMonth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.ButtonMonth.ForeColor = System.Drawing.Color.Black;
            this.ButtonMonth.HoverState.Parent = this.ButtonMonth;
            this.ButtonMonth.Location = new System.Drawing.Point(372, 4);
            this.ButtonMonth.Name = "ButtonMonth";
            this.ButtonMonth.ShadowDecoration.Parent = this.ButtonMonth;
            this.ButtonMonth.Size = new System.Drawing.Size(280, 56);
            this.ButtonMonth.TabIndex = 0;
            this.ButtonMonth.Text = "THÁNG 11 - 2020";
            this.ButtonMonth.Click += new System.EventHandler(this.ButtonMonth_Click);
            // 
            // PanelMonth
            // 
            this.PanelMonth.Controls.Add(this.iconSetting);
            this.PanelMonth.Controls.Add(this.ButtonMonth);
            this.PanelMonth.Controls.Add(this.dtpk);
            this.PanelMonth.Controls.Add(this.ButtonNext);
            this.PanelMonth.Controls.Add(this.ButtonPre);
            this.PanelMonth.Controls.Add(this.ButtonToday);
            this.PanelMonth.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelMonth.Location = new System.Drawing.Point(0, 0);
            this.PanelMonth.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMonth.Name = "PanelMonth";
            this.PanelMonth.ShadowDecoration.Parent = this.PanelMonth;
            this.PanelMonth.Size = new System.Drawing.Size(1009, 65);
            this.PanelMonth.TabIndex = 0;
            // 
            // iconSetting
            // 
            this.iconSetting.BackColor = System.Drawing.Color.Transparent;
            this.iconSetting.FlatAppearance.BorderSize = 0;
            this.iconSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconSetting.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconSetting.IconColor = System.Drawing.Color.Gray;
            this.iconSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconSetting.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconSetting.Location = new System.Drawing.Point(3, 1);
            this.iconSetting.Name = "iconSetting";
            this.iconSetting.Size = new System.Drawing.Size(55, 56);
            this.iconSetting.TabIndex = 10;
            this.iconSetting.UseVisualStyleBackColor = false;
            this.iconSetting.Click += new System.EventHandler(this.iconSetting_Click);
            // 
            // PanelDay
            // 
            this.PanelDay.Controls.Add(this.labelDOW);
            this.PanelDay.Controls.Add(this.labelDay);
            this.PanelDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelDay.ForeColor = System.Drawing.Color.Red;
            this.PanelDay.Location = new System.Drawing.Point(398, 6);
            this.PanelDay.Name = "PanelDay";
            this.PanelDay.ShadowDecoration.Parent = this.PanelDay;
            this.PanelDay.Size = new System.Drawing.Size(213, 217);
            this.PanelDay.TabIndex = 5;
            // 
            // labelDOW
            // 
            this.labelDOW.AutoSize = true;
            this.labelDOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelDOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOW.ForeColor = System.Drawing.Color.Red;
            this.labelDOW.Location = new System.Drawing.Point(8, 131);
            this.labelDOW.Name = "labelDOW";
            this.labelDOW.Size = new System.Drawing.Size(196, 46);
            this.labelDOW.TabIndex = 1;
            this.labelDOW.Text = "Chủ Nhật";
            this.labelDOW.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.BackColor = System.Drawing.Color.Transparent;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 92F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.Red;
            this.labelDay.Location = new System.Drawing.Point(12, 9);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(198, 141);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "30";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ButtonNote
            // 
            this.ButtonNote.BackColor = System.Drawing.Color.Transparent;
            this.ButtonNote.FlatAppearance.BorderSize = 0;
            this.ButtonNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNote.IconChar = FontAwesome.Sharp.IconChar.StickyNote;
            this.ButtonNote.IconColor = System.Drawing.Color.DimGray;
            this.ButtonNote.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonNote.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonNote.Location = new System.Drawing.Point(941, 6);
            this.ButtonNote.Name = "ButtonNote";
            this.ButtonNote.Size = new System.Drawing.Size(55, 56);
            this.ButtonNote.TabIndex = 7;
            this.ButtonNote.UseVisualStyleBackColor = false;
            this.ButtonNote.Click += new System.EventHandler(this.ButtonNote_Click);
            // 
            // PanelQuote
            // 
            this.PanelQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelQuote.Controls.Add(this.TextboxAuthor);
            this.PanelQuote.Controls.Add(this.TextboxQuote);
            this.PanelQuote.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelQuote.ForeColor = System.Drawing.Color.Red;
            this.PanelQuote.Location = new System.Drawing.Point(0, 255);
            this.PanelQuote.Name = "PanelQuote";
            this.PanelQuote.ShadowDecoration.Parent = this.PanelQuote;
            this.PanelQuote.Size = new System.Drawing.Size(1009, 108);
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
            this.TextboxAuthor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextboxAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxAuthor.FocusedState.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TextboxAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextboxAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxAuthor.HoverState.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Location = new System.Drawing.Point(0, 86);
            this.TextboxAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextboxAuthor.Name = "TextboxAuthor";
            this.TextboxAuthor.PasswordChar = '\0';
            this.TextboxAuthor.PlaceholderText = "";
            this.TextboxAuthor.ReadOnly = true;
            this.TextboxAuthor.SelectedText = "";
            this.TextboxAuthor.ShadowDecoration.Parent = this.TextboxAuthor;
            this.TextboxAuthor.Size = new System.Drawing.Size(1006, 18);
            this.TextboxAuthor.TabIndex = 2;
            this.TextboxAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextboxQuote
            // 
            this.TextboxQuote.BackColor = System.Drawing.Color.Transparent;
            this.TextboxQuote.BorderColor = System.Drawing.Color.Black;
            this.TextboxQuote.BorderThickness = 0;
            this.TextboxQuote.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextboxQuote.DefaultText = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            this.TextboxQuote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextboxQuote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextboxQuote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxQuote.DisabledState.Parent = this.TextboxQuote;
            this.TextboxQuote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextboxQuote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TextboxQuote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxQuote.FocusedState.Parent = this.TextboxQuote;
            this.TextboxQuote.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TextboxQuote.ForeColor = System.Drawing.Color.Black;
            this.TextboxQuote.HideSelection = false;
            this.TextboxQuote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxQuote.HoverState.Parent = this.TextboxQuote;
            this.TextboxQuote.Location = new System.Drawing.Point(0, 17);
            this.TextboxQuote.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxQuote.Multiline = true;
            this.TextboxQuote.Name = "TextboxQuote";
            this.TextboxQuote.PasswordChar = '\0';
            this.TextboxQuote.PlaceholderForeColor = System.Drawing.Color.White;
            this.TextboxQuote.PlaceholderText = "";
            this.TextboxQuote.ReadOnly = true;
            this.TextboxQuote.SelectedText = "";
            this.TextboxQuote.SelectionStart = 74;
            this.TextboxQuote.ShadowDecoration.Parent = this.TextboxQuote;
            this.TextboxQuote.Size = new System.Drawing.Size(1009, 75);
            this.TextboxQuote.TabIndex = 1;
            this.TextboxQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelEvent
            // 
            this.PanelEvent.BackColor = System.Drawing.Color.Transparent;
            this.PanelEvent.Controls.Add(this.TextboxEvent);
            this.PanelEvent.Location = new System.Drawing.Point(0, 230);
            this.PanelEvent.Name = "PanelEvent";
            this.PanelEvent.ShadowDecoration.Parent = this.PanelEvent;
            this.PanelEvent.Size = new System.Drawing.Size(1009, 40);
            this.PanelEvent.TabIndex = 8;
            // 
            // TextboxEvent
            // 
            this.TextboxEvent.AcceptsReturn = true;
            this.TextboxEvent.BorderColor = System.Drawing.Color.Transparent;
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
            this.TextboxEvent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.TextboxEvent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextboxEvent.HoverState.Parent = this.TextboxEvent;
            this.TextboxEvent.Location = new System.Drawing.Point(0, 0);
            this.TextboxEvent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextboxEvent.Multiline = true;
            this.TextboxEvent.Name = "TextboxEvent";
            this.TextboxEvent.PasswordChar = '\0';
            this.TextboxEvent.PlaceholderText = "";
            this.TextboxEvent.ReadOnly = true;
            this.TextboxEvent.SelectedText = "";
            this.TextboxEvent.ShadowDecoration.Parent = this.TextboxEvent;
            this.TextboxEvent.Size = new System.Drawing.Size(1009, 40);
            this.TextboxEvent.TabIndex = 0;
            this.TextboxEvent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelImage
            // 
            this.PanelImage.Controls.Add(this.ibtnSpeech);
            this.PanelImage.Controls.Add(this.PanelEvent);
            this.PanelImage.Controls.Add(this.PanelQuote);
            this.PanelImage.Controls.Add(this.ButtonNote);
            this.PanelImage.Controls.Add(this.PanelDay);
            this.PanelImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PanelImage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PanelImage.Location = new System.Drawing.Point(0, 65);
            this.PanelImage.Name = "PanelImage";
            this.PanelImage.ShadowDecoration.Parent = this.PanelImage;
            this.PanelImage.Size = new System.Drawing.Size(1009, 387);
            this.PanelImage.TabIndex = 8;
            // 
            // DisplayDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelImage);
            this.Controls.Add(this.PanelMonth);
            this.Controls.Add(this.PanelLunnarDate);
            this.Name = "DisplayDate";
            this.Size = new System.Drawing.Size(1009, 620);
            this.Load += new System.EventHandler(this.DisplayDate_Load);
            this.PanelLunnarMonth.ResumeLayout(false);
            this.PanelLunnarMonth.PerformLayout();
            this.PanelName.ResumeLayout(false);
            this.PanelHourLunnar.ResumeLayout(false);
            this.PanelHourLunnar.PerformLayout();
            this.PanelLunnarDay.ResumeLayout(false);
            this.PanelLunnarDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZodiacAnimal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZodiacAnimal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).EndInit();
            this.PanelLunnarDate.ResumeLayout(false);
            this.PanelMonth.ResumeLayout(false);
            this.PanelDay.ResumeLayout(false);
            this.PanelDay.PerformLayout();
            this.PanelQuote.ResumeLayout(false);
            this.PanelEvent.ResumeLayout(false);
            this.PanelImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ibtnSpeech;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelLunnarMonthName;
        private System.Windows.Forms.Label labelLunnarYearName;
        private System.Windows.Forms.Label labelLunnarDayName;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarMonth;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private Guna.UI2.WinForms.Guna2Button ButtonLunnarMonth;
        private Guna.UI2.WinForms.Guna2Button ButtonLunnarName;
        private Guna.UI2.WinForms.Guna2Button ButtonNameHour;
        private Guna.UI2.WinForms.Guna2Panel PanelHourLunnar;
        private Guna.UI2.WinForms.Guna2TextBox TextboxZodiacHour;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelHourLunnar;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarDay;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private FontAwesome.Sharp.IconPictureBox PictureZodiac;
        private System.Windows.Forms.Label labelLunnarDay;
        private Guna.UI2.WinForms.Guna2Panel PanelLunnarDate;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonToday;
        private FontAwesome.Sharp.IconButton ButtonPre;
        private FontAwesome.Sharp.IconButton ButtonNext;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
        private Guna.UI2.WinForms.Guna2Button ButtonMonth;
        private Guna.UI2.WinForms.Guna2Panel PanelMonth;
        private Guna.UI2.WinForms.Guna2Panel PanelDay;
        private System.Windows.Forms.Label labelDOW;
        private System.Windows.Forms.Label labelDay;
        private FontAwesome.Sharp.IconButton ButtonNote;
        private Guna.UI2.WinForms.Guna2Panel PanelQuote;
        private Guna.UI2.WinForms.Guna2TextBox TextboxAuthor;
        private Guna.UI2.WinForms.Guna2TextBox TextboxQuote;
        private Guna.UI2.WinForms.Guna2Panel PanelEvent;
        private Guna.UI2.WinForms.Guna2TextBox TextboxEvent;
        private Guna.UI2.WinForms.Guna2Panel PanelImage;
        private FontAwesome.Sharp.IconButton iconSetting;
        private Guna.UI2.WinForms.Guna2PictureBox ZodiacAnimal2;
        private Guna.UI2.WinForms.Guna2PictureBox ZodiacAnimal1;
    }
}
