namespace Calendar
{
    partial class DeadLineNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeadLineNote));
            this.UrgentCB = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ImportantCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MinutesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.HoursCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DescriptionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.MainNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UrgentCB
            // 
            this.UrgentCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrgentCB.FormattingEnabled = true;
            this.UrgentCB.Items.AddRange(new object[] {
            "1 Ngày",
            "3 Ngày",
            "1 Tuần",
            "2 Tuần"});
            this.UrgentCB.Location = new System.Drawing.Point(395, 457);
            this.UrgentCB.Name = "UrgentCB";
            this.UrgentCB.Size = new System.Drawing.Size(121, 37);
            this.UrgentCB.TabIndex = 105;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.MistyRose;
            this.SaveBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Location = new System.Drawing.Point(323, 538);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(98, 45);
            this.SaveBtn.TabIndex = 104;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(88, 458);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(275, 36);
            this.guna2HtmlLabel1.TabIndex = 103;
            this.guna2HtmlLabel1.Text = "Thời điểm gấp rút";
            // 
            // ImportantCheck
            // 
            this.ImportantCheck.AutoSize = true;
            this.ImportantCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ImportantCheck.CheckedState.BorderRadius = 0;
            this.ImportantCheck.CheckedState.BorderThickness = 0;
            this.ImportantCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ImportantCheck.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportantCheck.Location = new System.Drawing.Point(446, 418);
            this.ImportantCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ImportantCheck.Name = "ImportantCheck";
            this.ImportantCheck.Size = new System.Drawing.Size(149, 28);
            this.ImportantCheck.TabIndex = 102;
            this.ImportantCheck.Text = "Quan trọng";
            this.ImportantCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ImportantCheck.UncheckedState.BorderRadius = 0;
            this.ImportantCheck.UncheckedState.BorderThickness = 0;
            this.ImportantCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // ExitBtn
            // 
            this.ExitBtn.Animated = true;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.MistyRose;
            this.ExitBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(441, 538);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(98, 45);
            this.ExitBtn.TabIndex = 101;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MinutesCB
            // 
            this.MinutesCB.BackColor = System.Drawing.Color.Transparent;
            this.MinutesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MinutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MinutesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinutesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinutesCB.FocusedState.Parent = this.MinutesCB;
            this.MinutesCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.MinutesCB.HoverState.Parent = this.MinutesCB;
            this.MinutesCB.ItemHeight = 30;
            this.MinutesCB.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.MinutesCB.ItemsAppearance.Parent = this.MinutesCB;
            this.MinutesCB.Location = new System.Drawing.Point(357, 410);
            this.MinutesCB.Margin = new System.Windows.Forms.Padding(6);
            this.MinutesCB.Name = "MinutesCB";
            this.MinutesCB.ShadowDecoration.Parent = this.MinutesCB;
            this.MinutesCB.Size = new System.Drawing.Size(77, 36);
            this.MinutesCB.TabIndex = 100;
            this.MinutesCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HoursCB
            // 
            this.HoursCB.BackColor = System.Drawing.Color.Transparent;
            this.HoursCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HoursCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoursCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoursCB.FocusedState.Parent = this.HoursCB;
            this.HoursCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.HoursCB.HoverState.Parent = this.HoursCB;
            this.HoursCB.ItemHeight = 30;
            this.HoursCB.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.HoursCB.ItemsAppearance.Parent = this.HoursCB;
            this.HoursCB.Location = new System.Drawing.Point(231, 410);
            this.HoursCB.Margin = new System.Windows.Forms.Padding(6);
            this.HoursCB.Name = "HoursCB";
            this.HoursCB.ShadowDecoration.Parent = this.HoursCB;
            this.HoursCB.Size = new System.Drawing.Size(83, 36);
            this.HoursCB.TabIndex = 99;
            this.HoursCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(50, 362);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 98;
            this.iconPictureBox4.TabStop = false;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(91, 362);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(115, 36);
            this.guna2HtmlLabel6.TabIndex = 97;
            this.guna2HtmlLabel6.Text = "Day End";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(326, 410);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(19, 36);
            this.guna2HtmlLabel4.TabIndex = 96;
            this.guna2HtmlLabel4.Text = ":";
            // 
            // Dtpk
            // 
            this.Dtpk.Animated = true;
            this.Dtpk.BackColor = System.Drawing.Color.Transparent;
            this.Dtpk.CheckedState.Parent = this.Dtpk;
            this.Dtpk.CustomFormat = "dd/MM/yyyy";
            this.Dtpk.FillColor = System.Drawing.Color.PeachPuff;
            this.Dtpk.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.Dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtpk.HoverState.Parent = this.Dtpk;
            this.Dtpk.Location = new System.Drawing.Point(231, 362);
            this.Dtpk.Margin = new System.Windows.Forms.Padding(6);
            this.Dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtpk.Name = "Dtpk";
            this.Dtpk.ShadowDecoration.Parent = this.Dtpk;
            this.Dtpk.Size = new System.Drawing.Size(244, 36);
            this.Dtpk.TabIndex = 95;
            this.Dtpk.Value = new System.DateTime(2021, 1, 7, 7, 47, 6, 723);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(88, 410);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(131, 36);
            this.guna2HtmlLabel2.TabIndex = 94;
            this.guna2HtmlLabel2.Text = "Time End";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.AllowDrop = true;
            this.DescriptionTB.Animated = true;
            this.DescriptionTB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.DescriptionTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DescriptionTB.DefaultText = "Mô tả";
            this.DescriptionTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DescriptionTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTB.DisabledState.Parent = this.DescriptionTB;
            this.DescriptionTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DescriptionTB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DescriptionTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTB.FocusedState.Parent = this.DescriptionTB;
            this.DescriptionTB.Font = new System.Drawing.Font("Consolas", 12F);
            this.DescriptionTB.ForeColor = System.Drawing.Color.LightGray;
            this.DescriptionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTB.HoverState.Parent = this.DescriptionTB;
            this.DescriptionTB.Location = new System.Drawing.Point(88, 133);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.PasswordChar = '\0';
            this.DescriptionTB.PlaceholderText = "";
            this.DescriptionTB.SelectedText = "";
            this.DescriptionTB.SelectionStart = 5;
            this.DescriptionTB.ShadowDecoration.Parent = this.DescriptionTB;
            this.DescriptionTB.Size = new System.Drawing.Size(507, 217);
            this.DescriptionTB.TabIndex = 93;
            this.DescriptionTB.Enter += new System.EventHandler(this.DescriptionTB_Enter);
            this.DescriptionTB.Leave += new System.EventHandler(this.DescriptionTB_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(47, 91);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 92;
            this.iconPictureBox2.TabStop = false;
            // 
            // MainNote
            // 
            this.MainNote.Animated = true;
            this.MainNote.BackColor = System.Drawing.Color.Transparent;
            this.MainNote.BorderColor = System.Drawing.Color.LightGray;
            this.MainNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MainNote.DefaultText = "Ghi chú";
            this.MainNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MainNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MainNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MainNote.DisabledState.Parent = this.MainNote;
            this.MainNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MainNote.FillColor = System.Drawing.Color.WhiteSmoke;
            this.MainNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MainNote.FocusedState.Parent = this.MainNote;
            this.MainNote.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.MainNote.ForeColor = System.Drawing.Color.LightGray;
            this.MainNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MainNote.HoverState.Parent = this.MainNote;
            this.MainNote.Location = new System.Drawing.Point(88, 91);
            this.MainNote.Margin = new System.Windows.Forms.Padding(6);
            this.MainNote.Name = "MainNote";
            this.MainNote.PasswordChar = '\0';
            this.MainNote.PlaceholderText = "";
            this.MainNote.SelectedText = "";
            this.MainNote.SelectionStart = 7;
            this.MainNote.ShadowDecoration.Parent = this.MainNote;
            this.MainNote.Size = new System.Drawing.Size(507, 36);
            this.MainNote.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MainNote.TabIndex = 91;
            this.MainNote.Enter += new System.EventHandler(this.MainNote_Enter);
            this.MainNote.Leave += new System.EventHandler(this.MainNote_Leave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(47, 133);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 36);
            this.iconPictureBox1.TabIndex = 90;
            this.iconPictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(88, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(507, 39);
            this.TitleLabel.TabIndex = 89;
            this.TitleLabel.Text = "Dealine Hoàn Thành công việc";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // DeadLineNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 596);
            this.Controls.Add(this.UrgentCB);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.ImportantCheck);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MinutesCB);
            this.Controls.Add(this.HoursCB);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.Dtpk);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.MainNote);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeadLineNote";
            this.Text = "DeadLineNote";
            this.Load += new System.EventHandler(this.DeadLineNote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2CheckBox ImportantCheck;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        public Guna.UI2.WinForms.Guna2ComboBox MinutesCB;
        public Guna.UI2.WinForms.Guna2ComboBox HoursCB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2DateTimePicker Dtpk;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2TextBox DescriptionTB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public Guna.UI2.WinForms.Guna2TextBox MainNote;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Guna.UI2.WinForms.Guna2HtmlLabel TitleLabel;
        public System.Windows.Forms.ComboBox UrgentCB;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}