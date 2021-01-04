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
    public partial class GeneralNoteForm : Form
    {
        public int Button = 1;
        public ToDoClass c = new ToDoClass();
        public DeadlineClass d = new DeadlineClass();
        public GeneralNoteForm()
        {
            InitializeComponent();
            AddNoteToDay();
        }
        public void AddNoteToDay()
        {
            int y = 0;
            int i = 0;
            if (Button == 1)
            {
                ControlPanel.Controls.Clear();
                AddJobBtn.Text = "Thêm Công việc";
                DeadlineLabel.Visible = false;
                Dtpk.Visible = true;
                NextBtn.Visible = true;
                PreviousBtn.Visible = true;

                DateTime datefirst = Dtpk.Value;
                DateTime dateafter = Dtpk.Value.AddDays(1).AddSeconds(-1);
                string sql = $"select * from NoteByDate where AppDate between #{datefirst.ToShortDateString()}# and #{dateafter.ToShortDateString()}# order by FromH asc, FromM asc";
                DataTable dt = NoteData.QueryAsDatatable(sql);

                foreach (DataRow row in dt.Rows)
                {
                    ToDoControl Td = new ToDoControl();
                    Td.BackColor = System.Drawing.Color.WhiteSmoke;
                    Td.Location = new System.Drawing.Point(1, -1 + y);
                    Td.Size = new System.Drawing.Size(787, 86);
                    Td.TabIndex = i++;
                    c.Id = Convert.ToInt32(row["IdNote"]);
                    if (Convert.ToInt32(row["Important"]) == 1)
                    {
                        c.CheckImportant = true;
                    }
                    else c.CheckImportant = false;
                    Td.Tag = Convert.ToInt32(row["IdNote"]);
                    c.Date = Convert.ToDateTime(row["AppDate"]);
                    c.Description = row["Description"].ToString();
                    c.FHours = Convert.ToInt32(row["FromH"]);
                    c.FMinutes = Convert.ToInt32(row["FromM"]);
                    c.THours = Convert.ToInt32(row["ToH"]);
                    c.TMinutes = Convert.ToInt32(row["ToM"]);
                    c.Notes = row["NoteText"].ToString();
                    Td.AddDetails(c);
                    Td.Deleted += Td_Deleted;
                    Td.Edited += Td_Edited;
                    Td.Details += Td_Details;
                    ControlPanel.Controls.Add(Td);
                    y += Td.Height;
                }
            }
            if (Button == 2)
            {
                AddJobBtn.Text = "Thêm Deadline";
                ControlPanel.Controls.Clear();
                DeadlineLabel.Visible = true;
                Dtpk.Visible = false;
                NextBtn.Visible = false;
                PreviousBtn.Visible = false;

                string sql = $"select * from Deadline";
                DataTable dt = NoteData.QueryAsDatatable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) >= Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 1)
                    {
                        sql = $"update Deadline set Priority = '{1}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]);
                        NoteData.UpdateInsertDelete(sql);
                    }
                    else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) < Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 1)
                    {
                        sql = $"update Deadline set Priority = '{2}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]); ;
                        NoteData.UpdateInsertDelete(sql);
                    }
                    else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) >= Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 0)
                    {
                        sql = $"update Deadline set Priority = '{3}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]); ;
                        NoteData.UpdateInsertDelete(sql);
                    }
                    else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) < Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 0)
                    {
                        sql = $"update Deadline set Priority = '{4}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]); ;
                        NoteData.UpdateInsertDelete(sql);
                    }
                }
                sql = $"select * from Deadline order by Priority asc";
                dt = NoteData.QueryAsDatatable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    DeadLineControl DL = new DeadLineControl();
                    DL.BackColor = System.Drawing.Color.WhiteSmoke;
                    DL.Location = new System.Drawing.Point(1, -1 + y);
                    DL.Size = new System.Drawing.Size(787, 106);
                    DL.TabIndex = i++;
                    DL.Tag = Convert.ToInt32(row["IdDeadline"]);
                    if (Convert.ToInt32(row["Importance"]) == 1)
                    {
                        d.CheckImportant = true;
                    }
                    else
                    {
                        d.CheckImportant = false;
                    }
                    d.Id = Convert.ToInt32(row["IdDeadline"]);
                    d.Urgent = Convert.ToInt32(row["UrgentCount"]);
                    d.Priorities = Convert.ToInt32(row["Priority"]);
                    d.Date = Convert.ToDateTime(row["DateEnd"]);
                    d.Description = row["DescriptionText"].ToString();
                    d.Notes = row["DeadlineText"].ToString();
                    d.HoursEnd = Convert.ToInt32(row["TimeHEnd"]);
                    d.MinutesEnd = Convert.ToInt32(row["TimeMEnd"]);
                    ControlPanel.Controls.Add(DL);
                    DL.Deleted += DL_Deleted;
                    DL.Edited += DL_Edited;
                    DL.AddDetails(d);
                    DL.Details += DL_Details;
                    y += DL.Height;
                }
            }
        }
        void Td_Deleted(object sender, EventArgs e)
        {
            ToDoControl Td = sender as ToDoControl;
            string sql = $"delete from NoteByDate where IdNote = {Td.Tag}";
            NoteData.UpdateInsertDelete(sql);
            ControlPanel.Controls.Remove(Td);
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void Td_Edited(object sender, EventArgs e)
        {
            ToDoControl TDC = sender as ToDoControl;
            var Td = new ToDoNote();
            string sql = $"select * from NoteByDate where IdNote = {TDC.Tag}";
            Td.IdNote = Convert.ToInt32(TDC.Tag);
            DataTable dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                Td.MainNote.Text = row["NoteText"].ToString();
                Td.FHoursCB.SelectedIndex = Convert.ToInt32(row["FromH"]);
                Td.FMinutesCB.SelectedIndex = Convert.ToInt32(row["FromM"]);
                Td.THoursCB.SelectedIndex = Convert.ToInt32(row["ToH"]);
                Td.TMinutesCB.SelectedIndex = Convert.ToInt32(row["ToM"]);
                Td.DescriptionTB.Text = row["Description"].ToString();
                Td.FromDtpk.Value = Convert.ToDateTime(row["AppDate"]);
                Td.TitleLabel.Text = "Cập nhật ghi chú";
                if (Convert.ToInt32(row["Important"]) == 1)
                {
                    Td.ImportantCheck.Checked = true;
                }
                else
                {
                    Td.ImportantCheck.Checked = false;
                }

            }
            Td.ShowDialog();
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void Td_Details(object sender, EventArgs e)
        {
            ToDoControl TDC = sender as ToDoControl;
            var Td = new ToDoNote();
            string sql = $"select * from NoteByDate where IdNote = {TDC.Tag}";
            Td.IdNote = Convert.ToInt32(TDC.Tag);
            DataTable dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                Td.MainNote.Text = row["NoteText"].ToString();
                Td.FHoursCB.SelectedIndex = Convert.ToInt32(row["FromH"]);
                Td.FMinutesCB.SelectedIndex = Convert.ToInt32(row["FromM"]);
                Td.THoursCB.SelectedIndex = Convert.ToInt32(row["ToH"]);
                Td.TMinutesCB.SelectedIndex = Convert.ToInt32(row["ToM"]);
                Td.DescriptionTB.Text = row["Description"].ToString();
                Td.FromDtpk.Value = Convert.ToDateTime(row["AppDate"]);
                Td.TitleLabel.Text = "Cập nhật ghi chú";
                if (Convert.ToInt32(row["Important"]) == 1)
                {
                    Td.ImportantCheck.Checked = true;
                }
                else
                {
                    Td.ImportantCheck.Checked = false;
                }
            }
            Td.MainNote.Enabled = false;
            Td.FHoursCB.Enabled = false;
            Td.FMinutesCB.Enabled = false;
            Td.THoursCB.Enabled = false;
            Td.TMinutesCB.Enabled = false;
            Td.DescriptionTB.Enabled = false;
            Td.FromDtpk.Enabled = false;
            Td.SaveBtn.Visible = false;
            Td.ShowDialog();
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void DL_Deleted(object sender, EventArgs e)
        {
            DeadLineControl DL = sender as DeadLineControl;
            string sql = $"delete from Deadline where IdDeadline = {DL.Tag}";
            NoteData.UpdateInsertDelete(sql);
            ControlPanel.Controls.Remove(DL);
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void DL_Edited(object sender, EventArgs e)
        {
            DeadLineControl DLC = sender as DeadLineControl;
            var DL = new DeadLineNote();
            string sql = $"select * from Deadline where IdDeadline = {DLC.Tag}";
            DL.IDDeadLine = Convert.ToInt32(DLC.Tag);
            DataTable dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["UrgentCount"]) == 1) 
                    DL.UrgentCB.SelectedIndex = 0;
                else if (Convert.ToInt32(row["UrgentCount"]) == 3)
                    DL.UrgentCB.SelectedIndex = 1;
                else if (Convert.ToInt32(row["UrgentCount"]) == 7)
                    DL.UrgentCB.SelectedIndex = 2;
                else
                    DL.UrgentCB.SelectedIndex = 3;
                
                DL.HoursCB.SelectedIndex = Convert.ToInt32(row["TimeHEnd"]);
                DL.MinutesCB.SelectedIndex = Convert.ToInt32(row["TimeMEnd"]);
                DL.Dtpk.Value = Convert.ToDateTime(row["DateEnd"]);
                DL.DescriptionTB.Text = row["DescriptionText"].ToString();
                DL.MainNote.Text = row["DeadlineText"].ToString();
                if (Convert.ToInt32(row["Importance"]) == 1)
                {
                    DL.ImportantCheck.Checked = true;
                }
                else
                {
                    DL.ImportantCheck.Checked = false;
                }
            }
                
            DL.ShowDialog();
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void DL_Details(object sender, EventArgs e)
        {
            DeadLineControl DLC = sender as DeadLineControl;
            var DL = new DeadLineNote();
            string sql = $"select * from Deadline where IdDeadline = {DLC.Tag}";
            DL.IDDeadLine = Convert.ToInt32(DLC.Tag);
            DataTable dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["UrgentCount"]) == 1)
                    DL.UrgentCB.SelectedIndex = 0;
                else if (Convert.ToInt32(row["UrgentCount"]) == 3)
                    DL.UrgentCB.SelectedIndex = 1;
                else if (Convert.ToInt32(row["UrgentCount"]) == 7)
                    DL.UrgentCB.SelectedIndex = 2;
                else
                    DL.UrgentCB.SelectedIndex = 3;

                DL.HoursCB.SelectedIndex = Convert.ToInt32(row["TimeHEnd"]);
                DL.MinutesCB.SelectedIndex = Convert.ToInt32(row["TimeMEnd"]);
                DL.Dtpk.Value = Convert.ToDateTime(row["DateEnd"]);
                DL.DescriptionTB.Text = row["DescriptionText"].ToString();
                DL.MainNote.Text = row["DeadlineText"].ToString();
                if (Convert.ToInt32(row["Importance"]) == 1)
                {
                    DL.ImportantCheck.Checked = true;
                }
                else
                {
                    DL.ImportantCheck.Checked = false;
                }
            }
            DL.HoursCB.Enabled = false;
            DL.MinutesCB.Enabled = false;
            DL.Dtpk.Enabled = false;
            DL.DescriptionTB.Enabled = false;
            DL.MainNote.Enabled = false;
            DL.SaveBtn.Visible = false;
            DL.ShowDialog();
        }
        public int MaxDayOfMonth(int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    {
                        if (month % 4 == 0 || month % 100 != 0)
                            return 29;
                        return 28;
                    }
            }
            return 30;
        }
        public void AddDateTime(DateTime First, DateTime Last)
        {
            First = new DateTime(Dtpk.Value.Year, Dtpk.Value.Month, Dtpk.Value.Day);
            Last = First.AddDays(1);
        }
        private void AddJobBtn_Click_1(object sender, EventArgs e)
        {
            if (Button == 1)
            {
                var TDN = new ToDoNote();
                TDN.FromDtpk.Value = Dtpk.Value;
                TDN.ToDtpk.Value = Dtpk.Value;
                TDN.ShowDialog();
            }
            else
            {
                var DL = new DeadLineNote();
                DL.Dtpk.Value = DateTime.Now;
                DL.ShowDialog();
            }
            AddNoteToDay();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            Dtpk.Value = Dtpk.Value.AddDays(-1);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            Dtpk.Value = Dtpk.Value.AddDays(1);
        }

        private void Dtpk_ValueChanged(object sender, EventArgs e)
        {
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Button = 2;
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }

        private void ToDoBtn_Click(object sender, EventArgs e)
        {
            Button = 1;
            AddNoteToDay();
        }
    }
}
