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
    public partial class DisplayCountDay : UserControl
    {
        private static DisplayCountDay countdaydisplay;
        public DisplayCountDay()
        {
            InitializeComponent();
        }
        public static DisplayCountDay CountDayDisplay
        {
            get
            {
                if (countdaydisplay == null)
                    countdaydisplay = new DisplayCountDay();
                return countdaydisplay;
            }
        }

        #region Xử lí sự kiện đếm ngày
        private void buttonCount_Click(object sender, EventArgs e)
        {
            labelCount.Visible = true;
            long datefromcount = ChangeDateToJuliusDay(dtpkFrom.Value.Day, dtpkFrom.Value.Month, dtpkFrom.Value.Year);
            long datetocount = ChangeDateToJuliusDay(dtpkTo.Value.Day, dtpkTo.Value.Month, dtpkTo.Value.Year);
            long count = datetocount - datefromcount;
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ngày kết thúc!");
                return;
            }
            else if (count < 0)
            {
                MessageBox.Show("Bạn chọn ngày kết thúc nhỏ hơn ngày bắt đầu!");
                return;
            }
            else
            {
                switch (ComboBoxSelect.Text)
                {
                    case "Năm":
                        long year = count / 365;
                        long month = (count - year * 365) / 30;
                        long day = count - year * 365 - month * 30;
                        labelCount.Text = string.Format("{0} năm {1} tháng {2} ngày", year, month, day);
                        break;
                    case "Tháng":
                        month = count / 30;
                        day = count - month * 30;
                        labelCount.Text = string.Format("{0} tháng {1} ngày", month, day);
                        break;
                    case "Ngày":
                        labelCount.Text = string.Format("{0} ngày", count);
                        break;
                    case "Giờ":
                        long hour = count * 24;
                        labelCount.Text = string.Format("{0} giờ", hour);
                        break;
                    case "Phút":
                        hour = count * 24;
                        long minute = hour * 60;
                        labelCount.Text = string.Format("{0} phút", minute);
                        break;
                    case "Giây":
                        hour = count * 24;
                        minute = hour * 60;
                        long second = minute * 60;
                        labelCount.Text = string.Format("{0} giây", second);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Chuyển từ ngày bình thường (dd/mm/yy) sang số ngày Julius
        public long ChangeDateToJuliusDay(int dd, int mm, int yy)
        {
            var a = (int)(14 - mm) / 12;
            var y = yy + 4800 - a;
            var m = mm + 12 * a - 3;
            var jd = dd + (int)((153 * m + 2) / 5.0f) + (365 * y) + (int)(y / 4.0f) - (int)(y / 100.0f) + (int)(y / 400.0f) - 32045;
            if (jd < 2299161)
            {
                jd = dd + (int)((153 * m + 2) / 5.0f) + 365 * y + (int)(y / 4.0f) - 32083;
            }
            return jd;
        }
        #endregion

        #region Chuyển từ số ngày Julius thành ngày bình thường (dd/mm/yy)
        public int[] ChangeJuliusDayToDate(long jd)
        {
            long a, b, c, d, e, m;
            int day, month, year;
            // Sau 5/10/1582, lịch Gregorian
            if (jd > 2299160)
            {
                a = jd + 32044;
                b = (int)((4 * a + 3) / 146097.0f);
                c = a - (int)((b * 146097) / 4.0f);
            }
            else
            {
                b = 0;
                c = jd + 32082;
            }
            d = (int)((4 * c + 3) / 1461.0f);
            e = c - (int)((1461 * d) / 4.0f);
            m = (int)((5 * e + 2) / 153.0f);
            day = (int)(e - (int)((153 * m + 2) / 5.0f) + 1);
            month = (int)(m + 3 - 12 * (int)(m / 10.0f));
            year = (int)(b * 100 + d - 4800 + (int)(m / 10.0f));
            return new int[] { day, month, year };
        }
        #endregion

        #region Xử lí sự kiện chuyển đổi ngày

        #region Nhập dữ liệu vào textbox
        private long CountDayNumber()
        {
            long count = 0;
            try
            {
                count = Convert.ToInt64(TextBoxFromChange.Text);
            }
            catch
            {
                if (TextBoxFromChange.Text == "")
                    MessageBox.Show("Mời bạn nhập dữ liêu!");
                else
                    MessageBox.Show("Bạn đã nhập sai dữ liệu! Mời bạn nhập lại!");
            }
            return count;
        }
        #endregion

        #region Xử lí sự kiện Button Change From
        private void buttonChangeFrom_Click(object sender, EventArgs e)
        {
            long count = CountDayNumber();
            switch (ComboBoxFromChange.Text)
            {
                case "Năm":
                    count = count * 365;
                    break;
                case "Tháng":
                    count = count * 30;
                    break;
                case "Ngày":
                    break;
                default:
                    break;
            }
            long dateFrom = ChangeDateToJuliusDay(dtpkFromChange.Value.Day, dtpkFromChange.Value.Month, dtpkFromChange.Value.Year);
            long dateTo = dateFrom + count;
            int[] nums = ChangeJuliusDayToDate(dateTo);
            dtpkToChange.Value = new DateTime(nums[2], nums[1], nums[0]);
        }
        #endregion

        #region Xử lí sự kiện Button Change To
        private void buttonChangeTo_Click(object sender, EventArgs e)
        {
            long count = CountDayNumber();
            switch (ComboBoxFromChange.Text)
            {
                case "Năm":
                    count = count * 365;
                    break;
                case "Tháng":
                    count = count * 30;
                    break;
                case "Ngày":
                    break;
                default:
                    break;
            }
            long dateTo = ChangeDateToJuliusDay(dtpkToChange.Value.Day, dtpkToChange.Value.Month, dtpkToChange.Value.Year);
            long dateFrom = dateTo - count;
            int[] nums = ChangeJuliusDayToDate(dateFrom);
            dtpkFromChange.Value = new DateTime(nums[2], nums[1], nums[0]);
        }
        #endregion

        #endregion

        private void DisplayCountDay_Load(object sender, EventArgs e)
        {
            dtpkFrom.Value = DateTime.Now;
            dtpkTo.Value = DateTime.Now;
            dtpkFromChange.Value = DateTime.Now;
            dtpkToChange.Value = DateTime.Now;
        }
    }
}
