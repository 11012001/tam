
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelVN = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpk = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonName = new Guna.UI2.WinForms.Guna2Button();
            this.calendarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonVN = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewVN = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelWorld = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonWorld = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelGeneral.SuspendLayout();
            this.PanelVN.SuspendLayout();
            this.PanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVN)).BeginInit();
            this.PanelWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTG)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.PanelWorld);
            this.PanelGeneral.Controls.Add(this.PanelVN);
            this.PanelGeneral.Controls.Add(this.dtpk);
            this.PanelGeneral.Controls.Add(this.PanelName);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.ShadowDecoration.Parent = this.PanelGeneral;
            this.PanelGeneral.Size = new System.Drawing.Size(530, 590);
            this.PanelGeneral.TabIndex = 0;
            // 
            // PanelVN
            // 
            this.PanelVN.Controls.Add(this.DataGridViewVN);
            this.PanelVN.Controls.Add(this.ButtonVN);
            this.PanelVN.Location = new System.Drawing.Point(0, 90);
            this.PanelVN.Name = "PanelVN";
            this.PanelVN.ShadowDecoration.Parent = this.PanelVN;
            this.PanelVN.Size = new System.Drawing.Size(530, 500);
            this.PanelVN.TabIndex = 2;
            // 
            // dtpk
            // 
            this.dtpk.CheckedState.Parent = this.dtpk;
            this.dtpk.CustomFormat = "dd/MM/yyyy";
            this.dtpk.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpk.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.HoverState.Parent = this.dtpk;
            this.dtpk.Location = new System.Drawing.Point(0, 50);
            this.dtpk.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpk.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpk.Name = "dtpk";
            this.dtpk.ShadowDecoration.Parent = this.dtpk;
            this.dtpk.Size = new System.Drawing.Size(530, 40);
            this.dtpk.TabIndex = 1;
            this.dtpk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpk.Value = new System.DateTime(2020, 12, 12, 22, 2, 0, 0);
            this.dtpk.ValueChanged += new System.EventHandler(this.dtpk_ValueChanged);
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
            this.ButtonName.Text = "SỰ KIỆN LỊCH SỬ";
            // 
            // ButtonVN
            // 
            this.ButtonVN.CheckedState.Parent = this.ButtonVN;
            this.ButtonVN.CustomImages.Parent = this.ButtonVN;
            this.ButtonVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonVN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonVN.ForeColor = System.Drawing.Color.White;
            this.ButtonVN.HoverState.Parent = this.ButtonVN;
            this.ButtonVN.Location = new System.Drawing.Point(0, 0);
            this.ButtonVN.Name = "ButtonVN";
            this.ButtonVN.ShadowDecoration.Parent = this.ButtonVN;
            this.ButtonVN.Size = new System.Drawing.Size(530, 45);
            this.ButtonVN.TabIndex = 0;
            this.ButtonVN.Text = "SỰ KIỆN TRONG NƯỚC";
            this.ButtonVN.Click += new System.EventHandler(this.ButtonVN_Click);
            // 
            // DataGridViewVN
            // 
            this.DataGridViewVN.AllowUserToAddRows = false;
            this.DataGridViewVN.AllowUserToDeleteRows = false;
            this.DataGridViewVN.AllowUserToResizeColumns = false;
            this.DataGridViewVN.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataGridViewVN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewVN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewVN.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewVN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVN.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridViewVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewVN.EnableHeadersVisualStyles = false;
            this.DataGridViewVN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVN.Location = new System.Drawing.Point(0, 45);
            this.DataGridViewVN.Name = "DataGridViewVN";
            this.DataGridViewVN.RowHeadersVisible = false;
            this.DataGridViewVN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewVN.Size = new System.Drawing.Size(530, 455);
            this.DataGridViewVN.TabIndex = 1;
            this.DataGridViewVN.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewVN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewVN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewVN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewVN.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVN.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewVN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewVN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewVN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewVN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewVN.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewVN.ThemeStyle.ReadOnly = false;
            this.DataGridViewVN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewVN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewVN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewVN.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewVN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewVN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PanelWorld
            // 
            this.PanelWorld.Controls.Add(this.ButtonWorld);
            this.PanelWorld.Controls.Add(this.DataGridViewTG);
            this.PanelWorld.Location = new System.Drawing.Point(0, 90);
            this.PanelWorld.Name = "PanelWorld";
            this.PanelWorld.ShadowDecoration.Parent = this.PanelWorld;
            this.PanelWorld.Size = new System.Drawing.Size(530, 500);
            this.PanelWorld.TabIndex = 3;
            // 
            // ButtonWorld
            // 
            this.ButtonWorld.CheckedState.Parent = this.ButtonWorld;
            this.ButtonWorld.CustomImages.Parent = this.ButtonWorld;
            this.ButtonWorld.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonWorld.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonWorld.ForeColor = System.Drawing.Color.White;
            this.ButtonWorld.HoverState.Parent = this.ButtonWorld;
            this.ButtonWorld.Location = new System.Drawing.Point(0, 0);
            this.ButtonWorld.Name = "ButtonWorld";
            this.ButtonWorld.ShadowDecoration.Parent = this.ButtonWorld;
            this.ButtonWorld.Size = new System.Drawing.Size(530, 45);
            this.ButtonWorld.TabIndex = 0;
            this.ButtonWorld.Text = "SỰ KIỆN QUỐC TẾ";
            this.ButtonWorld.Click += new System.EventHandler(this.ButtonWorld_Click);
            // 
            // DataGridViewTG
            // 
            this.DataGridViewTG.AllowUserToAddRows = false;
            this.DataGridViewTG.AllowUserToDeleteRows = false;
            this.DataGridViewTG.AllowUserToResizeColumns = false;
            this.DataGridViewTG.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DataGridViewTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewTG.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTG.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewTG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGridViewTG.EnableHeadersVisualStyles = false;
            this.DataGridViewTG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTG.Location = new System.Drawing.Point(0, 45);
            this.DataGridViewTG.Name = "DataGridViewTG";
            this.DataGridViewTG.ReadOnly = true;
            this.DataGridViewTG.RowHeadersVisible = false;
            this.DataGridViewTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTG.Size = new System.Drawing.Size(530, 455);
            this.DataGridViewTG.TabIndex = 1;
            this.DataGridViewTG.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataGridViewTG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewTG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewTG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewTG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewTG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewTG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewTG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTG.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewTG.ThemeStyle.ReadOnly = true;
            this.DataGridViewTG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewTG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewTG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewTG.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridViewTG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewTG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DisplayDetailEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelGeneral);
            this.Name = "DisplayDetailEvent";
            this.Size = new System.Drawing.Size(530, 590);
            this.Load += new System.EventHandler(this.DisplayDetailEvent_Load);
            this.PanelGeneral.ResumeLayout(false);
            this.PanelVN.ResumeLayout(false);
            this.PanelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVN)).EndInit();
            this.PanelWorld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelGeneral;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private Guna.UI2.WinForms.Guna2Button ButtonName;
        private System.Windows.Forms.BindingSource calendarDataSetBindingSource;
        private Guna.UI2.WinForms.Guna2Panel PanelVN;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpk;
        private Guna.UI2.WinForms.Guna2Panel PanelWorld;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewTG;
        private Guna.UI2.WinForms.Guna2Button ButtonWorld;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewVN;
        private Guna.UI2.WinForms.Guna2Button ButtonVN;
    }
}
