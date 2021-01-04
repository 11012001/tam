namespace Calendar
{
    partial class DisplayDay
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
            this.displayCountDay1 = new Calendar.DisplayCountDay();
            this.displayChangeDate1 = new Calendar.DisplayChangeDate();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.SuspendLayout();
            // 
            // displayCountDay1
            // 
            this.displayCountDay1.Location = new System.Drawing.Point(508, 0);
            this.displayCountDay1.Name = "displayCountDay1";
            this.displayCountDay1.Size = new System.Drawing.Size(505, 590);
            this.displayCountDay1.TabIndex = 0;
            // 
            // displayChangeDate1
            // 
            this.displayChangeDate1.Location = new System.Drawing.Point(-3, 0);
            this.displayChangeDate1.Name = "displayChangeDate1";
            this.displayChangeDate1.Size = new System.Drawing.Size(505, 620);
            this.displayChangeDate1.TabIndex = 1;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillThickness = 10;
            this.guna2VSeparator1.Location = new System.Drawing.Point(498, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 620);
            this.guna2VSeparator1.TabIndex = 2;
            // 
            // DisplayDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.displayChangeDate1);
            this.Controls.Add(this.displayCountDay1);
            this.Name = "DisplayDay";
            this.Size = new System.Drawing.Size(1009, 620);
            this.ResumeLayout(false);

        }

        #endregion

        private DisplayCountDay displayCountDay1;
        private DisplayChangeDate displayChangeDate1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}
