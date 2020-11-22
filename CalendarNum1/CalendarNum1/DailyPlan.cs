using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNum1
{
    public partial class DailyPlan : Form
    {
        private DateTime date;
        private PlanData job;
        public DailyPlan(DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;

            DTPKdate.Value = Date;
        }

        public DateTime Date { get => date; set => date = value; }
        public PlanData Job { get => job; set => job = value; }

        void ShowJobByDate(DateTime date)
        {

        }
        private void DTPKdate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }
    }
}
