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
    public partial class ToDoControl : UserControl
    {
        public ToDoControl()
        {
            InitializeComponent();
        }
        public void AddDetails(ToDoClass c)
        {
            FHours.Text = c.FHours.ToString();
            FMinutes.Text = c.FMinutes.ToString();
            THours.Text = c.THours.ToString();
            TMinutes.Text = c.TMinutes.ToString();
            Notes.Text = c.Notes;
            if (c.CheckImportant == true)
            {
                FHours.ForeColor = Color.Red;
                FMinutes.ForeColor = Color.Red;
                THours.ForeColor = Color.Red;
                TMinutes.ForeColor = Color.Red;
                Notes.ForeColor = Color.Red;
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

        private void DetailsBtn_Click_1(object sender, EventArgs e)
        {
            if (details != null)
                details(this, new EventArgs());
        }

        private void DeleteBtn_Click_1(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void EditBtn_Click_1(object sender, EventArgs e)
        {
            if (edited != null)
                edited(this, new EventArgs());
        }
    }
}
