using LunnarSample;
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
            
            long datefromcount = ChangeDateToJuliusDay(dtpkFrom.Value.Day, dtpkFrom.Value.Month, dtpkFrom.Value.Year);
            long datetocount = ChangeDateToJuliusDay(dtpkTo.Value.Day, dtpkTo.Value.Month, dtpkTo.Value.Year);
            long count = datetocount - datefromcount;
            if (count == 0)
            {
                MessageBox.Show("Bạn chưa chọn ngày kết thúc!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (count < 0)
            {
                MessageBox.Show("Bạn chọn ngày kết thúc nhỏ hơn ngày bắt đầu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                labelCount.Visible = true;
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
                    MessageBox.Show("Mời bạn nhập dữ liêu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Bạn đã nhập sai dữ liệu! Mời bạn nhập lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ShowEvent(DateTime.Now.Year);
        }

        #region Sự kiện của PanelEvent
        //Xử lí datagridview sự kiện
        int DayOfMonth(int month, int year)
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
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        return 29;
                    return 28;
                default:
                    return 30;
            }
        }
        private void ShowEvent(int year)
        {
            dtgv.Rows.Clear();

            dtgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;

            for (int i = 1; i <= 12; i++)
            {
                for(int j = 1; j <= DayOfMonth(i,year);j++)
                {
                    if(i > month)
                    {
                        DateTime date = new DateTime(year, i, j);
                        IsPublicDate(date);
                    }    
                    else if ( i == month)
                    {
                        if(j >= day)
                        {
                            DateTime date = new DateTime(year, i, j);
                            IsPublicDate(date);
                        }    
                    }    
                }
            }

            DateTime datetemp = new DateTime(year, 1, 1);
            TimeSpan ts = DateTime.Now - datetemp;
            double count = Math.Round(ts.TotalDays, 0);
            if(count > 0)
            {
                IsPublicDate(new DateTime(year + 1, 1, 1));
            }    
            

            int k = 0;
            Color[] colors1 = new Color[100];
            for(int i = 1; i <= 12;i++)
            {
                Color[] colors = ColorPublicMonth(i, year);
                foreach(var clr in colors)
                {
                    colors1[k] = clr;
                    k++;
                }    
            }
            colors1[k] = Color.Red;

            k = 0;
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.DefaultCellStyle.ForeColor = colors1[k];
                k++;
            }

        }
        private void IsPublicDate(DateTime date)
        {
            string[] arrstring = PublicDate.IsPublicString(date);


            if (arrstring[0] == "")
            {
                return;
            }
            else
            {
                for (int i = 0; i < arrstring.Length; i++)
                {
                    DateTime dateEvent = PublicDate.IsPublicDate(arrstring[i], date.Year);
                    DateTime datecount = new DateTime(date.Year, dateEvent.Month, dateEvent.Day);
                    TimeSpan ts = datecount - DateTime.Now;
                    double count = Math.Round(ts.TotalDays,0);

                    dtgv.Rows.Add(string.Format("{0}{1}", count > 0 ? "+" : "", count), arrstring[i]);
                }
            }
        }
        private Color[] ColorPublicDate(DateTime date)
        {
            int[] arrint = PublicDate.IsPublic(date);
            if (arrint[0] == -1)
                return null;
            else
            {
                Color[] colors = new Color[arrint.Length];
                for (int i = 0; i < arrint.Length; i++)
                {
                    if (arrint[i] == 1)
                        colors[i] = Color.Red;
                    else
                        colors[i] = Color.Blue;
                }
                return colors;
            }
        }
        private Color[] ColorPublicMonth(int month, int year)
        {
            int day = DayOfMonth(month,year);
            Color[] colors = new Color[20];
            int num = 0;
            for (int i = 1; i <= day; i++)
            {
                if(month > DateTime.Now.Month)
                {
                    DateTime date = new DateTime(year, month, i);
                    Color[] colors1 = ColorPublicDate(date);
                    if (colors1 != null)
                    {
                        for (int j = 0; j < colors1.Length; j++)
                        {
                            colors[num] = colors1[j];
                            num++;
                        }
                    }
                }    
                else if(month == DateTime.Now.Month)
                {
                    if(i >= DateTime.Now.Day)
                    {
                        DateTime date = new DateTime(year, month, i);
                        Color[] colors1 = ColorPublicDate(date);
                        if (colors1 != null)
                        {
                            for (int j = 0; j < colors1.Length; j++)
                            {
                                colors[num] = colors1[j];
                                num++;
                            }
                        }
                    }    
                }    
            }
            Color[] colors2 = new Color[num];
            for (int i = 0; i < num; i++)
                colors2[i] = colors[i];
            return colors2;
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];

                DateTime date = PublicDate.IsPublicDate(row.Cells[1].Value.ToString(), DateTime.Now.Year);
                if ((date.Day == 1) && (date.Month == 1) && (date.Year == 1))
                {
                    return;
                }
                if (date.Day == 1 && date.Month == 1)
                {
                    if (date.Day == DateTime.Now.Day && date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year)
                        date = DateTime.Now;
                    else
                    {
                        TimeSpan ts = DateTime.Now - date;
                        double count = Math.Round(ts.TotalDays, 0);
                        if(count > 0)
                        {
                            date = new DateTime(DateTime.Now.Year + 1, 1, 1);
                        }    
                      
                    }                        
                }
                else
                {
                    date = new DateTime(DateTime.Now.Year, date.Month, date.Day);
                }
                PanelDetailEvent.Visible = true;
                PanelDetailEvent.BringToFront();
                ButtonName.Text = string.Format("{0}"+ "\r\n" + "NGÀY {1} THÁNG {2} NĂM {3}",row.Cells[1].Value.ToString().ToUpper(),date.Day,date.Month,date.Year);
                SetTime(date);
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            PanelDetailEvent.SendToBack();
            PanelDetailEvent.Visible = false;
        }
        private int counter = 60;
        private int counterH = 24;
        private void timerGio_Tick(object sender, EventArgs e)
        {
            counterH--;
            labelGio.Text = counter.ToString();
            if (counterH == 0)
                counterH = 60;
        }

        private void timerPhut_Tick(object sender, EventArgs e)
        {
            counter--;
            labelPhut.Text = counter.ToString();
            if (counter == 0)
                counter = 60;
        }

        private void timerGiay_Tick(object sender, EventArgs e)
        {
            counter--;
            labelGiay.Text = counter.ToString();
            if (counter == 0)
                counter = 60;
        }

        private void SetTime(DateTime date)
        {
            TimeSpan ts = date - DateTime.Now;
            double countS = Math.Floor(ts.TotalSeconds);
            double countM = 0;
            if(countS > 60)
            {
                countM = Math.Floor(countS / 60);
            }
            countS = countS - countM * 60;

            double countH = 0;
            if(countM > 60)
            {
                countH = Math.Floor(countM / 60);
            }
            countM = countM - countH * 60;

            double countD = 0;
            if(countH > 24)
            {
                countD = Math.Floor(countH / 24);
            }
            countH = countH - countD * 24;

            double countT = 0;
            if(countD > 30)
            {
                countT = Math.Floor(countD / 30);
            }
            countD = countD - countT * 30;

            labelThang.Text = string.Format("{0}{1}",countT < 10 ? "0" : "", countT);
            labelNgay.Text = string.Format("{0}{1}", countD < 10 ? "0" : "", countD);
            labelGio.Text = string.Format("{0}{1}", countH < 10 ? "0" : "", countH);
            labelPhut.Text = string.Format("{0}{1}", countM < 10 ? "0" : "", countM);
            labelGiay.Text = string.Format("{0}{1}", countS < 10 ? "0" : "", countS);
            timerGiay.Start();
            timerGio.Start();
            timerPhut.Start();
        }

    }
}
