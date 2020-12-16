﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelGeneral = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelWorld = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonWorld = new Guna.UI2.WinForms.Guna2Button();
            this.DataGridViewTG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PanelVN = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewVN = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ButtonVN = new Guna.UI2.WinForms.Guna2Button();
            this.PanelName = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonName = new Guna.UI2.WinForms.Guna2Button();
            this.calendarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ComboBoxSolarYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxSolarMonth = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxSolarDay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ButtonFind1 = new Guna.UI2.WinForms.Guna2Button();
            this.PanelGeneral.SuspendLayout();
            this.PanelWorld.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTG)).BeginInit();
            this.PanelVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVN)).BeginInit();
            this.PanelName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelGeneral
            // 
            this.PanelGeneral.Controls.Add(this.ComboBoxSolarYear);
            this.PanelGeneral.Controls.Add(this.ButtonFind1);
            this.PanelGeneral.Controls.Add(this.ComboBoxSolarMonth);
            this.PanelGeneral.Controls.Add(this.ComboBoxSolarDay);
            this.PanelGeneral.Controls.Add(this.PanelVN);
            this.PanelGeneral.Controls.Add(this.PanelName);
            this.PanelGeneral.Controls.Add(this.PanelWorld);
            this.PanelGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGeneral.Location = new System.Drawing.Point(0, 0);
            this.PanelGeneral.Name = "PanelGeneral";
            this.PanelGeneral.ShadowDecoration.Parent = this.PanelGeneral;
            this.PanelGeneral.Size = new System.Drawing.Size(530, 590);
            this.PanelGeneral.TabIndex = 0;
            // 
            // PanelWorld
            // 
            this.PanelWorld.Controls.Add(this.DataGridViewTG);
            this.PanelWorld.Controls.Add(this.ButtonWorld);
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
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            this.DataGridViewTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.DataGridViewTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewTG.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewTG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewTG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.DataGridViewTG.ColumnHeadersHeight = 4;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTG.DefaultCellStyle = dataGridViewCellStyle21;
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
            this.DataGridViewTG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            // DataGridViewVN
            // 
            this.DataGridViewVN.AllowUserToAddRows = false;
            this.DataGridViewVN.AllowUserToDeleteRows = false;
            this.DataGridViewVN.AllowUserToResizeColumns = false;
            this.DataGridViewVN.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.DataGridViewVN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.DataGridViewVN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataGridViewVN.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewVN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewVN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.DataGridViewVN.ColumnHeadersHeight = 4;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVN.DefaultCellStyle = dataGridViewCellStyle24;
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
            this.DataGridViewVN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            // PanelName
            // 
            this.PanelName.Controls.Add(this.ButtonName);
            this.PanelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelName.Location = new System.Drawing.Point(0, 0);
            this.PanelName.Name = "PanelName";
            this.PanelName.ShadowDecoration.Parent = this.PanelName;
            this.PanelName.Size = new System.Drawing.Size(530, 54);
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
            this.ButtonName.Size = new System.Drawing.Size(530, 54);
            this.ButtonName.TabIndex = 0;
            this.ButtonName.Text = "SỰ KIỆN LỊCH SỬ";
            // 
            // ComboBoxSolarYear
            // 
            this.ComboBoxSolarYear.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarYear.BorderThickness = 0;
            this.ComboBoxSolarYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarYear.FocusedState.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarYear.HoverState.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.ItemHeight = 30;
            this.ComboBoxSolarYear.ItemsAppearance.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Location = new System.Drawing.Point(220, 54);
            this.ComboBoxSolarYear.Name = "ComboBoxSolarYear";
            this.ComboBoxSolarYear.ShadowDecoration.Parent = this.ComboBoxSolarYear;
            this.ComboBoxSolarYear.Size = new System.Drawing.Size(150, 36);
            this.ComboBoxSolarYear.TabIndex = 20;
            this.ComboBoxSolarYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxSolarMonth
            // 
            this.ComboBoxSolarMonth.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarMonth.BorderThickness = 0;
            this.ComboBoxSolarMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarMonth.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarMonth.FocusedState.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarMonth.HoverState.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.ItemHeight = 30;
            this.ComboBoxSolarMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.ComboBoxSolarMonth.ItemsAppearance.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Location = new System.Drawing.Point(110, 54);
            this.ComboBoxSolarMonth.Name = "ComboBoxSolarMonth";
            this.ComboBoxSolarMonth.ShadowDecoration.Parent = this.ComboBoxSolarMonth;
            this.ComboBoxSolarMonth.Size = new System.Drawing.Size(110, 36);
            this.ComboBoxSolarMonth.TabIndex = 19;
            this.ComboBoxSolarMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ComboBoxSolarDay
            // 
            this.ComboBoxSolarDay.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxSolarDay.BorderThickness = 0;
            this.ComboBoxSolarDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxSolarDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSolarDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboBoxSolarDay.FocusedState.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.ComboBoxSolarDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxSolarDay.HoverState.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.ItemHeight = 30;
            this.ComboBoxSolarDay.ItemsAppearance.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Location = new System.Drawing.Point(0, 54);
            this.ComboBoxSolarDay.Name = "ComboBoxSolarDay";
            this.ComboBoxSolarDay.ShadowDecoration.Parent = this.ComboBoxSolarDay;
            this.ComboBoxSolarDay.Size = new System.Drawing.Size(110, 36);
            this.ComboBoxSolarDay.TabIndex = 18;
            this.ComboBoxSolarDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ButtonFind1
            // 
            this.ButtonFind1.CheckedState.Parent = this.ButtonFind1;
            this.ButtonFind1.CustomImages.Parent = this.ButtonFind1;
            this.ButtonFind1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.ButtonFind1.ForeColor = System.Drawing.Color.White;
            this.ButtonFind1.HoverState.Parent = this.ButtonFind1;
            this.ButtonFind1.Location = new System.Drawing.Point(370, 54);
            this.ButtonFind1.Name = "ButtonFind1";
            this.ButtonFind1.ShadowDecoration.Parent = this.ButtonFind1;
            this.ButtonFind1.Size = new System.Drawing.Size(160, 36);
            this.ButtonFind1.TabIndex = 17;
            this.ButtonFind1.Text = "CHỌN";
            this.ButtonFind1.Click += new System.EventHandler(this.ButtonFind1_Click);
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
            this.PanelWorld.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTG)).EndInit();
            this.PanelVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVN)).EndInit();
            this.PanelName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelGeneral;
        private Guna.UI2.WinForms.Guna2Panel PanelName;
        private Guna.UI2.WinForms.Guna2Button ButtonName;
        private System.Windows.Forms.BindingSource calendarDataSetBindingSource;
        private Guna.UI2.WinForms.Guna2Panel PanelVN;
        private Guna.UI2.WinForms.Guna2Panel PanelWorld;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewTG;
        private Guna.UI2.WinForms.Guna2Button ButtonWorld;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewVN;
        private Guna.UI2.WinForms.Guna2Button ButtonVN;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarYear;
        private Guna.UI2.WinForms.Guna2Button ButtonFind1;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarMonth;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxSolarDay;
    }
}
