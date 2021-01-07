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
            this.HoursTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DetailsBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Notes = new Guna.UI2.WinForms.Guna2TextBox();
            this.LAbel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MinutesTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateLB = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HoursTB
            // 
            this.HoursTB.BorderColor = System.Drawing.Color.DarkGray;
            this.HoursTB.BorderThickness = 2;
            this.HoursTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HoursTB.DefaultText = "";
            this.HoursTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HoursTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HoursTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HoursTB.DisabledState.Parent = this.HoursTB;
            this.HoursTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HoursTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoursTB.FocusedState.Parent = this.HoursTB;
            this.HoursTB.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.HoursTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoursTB.HoverState.Parent = this.HoursTB;
            this.HoursTB.Location = new System.Drawing.Point(50, 10);
            this.HoursTB.Margin = new System.Windows.Forms.Padding(6);
            this.HoursTB.Name = "HoursTB";
            this.HoursTB.PasswordChar = '\0';
            this.HoursTB.PlaceholderText = "";
            this.HoursTB.ReadOnly = true;
            this.HoursTB.SelectedText = "";
            this.HoursTB.ShadowDecoration.Parent = this.HoursTB;
            this.HoursTB.Size = new System.Drawing.Size(78, 29);
            this.HoursTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.HoursTB.TabIndex = 55;
            this.HoursTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DetailsBtn.IconColor = System.Drawing.Color.Black;
            this.DetailsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailsBtn.Location = new System.Drawing.Point(617, 0);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(76, 39);
            this.DetailsBtn.TabIndex = 67;
            this.DetailsBtn.Text = "Chi tiết";
            this.DetailsBtn.UseVisualStyleBackColor = true;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 30;
            this.DeleteBtn.Location = new System.Drawing.Point(702, 0);
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
            this.EditBtn.Location = new System.Drawing.Point(749, 0);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(35, 39);
            this.EditBtn.TabIndex = 65;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 10);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 64;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 45);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 63;
            this.iconPictureBox1.TabStop = false;
            // 
            // Notes
            // 
            this.Notes.BorderColor = System.Drawing.Color.DarkGray;
            this.Notes.BorderThickness = 2;
            this.Notes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Notes.DefaultText = "";
            this.Notes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Notes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Notes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Notes.DisabledState.Parent = this.Notes;
            this.Notes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Notes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notes.FocusedState.Parent = this.Notes;
            this.Notes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Notes.HoverState.Parent = this.Notes;
            this.Notes.Location = new System.Drawing.Point(50, 45);
            this.Notes.Margin = new System.Windows.Forms.Padding(6);
            this.Notes.Name = "Notes";
            this.Notes.PasswordChar = '\0';
            this.Notes.PlaceholderText = "";
            this.Notes.ReadOnly = true;
            this.Notes.SelectedText = "";
            this.Notes.ShadowDecoration.Parent = this.Notes;
            this.Notes.Size = new System.Drawing.Size(734, 29);
            this.Notes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Notes.TabIndex = 62;
            // 
            // LAbel
            // 
            this.LAbel.BackColor = System.Drawing.Color.Transparent;
            this.LAbel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAbel.Location = new System.Drawing.Point(140, 10);
            this.LAbel.Margin = new System.Windows.Forms.Padding(6);
            this.LAbel.Name = "LAbel";
            this.LAbel.Size = new System.Drawing.Size(15, 26);
            this.LAbel.TabIndex = 57;
            this.LAbel.Text = ":";
            // 
            // MinutesTB
            // 
            this.MinutesTB.BorderColor = System.Drawing.Color.DarkGray;
            this.MinutesTB.BorderThickness = 2;
            this.MinutesTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinutesTB.DefaultText = "";
            this.MinutesTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MinutesTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinutesTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinutesTB.DisabledState.Parent = this.MinutesTB;
            this.MinutesTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinutesTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinutesTB.FocusedState.Parent = this.MinutesTB;
            this.MinutesTB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MinutesTB.HoverState.Parent = this.MinutesTB;
            this.MinutesTB.Location = new System.Drawing.Point(167, 10);
            this.MinutesTB.Margin = new System.Windows.Forms.Padding(6);
            this.MinutesTB.Name = "MinutesTB";
            this.MinutesTB.PasswordChar = '\0';
            this.MinutesTB.PlaceholderText = "";
            this.MinutesTB.ReadOnly = true;
            this.MinutesTB.SelectedText = "";
            this.MinutesTB.ShadowDecoration.Parent = this.MinutesTB;
            this.MinutesTB.Size = new System.Drawing.Size(78, 29);
            this.MinutesTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MinutesTB.TabIndex = 56;
            this.MinutesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DateLB
            // 
            this.DateLB.BackColor = System.Drawing.Color.Transparent;
            this.DateLB.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLB.Location = new System.Drawing.Point(265, 9);
            this.DateLB.Name = "DateLB";
            this.DateLB.Size = new System.Drawing.Size(51, 26);
            this.DateLB.TabIndex = 69;
            this.DateLB.Text = "Date";
            // 
            // DeadLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DateLB);
            this.Controls.Add(this.HoursTB);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.LAbel);
            this.Controls.Add(this.MinutesTB);
            this.Name = "DeadLineControl";
            this.Size = new System.Drawing.Size(790, 81);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox HoursTB;
        private FontAwesome.Sharp.IconButton DetailsBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Notes;
        private Guna.UI2.WinForms.Guna2HtmlLabel LAbel;
        private Guna.UI2.WinForms.Guna2TextBox MinutesTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel DateLB;
    }
}
