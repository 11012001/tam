using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DisplayDate : UserControl
    {
        private static DisplayDate instance;
        private LunnarSample.LunnarCalendar lunnarCalendar = new LunnarSample.LunnarCalendar();
        private int timeZone = 7;
        private DateTime date = DateTime.Now;
        private int[] idate = new int[3];

        public static DisplayDate Instance 
        { 
            get
            {
                if (instance == null)
                    instance = new DisplayDate();
                return instance;
            } 
        }

        public DisplayDate()
        {
            idate = lunnarCalendar.ConvertSolarDateToLunarDate(date.Day, date.Month, date.Year, timeZone);
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            buttonMY_Paint();
            buttonD_Paint();
            buttonDOW_Paint();
            buttonLunnarDay_Paint();
            buttonLunnarMonth_Paint();
            buttonLunnarYear_Paint();
            buttonPre_Paint();
            buttonNext_Paint();
            buttonToday_Paint();
            buttonZodiacTime_Paint();
            ShowLunnarDate();
        }
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            date = (sender as DateTimePicker).Value;
            idate = lunnarCalendar.ConvertSolarDateToLunarDate(date.Day, date.Month, date.Year, timeZone);
            buttonLunnarDate.IMonth = idate[1];
        }

        private void buttonMY_Paint()
        {
            buttonMY.Size = new Size(Convert.ToInt32(this.Width * 10 / 27),Convert.ToInt32(this.Height * 7 / 74));
            buttonMY.Location = new Point(Convert.ToInt32(this.Width * 11 / 36),Convert.ToInt32(this.Height * 7 / 148));
            string sM = date.Month.ToString() + "/" + date.Year.ToString();
            int min = buttonMY.Width > buttonMY.Height ? buttonMY.Height : buttonMY.Width;
            int fontSizeMY = Convert.ToInt32(min * 0.3);
            Font fontMY = new Font("Verdana", fontSizeMY, FontStyle.Bold);
            buttonMY.Font = fontMY;
            buttonMY.BackgroundColor = Color.Empty;
            buttonMY.HoverBackgroundColor = Color.Empty;
            buttonMY.TextColor = Color.Red;
            buttonMY.ButtonText = sM;
        }
        private void buttonD_Paint()
        {
            buttonDay.Size = new Size(Convert.ToInt32(this.Width * 10 / 27), Convert.ToInt32(this.Height * 17 / 74));
            buttonDay.Location = new Point(Convert.ToInt32(this.Width * 11 / 36), Convert.ToInt32(this.Height * 11 / 74));
            string sD = date.Day.ToString();
            int min = buttonDay.Width > buttonDay.Height ? buttonDay.Height : buttonDay.Width;
            int fontSizeDay = Convert.ToInt32(min * 0.35);
            Font fontDay = new Font("Verdana", fontSizeDay, FontStyle.Bold);
            buttonDay.Font = fontDay;
            buttonDay.BackgroundColor = Color.Empty;
            buttonDay.HoverBackgroundColor = Color.Empty;
            buttonDay.TextColor = Color.DodgerBlue;
            buttonDay.ButtonText = sD;
        }
        private void buttonDOW_Paint()
        {
            labelDOW.Location = new Point(Convert.ToInt32(this.Width * 19 / 54), Convert.ToInt32(this.Height * 24 / 37));
            string sDOW = lunnarCalendar.GetThu(date);
            int min = this.Width * 10 / 27 > this.Height * 3 / 37 ? this.Height * 3 / 37 : this.Width * 10 / 27;
            int fontSizeDOW = Convert.ToInt32(min * 0.25);
            Font fontDOW = new Font("Verdana", fontSizeDOW, FontStyle.Bold);
            labelDOW.Font = fontDOW;
            labelDOW.BackColor = Color.Empty;
            labelDOW.ForeColor = Color.Lime;
            labelDOW.Text = sDOW;
        }
        private void buttonLunnarDay_Paint()
        {
            labelDay.Location = new Point(Convert.ToInt32(this.Width * 1 / 9), Convert.ToInt32(this.Height * 28 / 37));
            labelLunnarDay.Location = new Point(Convert.ToInt32(this.Width * 5 / 108), Convert.ToInt32(this.Height * 29 / 37));
            string sLunnarDay = lunnarCalendar.GetCanNgay(date) + " " + lunnarCalendar.GetChiNgay(date);
            int min = this.Width * 5 / 18 > this.Height * 3 / 37 ? this.Height * 3 / 37 : this.Width * 5 / 18;
            int fontSizeLD = Convert.ToInt32(min * 0.2);
            Font fontLD = new Font("Verdana", fontSizeLD, FontStyle.Bold);
            int fontSizeDay = Convert.ToInt32(min * 1 / 6);
            Font fontDay = new Font("Verdana", fontSizeDay, FontStyle.Bold);
            labelDay.Text = "Ngày";
            labelDay.Font = fontDay;
            labelDay.ForeColor = Color.White;
            label1.Location = new Point(Convert.ToInt32(this.Width * 1 / 27), Convert.ToInt32(this.Height * 31 / 37));
            label1.Width = Convert.ToInt32(this.Width * 0.25);
            label1.Height = 4;
            label1.AutoSize = false;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.BackColor = Color.Yellow;
            labelLunnarDay.Font = fontLD;
            labelLunnarDay.BackColor = Color.Empty;
            labelLunnarDay.ForeColor = Color.CornflowerBlue;
            labelLunnarDay.Text = sLunnarDay;
        }
        private void buttonLunnarMonth_Paint()
        {
            labelMonth.Location = new Point(Convert.ToInt32(this.Width * 7 / 9), Convert.ToInt32(this.Height * 28 / 37));
            labelMonthLunnar.Location = new Point(Convert.ToInt32(this.Width * 13 / 18), Convert.ToInt32(this.Height * 29 / 37));
            string sLunnarMonth = lunnarCalendar.GetCanThang(idate[1], idate[2]) + " " + lunnarCalendar.GetChiThang(idate[1]);
            int min = this.Width * 5 / 18 > this.Height * 3 / 37 ? this.Height * 3 / 37 : this.Width * 5 / 18;
            int fontSizeLM = Convert.ToInt32(min * 0.2);
            Font fontLM = new Font("Verdana", fontSizeLM, FontStyle.Bold);
            int fontSizeMonth = Convert.ToInt32(min * 1 / 6);
            Font fontMonth = new Font("Verdana", fontSizeMonth, FontStyle.Bold);
            labelMonth.Text = "Tháng";
            labelMonth.Font = fontMonth;
            labelMonth.ForeColor = Color.White;
            labelMonthLunnar.Font = fontLM;
            labelMonthLunnar.BackColor = Color.Empty;
            labelMonthLunnar.ForeColor = Color.CornflowerBlue;
            labelMonthLunnar.Text = sLunnarMonth;
            label2.Location = new Point(Convert.ToInt32(this.Width * 19 / 27), Convert.ToInt32(this.Height * 31 / 37));
            label2.Width = Convert.ToInt32(this.Width * 0.25);
            label2.Height = 4;
            label2.AutoSize = false;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.BackColor = Color.Yellow;
        }
        private void buttonLunnarYear_Paint()
        {           
            labelYearLunnar.Location = new Point(Convert.ToInt32(this.Width * 13 / 18), Convert.ToInt32(this.Height * 32 / 37));
            string sLunnarYear = lunnarCalendar.GetCanNam(idate[2]) + " " + lunnarCalendar.GetChiNam(idate[2]);
            int min = this.Width * 5 / 18 > this.Height * 3 / 37 ? this.Height * 3 / 37 : this.Width * 5 / 18;
            int fontSizeLY = Convert.ToInt32(min * 0.2);
            Font fontLY = new Font("Verdana", fontSizeLY, FontStyle.Bold);
            labelYearLunnar.Font = fontLY;
            labelYearLunnar.BackColor = Color.Empty;
            labelYearLunnar.ForeColor = Color.CornflowerBlue;
            labelYearLunnar.Text = sLunnarYear;
        }
        private void buttonZodiacTime_Paint()
        {
            labelZodiacTime.Location = new Point(Convert.ToInt32(this.Width * 1 / 54), Convert.ToInt32(this.Height * 71 / 74));
            string sZodiacTime = lunnarCalendar.GetZodiacTime(date);
            int min = this.Width * 2 / 9 > this.Height * 1 / 37 ? this.Height * 1 / 37 : this.Width * 2 / 9;
            int fontSizeZT = Convert.ToInt32(min * 0.35); 
            Font fontZT = new Font("Verdana", fontSizeZT, FontStyle.Bold);
            labelZodiacTime.Font = fontZT;
            labelZodiacTime.BackColor = Color.Empty;
            labelZodiacTime.ForeColor = Color.CornflowerBlue;
            labelZodiacTime.Text = sZodiacTime;
        }
        private void buttonPre_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(-1);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
        }

        private void buttonToday_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string sTime = DateTime.Now.ToLongTimeString();
            int width = Convert.ToInt32(this.Width * 5 / 18);
            int height = Convert.ToInt32(this.Height * 3 / 37);
            int min = width > height ? height : width;
            int fontSizeHour = Convert.ToInt32(min * 0.2);
            Font fontHour = new Font("Verdana", fontSizeHour, FontStyle.Bold);
            labelTime.Location = new Point(Convert.ToInt32(this.Width * 1 / 36), Convert.ToInt32(this.Height * 32 / 37));
            labelTime.Font = fontHour;
            labelTime.ForeColor = Color.CornflowerBlue;
            labelTime.Text = sTime;
        }

        private void DisplayDate_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
        }

        private void buttonPre_Paint()
        {
            buttonPre.Size = new Size(Convert.ToInt32(this.Width * 1 / 6), Convert.ToInt32(this.Height * 9 / 74));
            buttonPre.Location = new Point(Convert.ToInt32(this.Width * 1 / 54), Convert.ToInt32(this.Height * 35 / 74));
            int min = buttonPre.Width > buttonPre.Height ? buttonPre.Height : buttonPre.Width;
            int fontSizeDOW = Convert.ToInt32(min * 0.15);
            Font fontDOW = new Font("Verdana", fontSizeDOW, FontStyle.Bold);
            buttonPre.Font = fontDOW;
            buttonPre.BackgroundColor = Color.Empty;
            buttonPre.TextColor = Color.Lime;
            buttonPre.ButtonText = "Previous";
        }
        private void buttonNext_Paint()
        {
            buttonNext.Size = new Size(Convert.ToInt32(this.Width * 1 / 6), Convert.ToInt32(this.Height * 9 / 74));
            buttonNext.Location = new Point(Convert.ToInt32(this.Width * 22 / 27), Convert.ToInt32(this.Height * 35 / 74));
            int min = buttonNext.Width > buttonNext.Height ? buttonNext.Height : buttonNext.Width;
            int fontSizeDOW = Convert.ToInt32(min * 0.15);
            Font fontDOW = new Font("Verdana", fontSizeDOW, FontStyle.Bold);
            buttonNext.Font = fontDOW;
            buttonNext.BackgroundColor = Color.Empty;
            buttonNext.TextColor = Color.Lime;
            buttonNext.ButtonText = "Next";
        }
        private void buttonToday_Paint()
        {
            buttonToday.Size = new Size(Convert.ToInt32(this.Width * 7 / 54), Convert.ToInt32(this.Height * 13 / 148));
            buttonToday.Location = new Point(Convert.ToInt32(this.Width * 13 / 108), Convert.ToInt32(this.Height * 1 / 74));
            int min = buttonToday.Width > buttonToday.Height ? buttonToday.Height : buttonToday.Width;
            int fontSizeDOW = Convert.ToInt32(min * 0.15);
            Font fontDOW = new Font("Verdana", fontSizeDOW, FontStyle.Bold);
            buttonToday.Font = fontDOW;
            buttonToday.ButtonStyle = XanderUI.XUIButton.Style.MacOS;
            buttonToday.BackgroundColor = Color.Empty;
            buttonToday.HoverBackgroundColor = Color.Empty;
            buttonToday.TextColor = Color.Lime;
            buttonToday.ButtonText = DateTime.Now.Day.ToString();
        }         
        private void ShowLunnarDate()
        {
            buttonLunnarDate.Size = new Size(Convert.ToInt32(this.Width * 10 / 27),Convert.ToInt32(this.Height * 15 / 74));
            buttonLunnarDate.Location = new Point(Convert.ToInt32(this.Width * 11 / 36), Convert.ToInt32(this.Height * 53 / 74));
            buttonLunnarDate.ButtonText = idate[0].ToString();
            string sD = idate[0].ToString();
            int min = buttonLunnarDate.Width > buttonLunnarDate.Height ? buttonLunnarDate.Height : buttonLunnarDate.Width;
            int fontSizeDay = Convert.ToInt32(min * 0.3);
            Font fontDay = new Font("Verdana", fontSizeDay, FontStyle.Bold);
            buttonLunnarDate.Font = fontDay;
            buttonLunnarDate.BackgroundColor = Color.SandyBrown;
            buttonLunnarDate.HoverBackgroundColor = Color.SandyBrown;
            buttonLunnarDate.TextColor = Color.White;
            buttonLunnarDate.ColorMonth = Color.PaleTurquoise;
            buttonLunnarDate.ColorLine = Color.LightGoldenrodYellow;
            buttonLunnarDate.ButtonText = sD;
            buttonLunnarDate.IMonth = idate[1];
        }
    }
       
}
