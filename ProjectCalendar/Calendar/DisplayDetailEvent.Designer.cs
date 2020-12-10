
namespace Calendar
{
    partial class DisplayDetailEvent
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
            this.PanelGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonName = new Guna.UI2.WinForms.Guna2Button();
            this.PanelGeneral.SuspendLayout();
            this.PanelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.PanelName);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.ShadowDecoration.Parent = this.PanelGeneral;
            this.PanelGeneral.Size = new System.Drawing.Size(530, 590);
            this.PanelGeneral.TabIndex = 0;
            // 
            // PanelName
            // 
            this.PanelName.Controls.Add(this.ButtonName);
            this.PanelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelName.Location = new System.Drawing.Point(0, 0);
            this.PanelName.Name = "PanelName";
            this.PanelName.ShadowDecoration.Parent = this.PanelName;
            this.PanelName.Size = new System.Drawing.Size(530, 50);
            this.PanelName.TabIndex = 0;
            // 
            // ButtonName
            // 
            this.ButtonName.CheckedState.Parent = this.ButtonName;
            this.ButtonName.CustomImages.Parent = this.ButtonName;
            this.ButtonName.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonName.ForeColor = System.Drawing.Color.White;
            this.ButtonName.HoverState.Parent = this.ButtonName;
            this.ButtonName.Location = new System.Drawing.Point(0, 0);
            this.ButtonName.Name = "ButtonName";
            this.ButtonName.ShadowDecoration.Parent = this.ButtonName;
            this.ButtonName.Size = new System.Drawing.Size(530, 50);
            this.ButtonName.TabIndex = 0;
            this.ButtonName.Text = "guna2Button1";
            // 
            // DisplayDetailEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelGeneral);
            this.Name = "DisplayDetailEvent";
            this.Size = new System.Drawing.Size(530, 590);
            this.PanelGeneral.ResumeLayout(false);
            this.PanelName.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelGeneral;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private Guna.UI2.WinForms.Guna2Button ButtonName;
    }
}
