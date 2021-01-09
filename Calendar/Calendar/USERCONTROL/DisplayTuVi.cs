using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;
using LunnarSample;

namespace Calendar
{
    public partial class DisplayTuVi : UserControl
    {
        public DisplayTuVi()
        {
            InitializeComponent();
        }

        private static DisplayTuVi tuVi;
        public static DisplayTuVi TuViDisplay
        {
            get
            {
                if (tuVi == null)
                    tuVi = new DisplayTuVi();
                return tuVi;
            }
        }


        #region Thêm số liệu vào ComboBox của lịch dương
        private void SetUpSolar()
        {
            #region Set Up Năm
            int year = DateTime.Now.Year -1;
            ComboBoxSolarYear.Items.AddRange(Enumerable.Range(1, year).Select(i => (object)i).ToArray());
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
        private void SetUpDay(string sMonth, int year)
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

        private void DisplayTuVi_Load(object sender, EventArgs e)
        {
            SetUpSolar();
            PanelDisplay.Visible = false;
        }
        private DateTime GetDateFromComboBox()
        {
            DateTime date = DateTime.Now;
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
            date = new DateTime(year, month, day);
            return date;
        }
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            DateTime date = GetDateFromComboBox();
            int GT = -1;
            if (comboBoxGioiTinh.Text == "Nam")
                GT = 0;
            else if (comboBoxGioiTinh.Text == "Nữ")
                GT = 1;
            else
            {
                MessageBox.Show("Vui lòng chọn giới tính của bạn.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    
            PanelDisplay.Visible = true;
            rtbRead.Text = TuViClass.GetTuVi(date, GT);
            HighlightRTB(rtbRead, 14);
        }

        private void iconbtnPlus_Click(object sender, EventArgs e)
        {
            float temp = rtbRead.SelectionFont.Size;
            if (temp < 24 * 1f)
            {

                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size + 1f, rtbRead.SelectionFont.Style);
                HighlightRTB(rtbRead, rtbRead.SelectionFont.Size + 1f);
            }
            else
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size, rtbRead.SelectionFont.Style);
                HighlightRTB(rtbRead, rtbRead.SelectionFont.Size + 1f);
            }
        }

        private void iconbtnMinus_Click(object sender, EventArgs e)
        {
            float temp = rtbRead.SelectionFont.Size;
            if (temp > 9 * 1f)
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size - 1f, rtbRead.SelectionFont.Style);
                HighlightRTB(rtbRead, rtbRead.SelectionFont.Size - 1f);
            }
            else
            {
                rtbRead.SelectAll();
                rtbRead.SelectionFont = new Font(rtbRead.SelectionFont.FontFamily, rtbRead.SelectionFont.Size, rtbRead.SelectionFont.Style);
                HighlightRTB(rtbRead, rtbRead.SelectionFont.Size - 1f);
            }
        }

        public static void HighlightRTB(RichTextBox rtb, float size)
        {

            HighlightPhrase(rtb, "TỬ VI", "\n", Color.Blue, FontStyle.Bold, size + 4, HorizontalAlignment.Center);

            HighlightPhrase(rtb, "*", ":", Color.Red, FontStyle.Bold, size, HorizontalAlignment.Left);

            HighlightPhrase(rtb, "-", ":", Color.Green, FontStyle.Italic, size - 2, HorizontalAlignment.Left);

        }
        public static void HighlightPhrase(RichTextBox box, string begin, string end, Color color, FontStyle fontStyle, float size, HorizontalAlignment horizontal)
        {
            string s = box.Text;
            for (int ix = 0; ix < s.Length;)
            {
                int jx = s.IndexOf(begin, ix);
                if (jx < 0)
                    break;
                int kx = s.IndexOf(end, jx);
                if (kx < 0)
                    kx = jx;
                box.SelectionStart = jx;
                box.SelectionLength = kx - jx + 1;
                box.SelectionColor = color;
                box.SelectionAlignment = horizontal;
                box.SelectionFont = new Font(box.Font.FontFamily, size, fontStyle);
                ix = kx + 1;
            }
        }
    }
}
