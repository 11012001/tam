namespace Calendar
{
    partial class DeadLineControl
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
            this.DetailsBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Colon = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DateLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Notes = new System.Windows.Forms.Label();
            this.HoursLB = new System.Windows.Forms.Label();
            this.MinutesLB = new System.Windows.Forms.Label();
            this.SeparatorLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DoneCB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.BackColor = System.Drawing.Color.Transparent;
            this.DetailsBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DetailsBtn.IconColor = System.Drawing.Color.Black;
            this.DetailsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailsBtn.Location = new System.Drawing.Point(617, 44);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(76, 39);
            this.DetailsBtn.TabIndex = 67;
            this.DetailsBtn.Text = "Chi tiết";
            this.DetailsBtn.UseVisualStyleBackColor = false;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 30;
            this.DeleteBtn.Location = new System.Drawing.Point(702, 44);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(35, 39);
            this.DeleteBtn.TabIndex = 66;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.EditBtn.IconColor = System.Drawing.Color.Black;
            this.EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn.IconSize = 30;
            this.EditBtn.Location = new System.Drawing.Point(749, 44);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(35, 39);
            this.EditBtn.TabIndex = 65;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 28;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 50);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 28);
            this.iconPictureBox2.TabIndex = 64;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 9);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 63;
            this.iconPictureBox1.TabStop = false;
            // 
            // Colon
            // 
            this.Colon.BackColor = System.Drawing.Color.Transparent;
            this.Colon.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colon.Location = new System.Drawing.Point(146, 44);
            this.Colon.Margin = new System.Windows.Forms.Padding(6);
            this.Colon.Name = "Colon";
            this.Colon.Size = new System.Drawing.Size(18, 34);
            this.Colon.TabIndex = 57;
            this.Colon.Text = ":";
            // 
            // DateLB
            // 
            this.DateLB.BackColor = System.Drawing.Color.Transparent;
            this.DateLB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLB.Location = new System.Drawing.Point(329, 44);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(63, 34);
            this.DateLB.TabIndex = 69;
            this.DateLB.Text = "Date";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(47, 6);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(90, 32);
            this.Notes.TabIndex = 70;
            this.Notes.Text = "Notes";
            // 
            // HoursLB
            // 
            this.HoursLB.AutoSize = true;
            this.HoursLB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLB.Location = new System.Drawing.Point(47, 46);
            this.HoursLB.Name = "HoursLB";
            this.HoursLB.Size = new System.Drawing.Size(90, 32);
            this.HoursLB.TabIndex = 73;
            this.HoursLB.Text = "Hours";
            // 
            // MinutesLB
            // 
            this.MinutesLB.AutoSize = true;
            this.MinutesLB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesLB.Location = new System.Drawing.Point(173, 46);
            this.MinutesLB.Name = "MinutesLB";
            this.MinutesLB.Size = new System.Drawing.Size(120, 32);
            this.MinutesLB.TabIndex = 74;
            this.MinutesLB.Text = "Minutes";
            // 
            // SeparatorLB
            // 
            this.SeparatorLB.BackColor = System.Drawing.Color.Transparent;
            this.SeparatorLB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeparatorLB.Location = new System.Drawing.Point(302, 44);
            this.SeparatorLB.Margin = new System.Windows.Forms.Padding(6);
            this.SeparatorLB.Name = "SeparatorLB";
            this.SeparatorLB.Size = new System.Drawing.Size(18, 34);
            this.SeparatorLB.TabIndex = 75;
            this.SeparatorLB.Text = "|";
            // 
            // DoneCB
            // 
            this.DoneCB.AutoSize = true;
            this.DoneCB.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneCB.Location = new System.Drawing.Point(690, 2);
            this.DoneCB.Name = "DoneCB";
            this.DoneCB.Size = new System.Drawing.Size(94, 36);
            this.DoneCB.TabIndex = 76;
            this.DoneCB.Text = "Done";
            this.DoneCB.UseVisualStyleBackColor = true;
            this.DoneCB.CheckedChanged += new System.EventHandler(this.DoneCB_CheckedChanged);
            // 
            // DeadLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DoneCB);
            this.Controls.Add(this.SeparatorLB);
            this.Controls.Add(this.MinutesLB);
            this.Controls.Add(this.HoursLB);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Colon);
            this.Name = "DeadLineControl";
            this.Size = new System.Drawing.Size(790, 94);
            this.Load += new System.EventHandler(this.DeadLineControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton DetailsBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.CheckBox DoneCB;
        public Guna.UI2.WinForms.Guna2HtmlLabel Colon;
        public Guna.UI2.WinForms.Guna2HtmlLabel DateLB;
        public System.Windows.Forms.Label Notes;
        public System.Windows.Forms.Label HoursLB;
        public System.Windows.Forms.Label MinutesLB;
        public Guna.UI2.WinForms.Guna2HtmlLabel SeparatorLB;
    }
}
