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
        public int Priority;
        public DeadLineControl()
        {
            InitializeComponent();
        }
        public void AddDetails(DeadlineClass c)
        {
            Notes.Text = c.Notes;
            HoursLB.Text = c.HoursEnd.ToString();
            MinutesLB.Text = c.MinutesEnd.ToString();
            DateLB.Text = c.Date.ToString("D");
            switch (c.Priorities)
            {
                case 1:
                    {
                        HoursLB.ForeColor = Color.Red;
                        MinutesLB.ForeColor = Color.Red;
                        Notes.ForeColor = Color.Red;
                        DateLB.ForeColor = Color.Red;
                        break;
                    }
                case 2:
                    {
                        HoursLB.ForeColor = Color.Orange;
                        MinutesLB.ForeColor = Color.Orange;
                        Notes.ForeColor = Color.Orange;
                        DateLB.ForeColor = Color.Orange;
                        break;
                    }
                case 3:
                    {
                        HoursLB.ForeColor = Color.Violet;
                        MinutesLB.ForeColor = Color.Violet;
                        Notes.ForeColor = Color.Violet;
                        DateLB.ForeColor = Color.Violet;
                        break;
                    }
                case 4:
                    {
                        HoursLB.ForeColor = Color.Black;
                        MinutesLB.ForeColor = Color.Black;
                        Notes.ForeColor = Color.Black;
                        DateLB.ForeColor = Color.Black;
                        break;
                    }
                case 5:
                    {
                        HoursLB.ForeColor = Color.LightGray;
                        MinutesLB.ForeColor = Color.LightGray;
                        Notes.ForeColor = Color.LightGray;
                        DateLB.ForeColor = Color.LightGray;
                        Notes.Text = Notes.Text + "(DONE)";
                        break;
                    }
                case 6:
                    {
                        HoursLB.ForeColor = Color.LightGray;
                        MinutesLB.ForeColor = Color.LightGray;
                        Notes.ForeColor = Color.LightGray;
                        DateLB.ForeColor = Color.LightGray;
                        Notes.Text = Notes.Text + "(MISSED)";
                        break;
                    }
            }
            ArrangeControl();
        }
        public void ArrangeControl()
        {
            Colon.Location = new Point(HoursLB.Location.X + HoursLB.Size.Width + 3, 46);
            MinutesLB.Location = new Point(Colon.Location.X + Colon.Size.Width + 3, 46);
            SeparatorLB.Location = new Point(MinutesLB.Location.X + MinutesLB.Size.Width + 3, 46);
            DateLB.Location = new Point(SeparatorLB.Location.X + SeparatorLB.Size.Width + 6, 46);
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
        private event EventHandler done;
        public event EventHandler Done
        {
            add { done += value; }
            remove { done -= value; }
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

        private void DeadLineControl_Load(object sender, EventArgs e)
        {
            Colon.Location = new Point(HoursLB.Location.X + HoursLB.Size.Width + 3, 46);
            MinutesLB.Location = new Point(Colon.Location.X + Colon.Size.Width + 3, 46);
            DateLB.Location = new Point(MinutesLB.Location.X + MinutesLB.Size.Width + 3, 46);
        }

        private void DoneCB_CheckedChanged(object sender, EventArgs e)
        {
            if (done != null)
                done(this, new EventArgs());
        }
    }
}
