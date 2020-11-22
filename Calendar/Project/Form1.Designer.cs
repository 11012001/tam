namespace Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendar));
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.displayDate = new Project.DisplayDate();
            this.displayCalendar = new Project.DisplayCalendar();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonDate = new System.Windows.Forms.Button();
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.weatherForecastDisplay = new Project.WeatherForecastDisplay();
            this.panelDisplay.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.weatherForecastDisplay);
            this.panelDisplay.Controls.Add(this.displayDate);
            this.panelDisplay.Controls.Add(this.displayCalendar);
            resources.ApplyResources(this.panelDisplay, "panelDisplay");
            this.panelDisplay.Name = "panelDisplay";
            // 
            // displayDate
            // 
            this.displayDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.displayDate, "displayDate");
            this.displayDate.Name = "displayDate";
            // 
            // displayCalendar
            // 
            resources.ApplyResources(this.displayCalendar, "displayCalendar");
            this.displayCalendar.Name = "displayCalendar";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonDate);
            this.panelControl.Controls.Add(this.buttonCalendar);
            resources.ApplyResources(this.panelControl, "panelControl");
            this.panelControl.Name = "panelControl";
            // 
            // buttonDate
            // 
            resources.ApplyResources(this.buttonDate, "buttonDate");
            this.buttonDate.Name = "buttonDate";
            this.buttonDate.UseVisualStyleBackColor = true;
            this.buttonDate.Click += new System.EventHandler(this.buttonDate_Click);
            // 
            // buttonCalendar
            // 
            resources.ApplyResources(this.buttonCalendar, "buttonCalendar");
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // weatherForecastDisplay
            // 
            resources.ApplyResources(this.weatherForecastDisplay, "weatherForecastDisplay");
            this.weatherForecastDisplay.Name = "weatherForecastDisplay";
            // 
            // Calendar
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelDisplay);
            this.Name = "Calendar";
            this.panelDisplay.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDisplay;
        private DisplayDate displayDate;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonDate;
        private System.Windows.Forms.Button buttonCalendar;
        private DisplayCalendar displayCalendar;
        private WeatherForecastDisplay weatherForecastDisplay;
    }
}

