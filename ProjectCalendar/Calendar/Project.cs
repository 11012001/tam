using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CalendarProject : Form
    {
        public CalendarProject()
        {
            InitializeComponent();
        }
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonWeatherForecast_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayWF.WFDisplay))
            {
                PanelDisplay.Controls.Add(DisplayWF.WFDisplay);
                DisplayWF.WFDisplay.Dock = DockStyle.Fill;
                DisplayWF.WFDisplay.BringToFront();
            }
            else
                DisplayWF.WFDisplay.BringToFront();
        }

        private void ButtonCalendar_Click(object sender, EventArgs e)
        {
            var Lunnar = new DisplayLunnar();
            Lunnar.Location = new Point(0, 0);
            Lunnar.Size = new Size(1009, 620);
            Lunnar.DTPK += Lunnar_DTPK;
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(Lunnar);
        }

        void Lunnar_DTPK(object sender, EventArgs e)
        {
            DisplayLunnar display = sender as DisplayLunnar;
            dtpk.Value = display.dtpk.Value;
        }

        private void ButtonDate_Click(object sender, EventArgs e)
        {
            DisplayDate display = new DisplayDate(dtpk.Value);
            display.Size = new Size(1009, 620);
            display.Location = new Point(0, 0);
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(display);
            display.MonthBtn += DateDisplay_MonthBtn;
            display.Nextbtn += DateDisplay_NextBtn;
            display.Prebtn += DateDisplay_PreBtn;
            display.TDbtn += DateDisplay_TDBtn;
        }
        void DateDisplay_MonthBtn(object sender, EventArgs e)
        {
            DisplayDate displayDate = sender as DisplayDate;
            DateTime date = displayDate.Date;

            PanelDisplay.Controls.Clear();
            
            DisplayLunnar displayLunnar = new DisplayLunnar(date);
            PanelDisplay.Controls.Add(displayLunnar);
            displayLunnar.Dock = DockStyle.Fill;
        }
        void DateDisplay_NextBtn(object sender, EventArgs e)
        {
            DisplayDate displayDate = sender as DisplayDate;
            dtpk.Value = dtpk.Value.AddDays(1);
        }
        void DateDisplay_PreBtn(object sender, EventArgs e)
        {
            DisplayDate displayDate = sender as DisplayDate;
            dtpk.Value = dtpk.Value.AddDays(-1);
        }
        void DateDisplay_TDBtn(object sender, EventArgs e)
        {
            DisplayDate displayDate = sender as DisplayDate;
            dtpk.Value = DateTime.Now;
        }
        private void ButtonDay_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayDay.DayDisplay))
            {
                PanelDisplay.Controls.Add(DisplayDay.DayDisplay);
                DisplayDay.DayDisplay.Dock = DockStyle.Fill;
                DisplayDay.DayDisplay.BringToFront();
            }
            else
                DisplayDay.DayDisplay.BringToFront();
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayDetailEvent.DetailEventDisplay))
            {
                PanelDisplay.Controls.Add(DisplayDetailEvent.DetailEventDisplay);
                DisplayDetailEvent.DetailEventDisplay.Dock = DockStyle.Fill;
                DisplayDetailEvent.DetailEventDisplay.BringToFront();
            }
            else
                DisplayDetailEvent.DetailEventDisplay.BringToFront();
        }
        public void EventDate()
        {

        }

        private void CalendarProject_Load(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void AddDisplayDateCondition(DateTime date)
        {
            DisplayDate displayDate = new DisplayDate(date);
            displayDate.Size = new Size(1009, 620);
            displayDate.Location = new Point(0, 0);
            PanelDisplay.Controls.Add(displayDate);
            displayDate.MonthBtn += DateDisplay_MonthBtn;
            displayDate.Nextbtn += DateDisplay_NextBtn;
            displayDate.Prebtn += DateDisplay_PreBtn;
            displayDate.TDbtn += DateDisplay_TDBtn;
        }
        private void AddDisplayDetailDateCondition(DateTime date)
        {
            condition = 1;
            var DetailDate = new DisplayDetailDate(dtpk.Value);
            DetailDate.Location = new Point(0, 0);
            DetailDate.Size = new Size(1009, 620);
            PanelDisplay.Controls.Add(DetailDate);
            DetailDate.Nextbtn += DateDisplay_NextBtn1;
            DetailDate.Prebtn += DateDisplay_PreBtn1;
        }

        public static int condition = 0;
        // condition = 0 là DisplayDate , condition = 1 là DisplayDetailDate
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            if (condition == 1)
            {
                AddDisplayDetailDateCondition(date);
            }
            else {
                AddDisplayDateCondition(date);
            }
        }

        private void buttonDetailDate_Click(object sender, EventArgs e)
        {
            var DetailDate = new DisplayDetailDate(dtpk.Value);
            DetailDate.Location = new Point(0, 0);
            DetailDate.Size = new Size(1009, 620);
            DetailDate.Nextbtn += DateDisplay_NextBtn1;
            DetailDate.Prebtn += DateDisplay_PreBtn1;
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(DetailDate);
        }
        void DateDisplay_NextBtn1(object sender, EventArgs e)
        {
            condition = 1;
            DisplayDetailDate displayDate = sender as DisplayDetailDate;
            dtpk.Value = dtpk.Value.AddDays(1);
        }
        void DateDisplay_PreBtn1(object sender, EventArgs e)
        {
            condition = 1;
            DisplayDetailDate displayDate = sender as DisplayDetailDate;
            dtpk.Value = dtpk.Value.AddDays(-1);
        }

        private void buttonVanKhan_Click(object sender, EventArgs e)
        {
            var VanKhan = new DisplayVanKhan();
            VanKhan.Location = new Point(0, 0);
            VanKhan.Size = new Size(1009, 620);
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(VanKhan);
        }

        private void buttonTuVi_Click(object sender, EventArgs e)
        {
            DisplayTuVi display = new DisplayTuVi();
            display.Size = new Size(1009, 620);
            display.Location = new Point(0, 0);
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(display);
        }

        private void buttonHDSD_Click(object sender, EventArgs e)
        {
            Tutorial Tutorial = new Tutorial();
            Tutorial.ShowDialog();
        }
    }
}
