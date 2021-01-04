namespace Calendar
{
    partial class GeneralNoteForm
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
            this.PreviousBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.ToDoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.AddJobBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DeadlineLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.CheckedState.Parent = this.PreviousBtn;
            this.PreviousBtn.CustomImages.Parent = this.PreviousBtn;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviousBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousBtn.HoverState.Parent = this.PreviousBtn;
            this.PreviousBtn.Location = new System.Drawing.Point(242, 51);
            this.PreviousBtn.Margin = new System.Windows.Forms.Padding(6);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.ShadowDecoration.Parent = this.PreviousBtn;
            this.PreviousBtn.Size = new System.Drawing.Size(31, 36);
            this.PreviousBtn.TabIndex = 9;
            this.PreviousBtn.Text = "<";
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.ToDoBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(812, 45);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(406, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(406, 45);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Deadlines phải hoàn thành";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // ToDoBtn
            // 
            this.ToDoBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ToDoBtn.CheckedState.Parent = this.ToDoBtn;
            this.ToDoBtn.CustomImages.Parent = this.ToDoBtn;
            this.ToDoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ToDoBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDoBtn.ForeColor = System.Drawing.Color.Black;
            this.ToDoBtn.HoverState.Parent = this.ToDoBtn;
            this.ToDoBtn.Location = new System.Drawing.Point(0, 0);
            this.ToDoBtn.Name = "ToDoBtn";
            this.ToDoBtn.ShadowDecoration.Parent = this.ToDoBtn;
            this.ToDoBtn.Size = new System.Drawing.Size(406, 45);
            this.ToDoBtn.TabIndex = 0;
            this.ToDoBtn.Text = "Công việc trong ngày";
            this.ToDoBtn.Click += new System.EventHandler(this.ToDoBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.CheckedState.Parent = this.NextBtn;
            this.NextBtn.CustomImages.Parent = this.NextBtn;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.HoverState.Parent = this.NextBtn;
            this.NextBtn.Location = new System.Drawing.Point(539, 51);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.ShadowDecoration.Parent = this.NextBtn;
            this.NextBtn.Size = new System.Drawing.Size(31, 36);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = ">";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.CheckedState.Parent = this.AddJobBtn;
            this.AddJobBtn.CustomImages.Parent = this.AddJobBtn;
            this.AddJobBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJobBtn.ForeColor = System.Drawing.Color.White;
            this.AddJobBtn.HoverState.Parent = this.AddJobBtn;
            this.AddJobBtn.Location = new System.Drawing.Point(12, 51);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.ShadowDecoration.Parent = this.AddJobBtn;
            this.AddJobBtn.Size = new System.Drawing.Size(180, 36);
            this.AddJobBtn.TabIndex = 8;
            this.AddJobBtn.Text = "Thêm công việc";
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click_1);
            // 
            // Dtpk
            // 
            this.Dtpk.CheckedState.Parent = this.Dtpk;
            this.Dtpk.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtpk.HoverState.Parent = this.Dtpk;
            this.Dtpk.Location = new System.Drawing.Point(285, 51);
            this.Dtpk.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtpk.Name = "Dtpk";
            this.Dtpk.ShadowDecoration.Parent = this.Dtpk;
            this.Dtpk.Size = new System.Drawing.Size(242, 36);
            this.Dtpk.TabIndex = 6;
            this.Dtpk.Value = new System.DateTime(2020, 12, 19, 0, 0, 0, 0);
            this.Dtpk.ValueChanged += new System.EventHandler(this.Dtpk_ValueChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(617, 51);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 36);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "Thoát";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeadlineLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineLabel.Location = new System.Drawing.Point(260, 57);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(291, 26);
            this.DeadlineLabel.TabIndex = 12;
            this.DeadlineLabel.Text = "Deadline theo độ ưu tiên";
            // 
            // ControlPanel
            // 
            this.ControlPanel.AutoScroll = true;
            this.ControlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlPanel.Location = new System.Drawing.Point(0, 89);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(812, 542);
            this.ControlPanel.TabIndex = 13;
            // 
            // GeneralNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 630);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.AddJobBtn);
            this.Controls.Add(this.Dtpk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GeneralNoteForm";
            this.Text = "GeneralNoteForm";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PreviousBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button ToDoBtn;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        private Guna.UI2.WinForms.Guna2GradientButton AddJobBtn;
        public Guna.UI2.WinForms.Guna2DateTimePicker Dtpk;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel DeadlineLabel;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
    }
}