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
        public ToDoClass c = new ToDoClass();
        public GeneralNoteForm()
        {
            InitializeComponent();
            AddNoteToDay();
        }
        public void AddNoteToDay()
        {

            int y = 0;
            int i = 0;

            DateTime datefirst = Dtpk.Value;
            DateTime dateafter = Dtpk.Value.AddDays(1);
            string sql = $"select * from NoteByDate where AppDate between #{datefirst.ToShortDateString()}# and #{dateafter.ToShortDateString()}# order by FromH asc, FromM asc";
            DataTable dt = NoteData.QueryAsDatatable(sql);

            foreach (DataRow row in dt.Rows)
            {
                ToDoControl Td = new ToDoControl();
                Td.Deleted += Td_Deleted;
                //Td.Edited -= TD_Edited;
                Td.BackColor = System.Drawing.Color.WhiteSmoke;
                Td.Location = new System.Drawing.Point(1, -1 + y);
                Td.Size = new System.Drawing.Size(812, 86);
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
            var Note = new ToDoNote();
            Note.MainNote.Text = c.Notes;
            Note.FHoursCB.SelectedIndex = c.FHours;
            Note.FMinutesCB.SelectedIndex = c.FMinutes;
            Note.THoursCB.SelectedIndex = c.THours;
            Note.TMinutesCB.SelectedIndex = c.TMinutes;
            Note.DescriptionTB.Text = c.Description;
            Note.FromDtpk.Value = c.Date;
            Note.IdNote = c.Id;
            Note.TitleLabel.Text = "Cập nhật ghi chú";
            if (c.CheckImportant == true)
                Note.ImportantCheck.Checked = true;
            Note.ShowDialog();
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        void Td_Details(object sender, EventArgs e)
        {
            var Note = new ToDoNote();
            Note.MainNote.Text = c.Notes;
            Note.FHoursCB.SelectedIndex = c.FHours;
            Note.FMinutesCB.SelectedIndex = c.FMinutes;
            Note.THoursCB.SelectedIndex = c.THours;
            Note.TMinutesCB.SelectedIndex = c.TMinutes;
            Note.DescriptionTB.Text = c.Description;
            Note.FromDtpk.Value = c.Date;
            Note.TitleLabel.Text = "Chi tiết";
            Note.SaveBtn.Visible = false;
            Note.MainNote.Enabled = false;
            Note.DescriptionTB.Enabled = false;
            Note.FHoursCB.Enabled = false;
            Note.FMinutesCB.Enabled = false;
            Note.THoursCB.Enabled = false;
            Note.TMinutesCB.Enabled = false;
            Note.ImportantCheck.Enabled = false;
            Note.RepeatCB.Enabled = false;
            Note.FromDtpk.Enabled = false;
            Note.ShowDialog();
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
            var TDN = new ToDoNote();
            TDN.FromDtpk.Value = Dtpk.Value;
            TDN.ShowDialog();
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
    }
}
