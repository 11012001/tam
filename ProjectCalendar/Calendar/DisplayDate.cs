using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;

namespace Calendar
{
    public partial class DisplayDate : UserControl
    {
        private static DisplayDate dateDisplay;
        public Color ColorSolar { get; set; }
        public Color ColorLunnar { get; set; }
        public Color ColorHourLunnar { get; set; }

        public DateTime Date = DateTime.Now;

        public DisplayDate()
        {
            InitializeComponent();
        }
        public DisplayDate(DateTime date)
        {
            dtpk.Value = date;
            InitializeComponent();
        }
        public static DisplayDate DateDisplay
        {
            get
            {
                if (dateDisplay == null)
                    dateDisplay = new DisplayDate();
                return dateDisplay;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DisplaySolarDate();
            DisplayLunnar();
        }

        #region Lấy thông tin giờ, giờ âm
        private void timer_Tick(object sender, EventArgs e)
        {
            //Thông tin giờ
            string sTime = DateTime.Now.ToLongTimeString();
            labelHour.Text = sTime;

            //Thông tin giờ âm
            LunnarSample.LunnarCalendar lunnar = new LunnarSample.LunnarCalendar();
            int hour = DateTime.Now.Hour;
            labelHourLunnar.Text = string.Format("Giờ {0}",lunnar.GetGioAm(hour));

        }
        //Sự kiện để lấy thông tin giờ
        private void DisplayDate_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            DisplayQuote();
            DisplayEvent();
        }
        #endregion

        #region Hiển thị ngày

        #region Sự kiện để thay đổi giá trị của ngày
        //Sự kiện của DateTimePicker để thay đổi giá trị của ngày
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as DateTimePicker).Value;
            Date = date;
            DisplayQuote();
            DisplayEvent();
        }
        #endregion

        #region Hiển thị thông tin ngày dương lịch
        private void DisplaySolarDate()
        {
            LunnarSample.LunnarCalendar lunnar = new LunnarSample.LunnarCalendar();
            //Lấy thông tin ngày, thứ
            if (Date.Day >= 10)
            {
                labelDay.Text = Date.Day.ToString();
                labelDay.ForeColor = ColorSolar;
                labelDay.Location = new Point(0, 0);
                labelDOW.Text = lunnar.GetThu(Date);
                labelDOW.ForeColor = ColorSolar;
            }
            else
            {
                labelDay.Text = Date.Day.ToString();
                labelDay.ForeColor = ColorSolar;
                labelDay.Location = new Point(34, 0);
                labelDOW.Text = lunnar.GetThu(Date);
                labelDOW.ForeColor = ColorSolar;
            }

            //Lấy thông tin tháng và năm
            ButtonMonth.Text = string.Format("THÁNG {0} - {1}",Date.Month.ToString(),Date.Year.ToString());

            //Lấy thông tin ngày hiện tại ở buttonToday
            ButtonToday.Text = DateTime.Now.Day.ToString();
        }
        #endregion

        #region Hiển thị thông tin lịch âm
        private void DisplayLunnar()
        {
            DisplayLunnarDate(Date);
            DisplayLunnarNameDate(Date);
            DisplayLunnarZodiacHour(Date);
        }

        //Hiển thị ngày âm, tháng âm và giờ hoàng đạo
        private void DisplayLunnarDate(DateTime date)
        {
            #region Chú thích
            LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            LunnarSample.LunnarCalendar lunnar = new LunnarSample.LunnarCalendar();
            #endregion

            #region Lấy thông tin ngày âm
            if (lunnardate.Day >= 10)
            {
                labelLunnarDay.Text = lunnardate.Day.ToString();
                labelLunnarDay.ForeColor = ColorLunnar;
                labelLunnarDay.Location = new Point(43, 28);
            }
            else
            {
                labelLunnarDay.Text = lunnardate.Day.ToString();
                labelLunnarDay.ForeColor = ColorLunnar;
                labelLunnarDay.Location = new Point(60, 28);
            }
            #endregion

            #region Lấy thông tin ngày hoàng đạo
            if (lunnar.IsZodiacDay(date,lunnardate.Month)  == 1)
            {
                PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
                PictureZodiac.IconColor = Color.White;
            }
            else if (lunnar.IsZodiacDay(date, lunnardate.Month) == -1)
            {
                PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
                PictureZodiac.IconColor = Color.Black;
            }
            else
            {
                PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.None;
            }
            #endregion

            #region Lấy thông tin tháng âm
            ButtonLunnarMonth.Text = string.Format("Tháng {0}",lunnardate.MonthShortName);
            #endregion

        }

        //Hiển thị tên của ngày, tháng, năm
        private void DisplayLunnarNameDate(DateTime date)
        {
            #region Chú thích
            LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            LunnarSample.LunnarCalendar lunnar = new LunnarSample.LunnarCalendar();
            #endregion

            #region Hiển thị thông tin 
            labelLunnarDayName.Text = string.Format("Ngày {0}",lunnardate.DayName);

            labelLunnarMonthName.Text = string.Format("Tháng {0}",lunnardate.MonthLongName);
            int SizeText = labelLunnarMonthName.Text.Length;
            if(SizeText > 15)
            {
                labelLunnarMonthName.Location = new Point(0,45);
            }    
            else
            {
                labelLunnarMonthName.Location = new Point(22, 45);
            }

            labelLunnarYearName.Text = string.Format("Năm {0}",lunnardate.YearName);
            #endregion
        }

        //Hiển thị thông tin giờ hoàng đạo
        private void DisplayLunnarZodiacHour(DateTime date)
        {
            #region Chú thích
            LunnarSample.LunnarCalendar lunnar = new LunnarSample.LunnarCalendar();
            #endregion

            #region Thông tin giờ hoàng đạo
            string[] ZodiacHours = lunnar.GetZodiacTimeSmallVersion(date).Split(',');
            labelZodiac1.Text = string.Format(" {0}, {1}, {2}",ZodiacHours[0],ZodiacHours[1],ZodiacHours[2]);
            labelZodiac2.Text = string.Format(" {0}, {1}, {2}", ZodiacHours[3], ZodiacHours[4], ZodiacHours[5]);
            #endregion
        }
        #endregion

        #region Các sự kiện liên quan tới ngày
        //Sự kiện khi nhấn vào ButtonPrevious để trở lại 1 ngày
        private void ButtonPre_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(-1);
        }
        //Sự kiện khi nhấn vào ButtonNext để tiến tới 1 ngày
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
        }
        //Sự kiện khi nhấn vào ButtonToday để quay trở lại hiện tại
        private void ButtonToday_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }
        #endregion

        #endregion

        #region Hiển thị câu châm ngôn
        //Căt dòng trong chuỗi
        private string SlipQuote(string s)
        {
            if (s.Length < 60)
                return s;
            string text = "";
            string str = "";
            string[] words = s.Split(' ');
            int num = 0;
            foreach(var word in words)
            {
                num++;
                str = string.Format("{0} {1}",str,word);
                if(num > 13)
                {
                    str = string.Format("{0}\n",str);
                    num = 0;
                }

            }
            text = string.Format("{0}.", str);
            return text;
        }
        //Hiển thị thông tin châm ngôn
        private void DisplayQuote()
        {
            LunnarSample.StringText text = new LunnarSample.StringText();
            text.GetQuote();
            LunnarSample.StringText.QuoteClass quote = text.MakeRandomQuote();
            labelQuote.Text = SlipQuote(quote.Quote);
            labelAuthor.Text = quote.Author;
        }
        #endregion

        #region Hiển thị ngày lễ
        void DisplayEvent()
        {
            labelEvent.Text=PublicDate.IsPublicString(dtpk.Value);
        }
        #endregion
    }
}
