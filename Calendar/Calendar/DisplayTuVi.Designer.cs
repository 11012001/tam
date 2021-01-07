namespace Calendar
{
    partial class DisplayTuVi
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
            this.PanelGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.tbLuuY1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconbtnMinus = new FontAwesome.Sharp.IconButton();
            this.iconbtnPlus = new FontAwesome.Sharp.IconButton();
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.PanelSetting = new Guna.UI2.WinForms.Guna2Panel();
            this.tbLuuY2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxGioiTinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonFind = new Guna.UI2.WinForms.Guna2Button();
            this.ComboBoxSolarYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxSolarMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxSolarDay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.PictureZodiac = new FontAwesome.Sharp.IconPictureBox();
            this.buttonName = new Guna.UI2.WinForms.Guna2Button();
            this.PanelGeneral.SuspendLayout();
            this.PanelDisplay.SuspendLayout();
            this.PanelSetting.SuspendLayout();
            this.PanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelGeneral.Controls.Add(this.PanelDisplay);
            this.PanelGeneral.Controls.Add(this.PanelSetting);
            this.PanelGeneral.Controls.Add(this.PanelName);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.ShadowDecoration.Parent = this.PanelGeneral;
            this.PanelGeneral.Size = new System.Drawing.Size(1009, 620);
            this.PanelGeneral.TabIndex = 0;
            // 
            // PanelDisplay
            // 
            this.PanelDisplay.Controls.Add(this.tbLuuY1);
            this.PanelDisplay.Controls.Add(this.iconbtnMinus);
            this.PanelDisplay.Controls.Add(this.iconbtnPlus);
            this.PanelDisplay.Controls.Add(this.rtbRead);
            this.PanelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDisplay.Location = new System.Drawing.Point(0, 170);
            this.PanelDisplay.Name = "PanelDisplay";
            this.PanelDisplay.ShadowDecoration.Parent = this.PanelDisplay;
            this.PanelDisplay.Size = new System.Drawing.Size(1009, 450);
            this.PanelDisplay.TabIndex = 2;
            // 
            // tbLuuY1
            // 
            this.tbLuuY1.BorderThickness = 0;
            this.tbLuuY1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLuuY1.DefaultText = "*LƯU Ý: Dữ liệu tử vi này chủ yếu chỉ mang tính chất tham khảo. Bạn cần cân nhắc " +
    "trước khi áp dụng thực tế.";
            this.tbLuuY1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLuuY1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLuuY1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLuuY1.DisabledState.Parent = this.tbLuuY1;
            this.tbLuuY1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLuuY1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLuuY1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLuuY1.FocusedState.Parent = this.tbLuuY1;
            this.tbLuuY1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuuY1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLuuY1.HoverState.Parent = this.tbLuuY1;
            this.tbLuuY1.Location = new System.Drawing.Point(75, 400);
            this.tbLuuY1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLuuY1.Name = "tbLuuY1";
            this.tbLuuY1.PasswordChar = '\0';
            this.tbLuuY1.PlaceholderText = "";
            this.tbLuuY1.SelectedText = "";
            this.tbLuuY1.SelectionStart = 107;
            this.tbLuuY1.ShadowDecoration.Parent = this.tbLuuY1;
            this.tbLuuY1.Size = new System.Drawing.Size(859, 50);
            this.tbLuuY1.TabIndex = 3;
            this.tbLuuY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconbtnMinus
            // 
            this.iconbtnMinus.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconbtnMinus.FlatAppearance.BorderSize = 0;
            this.iconbtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnMinus.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconbtnMinus.IconColor = System.Drawing.Color.Blue;
            this.iconbtnMinus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMinus.IconSize = 50;
            this.iconbtnMinus.Location = new System.Drawing.Point(934, 395);
            this.iconbtnMinus.Name = "iconbtnMinus";
            this.iconbtnMinus.Size = new System.Drawing.Size(75, 55);
            this.iconbtnMinus.TabIndex = 2;
            this.iconbtnMinus.UseVisualStyleBackColor = true;
            this.iconbtnMinus.Click += new System.EventHandler(this.iconbtnMinus_Click);
            // 
            // iconbtnPlus
            // 
            this.iconbtnPlus.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconbtnPlus.FlatAppearance.BorderSize = 0;
            this.iconbtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnPlus.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnPlus.IconColor = System.Drawing.Color.Red;
            this.iconbtnPlus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnPlus.IconSize = 50;
            this.iconbtnPlus.Location = new System.Drawing.Point(0, 395);
            this.iconbtnPlus.Name = "iconbtnPlus";
            this.iconbtnPlus.Size = new System.Drawing.Size(75, 55);
            this.iconbtnPlus.TabIndex = 1;
            this.iconbtnPlus.UseVisualStyleBackColor = true;
            this.iconbtnPlus.Click += new System.EventHandler(this.iconbtnPlus_Click);
            // 
            // rtbRead
            // 
            this.rtbRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRead.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbRead.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRead.Location = new System.Drawing.Point(0, 0);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(1009, 395);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // PanelSetting
            // 
            this.PanelSetting.Controls.Add(this.tbLuuY2);
            this.PanelSetting.Controls.Add(this.comboBoxGioiTinh);
            this.PanelSetting.Controls.Add(this.ButtonFind);
            this.PanelSetting.Controls.Add(this.ComboBoxSolarYear);
            this.PanelSetting.Controls.Add(this.ComboBoxSolarMonth);
            this.PanelSetting.Controls.Add(this.ComboBoxSolarDay);
            this.PanelSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSetting.Location = new System.Drawing.Point(0, 70);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.ShadowDecoration.Parent = this.PanelSetting;
            this.PanelSetting.Size = new System.Drawing.Size(1009, 100);
            this.PanelSetting.TabIndex = 1;
            // 
            // tbLuuY2
            // 
            this.tbLuuY2.BorderColor = System.Drawing.Color.DarkGray;
            this.tbLuuY2.BorderThickness = 0;
            this.tbLuuY2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbLuuY2.DefaultText = "CHỌN GIỚI TÍNH VÀ NGÀY SINH (DƯƠNG LỊCH)";
            this.tbLuuY2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLuuY2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLuuY2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLuuY2.DisabledState.Parent = this.tbLuuY2;
            this.tbLuuY2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLuuY2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLuuY2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLuuY2.FocusedState.Parent = this.tbLuuY2;
            this.tbLuuY2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLuuY2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLuuY2.HoverState.Parent = this.tbLuuY2;
            this.tbLuuY2.Location = new System.Drawing.Point(0, 0);
            this.tbLuuY2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLuuY2.Name = "tbLuuY2";
            this.tbLuuY2.PasswordChar = '\0';
            this.tbLuuY2.PlaceholderText = "";
            this.tbLuuY2.SelectedText = "";
            this.tbLuuY2.SelectionStart = 40;
            this.tbLuuY2.ShadowDecoration.Parent = this.tbLuuY2;
            this.tbLuuY2.Size = new System.Drawing.Size(1009, 50);
            this.tbLuuY2.TabIndex = 22;
            this.tbLuuY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGioiTinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGioiTinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxGioiTinh.FocusedState.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.comboBoxGioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxGioiTinh.HoverState.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.ItemHeight = 30;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.ItemsAppearance.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(642, 58);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.ShadowDecoration.Parent = this.comboBoxGioiTinh;
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(108, 36);
            this.comboBoxGioiTinh.TabIndex = 21;
            this.comboBoxGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonFind
            // 
            this.ButtonFind.CheckedState.Parent = this.ButtonFind;
            this.ButtonFind.CustomImages.Parent = this.ButtonFind;
            this.ButtonFind.FillColor = System.Drawing.Color.PaleGreen;
            this.ButtonFind.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ButtonFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonFind.HoverState.Parent = this.ButtonFind;
            this.ButtonFind.Location = new System.Drawing.Point(802, 49);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.ShadowDecoration.Parent = this.ButtonFind;
            this.ButtonFind.Size = new System.Drawing.Size(180, 45);
            this.ButtonFind.TabIndex = 20;
            this.ButtonFind.Text = "CHỌN";
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // ComboBoxSolarYear
            // 
            this.ComboBoxSolarYear.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarYear.FocusedState.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarYear.HoverState.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.ItemHeight = 30;
            this.ComboBoxSolarYear.ItemsAppearance.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Location = new System.Drawing.Point(477, 58);
            this.ComboBoxSolarYear.Name = "ComboBoxSolarYear";
            this.ComboBoxSolarYear.ShadowDecoration.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Size = new System.Drawing.Size(124, 36);
            this.ComboBoxSolarYear.TabIndex = 19;
            this.ComboBoxSolarYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxSolarMonth
            // 
            this.ComboBoxSolarMonth.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarMonth.FocusedState.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarMonth.HoverState.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.ItemHeight = 30;
            this.ComboBoxSolarMonth.ItemsAppearance.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Location = new System.Drawing.Point(195, 58);
            this.ComboBoxSolarMonth.Name = "ComboBoxSolarMonth";
            this.ComboBoxSolarMonth.ShadowDecoration.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Size = new System.Drawing.Size(276, 36);
            this.ComboBoxSolarMonth.TabIndex = 18;
            this.ComboBoxSolarMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxSolarDay
            // 
            this.ComboBoxSolarDay.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarDay.FocusedState.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarDay.HoverState.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.ItemHeight = 30;
            this.ComboBoxSolarDay.ItemsAppearance.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Location = new System.Drawing.Point(95, 58);
            this.ComboBoxSolarDay.Name = "ComboBoxSolarDay";
            this.ComboBoxSolarDay.ShadowDecoration.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Size = new System.Drawing.Size(94, 36);
            this.ComboBoxSolarDay.TabIndex = 17;
            this.ComboBoxSolarDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelName
            // 
            this.PanelName.Controls.Add(this.iconPictureBox1);
            this.PanelName.Controls.Add(this.PictureZodiac);
            this.PanelName.Controls.Add(this.buttonName);
            this.PanelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelName.Location = new System.Drawing.Point(0, 0);
            this.PanelName.Name = "PanelName";
            this.PanelName.ShadowDecoration.Parent = this.PanelName;
            this.PanelName.Size = new System.Drawing.Size(1009, 70);
            this.PanelName.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(616, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(52, 67);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 3;
            this.iconPictureBox1.TabStop = false;
            // 
            // PictureZodiac
            // 
            this.PictureZodiac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.PictureZodiac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
            this.PictureZodiac.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.PictureZodiac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PictureZodiac.IconSize = 60;
            this.PictureZodiac.Location = new System.Drawing.Point(345, 0);
            this.PictureZodiac.Name = "PictureZodiac";
            this.PictureZodiac.Size = new System.Drawing.Size(53, 67);
            this.PictureZodiac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureZodiac.TabIndex = 2;
            this.PictureZodiac.TabStop = false;
            // 
            // buttonName
            // 
            this.buttonName.CheckedState.Parent = this.buttonName;
            this.buttonName.CustomImages.Parent = this.buttonName;
            this.buttonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonName.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonName.HoverState.Parent = this.buttonName;
            this.buttonName.Location = new System.Drawing.Point(0, 0);
            this.buttonName.Name = "buttonName";
            this.buttonName.ShadowDecoration.Parent = this.buttonName;
            this.buttonName.Size = new System.Drawing.Size(1009, 70);
            this.buttonName.TabIndex = 0;
            this.buttonName.Text = "TỬ VI";
            // 
            // DisplayTuVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelGeneral);
            this.Name = "DisplayTuVi";
            this.Size = new System.Drawing.Size(1009, 620);
            this.Load += new System.EventHandler(this.DisplayTuVi_Load);
            this.PanelGeneral.ResumeLayout(false);
            this.PanelDisplay.ResumeLayout(false);
            this.PanelSetting.ResumeLayout(false);
            this.PanelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureZodiac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelGeneral;
        private Guna.UI2.WinForms.Guna2Panel PanelDisplay;
        private Guna.UI2.WinForms.Guna2Panel PanelSetting;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private Guna.UI2.WinForms.Guna2Button buttonName;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarYear;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarMonth;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarDay;
        private FontAwesome.Sharp.IconButton iconbtnMinus;
        private FontAwesome.Sharp.IconButton iconbtnPlus;
        private System.Windows.Forms.RichTextBox rtbRead;
        private Guna.UI2.WinForms.Guna2Button ButtonFind;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxGioiTinh;
        private Guna.UI2.WinForms.Guna2TextBox tbLuuY1;
        private Guna.UI2.WinForms.Guna2TextBox tbLuuY2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox PictureZodiac;
    }
}
