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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralNoteForm));
            this.PreviousBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.TodoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeadlineBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NextBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.HideBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DeadlineLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddJobBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.CheckedState.Parent = this.PreviousBtn;
            this.PreviousBtn.CustomImages.Parent = this.PreviousBtn;
            this.PreviousBtn.FillColor = System.Drawing.Color.Silver;
            this.PreviousBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PreviousBtn.ForeColor = System.Drawing.Color.White;
            this.PreviousBtn.HoverState.Parent = this.PreviousBtn;
            this.PreviousBtn.Location = new System.Drawing.Point(207, 51);
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
            this.guna2Panel1.Controls.Add(this.TodoBtn);
            this.guna2Panel1.Controls.Add(this.DeadlineBtn);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(812, 45);
            this.guna2Panel1.TabIndex = 7;
            // 
            // TodoBtn
            // 
            this.TodoBtn.BackColor = System.Drawing.Color.Transparent;
            this.TodoBtn.CheckedState.Parent = this.TodoBtn;
            this.TodoBtn.CustomImages.Parent = this.TodoBtn;
            this.TodoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TodoBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodoBtn.ForeColor = System.Drawing.Color.Black;
            this.TodoBtn.HoverState.Parent = this.TodoBtn;
            this.TodoBtn.Location = new System.Drawing.Point(0, 0);
            this.TodoBtn.Name = "TodoBtn";
            this.TodoBtn.ShadowDecoration.Parent = this.TodoBtn;
            this.TodoBtn.Size = new System.Drawing.Size(406, 45);
            this.TodoBtn.TabIndex = 0;
            this.TodoBtn.Text = "Công việc trong ngày";
            this.TodoBtn.Click += new System.EventHandler(this.ToDoBtn_Click);
            // 
            // DeadlineBtn
            // 
            this.DeadlineBtn.CheckedState.Parent = this.DeadlineBtn;
            this.DeadlineBtn.CustomImages.Parent = this.DeadlineBtn;
            this.DeadlineBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DeadlineBtn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineBtn.ForeColor = System.Drawing.Color.Black;
            this.DeadlineBtn.HoverState.Parent = this.DeadlineBtn;
            this.DeadlineBtn.Location = new System.Drawing.Point(406, 0);
            this.DeadlineBtn.Name = "DeadlineBtn";
            this.DeadlineBtn.ShadowDecoration.Parent = this.DeadlineBtn;
            this.DeadlineBtn.Size = new System.Drawing.Size(406, 45);
            this.DeadlineBtn.TabIndex = 1;
            this.DeadlineBtn.Text = "Deadlines phải hoàn thành";
            this.DeadlineBtn.Click += new System.EventHandler(this.DeadlineBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.CheckedState.Parent = this.NextBtn;
            this.NextBtn.CustomImages.Parent = this.NextBtn;
            this.NextBtn.FillColor = System.Drawing.Color.Silver;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NextBtn.ForeColor = System.Drawing.Color.White;
            this.NextBtn.HoverState.Parent = this.NextBtn;
            this.NextBtn.Location = new System.Drawing.Point(574, 51);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.ShadowDecoration.Parent = this.NextBtn;
            this.NextBtn.Size = new System.Drawing.Size(31, 36);
            this.NextBtn.TabIndex = 10;
            this.NextBtn.Text = ">";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Dtpk
            // 
            this.Dtpk.CheckedState.Parent = this.Dtpk;
            this.Dtpk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Dtpk.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Dtpk.HoverState.Parent = this.Dtpk;
            this.Dtpk.Location = new System.Drawing.Point(250, 51);
            this.Dtpk.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.Dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Dtpk.Name = "Dtpk";
            this.Dtpk.ShadowDecoration.Parent = this.Dtpk;
            this.Dtpk.Size = new System.Drawing.Size(312, 36);
            this.Dtpk.TabIndex = 6;
            this.Dtpk.Value = new System.DateTime(2020, 12, 19, 0, 0, 0, 0);
            this.Dtpk.ValueChanged += new System.EventHandler(this.Dtpk_ValueChanged);
            // 
            // HideBtn
            // 
            this.HideBtn.CheckedState.Parent = this.HideBtn;
            this.HideBtn.CustomImages.Parent = this.HideBtn;
            this.HideBtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.HideBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideBtn.ForeColor = System.Drawing.Color.White;
            this.HideBtn.HoverState.Parent = this.HideBtn;
            this.HideBtn.Location = new System.Drawing.Point(617, 51);
            this.HideBtn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.HideBtn.Name = "HideBtn";
            this.HideBtn.ShadowDecoration.Parent = this.HideBtn;
            this.HideBtn.Size = new System.Drawing.Size(180, 36);
            this.HideBtn.TabIndex = 11;
            this.HideBtn.Text = "Thoát";
            this.HideBtn.Click += new System.EventHandler(this.guna2Button1_Click);
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
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ControlPanel.Location = new System.Drawing.Point(0, 89);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(812, 542);
            this.ControlPanel.TabIndex = 13;
            // 
            // AddJobBtn
            // 
            this.AddJobBtn.CheckedState.Parent = this.AddJobBtn;
            this.AddJobBtn.CustomImages.Parent = this.AddJobBtn;
            this.AddJobBtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddJobBtn.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddJobBtn.ForeColor = System.Drawing.Color.White;
            this.AddJobBtn.HoverState.Parent = this.AddJobBtn;
            this.AddJobBtn.Location = new System.Drawing.Point(15, 51);
            this.AddJobBtn.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.AddJobBtn.Name = "AddJobBtn";
            this.AddJobBtn.ShadowDecoration.Parent = this.AddJobBtn;
            this.AddJobBtn.Size = new System.Drawing.Size(180, 36);
            this.AddJobBtn.TabIndex = 15;
            this.AddJobBtn.Text = "Thêm công việc";
            this.AddJobBtn.Click += new System.EventHandler(this.AddJobBtn_Click_1);
            // 
            // GeneralNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(812, 630);
            this.Controls.Add(this.AddJobBtn);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.HideBtn);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.Dtpk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneralNoteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GeneralNoteForm";
            this.Load += new System.EventHandler(this.GeneralNoteForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PreviousBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button DeadlineBtn;
        private Guna.UI2.WinForms.Guna2Button TodoBtn;
        private Guna.UI2.WinForms.Guna2Button NextBtn;
        public Guna.UI2.WinForms.Guna2DateTimePicker Dtpk;
        private Guna.UI2.WinForms.Guna2Button HideBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel DeadlineLabel;
        private System.Windows.Forms.FlowLayoutPanel ControlPanel;
        private Guna.UI2.WinForms.Guna2Button AddJobBtn;
    }
}