
namespace Calendar
{
    partial class DisplayTutorial
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
            this.rtbRead = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbRead
            // 
            this.rtbRead.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRead.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rtbRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRead.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRead.Location = new System.Drawing.Point(0, 0);
            this.rtbRead.Name = "rtbRead";
            this.rtbRead.Size = new System.Drawing.Size(1009, 620);
            this.rtbRead.TabIndex = 0;
            this.rtbRead.Text = "";
            // 
            // DisplayTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.rtbRead);
            this.Name = "DisplayTutorial";
            this.Size = new System.Drawing.Size(1009, 620);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbRead;
    }
}
