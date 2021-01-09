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
        #region Tạo các usercontrol vào ControlPanel
        public int Button = 1;
        public ToDoClass c = new ToDoClass();
        public DeadlineClass d = new DeadlineClass();
        public GeneralNoteForm()
        {
            InitializeComponent();
            AddNoteToDay();
        }
        //Thêm Note hoặc Deadline
        public void AddNoteToDay()
        {
            int y = 0;
            int i = 0;

            //Thêm lập lịch

            if (Button == 1)
            {
                ControlPanel.Controls.Clear();
                AddJobBtn.Text = "Thêm Công việc";
                DeadlineLabel.Visible = false;
                Dtpk.Visible = true;
                NextBtn.Visible = true;
                PreviousBtn.Visible = true;
                
                DateTime datefirst = new DateTime(Dtpk.Value.Year,Dtpk.Value.Month,Dtpk.Value.Day,0,0,0);
                DateTime dateafter = datefirst.AddDays(1).AddSeconds(-1);

                string sql = $"select * from NoteByDate where AppDate between #{datefirst.ToShortDateString()}# and #{dateafter.ToShortDateString()}# order by FromH asc, FromM asc";
                DataTable dt = NoteData.QueryAsDatatable(sql);

                foreach (DataRow row in dt.Rows)
                {
                    ToDoControl Td = new ToDoControl();
                    Td.BackColor = System.Drawing.Color.Transparent;
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

            //Thêm Deadline

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
                    if (Convert.ToInt32(row["Priority"]) != 5)
                    {
                        if (DateTime.Now > Convert.ToDateTime(row["DateEnd"]))
                        {
                            sql = $"update Deadline set Priority ='{6}' where IdDeadline =" + Convert.ToInt32(row["IdDeadLine"]);
                            NoteData.UpdateInsertDelete(sql);
                        }
                        else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) >= Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 1)
                        {
                            sql = $"update Deadline set Priority = '{1}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]);
                            NoteData.UpdateInsertDelete(sql);
                        }
                        else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) < Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 1)
                        {
                            sql = $"update Deadline set Priority = '{2}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]);
                            NoteData.UpdateInsertDelete(sql);
                        }
                        else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) >= Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 0)
                        {
                            sql = $"update Deadline set Priority = '{3}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]);
                            NoteData.UpdateInsertDelete(sql);
                        }
                        else if (DateTime.Now.AddDays(Convert.ToInt32(row["UrgentCount"])) < Convert.ToDateTime(row["DateEnd"]) && Convert.ToInt32(row["Importance"]) == 0)
                        {
                            sql = $"update Deadline set Priority = '{4}' where IdDeadline = " + Convert.ToInt32(row["IdDeadLine"]);
                            NoteData.UpdateInsertDelete(sql);
                        }
                    }
                }
                sql = $"select * from Deadline order by Priority asc, DateEnd asc";
                dt = NoteData.QueryAsDatatable(sql);
                foreach (DataRow row in dt.Rows)
                {
                    DeadLineControl DL = new DeadLineControl();
                    DL.BackColor = System.Drawing.Color.Transparent;
                    DL.Location = new System.Drawing.Point(1, -1 + y);
                    DL.Size = new System.Drawing.Size(787, 94);
                    DL.TabIndex = i++;
                    DL.Tag = Convert.ToInt32(row["IdDeadline"]);
                    if (Convert.ToInt32(row["Priority"]) == 5) 
                        DL.DoneCB.Checked = true;
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
                    DL.Done += DL_Done;
                    y += DL.Height;
                }
            }
        }
        #endregion


        #region Tạo chức năng xóa, sửa, xem chi tiết cho các nút trong các usercontrol

        //Thêm chức năng nút xóa cho lập lịch
        void Td_Deleted(object sender, EventArgs e)
        {
            ToDoControl Td = sender as ToDoControl;
            string sql = $"delete from NoteByDate where IdNote = {Td.Tag}";
            NoteData.UpdateInsertDelete(sql);
            ControlPanel.Controls.Remove(Td);
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }
        //Thêm chức năng nút edit cho lập lịch
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
                Td.DescriptionTB.ForeColor = Color.Black;
                if (Convert.ToInt32(row["Important"]) == 1)
                {
                    Td.ImportantCheck.Checked = true;
                }
                else
                {
                    Td.ImportantCheck.Checked = false;
                }

            }
            Td.MainNote.ForeColor = Color.Black;
            if (Td.ShowDialog() == DialogResult.OK)
            {
                ControlPanel.Controls.Clear();
                AddNoteToDay();
            }
        }
        //Thêm chức năng nút chi tiết cho lập lịch
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
            Td.RepeatCB.Enabled = false;
            Td.ToDtpk.Enabled = false;
            Td.ImportantCheck.Enabled = false;
            Td.SaveBtn.Visible = false;
            Td.ShowDialog();
        }

        //Thêm chức năng nút xóa cho deadline

        void DL_Deleted(object sender, EventArgs e)
        {
            DeadLineControl DL = sender as DeadLineControl;
            string sql = $"delete from Deadline where IdDeadline = {DL.Tag}";
            NoteData.UpdateInsertDelete(sql);
            ControlPanel.Controls.Remove(DL);
            ControlPanel.Controls.Clear();
            AddNoteToDay();
        }

        //Thêm chức năng nút edit cho lập lịch

        void DL_Edited(object sender, EventArgs e)
        {
            DeadLineControl DLC = sender as DeadLineControl;
            var DL = new DeadLineNote();
            DL.MainNote.ForeColor = Color.Black;
            DL.DescriptionTB.ForeColor = Color.Black;
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
                DL.MainNote.ForeColor = Color.Black;
                DL.DescriptionTB.ForeColor = Color.Black;
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
            if (DL.ShowDialog() == DialogResult.OK)
            {
                ControlPanel.Controls.Clear();
                AddNoteToDay();
            }
        }

        //Thêm chức năng nút chi tiết cho deadline

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
            DL.UrgentCB.Enabled = false;
            DL.ImportantCheck.Enabled = false;
            DL.SaveBtn.Visible = false;
            DL.ShowDialog();
        }

        //Thay đổi trạng thái done

        private void DL_Done(object sender, EventArgs e)
        {
            string sql;
            DeadLineControl DLC = sender as DeadLineControl;
            if (DLC.DoneCB.Checked == true)
            {
                sql = $"update Deadline set Priority = '{5}' where IdDeadline = { DLC.Tag}";
                NoteData.UpdateInsertDelete(sql);
                AddNoteToDay();
            }   
            else
            {
                sql = $"update Deadline set Priority = '{0}' where IdDeadline = { DLC.Tag}";
                NoteData.UpdateInsertDelete(sql);
                AddNoteToDay();
            }
        }
        #endregion


        #region Các nút chức năng trong Form chung
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

        private void DeadlineBtn_Click(object sender, EventArgs e)
        {
            Button = 2;
            DeadlineBtn.FillColor = Color.Transparent;
            TodoBtn.FillColor = Color.PaleTurquoise;
            AddNoteToDay();
        }

        private void ToDoBtn_Click(object sender, EventArgs e)
        {
            Button = 1;
            TodoBtn.FillColor = Color.Transparent;
            DeadlineBtn.FillColor = Color.PaleTurquoise;
            AddNoteToDay();
        }

        private void GeneralNoteForm_Load(object sender, EventArgs e)
        {
            TodoBtn.FillColor = Color.Transparent;
        }
        #endregion
    }
}
