using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Calendar
{
    public partial class CalendarProject : Form
    {
        
        #region Các nút hiển thị usercontrol
        public CalendarProject()
        {
            InitializeComponent();
            SetUpPanelSetting();
        }
        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ButtonWeatherForecast_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
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
            ActivateButton(sender, RGBColors.color2);
            var Lunnar = new DisplayLunnar(dtpk.Value);
            Lunnar.Location = new Point(0, 0);
            Lunnar.Size = new Size(1009, 620);
            Lunnar.DTPK += Lunnar_DTPK;
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(Lunnar);
        }

        void Lunnar_DTPK(object sender, EventArgs e)
        {
            ActivateButton(ButtonCalendar, RGBColors.color2);
            condition = 2;
            DisplayLunnar display = sender as DisplayLunnar;
            dtpk.Value = display.dtpk.Value;
        }

        private void ButtonDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
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
            ActivateButton(ButtonCalendar, RGBColors.color2);
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
            ActivateButton(sender, RGBColors.color7);
            var ChangeDate = new DisplayChangeDate();
            ChangeDate.Location = new Point(0, 0);
            ChangeDate.Size = new Size(1009, 620);
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(ChangeDate);
            ChangeDate.Detail += Detail_Btn;
            ChangeDate.DetailLunnar += DetailLunnar_Btn;
        }
        void Detail_Btn(object sender, EventArgs e)
        {
            DisplayChangeDate displayDate = sender as DisplayChangeDate;
            PanelDisplay.Controls.Clear();

            ActivateButton(ButtonDetailDate, RGBColors.color3);
            DisplayDetailDate DetailDate = new DisplayDetailDate(displayDate.Solar);
            DetailDate.Location = new Point(0, 0);
            DetailDate.Size = new Size(1009, 620);
            PanelDisplay.Controls.Add(DetailDate);
        }
        void DetailLunnar_Btn(object sender, EventArgs e)
        {
            DisplayChangeDate displayDate = sender as DisplayChangeDate;
            PanelDisplay.Controls.Clear();

            ActivateButton(ButtonDate, RGBColors.color1);
            DisplayDate displaydate = new DisplayDate(displayDate.Lunar);
            PanelDisplay.Controls.Add(displaydate);
        }

        private void ButtonHistory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            if (!PanelDisplay.Contains(DisplayDetailEvent.DetailEventDisplay))
            {
                PanelDisplay.Controls.Add(DisplayDetailEvent.DetailEventDisplay);
                DisplayDetailEvent.DetailEventDisplay.Dock = DockStyle.Fill;
                DisplayDetailEvent.DetailEventDisplay.BringToFront();
            }
            else
                DisplayDetailEvent.DetailEventDisplay.BringToFront();
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
                ActivateButton(ButtonDetailDate, RGBColors.color3);
                AddDisplayDetailDateCondition(date);
            }
            else if (condition == 0)
            {
                ActivateButton(ButtonDate, RGBColors.color1);
                AddDisplayDateCondition(date);
            }
        }

        private void buttonDetailDate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
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
            ActivateButton(sender, RGBColors.color8);
            var VanKhan = new DisplayVanKhan();
            VanKhan.Location = new Point(0, 0);
            VanKhan.Size = new Size(1009, 590);
            PanelDisplay.Controls.Clear();
            PanelDisplay.Controls.Add(VanKhan);
            VanKhan.Dock = DockStyle.Fill;
        }

        private void buttonTuVi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color9);
            if (!PanelDisplay.Contains(DisplayTuVi.TuViDisplay))
            {
                PanelDisplay.Controls.Add(DisplayTuVi.TuViDisplay);
                DisplayTuVi.TuViDisplay.Dock = DockStyle.Fill;
                DisplayTuVi.TuViDisplay.BringToFront();
            }
            else
                DisplayTuVi.TuViDisplay.BringToFront();
        }

        private void buttonHDSD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color10);
            if (!PanelDisplay.Contains(DisplayTutorial.Tutorial))
            {
                PanelDisplay.Controls.Add(DisplayTutorial.Tutorial);
                DisplayTutorial.Tutorial.Dock = DockStyle.Fill;
                DisplayTutorial.Tutorial.BringToFront();
            }
            else
                DisplayTutorial.Tutorial.BringToFront();
        }

        private void buttonCountDay_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            if (!PanelDisplay.Contains(DisplayCountDay.CountDayDisplay))
            {
                PanelDisplay.Controls.Add(DisplayCountDay.CountDayDisplay);
                DisplayCountDay.CountDayDisplay.Dock = DockStyle.Fill;
                DisplayCountDay.CountDayDisplay.BringToFront();
            }
            else
                DisplayCountDay.CountDayDisplay.BringToFront();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            ClockLB.Text = DateTime.Now.ToString("T");
            ClockLB.Location = new Point(PanelIcon.Size.Width / 2 - ClockLB.Size.Width / 2, 12);
        }

        //Fields
        private Guna2Button currentBtn;
        private Panel leftBorderBtn;
        //Constructor
        public void SetUpPanelSetting()
        {
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, 45);
            PanelSetting.Controls.Add(leftBorderBtn);
        }
        //Structs
        private struct RGBColors
        {
            //Màu cho Button Date (Lịch Ngày)
            public static Color color1 = Color.LightCoral;

            //Màu cho Button Calendar (Lịch Âm)
            public static Color color2 = Color.Orange;

            //Màu cho Button DetailDate (Lịch Chi Tiết)
            public static Color color3 = Color.Red;

            //Màu cho Button History (Sự Kiện Lịch Sử)
            public static Color color4 = Color.Purple;

            //Màu cho Button CountDay (Đếm Ngày)
            public static Color color5 = Color.Pink;

            //Màu cho Button Weather (Thời Tiết)
            public static Color color6 = Color.Brown;

            //Màu cho Button ChangeDate (Đổi Ngày Âm Dương)
            public static Color color7 = Color.Green;

            //Màu cho Button VanKhan (Văn Khấn)
            public static Color color8 = Color.PaleTurquoise;

            //Màu cho Button TuVi (Tử Vi)
            public static Color color9 = Color.BurlyWood;

            //Màu cho Button HDSD (Hướng Dẫn Sử Dụng)
            public static Color color10 = Color.Maroon;
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Guna2Button)senderBtn;
                currentBtn.BackColor = Color.Cornsilk;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = HorizontalAlignment.Center;
                currentBtn.ImageAlign = HorizontalAlignment.Right;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = HorizontalAlignment.Left;
                currentBtn.ImageAlign = HorizontalAlignment.Left;
            }
        }
        #endregion


        #region Chạy ngầm
        public int CountSchedule = 0;
        public int CountDeadline = 0;
        private void CalendarProject_Load(object sender, EventArgs e)
        {
            Count();
            NotifyIcon1.ShowBalloonTip(100, "Số việc trong ngày", "Hôm nay có " + CountSchedule + " công việc và còn " + CountDeadline + " Deadline", ToolTipIcon.Info);
            dtpk.Value = DateTime.Now;
            ClockLB.Text = DateTime.Now.ToString("T");
            ClockLB.Location = new Point(PanelIcon.Size.Width / 2 - ClockLB.Size.Width / 2, 12);
            timer1.Start();
        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        //Đếm số lịch trong ngày và đếm deadline
        private void Count()
        {
            DateTime datefirst = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            DateTime dateafter = datefirst.AddDays(1).AddSeconds(-1);

            string sql = $"select * from NoteByDate where AppDate between #{datefirst.ToShortDateString()}# and #{dateafter.ToShortDateString()}#";
            DataTable dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                CountSchedule++;
            }
            sql = $"select * from Deadline where Priority <> {5} and Priority <> {6}";
            dt = NoteData.QueryAsDatatable(sql);
            foreach (DataRow row in dt.Rows)
            {
                CountDeadline++;
            }
        }
        

        private void thêmCôngViệcTrongNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDoNote ToDo = new ToDoNote();
            ToDo.FromDtpk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            ToDo.ToDtpk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            ToDo.ShowDialog();
        }

        private void thêmDeadlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeadLineNote Deadline = new DeadLineNote();
            Deadline.Dtpk.Value = DateTime.Now;
            Deadline.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void hiệnLịchNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelDisplay.Controls.Clear();
            dtpk.Value = DateTime.Now;
            var displayDate = new DisplayDate(dtpk.Value)
            {
                Size = new Size(1009, 620),
                Location = new Point(0, 0),
                Dock = DockStyle.Fill,
            };
            displayDate.MonthBtn += DateDisplay_MonthBtn;
            displayDate.Nextbtn += DateDisplay_NextBtn;
            displayDate.Prebtn += DateDisplay_PreBtn;
            displayDate.TDbtn += DateDisplay_TDBtn;
            ActivateButton(ButtonDate, RGBColors.color1);
            PanelDisplay.Controls.Add(displayDate);
            this.Show();
            NotifyIcon1.ShowBalloonTip(100, "Số việc trong ngày", "Hôm nay có " + CountSchedule + " công việc và còn " + CountDeadline + " Deadline", ToolTipIcon.Info);
        }

        private void hiệnGhiChúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIcon1.ShowBalloonTip(100, "Số việc trong ngày", "Hôm nay có " + CountSchedule + " công việc và còn " + CountDeadline + " Deadline", ToolTipIcon.Info);
            GeneralNoteForm NoteForm = new GeneralNoteForm();
            NoteForm.Dtpk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            NoteForm.ShowDialog();
        }

        private void thêmDeadlineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DeadLineNote Deadline = new DeadLineNote();
            Deadline.Dtpk.Value = DateTime.Now;
            Deadline.ShowDialog();
        }

        private void thêmCôngViệcTrongNgàyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ToDoNote ToDo = new ToDoNote();
            ToDo.FromDtpk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            ToDo.ToDtpk.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            ToDo.ShowDialog();
        }

        private void NotifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            NotifyIcon1.ShowBalloonTip(100, "Số việc trong ngày", "Hôm nay có " + CountSchedule + " công việc và còn " + CountDeadline + " Deadline", ToolTipIcon.Info);
        }
        #endregion
    }
}
