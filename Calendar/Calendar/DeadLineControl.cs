using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DeadLineControl : UserControl
    {
        public DeadLineControl()
        {
            InitializeComponent();
        }
        public void AddDetails(DeadlineClass c)
        {
            HoursTB.Text = c.HoursEnd.ToString();
            MinutesTB.Text = c.MinutesEnd.ToString();
            Notes.Text = c.Notes;
            DateLB.Text = c.Date.ToString("D");
            if (c.Priorities == 1)
            {
                HoursTB.ForeColor = Color.Red;
                MinutesTB.ForeColor = Color.Red;
                Notes.ForeColor = Color.Red;
                DateLB.ForeColor = Color.Red;
            }
            if (c.Priorities == 2)
            {
                HoursTB.ForeColor = Color.Orange;
                MinutesTB.ForeColor = Color.Orange;
                Notes.ForeColor = Color.Orange;
                DateLB.ForeColor = Color.Orange;
            }
            if (c.Priorities == 3)
            {
                HoursTB.ForeColor = Color.Violet;
                MinutesTB.ForeColor = Color.Violet;
                Notes.ForeColor = Color.Violet;
                DateLB.ForeColor = Color.Violet;
            }
            if (c.Priorities == 4)
            {
                HoursTB.ForeColor = Color.Black;
                MinutesTB.ForeColor = Color.Black;
                Notes.ForeColor = Color.Black;
                DateLB.ForeColor = Color.Black;
            }
        }
        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; ; }
        }
        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private event EventHandler details;
        public event EventHandler Details
        {
            add { details += value; }
            remove { details -= value; }
        }

        private void DetailsBtn_Click(object sender, EventArgs e)
        {
            if (details != null)
                details(this, new EventArgs());
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (edited != null)
                edited(this, new EventArgs());
        }
    }
}
