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
    public partial class Project : Form
    {
        public Project()
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

        private void ButtonChangeDate_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayChangeDate.ChangeDateDisplay))
            {
                PanelDisplay.Controls.Add(DisplayChangeDate.ChangeDateDisplay);
                DisplayChangeDate.ChangeDateDisplay.Dock = DockStyle.Fill;
                DisplayChangeDate.ChangeDateDisplay.BringToFront();
            }
            else
                DisplayChangeDate.ChangeDateDisplay.BringToFront();
        }

        private void ButtonCalendar_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayCalendar.CalendarDisplay))
            {
                PanelDisplay.Controls.Add(DisplayCalendar.CalendarDisplay);
                DisplayCalendar.CalendarDisplay.Dock = DockStyle.Fill;
                DisplayCalendar.CalendarDisplay.BringToFront();
            }
            else
                DisplayCalendar.CalendarDisplay.BringToFront();
        }

        private void ButtonDate_Click(object sender, EventArgs e)
        { 
                if (!PanelDisplay.Contains(DisplayDate.DateDisplay))
                {
                    PanelDisplay.Controls.Add(DisplayDate.DateDisplay);
                    DisplayDate.DateDisplay.Dock = DockStyle.Fill;
                    DisplayDate.DateDisplay.BringToFront();
                }
                else
                    DisplayDate.DateDisplay.BringToFront();
        }
        private void ButtonCount_Click(object sender, EventArgs e)
        {
            if (!PanelDisplay.Contains(DisplayCountDay.CountDayDisplay))
            {
                PanelDisplay.Controls.Add(DisplayCountDay.CountDayDisplay);
                DisplayCountDay.CountDayDisplay.Dock = DockStyle.Fill;
                DisplayCountDay.CountDayDisplay.BringToFront();
            }
            else
                DisplayCountDay.CountDayDisplay.BringToFront();
        }
    }
}
