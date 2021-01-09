namespace Calendar
{
    partial class ToDoControl
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
            this.Notes = new System.Windows.Forms.Label();
            this.FHours = new System.Windows.Forms.Label();
            this.Conlon1 = new System.Windows.Forms.Label();
            this.FMinutes = new System.Windows.Forms.Label();
            this.Separator = new System.Windows.Forms.Label();
            this.THours = new System.Windows.Forms.Label();
            this.Conlon2 = new System.Windows.Forms.Label();
            this.TMinutes = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DetailsBtn.IconColor = System.Drawing.Color.Black;
            this.DetailsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailsBtn.Location = new System.Drawing.Point(617, 3);
            this.DetailsBtn.Name = "DetailsBtn";
            this.DetailsBtn.Size = new System.Drawing.Size(76, 39);
            this.DetailsBtn.TabIndex = 27;
            this.DetailsBtn.Text = "Chi tiết";
            this.DetailsBtn.UseVisualStyleBackColor = true;
            this.DetailsBtn.Click += new System.EventHandler(this.DetailsBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteBtn.IconSize = 30;
            this.DeleteBtn.Location = new System.Drawing.Point(702, 3);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(35, 39);
            this.DeleteBtn.TabIndex = 26;
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click_1);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditBtn.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.EditBtn.IconColor = System.Drawing.Color.Black;
            this.EditBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditBtn.IconSize = 30;
            this.EditBtn.Location = new System.Drawing.Point(749, 6);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(35, 39);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 48);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 24;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 6);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 23;
            this.iconPictureBox1.TabStop = false;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notes.Location = new System.Drawing.Point(77, 4);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(90, 32);
            this.Notes.TabIndex = 28;
            this.Notes.Text = "Notes";
            // 
            // FHours
            // 
            this.FHours.AutoSize = true;
            this.FHours.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FHours.Location = new System.Drawing.Point(77, 45);
            this.FHours.Name = "FHours";
            this.FHours.Size = new System.Drawing.Size(90, 32);
            this.FHours.TabIndex = 29;
            this.FHours.Text = "Hours";
            // 
            // Conlon1
            // 
            this.Conlon1.AutoSize = true;
            this.Conlon1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conlon1.Location = new System.Drawing.Point(173, 45);
            this.Conlon1.Name = "Conlon1";
            this.Conlon1.Size = new System.Drawing.Size(30, 32);
            this.Conlon1.TabIndex = 30;
            this.Conlon1.Text = ":";
            // 
            // FMinutes
            // 
            this.FMinutes.AutoSize = true;
            this.FMinutes.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMinutes.Location = new System.Drawing.Point(199, 45);
            this.FMinutes.Name = "FMinutes";
            this.FMinutes.Size = new System.Drawing.Size(120, 32);
            this.FMinutes.TabIndex = 31;
            this.FMinutes.Text = "Minutes";
            // 
            // Separator
            // 
            this.Separator.AutoSize = true;
            this.Separator.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Separator.Location = new System.Drawing.Point(325, 45);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(30, 32);
            this.Separator.TabIndex = 32;
            this.Separator.Text = "-";
            // 
            // THours
            // 
            this.THours.AutoSize = true;
            this.THours.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THours.Location = new System.Drawing.Point(361, 45);
            this.THours.Name = "THours";
            this.THours.Size = new System.Drawing.Size(90, 32);
            this.THours.TabIndex = 33;
            this.THours.Text = "Hours";
            // 
            // Conlon2
            // 
            this.Conlon2.AutoSize = true;
            this.Conlon2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conlon2.Location = new System.Drawing.Point(457, 45);
            this.Conlon2.Name = "Conlon2";
            this.Conlon2.Size = new System.Drawing.Size(30, 32);
            this.Conlon2.TabIndex = 34;
            this.Conlon2.Text = ":";
            // 
            // TMinutes
            // 
            this.TMinutes.AutoSize = true;
            this.TMinutes.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinutes.Location = new System.Drawing.Point(493, 45);
            this.TMinutes.Name = "TMinutes";
            this.TMinutes.Size = new System.Drawing.Size(120, 32);
            this.TMinutes.TabIndex = 35;
            this.TMinutes.Text = "Minutes";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 4;
            this.guna2VSeparator1.Location = new System.Drawing.Point(47, 6);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 71);
            this.guna2VSeparator1.TabIndex = 78;
            // 
            // ToDoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.TMinutes);
            this.Controls.Add(this.Conlon2);
            this.Controls.Add(this.THours);
            this.Controls.Add(this.Separator);
            this.Controls.Add(this.FMinutes);
            this.Controls.Add(this.Conlon1);
            this.Controls.Add(this.FHours);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "ToDoControl";
            this.Size = new System.Drawing.Size(790, 86);
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
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Label FHours;
        private System.Windows.Forms.Label Conlon1;
        private System.Windows.Forms.Label FMinutes;
        private System.Windows.Forms.Label Separator;
        private System.Windows.Forms.Label THours;
        private System.Windows.Forms.Label Conlon2;
        private System.Windows.Forms.Label TMinutes;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}
