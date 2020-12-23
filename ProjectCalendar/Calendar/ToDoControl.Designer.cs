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
            this.FHours = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.DetailsBtn = new FontAwesome.Sharp.IconButton();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.EditBtn = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Notes = new Guna.UI2.WinForms.Guna2TextBox();
            this.TMinutes = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.THours = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LAbel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FMinutes = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FHours
            // 
            this.FHours.BorderColor = System.Drawing.Color.DarkGray;
            this.FHours.BorderThickness = 2;
            this.FHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FHours.DefaultText = "";
            this.FHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FHours.DisabledState.Parent = this.FHours;
            this.FHours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FHours.FocusedState.Parent = this.FHours;
            this.FHours.Font = new System.Drawing.Font("Consolas", 15.75F);
            this.FHours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FHours.HoverState.Parent = this.FHours;
            this.FHours.Location = new System.Drawing.Point(50, 14);
            this.FHours.Margin = new System.Windows.Forms.Padding(6);
            this.FHours.Name = "FHours";
            this.FHours.PasswordChar = '\0';
            this.FHours.PlaceholderText = "";
            this.FHours.ReadOnly = true;
            this.FHours.SelectedText = "";
            this.FHours.ShadowDecoration.Parent = this.FHours;
            this.FHours.Size = new System.Drawing.Size(78, 29);
            this.FHours.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FHours.TabIndex = 15;
            this.FHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // DetailsBtn
            // 
            this.DetailsBtn.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DetailsBtn.IconColor = System.Drawing.Color.Black;
            this.DetailsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DetailsBtn.Location = new System.Drawing.Point(639, 8);
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
            this.DeleteBtn.Location = new System.Drawing.Point(724, 8);
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
            this.EditBtn.Location = new System.Drawing.Point(771, 8);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(35, 39);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click_1);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(6, 14);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 24;
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
            this.iconPictureBox1.Location = new System.Drawing.Point(6, 49);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 23;
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
            this.Notes.Location = new System.Drawing.Point(50, 49);
            this.Notes.Margin = new System.Windows.Forms.Padding(6);
            this.Notes.Name = "Notes";
            this.Notes.PasswordChar = '\0';
            this.Notes.PlaceholderText = "";
            this.Notes.ReadOnly = true;
            this.Notes.SelectedText = "";
            this.Notes.ShadowDecoration.Parent = this.Notes;
            this.Notes.Size = new System.Drawing.Size(756, 29);
            this.Notes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Notes.TabIndex = 22;
            // 
            // TMinutes
            // 
            this.TMinutes.BorderColor = System.Drawing.Color.DarkGray;
            this.TMinutes.BorderThickness = 2;
            this.TMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TMinutes.DefaultText = "";
            this.TMinutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TMinutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TMinutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TMinutes.DisabledState.Parent = this.TMinutes;
            this.TMinutes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TMinutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMinutes.FocusedState.Parent = this.TMinutes;
            this.TMinutes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TMinutes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TMinutes.HoverState.Parent = this.TMinutes;
            this.TMinutes.Location = new System.Drawing.Point(401, 14);
            this.TMinutes.Margin = new System.Windows.Forms.Padding(6);
            this.TMinutes.Name = "TMinutes";
            this.TMinutes.PasswordChar = '\0';
            this.TMinutes.PlaceholderText = "";
            this.TMinutes.ReadOnly = true;
            this.TMinutes.SelectedText = "";
            this.TMinutes.ShadowDecoration.Parent = this.TMinutes;
            this.TMinutes.Size = new System.Drawing.Size(78, 29);
            this.TMinutes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TMinutes.TabIndex = 21;
            this.TMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(374, 14);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(15, 26);
            this.guna2HtmlLabel2.TabIndex = 20;
            this.guna2HtmlLabel2.Text = ":";
            // 
            // THours
            // 
            this.THours.BorderColor = System.Drawing.Color.DarkGray;
            this.THours.BorderThickness = 2;
            this.THours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.THours.DefaultText = "";
            this.THours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.THours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.THours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.THours.DisabledState.Parent = this.THours;
            this.THours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.THours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.THours.FocusedState.Parent = this.THours;
            this.THours.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.THours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.THours.HoverState.Parent = this.THours;
            this.THours.Location = new System.Drawing.Point(284, 14);
            this.THours.Margin = new System.Windows.Forms.Padding(6);
            this.THours.Name = "THours";
            this.THours.PasswordChar = '\0';
            this.THours.PlaceholderText = "";
            this.THours.ReadOnly = true;
            this.THours.SelectedText = "";
            this.THours.ShadowDecoration.Parent = this.THours;
            this.THours.Size = new System.Drawing.Size(78, 29);
            this.THours.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.THours.TabIndex = 19;
            this.THours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(257, 14);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(15, 26);
            this.guna2HtmlLabel1.TabIndex = 18;
            this.guna2HtmlLabel1.Text = "-";
            // 
            // LAbel
            // 
            this.LAbel.BackColor = System.Drawing.Color.Transparent;
            this.LAbel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAbel.Location = new System.Drawing.Point(140, 14);
            this.LAbel.Margin = new System.Windows.Forms.Padding(6);
            this.LAbel.Name = "LAbel";
            this.LAbel.Size = new System.Drawing.Size(15, 26);
            this.LAbel.TabIndex = 17;
            this.LAbel.Text = ":";
            // 
            // FMinutes
            // 
            this.FMinutes.BorderColor = System.Drawing.Color.DarkGray;
            this.FMinutes.BorderThickness = 2;
            this.FMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FMinutes.DefaultText = "";
            this.FMinutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FMinutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FMinutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FMinutes.DisabledState.Parent = this.FMinutes;
            this.FMinutes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FMinutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FMinutes.FocusedState.Parent = this.FMinutes;
            this.FMinutes.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMinutes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FMinutes.HoverState.Parent = this.FMinutes;
            this.FMinutes.Location = new System.Drawing.Point(167, 14);
            this.FMinutes.Margin = new System.Windows.Forms.Padding(6);
            this.FMinutes.Name = "FMinutes";
            this.FMinutes.PasswordChar = '\0';
            this.FMinutes.PlaceholderText = "";
            this.FMinutes.ReadOnly = true;
            this.FMinutes.SelectedText = "";
            this.FMinutes.ShadowDecoration.Parent = this.FMinutes;
            this.FMinutes.Size = new System.Drawing.Size(78, 29);
            this.FMinutes.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FMinutes.TabIndex = 16;
            this.FMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToDoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FHours);
            this.Controls.Add(this.DetailsBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.TMinutes);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.THours);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.LAbel);
            this.Controls.Add(this.FMinutes);
            this.Name = "ToDoControl";
            this.Size = new System.Drawing.Size(812, 86);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox FHours;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private FontAwesome.Sharp.IconButton DetailsBtn;
        private FontAwesome.Sharp.IconButton DeleteBtn;
        private FontAwesome.Sharp.IconButton EditBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Notes;
        private Guna.UI2.WinForms.Guna2TextBox TMinutes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox THours;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel LAbel;
        private Guna.UI2.WinForms.Guna2TextBox FMinutes;
    }
}
