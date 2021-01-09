using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;
using LunnarSample;

namespace Calendar
{
    public partial class DisplayDetailDate : UserControl
    {
        public DateTime Date { get; set; }
        public DisplayDetailDate()
        {
            InitializeComponent();
            DisplayDate(DateTime.Now);
        }
        public DisplayDetailDate(DateTime date)
        {
            InitializeComponent();
            DisplayDate(date);
            Date = date;
        }
        #region Hiển thị chi tiết ngày

        #region Hiển thị ngày

        public void DisplayDate(DateTime date)
        {
            LunnarCalendar calendar = new LunnarCalendar();
            LuniSolarDate<VietnameseLocalInfoProvider> luni = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(date);

            #region Chỉnh sửa panelDisplayDate
            labelSolarDate.Text = string.Format("{0}, {1}/{2}/{3}", calendar.GetThu(date), date.Day, date.Month, date.Year);
            labelLunnarDate.Text = string.Format("Ngày {0}/{1}/{2} Tức ngày {3}, tháng {4}, năm {5}", luni.Day, luni.Month, luni.Year, luni.DayName, luni.MonthLongName, luni.YearName);
            labelDetailDate.Text = string.Format("Hành {0} - Sao {1} - Trực {2} - Ngày {3}", calendar.GetNguHanh(date), calendar.GetSao(date), calendar.GoodDayString(date), calendar.GetNameHoangHacDao(date));
            labelTietKhi.Text = string.Format("{0}", calendar.SolarTermString(luni.SolarTerm));
            #endregion

            #region Chỉnh sửa PanelZodiacHour
            string[] words1 = calendar.GetZodiacTime(date).Split(',');
            labelGood1.Text = words1[0];
            labelGood2.Text = words1[1];
            labelGood3.Text = words1[2];
            labelGood4.Text = words1[3];
            labelGood5.Text = words1[4];
            labelGood6.Text = words1[5];

            string[] word2 = calendar.GetUnZodiacTime(date).Split(',');
            labelBad1.Text = word2[0];
            labelBad2.Text = word2[1];
            labelBad3.Text = word2[2];
            labelBad4.Text = word2[3];
            labelBad5.Text = word2[4];
            labelBad6.Text = word2[5];
            #endregion

            #region Chỉnh sửa PanelTruc
            tbTrucName.Text = string.Format("Trực {0}", calendar.GoodDayString(date));
            DataTable dtTruc = calendar.GetDetailTruc(date);
            foreach (DataRow row in dtTruc.Rows)
            {
                tbTrucDo.Text = (string)row["Do"];
                tbUnDoTruc.Text = (string)row["Undo"];
                tbTrucBonus.Text = (string)row["Bonus"];
            }
            #endregion

            #region Chính sửa PanelStar
            DataTable dtTot = calendar.GetGoodStar(date);
            string sTot = "";
            foreach (DataRow row in dtTot.Rows)
            {
                sTot += string.Format("{0}\r\n", (string)row["Name"]);
            }
            tbSaoTot.Text = sTot;

            DataTable dtXau = calendar.GetBadStar(date);
            string sXau = "";
            foreach (DataRow row in dtXau.Rows)
            {
                sXau += string.Format("{0}\r\n", (string)row["Name"]);
            }
            tbSaoXau.Text = sXau;
            #endregion

            #region Chính sửa PanelNTBT
            rtb.Text = calendar.GetDetailStar28(date);
            HighlightRTB(rtb, 11);
            #endregion

            #region Chỉnh sửa PanelHXH
            labelTaiThan.Text = string.Format("Đi về hướng {0} để nghênh tiếp Tài Thần", calendar.GetTaiThan(date));
            labelHyThan.Text = string.Format("Đi về hướng {0} để đón Hỷ Thần", calendar.GetHyThan(date));
            string sHacThan = calendar.GetHacThan(date);
            if (sHacThan == "Vô")
            {
                labelHacThan.Visible = false;
            }
            else
            {
                labelHacThan.Visible = true;
                labelHacThan.Text = string.Format("Tránh đi về hướng {0} để gặp Hắc Thần", sHacThan);
            }
            #endregion

            #region Chỉnh sửa PanelNXH
            DataTable dtNXH = calendar.GetNgayXuatHanh(date);
            string sNXH = "";
            foreach (DataRow row in dtNXH.Rows)
            {
                string sName = (string)row["Name"];
                string sMean = (string)row["Mean"];
                sNXH = string.Format("Ngày {0}: {1}", sName, sMean);
            }
            tbNXH.Text = sNXH;
            #endregion

            #region Chỉnh sửa PanelGXH
            DataTable dtGXH1 = calendar.GetXuatHanh(date, 1);
            foreach (DataRow row in dtGXH1.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName1.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean1.Text = string.Format("{0}", (string)row["Mean"]);
            }

            DataTable dtGXH2 = calendar.GetXuatHanh(date, 2);
            foreach (DataRow row in dtGXH2.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName2.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean2.Text = string.Format("{0}", (string)row["Mean"]);
            }

            DataTable dtGXH3 = calendar.GetXuatHanh(date, 3);
            foreach (DataRow row in dtGXH3.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName3.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean3.Text = string.Format("{0}", (string)row["Mean"]);
            }

            DataTable dtGXH4 = calendar.GetXuatHanh(date, 4);
            foreach (DataRow row in dtGXH4.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName4.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean4.Text = string.Format("{0}", (string)row["Mean"]);
            }

            DataTable dtGXH5 = calendar.GetXuatHanh(date, 5);
            foreach (DataRow row in dtGXH5.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName5.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean5.Text = string.Format("{0}", (string)row["Mean"]);
            }

            DataTable dtGXH6 = calendar.GetXuatHanh(date, 6);
            foreach (DataRow row in dtGXH6.Rows)
            {
                string sName = (string)row["Name"];
                tbGXHName6.Text = string.Format("{0}", sName.ToUpper());
                tbGXHMean6.Text = string.Format("{0}", (string)row["Mean"]);
            }
            #endregion
        }

        //Sửa màu sắc richtextbox

        #endregion

        #endregion
        public static void HighlightRTB(RichTextBox rtb, float size)
        {

            HighlightPhrase(rtb, "~", ".~", Color.Blue, FontStyle.Bold, size + 2, HorizontalAlignment.Center);

            HighlightPhrase(rtb, "-", ":", Color.Red, FontStyle.Bold, size, HorizontalAlignment.Left);

            HighlightPhrase(rtb, "*", "!", Color.Green, FontStyle.Italic, size, HorizontalAlignment.Center);


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

        #region Các sự kiện liên quan tới ngày
        //Sự kiện khi nhấn vào ButtonPrevious để trở lại 1 ngày
        private event EventHandler prebtn;
        public event EventHandler Prebtn
        {
            add { prebtn += value; }
            remove { prebtn -= value; ; }
        }

        private void ButtonPre_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(-1);
            if (prebtn != null)
                prebtn(this, new EventArgs());
        }
        //Sự kiện khi nhấn vào ButtonNext để tiến tới 1 ngày
        private event EventHandler nextbtn;
        public event EventHandler Nextbtn
        {
            add { nextbtn += value; }
            remove { nextbtn -= value; ; }
        }
        private void ButtonNext_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddDays(1);
            if (nextbtn != null)
                nextbtn(this, new EventArgs());
        }
        #endregion

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            //Date = date;
            DisplayDate(date);
        }

        private void DisplayDetailDate_Load(object sender, EventArgs e)
        {
            dtpk.Value = Date;
        }

    }
}
