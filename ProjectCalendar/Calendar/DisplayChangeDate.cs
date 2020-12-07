using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;

namespace Calendar
{
    public partial class DisplayChangeDate : UserControl
    {
        private static DisplayChangeDate changedatedisplay;
        public DisplayChangeDate()
        {
            InitializeComponent();
        }
        public static DisplayChangeDate ChangeDateDisplay
        {
            get
            {
                if (changedatedisplay == null)
                    changedatedisplay = new DisplayChangeDate();
                return changedatedisplay;
            }
        }

        #region Thêm số liệu vào ComboBox của lịch dương
        private void SetUpSolar()
        {
            #region Set Up Năm
            ComboBoxSolarYear.Items.AddRange(Enumerable.Range(1, 9999).Select(i => (object)i).ToArray());
            int year = DateTime.Now.Year;
            ComboBoxSolarYear.Text = year.ToString();
            #endregion

            //Set Up Tháng
            SetUpMonth(year);

            //Set Up Ngày
            string sMonth = ComboBoxSolarMonth.Text;
            SetUpDay(sMonth, year);
        }

        #region Set Up Tháng
        private void SetUpMonth(int year)
        {
            ComboBoxSolarMonth.Items.Clear();
            ComboBoxSolarMonth.Items.AddRange(new object[]
                {
                    "Tháng Một",
                    "Tháng Hai",
                    "Tháng Ba",
                    "Tháng Tư",
                    "Tháng Năm",
                    "Tháng Sáu",
                    "Tháng Bảy",
                    "Tháng Tám",
                    "Tháng Chín",
                    "Tháng Mười",
                    "Tháng Mười Một",
                    "Tháng Mười Hai"
                });
            string s = "";
            switch (DateTime.Now.Month)
            {
                case 1:
                    s = "Tháng Một";
                    break;
                case 2:
                    s = "Tháng Hai";
                    break;
                case 3:
                    s = "Tháng Ba";
                    break;
                case 4:
                    s = "Tháng Tư";
                    break;
                case 5:
                    s = "Tháng Năm";
                    break;
                case 6:
                    s = "Tháng Sáu";
                    break;
                case 7:
                    s = "Tháng Bảy";
                    break;
                case 8:
                    s = "Tháng Tám";
                    break;
                case 9:
                    s = "Tháng Chín";
                    break;
                case 10:
                    s = "Tháng Mười";
                    break;
                case 11:
                    s = "Tháng Mười Một";
                    break;
                case 12:
                    s = "Tháng Mười Hai";
                    break;
                default:
                    break;
            }
            ComboBoxSolarMonth.Text = s;

        }
        #endregion

        #region Set Up Ngày
        private void SetUpDay(string sMonth,int year)
        {
            ComboBoxSolarDay.Items.Clear();
            switch (sMonth)
            {
                case "Tháng Một":
                case "Tháng Ba":
                case "Tháng Năm":
                case "Tháng Bảy":
                case "Tháng Tám":
                case "Tháng Mười":
                case "Tháng Mười Hai":
                    ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 31).Select(i => (object)i).ToArray());
                    break;
                case "Tháng Tư":
                case "Tháng Sáu":
                case "Tháng Chín":
                case "Tháng Mười Một":
                    ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 30).Select(i => (object)i).ToArray());
                    break;
                case "Tháng Hai":
                    if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                        ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 29).Select(i => (object)i).ToArray());
                    else
                        ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 28).Select(i => (object)i).ToArray());
                    break;
                default:
                    break;
            }
            ComboBoxSolarDay.Text = DateTime.Now.Day.ToString();
        }
        #endregion

        #endregion

        #region Thêm số liệu vào ComboBox của lịch âm
        private void SetUpLunnar()
        {
            #region Set Up Năm Âm
            ComboBoxLunnarYear.Items.AddRange(Enumerable.Range(1, 9999).Select(i => (object)i).ToArray());
            LuniSolarYear<VietnameseLocalInfoProvider> lunarDate = LuniSolarCalendar<VietnameseLocalInfoProvider>.GetLunarYear(DateTime.Now.Year);
            ComboBoxLunnarYear.Text = lunarDate.Year.ToString();
            int year = lunarDate.Year;
            #endregion

            //Set up Tháng
            SetUpLunnarMonth(year);

            //Set up Ngày
            string sMonth = ComboBoxLunnarMonth.Text;
            SetUpLunnarDay(sMonth, year);
        }

        #region Set Up Tháng Âm
        private void SetUpLunnarMonth(int year)
        {
            ComboBoxLunnarMonth.Items.Clear();

            LuniSolarYear<VietnameseLocalInfoProvider> lunarYear = LuniSolarCalendar<VietnameseLocalInfoProvider>.GetLunarYear(year);
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            DateTime date = new DateTime(year, month, day);
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);

            //Kiểm tra năm đó có phải năm nhuận không
            if (lunarYear.IsLeapYear == false)
            {
                ComboBoxLunnarMonth.Items.AddRange(new object[]
                {
                    "Tháng Giêng",
                    "Tháng Hai",
                    "Tháng Ba",
                    "Tháng Tư",
                    "Tháng Năm",
                    "Tháng Sáu",
                    "Tháng Bảy",
                    "Tháng Tám",
                    "Tháng Chín",
                    "Tháng Mười",
                    "Tháng Mười Một",
                    "Tháng Chạp"
                });
            }
            else
            {
                ComboBoxLunnarMonth.Items.Add("Tháng Giêng");
                ComboBoxLunnarMonth.Items.Add("Tháng Hai");
                if (lunarYear.LeapMonthIndex - 2 == 2)
                    ComboBoxLunnarMonth.Items.Add("Tháng Hai nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Ba");
                if (lunarYear.LeapMonthIndex - 2 == 3)
                    ComboBoxLunnarMonth.Items.Add("Tháng Ba nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Tư");
                if (lunarYear.LeapMonthIndex - 2 == 4)
                    ComboBoxLunnarMonth.Items.Add("Tháng Tư nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Năm");
                if (lunarYear.LeapMonthIndex - 2 == 5)
                    ComboBoxLunnarMonth.Items.Add("Tháng Năm nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Sáu");
                if (lunarYear.LeapMonthIndex - 2 == 6)
                    ComboBoxLunnarMonth.Items.Add("Tháng Sáu nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Bảy");
                if (lunarYear.LeapMonthIndex - 2 == 7)
                    ComboBoxLunnarMonth.Items.Add("Tháng Bảy nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Tám");
                if (lunarYear.LeapMonthIndex - 2 == 8)
                    ComboBoxLunnarMonth.Items.Add("Tháng Tám nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Chín");
                if (lunarYear.LeapMonthIndex - 2 == 9)
                    ComboBoxLunnarMonth.Items.Add("Tháng Chín nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Mười");
                if (lunarYear.LeapMonthIndex - 2 == 10)
                    ComboBoxLunnarMonth.Items.Add("Tháng Mười nhuận");
                ComboBoxLunnarMonth.Items.Add("Tháng Mười Một");
                ComboBoxLunnarMonth.Items.Add("Tháng Chạp");
            }

            int monthLunnar = lunarDate.Month;
            ComboBoxLunnarMonth.Text = string.Format("Tháng {0}{1}", monthLunnar == 11 ? "Mười " : "", LuniSolarDate<VietnameseLocalInfoProvider>.GetMonthShortName(lunarDate.Month, lunarDate.IsLeapMonth));
        }
        #endregion

        #region Set Up Ngày Âm
        private void SetUpLunnarDay(string sMonth,int year)
        {
            ComboBoxLunnarDay.Items.Clear();

            bool leap = false;
            int month = 0;
            year = Convert.ToInt32(ComboBoxLunnarYear.Text);
            LuniSolarYear<VietnameseLocalInfoProvider> lunarYear = LuniSolarCalendar<VietnameseLocalInfoProvider>.GetLunarYear(year);
            int leapMonth = lunarYear.LeapMonthIndex - 2;

            //Tìm tháng (dưới dạng number) dựa trên tháng (dưới dạng string) 
            switch (sMonth)
            {
                case "Tháng Giêng":
                    month = 1;
                    break;
                case "Tháng Hai":
                case "Tháng Hai nhuận":
                    month = 2;
                    break;
                case "Tháng Ba":
                case "Tháng Ba nhuận":
                    month = 3;
                    break;
                case "Tháng Tư":
                case "Tháng Tư nhuận":
                    month = 4;
                    break;
                case "Tháng Năm":
                case "Tháng Năm nhuận":
                    month = 5;
                    break;
                case "Tháng Sáu":
                case "Tháng Sáu nhuận":
                    month = 6;
                    break;
                case "Tháng Bảy":
                case "Tháng Bảy nhuận":
                    month = 7;
                    break;
                case "Tháng Tám":
                case "Tháng Tám nhuận":
                    month = 8;
                    break;
                case "Tháng Chín":
                case "Tháng Chín nhuận":
                    month = 9;
                    break;
                case "Tháng Mười":
                case "Tháng Mười nhuận":
                    month = 10;
                    break;
                case "Tháng Mười Một":
                    month = 11;
                    break;
                case "Tháng Chạp":
                    month = 12;
                    break;
                default:
                    break;

            }

            //Kiểm tra tháng đó có phải tháng nhuận không
            if (leapMonth == month)
            {
                leap = true;
            }
            if (month == 12)
            {
                month = 1;
                year = year + 1;
            }
            else
            {
                if (leap == false)
                {
                    month = month + 1;
                }
            }

            //Tìm ngày đầu tiên của tháng tiếp theo để tìm ngày cuối cùng của tháng này
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate1 = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(year, leap == true ? month + 1 : month, leap == true ? false : true, 1);
            DateTime date = lunarDate1.SolarDate;
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate2 = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date.AddDays(-1));
            int day = lunarDate2.Day;
            ComboBoxLunnarDay.Items.AddRange(Enumerable.Range(1, day).Select(i => (object)i).ToArray());

            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            DateTime dateSolar = new DateTime(year, month, day);
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(dateSolar);
            ComboBoxLunnarDay.Text = string.Format("{0}", lunarDate.Day);
        }
        #endregion

        #endregion
        private void DisplayChangeDate_Load(object sender, EventArgs e)
        { 
            SetUpSolar();
            SetUpLunnar();
            PanelDetailLunnar.Visible = false;
            PanelDetailSolar.Visible = false;
        }

        #region Xử lý sự kiện cho chuyển lịch

        #region Chuyển lịch dương
        private void ButtonFind1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt32(ComboBoxSolarYear.Text);
            int month = 0;
            string s = ComboBoxSolarMonth.Text;
            switch (s)
            {
                case "Tháng Một":
                    month = 1;
                    break;
                case "Tháng Hai":
                    month = 2;
                    break;
                case "Tháng Ba":
                    month = 3;
                    break;
                case "Tháng Tư":
                    month = 4;
                    break;
                case "Tháng Năm":
                    month = 5;
                    break;
                case "Tháng Sáu":
                    month = 6;
                    break;
                case "Tháng Bảy":
                    month = 7;
                    break;
                case "Tháng Tám":
                    month = 8;
                    break;
                case "Tháng Chín":
                    month = 9;
                    break;
                case "Tháng Mười":
                    month = 10;
                    break;
                case "Tháng Mười Một":
                    month = 11;
                    break;
                case "Tháng Mười Hai":
                    month = 12;
                    break;
                default:
                    break;
            }
            int day = Convert.ToInt32(ComboBoxSolarDay.Text);
            DateTime date = new DateTime(year, month, day);
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);
            LunnarSample.LunnarCalendar lunnarCalendar = new LunnarSample.LunnarCalendar();
            PanelDetailLunnar.Visible = true;
            string sGD = "";
            int iZodiac = lunnarCalendar.IsZodiacDay(date, lunarDate.Month);
            if (iZodiac == 1)
                sGD = " - NGÀY HOÀNG ĐẠO";
            else if (iZodiac == -1)
                sGD = " - NGÀY HẮC ĐẠO";
            labelLunnarDay.Text = string.Format("NGÀY {0}/{1}/{2}",lunarDate.Day,lunarDate.Month,lunarDate.Year);
            labelNameLunnarDay.Text = string.Format("NGÀY {0}{1}",lunarDate.DayName.ToUpper(),sGD);
            labelNameLunnarMY.Text = string.Format("THÁNG {0} - NĂM {1}",lunarDate.MonthLongName.ToUpper(),lunarDate.YearName.ToUpper());
            labelNameSolarTerm.Text = string.Format("TIẾT {0}",lunnarCalendar.SolarTermString(lunarDate.SolarTerm).ToUpper());
            labelNameGoodDay.Text = string.Format("TRỰC {0}", lunnarCalendar.GoodDayString(date).ToUpper());
        }
        #endregion

        #region Chuyển lịch âm
        private void ButtonFind2_Click(object sender, EventArgs e)
        {
            PanelDetailSolar.Visible = true;
            int month = 0;
            string s = ComboBoxLunnarMonth.Text;
            switch (s)
            {
                case "Tháng Giêng":
                    month = 1;
                    break;
                case "Tháng Hai":
                case "Tháng Hai nhuận":
                    month = 2;
                    break;
                case "Tháng Ba":
                case "Tháng Ba nhuận":
                    month = 3;
                    break;
                case "Tháng Tư":
                case "Tháng Tư nhuận":
                    month = 4;
                    break;
                case "Tháng Năm":
                case "Tháng Năm nhuận":
                    month = 5;
                    break;
                case "Tháng Sáu":
                case "Tháng Sáu nhuận":
                    month = 6;
                    break;
                case "Tháng Bảy":
                case "Tháng Bảy nhuận":
                    month = 7;
                    break;
                case "Tháng Tám":
                case "Tháng Tám nhuận":
                    month = 8;
                    break;
                case "Tháng Chín":
                case "Tháng Chín nhuận":
                    month = 9;
                    break;
                case "Tháng Mười":
                case "Tháng Mười nhuận":
                    month = 10;
                    break;
                case "Tháng Mười Một":
                    month = 11;
                    break;
                case "Tháng Chạp":
                    month = 12;
                    break;
                default:
                    break;
            }
            bool leap = false;
            string leapstring = ComboBoxLunnarMonth.Text.Substring(ComboBoxLunnarMonth.Text.LastIndexOf(" ")).Trim();
            if (leapstring == "nhuận")
                leap = true;
            LuniSolarDate<VietnameseLocalInfoProvider> lunarDate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(Convert.ToInt32(ComboBoxLunnarYear.Text), month, leap, Convert.ToInt32(ComboBoxLunnarDay.Text));
            string MonthName = string.Format("Tháng {0}{1}", month == 11 ? "Mười " : "", LuniSolarDate<VietnameseLocalInfoProvider>.GetMonthShortName(lunarDate.Month, lunarDate.IsLeapMonth));
            labelLunnarDayChange.Text = string.Format("NGÀY {0}, {1}, NĂM {2}",lunarDate.Day,MonthName.ToUpper(),lunarDate.Year);
            labelSolarDay.Text = string.Format("NGÀY {0}/{1}/{2}", lunarDate.SolarDate.Day, lunarDate.SolarDate.Month, lunarDate.SolarDate.Year);
        }
        #endregion

        #endregion

    }
}
