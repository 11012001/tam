namespace Calendar
{
    partial class ToDoNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoNote));
            this.ToDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.RepeatCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ImportantCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TMinutesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.THoursCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FMinutesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ToDtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FHoursCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.FromDtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DescriptionTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.MainNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.TitleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToDate
            // 
            this.ToDate.BackColor = System.Drawing.Color.Transparent;
            this.ToDate.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Location = new System.Drawing.Point(145, 565);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(131, 36);
            this.ToDate.TabIndex = 49;
            this.ToDate.Text = "Đến ngày";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.Location = new System.Drawing.Point(145, 521);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox5.TabIndex = 48;
            this.iconPictureBox5.TabStop = false;
            // 
            // RepeatCB
            // 
            this.RepeatCB.Animated = true;
            this.RepeatCB.BackColor = System.Drawing.Color.Transparent;
            this.RepeatCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RepeatCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RepeatCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RepeatCB.FocusedState.Parent = this.RepeatCB;
            this.RepeatCB.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.RepeatCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RepeatCB.HoverState.Parent = this.RepeatCB;
            this.RepeatCB.ItemHeight = 30;
            this.RepeatCB.Items.AddRange(new object[] {
            "Không lặp",
            "Theo ngày",
            "Theo tuần",
            "Theo tháng",
            "Theo năm"});
            this.RepeatCB.ItemsAppearance.Parent = this.RepeatCB;
            this.RepeatCB.Location = new System.Drawing.Point(186, 517);
            this.RepeatCB.Margin = new System.Windows.Forms.Padding(6);
            this.RepeatCB.Name = "RepeatCB";
            this.RepeatCB.ShadowDecoration.Parent = this.RepeatCB;
            this.RepeatCB.Size = new System.Drawing.Size(189, 36);
            this.RepeatCB.TabIndex = 47;
            this.RepeatCB.SelectedIndexChanged += new System.EventHandler(this.RepeatCB_SelectedIndexChanged_1);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(145, 252);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(131, 36);
            this.guna2HtmlLabel6.TabIndex = 46;
            this.guna2HtmlLabel6.Text = "Vào ngày";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Animated = true;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ExitBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(451, 617);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(10);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(98, 45);
            this.ExitBtn.TabIndex = 45;
            this.ExitBtn.Text = "Thoát";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click_1);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveBtn.Font = new System.Drawing.Font("Consolas", 12F);
            this.SaveBtn.ForeColor = System.Drawing.Color.Black;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Location = new System.Drawing.Point(333, 617);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(10);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(98, 45);
            this.SaveBtn.TabIndex = 44;
            this.SaveBtn.Text = "Lưu";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click_1);
            // 
            // ImportantCheck
            // 
            this.ImportantCheck.AutoSize = true;
            this.ImportantCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ImportantCheck.CheckedState.BorderRadius = 0;
            this.ImportantCheck.CheckedState.BorderThickness = 0;
            this.ImportantCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ImportantCheck.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportantCheck.Location = new System.Drawing.Point(400, 480);
            this.ImportantCheck.Margin = new System.Windows.Forms.Padding(6);
            this.ImportantCheck.Name = "ImportantCheck";
            this.ImportantCheck.Size = new System.Drawing.Size(149, 28);
            this.ImportantCheck.TabIndex = 43;
            this.ImportantCheck.Text = "Quan trọng";
            this.ImportantCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ImportantCheck.UncheckedState.BorderRadius = 0;
            this.ImportantCheck.UncheckedState.BorderThickness = 0;
            this.ImportantCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(333, 432);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(19, 36);
            this.guna2HtmlLabel5.TabIndex = 42;
            this.guna2HtmlLabel5.Text = ":";
            // 
            // TMinutesCB
            // 
            this.TMinutesCB.BackColor = System.Drawing.Color.Transparent;
            this.TMinutesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TMinutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TMinutesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMinutesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMinutesCB.FocusedState.Parent = this.TMinutesCB;
            this.TMinutesCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinutesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TMinutesCB.HoverState.Parent = this.TMinutesCB;
            this.TMinutesCB.ItemHeight = 30;
            this.TMinutesCB.Items.AddRange(new object[] {
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
            this.TMinutesCB.ItemsAppearance.Parent = this.TMinutesCB;
            this.TMinutesCB.Location = new System.Drawing.Point(378, 432);
            this.TMinutesCB.Margin = new System.Windows.Forms.Padding(6);
            this.TMinutesCB.Name = "TMinutesCB";
            this.TMinutesCB.ShadowDecoration.Parent = this.TMinutesCB;
            this.TMinutesCB.Size = new System.Drawing.Size(109, 36);
            this.TMinutesCB.TabIndex = 41;
            this.TMinutesCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // THoursCB
            // 
            this.THoursCB.BackColor = System.Drawing.Color.Transparent;
            this.THoursCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.THoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.THoursCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.THoursCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.THoursCB.FocusedState.Parent = this.THoursCB;
            this.THoursCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THoursCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.THoursCB.HoverState.Parent = this.THoursCB;
            this.THoursCB.ItemHeight = 30;
            this.THoursCB.Items.AddRange(new object[] {
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
            this.THoursCB.ItemsAppearance.Parent = this.THoursCB;
            this.THoursCB.Location = new System.Drawing.Point(186, 432);
            this.THoursCB.Margin = new System.Windows.Forms.Padding(6);
            this.THoursCB.Name = "THoursCB";
            this.THoursCB.ShadowDecoration.Parent = this.THoursCB;
            this.THoursCB.Size = new System.Drawing.Size(109, 36);
            this.THoursCB.TabIndex = 40;
            this.THoursCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(145, 436);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 39;
            this.iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(145, 346);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 38;
            this.iconPictureBox3.TabStop = false;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(333, 342);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(19, 36);
            this.guna2HtmlLabel4.TabIndex = 37;
            this.guna2HtmlLabel4.Text = ":";
            // 
            // FMinutesCB
            // 
            this.FMinutesCB.BackColor = System.Drawing.Color.Transparent;
            this.FMinutesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FMinutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FMinutesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FMinutesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FMinutesCB.FocusedState.Parent = this.FMinutesCB;
            this.FMinutesCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMinutesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FMinutesCB.HoverState.Parent = this.FMinutesCB;
            this.FMinutesCB.ItemHeight = 30;
            this.FMinutesCB.Items.AddRange(new object[] {
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
            this.FMinutesCB.ItemsAppearance.Parent = this.FMinutesCB;
            this.FMinutesCB.Location = new System.Drawing.Point(378, 342);
            this.FMinutesCB.Margin = new System.Windows.Forms.Padding(6);
            this.FMinutesCB.Name = "FMinutesCB";
            this.FMinutesCB.ShadowDecoration.Parent = this.FMinutesCB;
            this.FMinutesCB.Size = new System.Drawing.Size(109, 36);
            this.FMinutesCB.TabIndex = 36;
            this.FMinutesCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(145, 387);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(51, 36);
            this.guna2HtmlLabel3.TabIndex = 35;
            this.guna2HtmlLabel3.Text = "Đến";
            // 
            // ToDtpk
            // 
            this.ToDtpk.Animated = true;
            this.ToDtpk.CheckedState.Parent = this.ToDtpk;
            this.ToDtpk.CustomFormat = "dd/MM/yyyy";
            this.ToDtpk.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.ToDtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDtpk.HoverState.Parent = this.ToDtpk;
            this.ToDtpk.Location = new System.Drawing.Point(285, 565);
            this.ToDtpk.Margin = new System.Windows.Forms.Padding(6);
            this.ToDtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDtpk.Name = "ToDtpk";
            this.ToDtpk.ShadowDecoration.Parent = this.ToDtpk;
            this.ToDtpk.Size = new System.Drawing.Size(288, 36);
            this.ToDtpk.TabIndex = 34;
            this.ToDtpk.Value = new System.DateTime(2020, 12, 17, 18, 21, 14, 261);
            // 
            // FHoursCB
            // 
            this.FHoursCB.BackColor = System.Drawing.Color.Transparent;
            this.FHoursCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FHoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FHoursCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FHoursCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FHoursCB.FocusedState.Parent = this.FHoursCB;
            this.FHoursCB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHoursCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FHoursCB.HoverState.Parent = this.FHoursCB;
            this.FHoursCB.ItemHeight = 30;
            this.FHoursCB.Items.AddRange(new object[] {
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
            this.FHoursCB.ItemsAppearance.Parent = this.FHoursCB;
            this.FHoursCB.Location = new System.Drawing.Point(186, 342);
            this.FHoursCB.Margin = new System.Windows.Forms.Padding(6);
            this.FHoursCB.Name = "FHoursCB";
            this.FHoursCB.ShadowDecoration.Parent = this.FHoursCB;
            this.FHoursCB.Size = new System.Drawing.Size(109, 36);
            this.FHoursCB.TabIndex = 33;
            this.FHoursCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FromDtpk
            // 
            this.FromDtpk.Animated = true;
            this.FromDtpk.BackColor = System.Drawing.Color.Transparent;
            this.FromDtpk.CheckedState.Parent = this.FromDtpk;
            this.FromDtpk.CustomFormat = "dd/MM/yyyy";
            this.FromDtpk.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.FromDtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDtpk.HoverState.Parent = this.FromDtpk;
            this.FromDtpk.Location = new System.Drawing.Point(285, 252);
            this.FromDtpk.Margin = new System.Windows.Forms.Padding(6);
            this.FromDtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDtpk.Name = "FromDtpk";
            this.FromDtpk.ShadowDecoration.Parent = this.FromDtpk;
            this.FromDtpk.Size = new System.Drawing.Size(288, 36);
            this.FromDtpk.TabIndex = 32;
            this.FromDtpk.Value = new System.DateTime(2020, 12, 17, 18, 21, 14, 261);
            this.FromDtpk.ValueChanged += new System.EventHandler(this.FromDtpk_ValueChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(145, 297);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(195, 36);
            this.guna2HtmlLabel2.TabIndex = 31;
            this.guna2HtmlLabel2.Text = "Từ thời điểm";
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
            this.DescriptionTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DescriptionTB.HoverState.Parent = this.DescriptionTB;
            this.DescriptionTB.Location = new System.Drawing.Point(186, 142);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(6);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.PasswordChar = '\0';
            this.DescriptionTB.PlaceholderText = "";
            this.DescriptionTB.SelectedText = "";
            this.DescriptionTB.SelectionStart = 5;
            this.DescriptionTB.ShadowDecoration.Parent = this.DescriptionTB;
            this.DescriptionTB.Size = new System.Drawing.Size(387, 87);
            this.DescriptionTB.TabIndex = 30;
            this.DescriptionTB.Enter += new System.EventHandler(this.DescriptionTB_Enter_1);
            this.DescriptionTB.Leave += new System.EventHandler(this.DescriptionTB_Leave_1);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(145, 98);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 29;
            this.iconPictureBox2.TabStop = false;
            // 
            // MainNote
            // 
            this.MainNote.Animated = true;
            this.MainNote.BackColor = System.Drawing.Color.Transparent;
            this.MainNote.BorderColor = System.Drawing.Color.LightGray;
            this.MainNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MainNote.DefaultText = "Nhập ghi chú";
            this.MainNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MainNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MainNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MainNote.DisabledState.Parent = this.MainNote;
            this.MainNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MainNote.FillColor = System.Drawing.Color.WhiteSmoke;
            this.MainNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MainNote.FocusedState.Parent = this.MainNote;
            this.MainNote.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.MainNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MainNote.HoverState.Parent = this.MainNote;
            this.MainNote.Location = new System.Drawing.Point(186, 91);
            this.MainNote.Margin = new System.Windows.Forms.Padding(6);
            this.MainNote.Name = "MainNote";
            this.MainNote.PasswordChar = '\0';
            this.MainNote.PlaceholderText = "";
            this.MainNote.SelectedText = "";
            this.MainNote.SelectionStart = 12;
            this.MainNote.ShadowDecoration.Parent = this.MainNote;
            this.MainNote.Size = new System.Drawing.Size(387, 36);
            this.MainNote.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MainNote.TabIndex = 28;
            this.MainNote.Enter += new System.EventHandler(this.MainNote_Enter_1);
            this.MainNote.Leave += new System.EventHandler(this.MainNote_Leave_1);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(145, 142);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 36);
            this.iconPictureBox1.TabIndex = 27;
            this.iconPictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Brown;
            this.TitleLabel.Location = new System.Drawing.Point(257, 35);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(207, 26);
            this.TitleLabel.TabIndex = 26;
            this.TitleLabel.Text = "Thêm việc cần làm";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this;
            // 
            // ToDoNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 670);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.iconPictureBox5);
            this.Controls.Add(this.RepeatCB);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ImportantCheck);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.TMinutesCB);
            this.Controls.Add(this.THoursCB);
            this.Controls.Add(this.iconPictureBox4);
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.FMinutesCB);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.ToDtpk);
            this.Controls.Add(this.FHoursCB);
            this.Controls.Add(this.FromDtpk);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.MainNote);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToDoNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToDoNote";
            this.Load += new System.EventHandler(this.ToDoNote_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2HtmlLabel ToDate;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        public Guna.UI2.WinForms.Guna2ComboBox RepeatCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        public Guna.UI2.WinForms.Guna2Button SaveBtn;
        public Guna.UI2.WinForms.Guna2CheckBox ImportantCheck;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        public Guna.UI2.WinForms.Guna2ComboBox TMinutesCB;
        public Guna.UI2.WinForms.Guna2ComboBox THoursCB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2ComboBox FMinutesCB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        public Guna.UI2.WinForms.Guna2ComboBox FHoursCB;
        public Guna.UI2.WinForms.Guna2DateTimePicker FromDtpk;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2TextBox DescriptionTB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        public Guna.UI2.WinForms.Guna2TextBox MainNote;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public Guna.UI2.WinForms.Guna2HtmlLabel TitleLabel;
        public Guna.UI2.WinForms.Guna2DateTimePicker ToDtpk;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}