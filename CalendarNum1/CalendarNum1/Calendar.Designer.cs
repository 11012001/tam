namespace CalendarNum1
{
    partial class Calendar
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
            this.Date = new System.Windows.Forms.Panel();
            this.DigitalClock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Saturday = new System.Windows.Forms.TextBox();
            this.Friday = new System.Windows.Forms.TextBox();
            this.Thursday = new System.Windows.Forms.TextBox();
            this.Wednesday = new System.Windows.Forms.TextBox();
            this.Tuesday = new System.Windows.Forms.TextBox();
            this.Monday = new System.Windows.Forms.TextBox();
            this.Sunday = new System.Windows.Forms.TextBox();
            this.MatrixPanel = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.NextBttn = new System.Windows.Forms.Button();
            this.PreviousBttn = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Date.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.AutoScroll = true;
            this.Date.Controls.Add(this.DigitalClock);
            this.Date.Location = new System.Drawing.Point(12, 12);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(234, 45);
            this.Date.TabIndex = 1;
            this.Date.Paint += new System.Windows.Forms.PaintEventHandler(this.Date_Paint);
            // 
            // DigitalClock
            // 
            this.DigitalClock.AutoSize = true;
            this.DigitalClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DigitalClock.Location = new System.Drawing.Point(42, 0);
            this.DigitalClock.Name = "DigitalClock";
            this.DigitalClock.Size = new System.Drawing.Size(175, 37);
            this.DigitalClock.TabIndex = 0;
            this.DigitalClock.Text = "00:00:00 A.M";
            this.DigitalClock.UseCompatibleTextRendering = true;
            this.DigitalClock.Click += new System.EventHandler(this.DigitalClock_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Saturday);
            this.panel1.Controls.Add(this.Friday);
            this.panel1.Controls.Add(this.Thursday);
            this.panel1.Controls.Add(this.Wednesday);
            this.panel1.Controls.Add(this.Tuesday);
            this.panel1.Controls.Add(this.Monday);
            this.panel1.Controls.Add(this.Sunday);
            this.panel1.Location = new System.Drawing.Point(12, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 31);
            this.panel1.TabIndex = 2;
            // 
            // Saturday
            // 
            this.Saturday.Location = new System.Drawing.Point(636, 3);
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Size = new System.Drawing.Size(93, 22);
            this.Saturday.TabIndex = 6;
            this.Saturday.Text = "Saturday";
            this.Saturday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Friday
            // 
            this.Friday.Location = new System.Drawing.Point(537, 3);
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Size = new System.Drawing.Size(93, 22);
            this.Friday.TabIndex = 5;
            this.Friday.Text = "Friday";
            this.Friday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thursday
            // 
            this.Thursday.Location = new System.Drawing.Point(438, 3);
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Size = new System.Drawing.Size(93, 22);
            this.Thursday.TabIndex = 4;
            this.Thursday.Text = "Thursday";
            this.Thursday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Thursday.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // Wednesday
            // 
            this.Wednesday.Location = new System.Drawing.Point(339, 3);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Size = new System.Drawing.Size(93, 22);
            this.Wednesday.TabIndex = 3;
            this.Wednesday.Text = "Wednesday";
            this.Wednesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tuesday
            // 
            this.Tuesday.Location = new System.Drawing.Point(240, 3);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Size = new System.Drawing.Size(93, 22);
            this.Tuesday.TabIndex = 2;
            this.Tuesday.Text = "Tuesday";
            this.Tuesday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Monday
            // 
            this.Monday.Location = new System.Drawing.Point(141, 3);
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Size = new System.Drawing.Size(93, 22);
            this.Monday.TabIndex = 1;
            this.Monday.Text = "Monday";
            this.Monday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sunday
            // 
            this.Sunday.Location = new System.Drawing.Point(42, 3);
            this.Sunday.Multiline = true;
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Size = new System.Drawing.Size(93, 22);
            this.Sunday.TabIndex = 0;
            this.Sunday.Text = "Sunday";
            this.Sunday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MatrixPanel
            // 
            this.MatrixPanel.Location = new System.Drawing.Point(54, 100);
            this.MatrixPanel.Name = "MatrixPanel";
            this.MatrixPanel.Size = new System.Drawing.Size(693, 338);
            this.MatrixPanel.TabIndex = 3;
            this.MatrixPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MatrixPanel_Paint);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(252, 9);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(291, 22);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // NextBttn
            // 
            this.NextBttn.Location = new System.Drawing.Point(678, 8);
            this.NextBttn.Name = "NextBttn";
            this.NextBttn.Size = new System.Drawing.Size(75, 23);
            this.NextBttn.TabIndex = 4;
            this.NextBttn.Text = ">";
            this.NextBttn.UseVisualStyleBackColor = true;
            this.NextBttn.Click += new System.EventHandler(this.NextBttn_Click);
            // 
            // PreviousBttn
            // 
            this.PreviousBttn.Location = new System.Drawing.Point(597, 8);
            this.PreviousBttn.Name = "PreviousBttn";
            this.PreviousBttn.Size = new System.Drawing.Size(75, 23);
            this.PreviousBttn.TabIndex = 5;
            this.PreviousBttn.Text = "<";
            this.PreviousBttn.UseVisualStyleBackColor = true;
            this.PreviousBttn.Click += new System.EventHandler(this.PreviousBttn_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PreviousBttn);
            this.Controls.Add(this.NextBttn);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.MatrixPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Date);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.Date.ResumeLayout(false);
            this.Date.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Saturday;
        private System.Windows.Forms.TextBox Friday;
        private System.Windows.Forms.TextBox Thursday;
        private System.Windows.Forms.TextBox Wednesday;
        private System.Windows.Forms.TextBox Tuesday;
        private System.Windows.Forms.TextBox Monday;
        private System.Windows.Forms.TextBox Sunday;
        private System.Windows.Forms.Panel MatrixPanel;
        public System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button NextBttn;
        private System.Windows.Forms.Button PreviousBttn;
        private System.Windows.Forms.Label DigitalClock;
        private System.Windows.Forms.Timer timer2;
    }
}

