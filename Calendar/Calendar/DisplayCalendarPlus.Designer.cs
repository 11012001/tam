
namespace Calendar
{
    partial class DisplayCalendarPlus
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
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PanelMatrix = new Guna.UI2.WinForms.Guna2Panel();
            this.BackToDateBtn = new XanderUI.XUIButton();
            this.DigitalClock = new System.Windows.Forms.Label();
            this.panelDOW = new System.Windows.Forms.Panel();
            this.BtnSun = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSat = new Guna.UI2.WinForms.Guna2Button();
            this.BtnFri = new Guna.UI2.WinForms.Guna2Button();
            this.BtnThu = new Guna.UI2.WinForms.Guna2Button();
            this.BtnWed = new Guna.UI2.WinForms.Guna2Button();
            this.BtnTue = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMon = new Guna.UI2.WinForms.Guna2Button();
            this.BtnNext = new FontAwesome.Sharp.IconButton();
            this.BtnPre = new FontAwesome.Sharp.IconButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDOW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpk
            // 
            this.dtpk.BorderColor = System.Drawing.Color.White;
            this.dtpk.BorderThickness = 4;
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.CustomFormat = "dddd,dd MMMM ,yyyy";
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(64, 53);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(402, 50);
            this.dtpk.TabIndex = 22;
            this.dtpk.Value = new System.DateTime(2020, 12, 7, 16, 39, 13, 620);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
            // 
            // PanelMatrix
            // 
            this.PanelMatrix.Location = new System.Drawing.Point(0, 164);
            this.PanelMatrix.Name = "PanelMatrix";
            this.PanelMatrix.ShadowDecoration.Parent = this.PanelMatrix;
            this.PanelMatrix.Size = new System.Drawing.Size(530, 426);
            this.PanelMatrix.TabIndex = 26;
            // 
            // BackToDateBtn
            // 
            this.BackToDateBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackToDateBtn.ButtonImage = null;
            this.BackToDateBtn.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.BackToDateBtn.ButtonText = "Hôm Nay";
            this.BackToDateBtn.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.BackToDateBtn.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.BackToDateBtn.CornerRadius = 5;
            this.BackToDateBtn.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.BackToDateBtn.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BackToDateBtn.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.BackToDateBtn.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackToDateBtn.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.BackToDateBtn.Location = new System.Drawing.Point(418, 3);
            this.BackToDateBtn.Name = "BackToDateBtn";
            this.BackToDateBtn.Size = new System.Drawing.Size(107, 45);
            this.BackToDateBtn.TabIndex = 23;
            this.BackToDateBtn.TextColor = System.Drawing.Color.DodgerBlue;
            this.BackToDateBtn.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BackToDateBtn.Click += new System.EventHandler(this.TodayBtn_Click);
            // 
            // DigitalClock
            // 
            this.DigitalClock.AutoSize = true;
            this.DigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalClock.Location = new System.Drawing.Point(3, 12);
            this.DigitalClock.Name = "DigitalClock";
            this.DigitalClock.Size = new System.Drawing.Size(234, 47);
            this.DigitalClock.TabIndex = 24;
            this.DigitalClock.Text = "00:00:00 A.M";
            this.DigitalClock.UseCompatibleTextRendering = true;
            // 
            // panelDOW
            // 
            this.panelDOW.Controls.Add(this.BtnSun);
            this.panelDOW.Controls.Add(this.BtnSat);
            this.panelDOW.Controls.Add(this.BtnFri);
            this.panelDOW.Controls.Add(this.BtnThu);
            this.panelDOW.Controls.Add(this.BtnWed);
            this.panelDOW.Controls.Add(this.BtnTue);
            this.panelDOW.Controls.Add(this.BtnMon);
            this.panelDOW.Location = new System.Drawing.Point(0, 109);
            this.panelDOW.Name = "panelDOW";
            this.panelDOW.Size = new System.Drawing.Size(530, 49);
            this.panelDOW.TabIndex = 25;
            // 
            // BtnSun
            // 
            this.BtnSun.BorderColor = System.Drawing.Color.White;
            this.BtnSun.BorderRadius = 15;
            this.BtnSun.CheckedState.Parent = this.BtnSun;
            this.BtnSun.CustomImages.Parent = this.BtnSun;
            this.BtnSun.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSun.FillColor = System.Drawing.Color.Transparent;
            this.BtnSun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSun.ForeColor = System.Drawing.Color.Black;
            this.BtnSun.HoverState.Parent = this.BtnSun;
            this.BtnSun.Location = new System.Drawing.Point(450, 0);
            this.BtnSun.Name = "BtnSun";
            this.BtnSun.ShadowDecoration.Parent = this.BtnSun;
            this.BtnSun.Size = new System.Drawing.Size(75, 49);
            this.BtnSun.TabIndex = 6;
            this.BtnSun.Text = "CHỦ NHẬT";
            // 
            // BtnSat
            // 
            this.BtnSat.BorderColor = System.Drawing.Color.White;
            this.BtnSat.BorderRadius = 15;
            this.BtnSat.CheckedState.Parent = this.BtnSat;
            this.BtnSat.CustomImages.Parent = this.BtnSat;
            this.BtnSat.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSat.FillColor = System.Drawing.Color.Transparent;
            this.BtnSat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSat.ForeColor = System.Drawing.Color.Black;
            this.BtnSat.HoverState.Parent = this.BtnSat;
            this.BtnSat.Location = new System.Drawing.Point(375, 0);
            this.BtnSat.Name = "BtnSat";
            this.BtnSat.ShadowDecoration.Parent = this.BtnSat;
            this.BtnSat.Size = new System.Drawing.Size(75, 49);
            this.BtnSat.TabIndex = 5;
            this.BtnSat.Text = "THỨ BẢY";
            // 
            // BtnFri
            // 
            this.BtnFri.BorderColor = System.Drawing.Color.White;
            this.BtnFri.BorderRadius = 15;
            this.BtnFri.CheckedState.Parent = this.BtnFri;
            this.BtnFri.CustomImages.Parent = this.BtnFri;
            this.BtnFri.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnFri.FillColor = System.Drawing.Color.Transparent;
            this.BtnFri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFri.ForeColor = System.Drawing.Color.Black;
            this.BtnFri.HoverState.Parent = this.BtnFri;
            this.BtnFri.Location = new System.Drawing.Point(300, 0);
            this.BtnFri.Name = "BtnFri";
            this.BtnFri.ShadowDecoration.Parent = this.BtnFri;
            this.BtnFri.Size = new System.Drawing.Size(75, 49);
            this.BtnFri.TabIndex = 4;
            this.BtnFri.Text = "THỨ SÁU";
            // 
            // BtnThu
            // 
            this.BtnThu.BorderColor = System.Drawing.Color.White;
            this.BtnThu.BorderRadius = 15;
            this.BtnThu.CheckedState.Parent = this.BtnThu;
            this.BtnThu.CustomImages.Parent = this.BtnThu;
            this.BtnThu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnThu.FillColor = System.Drawing.Color.Transparent;
            this.BtnThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThu.ForeColor = System.Drawing.Color.Black;
            this.BtnThu.HoverState.Parent = this.BtnThu;
            this.BtnThu.Location = new System.Drawing.Point(225, 0);
            this.BtnThu.Name = "BtnThu";
            this.BtnThu.ShadowDecoration.Parent = this.BtnThu;
            this.BtnThu.Size = new System.Drawing.Size(75, 49);
            this.BtnThu.TabIndex = 3;
            this.BtnThu.Text = "THỨ NĂM";
            // 
            // BtnWed
            // 
            this.BtnWed.BorderColor = System.Drawing.Color.White;
            this.BtnWed.BorderRadius = 15;
            this.BtnWed.CheckedState.Parent = this.BtnWed;
            this.BtnWed.CustomImages.Parent = this.BtnWed;
            this.BtnWed.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnWed.FillColor = System.Drawing.Color.Transparent;
            this.BtnWed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWed.ForeColor = System.Drawing.Color.Black;
            this.BtnWed.HoverState.Parent = this.BtnWed;
            this.BtnWed.Location = new System.Drawing.Point(150, 0);
            this.BtnWed.Name = "BtnWed";
            this.BtnWed.ShadowDecoration.Parent = this.BtnWed;
            this.BtnWed.Size = new System.Drawing.Size(75, 49);
            this.BtnWed.TabIndex = 2;
            this.BtnWed.Text = "THỨ TƯ";
            // 
            // BtnTue
            // 
            this.BtnTue.BorderColor = System.Drawing.Color.White;
            this.BtnTue.BorderRadius = 15;
            this.BtnTue.CheckedState.Parent = this.BtnTue;
            this.BtnTue.CustomImages.Parent = this.BtnTue;
            this.BtnTue.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnTue.FillColor = System.Drawing.Color.Transparent;
            this.BtnTue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTue.ForeColor = System.Drawing.Color.Black;
            this.BtnTue.HoverState.Parent = this.BtnTue;
            this.BtnTue.Location = new System.Drawing.Point(75, 0);
            this.BtnTue.Name = "BtnTue";
            this.BtnTue.ShadowDecoration.Parent = this.BtnTue;
            this.BtnTue.Size = new System.Drawing.Size(75, 49);
            this.BtnTue.TabIndex = 1;
            this.BtnTue.Text = "THỨ BA";
            // 
            // BtnMon
            // 
            this.BtnMon.BorderColor = System.Drawing.Color.White;
            this.BtnMon.BorderRadius = 15;
            this.BtnMon.CheckedState.Parent = this.BtnMon;
            this.BtnMon.CustomImages.Parent = this.BtnMon;
            this.BtnMon.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMon.FillColor = System.Drawing.Color.Transparent;
            this.BtnMon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMon.ForeColor = System.Drawing.Color.Black;
            this.BtnMon.HoverState.Parent = this.BtnMon;
            this.BtnMon.Location = new System.Drawing.Point(0, 0);
            this.BtnMon.Name = "BtnMon";
            this.BtnMon.ShadowDecoration.Parent = this.BtnMon;
            this.BtnMon.Size = new System.Drawing.Size(75, 49);
            this.BtnMon.TabIndex = 0;
            this.BtnMon.Text = "THỨ HAI";
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.BtnNext.IconColor = System.Drawing.Color.Black;
            this.BtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnNext.Location = new System.Drawing.Point(470, 54);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(55, 50);
            this.BtnNext.TabIndex = 29;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.Nextbtn_Click);
            // 
            // BtnPre
            // 
            this.BtnPre.BackColor = System.Drawing.Color.Transparent;
            this.BtnPre.FlatAppearance.BorderSize = 0;
            this.BtnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPre.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.BtnPre.IconColor = System.Drawing.Color.Black;
            this.BtnPre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnPre.Location = new System.Drawing.Point(3, 53);
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.Size = new System.Drawing.Size(55, 50);
            this.BtnPre.TabIndex = 28;
            this.BtnPre.UseVisualStyleBackColor = false;
            this.BtnPre.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(254, 2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(93, 57);
            this.guna2CirclePictureBox1.TabIndex = 27;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DisplayCalendarPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPre);
            this.Controls.Add(this.dtpk);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.PanelMatrix);
            this.Controls.Add(this.BackToDateBtn);
            this.Controls.Add(this.DigitalClock);
            this.Controls.Add(this.panelDOW);
            this.Name = "DisplayCalendarPlus";
            this.Size = new System.Drawing.Size(535, 590);
            this.Load += new System.EventHandler(this.LichDuong_Load);
            this.panelDOW.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnNext;
        private FontAwesome.Sharp.IconButton BtnPre;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Panel PanelMatrix;
        private XanderUI.XUIButton BackToDateBtn;
        private System.Windows.Forms.Label DigitalClock;
        private System.Windows.Forms.Panel panelDOW;
        private Guna.UI2.WinForms.Guna2Button BtnSun;
        private Guna.UI2.WinForms.Guna2Button BtnSat;
        private Guna.UI2.WinForms.Guna2Button BtnFri;
        private Guna.UI2.WinForms.Guna2Button BtnThu;
        private Guna.UI2.WinForms.Guna2Button BtnWed;
        private Guna.UI2.WinForms.Guna2Button BtnTue;
        private Guna.UI2.WinForms.Guna2Button BtnMon;
        private System.Windows.Forms.Timer timer1;
    }
}
