using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Calendar : Form
    {
        public Calendar()
        {
            InitializeComponent();
        }

        private void displayDate1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            if (!panelDisplay.Contains(displayDate))
            {
                panelDisplay.Controls.Add(displayDate);
                displayDate.Dock = DockStyle.Fill;
                displayDate.BringToFront();
            }
            else
                displayDate.BringToFront();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (!panelDisplay.Contains(displayCalendar))
            {
                panelDisplay.Controls.Add(displayCalendar);
                displayCalendar.Dock = DockStyle.Fill;
                displayCalendar.BringToFront();
            }
            else
                displayCalendar.BringToFront();
        }
    }
}
