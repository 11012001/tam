using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;
using LunnarSample;
using Newtonsoft.Json;
using WMPLib;

namespace Calendar
{
    public partial class DisplayDate : UserControl
    {
        
        public static Color ColorSolar { get; set; }
        public static Color ColorLunnar { get; set; }
        public Color ColorHourLunnar { get; set; }

        public DateTime Date = DateTime.Now;

        public DateTimePicker DateTimePicker { get; set; }


        public DisplayDate()
        {
            InitializeComponent();
        }
        public DisplayDate(DateTime date)
        {
            Date = date;
            InitializeComponent();
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
            labelHour.Location = new Point(PanelHourLunnar.Size.Width / 2 - labelHour.Size.Width / 2, 28);

        }
        //Sự kiện để lấy thông tin giờ
        private void DisplayDate_Load(object sender, EventArgs e)
        {
            timer.Enabled = true;
            timer.Start();
            dtpk.Value = Date;
            labelHourLunnar.Location = new Point(PanelHourLunnar.Size.Width / 2 - labelHourLunnar.Size.Width / 2, 3);
            //labelHour.Location = new Point(PanelHourLunnar.Size.Width / 2 - labelHour.Size.Width / 2, 28);
            DisplayGeneral();
        }
        #endregion

        #region Hiển thị ngày

        #region Sự kiện để thay đổi giá trị của ngày
        //Sự kiện của DateTimePicker để thay đổi giá trị của ngày
        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            Date = date;
            DisplayGeneral();
        }

        private void DisplayGeneral()
        {
            display_picture();
            DisplayQuote();
            DisplayEvent();
            ColorEvent();
            DisplaySolarDate();
            DisplayLunnar();
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
                labelDay.Location = new Point((PanelDay.Size.Width/2) - (labelDay.Size.Width/2), 0);
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
            labelLunnarDay.Text = lunnardate.Day.ToString();
            labelLunnarDay.ForeColor = ColorLunnar;
            labelLunnarDay.Location = new Point((PanelLunnarDay.Size.Width / 2) - (labelLunnarDay.Size.Width / 2), 32);
            #endregion

            #region Lấy thông tin ngày hoàng đạo
            if (lunnar.IsZodiacDay(date,lunnardate.Month)  == 1)
            {
                PictureZodiac.IconChar = FontAwesome.Sharp.IconChar.YinYang;
                PictureZodiac.IconColor = Color.Yellow;
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
            ButtonLunnarMonth.Text = string.Format("Tháng {0}",lunnardate.Month);
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
            TextboxZodiacHour.Text = lunnar.GetZodiacTimeSmallVersion(date);
            #endregion
        }
        #endregion

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
        //Sự kiện khi nhấn vào ButtonToday để quay trở lại hiện tại
        private event EventHandler tdbtn;
        public event EventHandler TDbtn
        {
            add { tdbtn += value; }
            remove { tdbtn -= value; ; }
        }
        private void ButtonToday_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
            if (tdbtn != null)
                tdbtn(this, new EventArgs());
        }
        #endregion

        #region Màu sắc cho các ngày đặc biệt
        private void ColorEvent()
        {
            int[] arrint = PublicDate.IsPublic(dtpk.Value);
            if(arrint[0] == -1)
            {
                if(dtpk.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    ColorSolar = Color.OrangeRed;
                    ColorLunnar = Color.OrangeRed;
                }
                else
                {
                    ColorSolar = Color.Black;
                    ColorLunnar = Color.Black;
                }
            }
            else
            {
                int k = 0;
                for(int i = 0;i<arrint.Length;i++)
                {
                    if (k < arrint[i])
                        k = arrint[i];
                }
                if(k==1)
                {
                    ColorSolar = Color.Red;
                    ColorLunnar = Color.Red;
                    TextboxEvent.ForeColor = Color.Red;
                }
                else
                {
                    ColorSolar = Color.Blue;
                    ColorLunnar = Color.Blue;
                    TextboxEvent.ForeColor = Color.Blue;
                }
            }   
        }
        #endregion

        #endregion

        #region Hiển thị câu châm ngôn
        //Hiển thị thông tin châm ngôn
        private void DisplayQuote()
        {
            LunnarSample.StringText text = new LunnarSample.StringText();
            LunnarSample.StringText.QuoteClass quote = text.MakeRandomQuote();
            TextboxQuote.Text = quote.Quote;
            TextboxAuthor.Text = quote.Author;
        }
        #endregion

        #region Hiển thị ngày lễ
        void DisplayEvent()
        {
            TextboxEvent.Clear();

            string[] arr = PublicDate.IsPublicString(dtpk.Value);
            if(arr[0] == "")
            {
                TextboxEvent.Text = "";
            }
            else
            {
                for(int i=0;i<arr.Length;i++)
                {
                    if(i== arr.Length -1)
                    {
                        TextboxEvent.Text += arr[i];
                    }
                    else
                    {
                        TextboxEvent.Text += arr[i] + "\r\n";
                    }
                    TextboxEvent.Lines[i] = arr[i];
                }
            }
        }
        #endregion

        #region Sử dụng sự kiện âm thanh
        public string url = "";

        private void ibtnSpeech_Click(object sender, EventArgs e)
        {
            try
            {
                String sevent = string.Format("{0}", TextboxEvent.Text == "" ? "Không có sự kiện gì vào ngày hôm nay" : "Hôm nay có sự kiện là " + TextboxEvent.Text);
                String payload = string.Format("Hôm nay. {0}. ngày {1}. tháng {2}. năm {3}. tức là {4}. {5}.{6} . {7}", labelDOW.Text, labelDay.Text, dtpk.Value.Month, dtpk.Value.Year
                                                , labelLunnarDayName.Text, labelLunnarMonthName.Text, labelLunnarYearName.Text, sevent);
                if (SpeechClass.voice == null)
                {
                    SpeechClass.voice = "linhsan";
                }
                try
                {
                    String result = Task.Run(async () =>
                    {
                        HttpClient client = new HttpClient();
                        client.DefaultRequestHeaders.Add("api-key", SpeechClass.API);
                        client.DefaultRequestHeaders.Add("speed", "");
                        client.DefaultRequestHeaders.Add("voice", SpeechClass.voice);
                        client.DefaultRequestHeaders.Add("callback_url", "");
                        var response = await client.PostAsync("https://api.fpt.ai/hmi/tts/v5", new StringContent(payload));
                        return await response.Content.ReadAsStringAsync();
                    }).GetAwaiter().GetResult();

                    var json = JsonConvert.DeserializeObject<SpeechJSon.root>(result);
                    SpeechJSon.root output = json;

                    url = string.Format("{0}", output.async);
                }
                catch (System.Net.Http.HttpRequestException)
                {
                    MessageBox.Show("Vui lòng kết nối mạng trước khi sử dụng tính năng  này.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                using (var responseStream = response.GetResponseStream())
                {
                    WindowsMediaPlayer sound = new WindowsMediaPlayer();
                    sound.URL = url;
                    sound.controls.play();
                }
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.NotFound)
            {
                MessageBox.Show("Trang web xử lí âm thanh đang gặp trục trặc. Vui lòng thử lại sau.", "Báo Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void ButtonNote_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton;
            Date = dtpk.Value;
            var NoteForm = new GeneralNoteForm();
            NoteForm.Dtpk.Value = Date;
            NoteForm.ShowDialog();
        }
        private event EventHandler monthbtn;
        public event EventHandler MonthBtn
        {
            add { monthbtn += value; }
            remove { monthbtn -= value; ; }
        }

        private void ButtonMonth_Click(object sender, EventArgs e)
        {
            if (monthbtn != null)
                monthbtn(this, new EventArgs());
        }

        private void iconSetting_Click(object sender, EventArgs e)
        {
            FormSetting setting = new FormSetting();
            setting.ShowDialog();
        }
        private void display_picture()
        {
            LunnarCalendar lunnar = new LunnarCalendar();
            string sChi = lunnar.GetChiNgay(Date);

            
            switch (sChi)
            {
                case "Tý":
                    ZodiacAnimal1.Image = _12ConGiap.Ty;
                    ZodiacAnimal2.Image = _12ConGiap.Ty;
                    break;
                case "Sửu":
                    ZodiacAnimal1.Image = _12ConGiap.Suu;
                    ZodiacAnimal2.Image = _12ConGiap.Suu;
                    break;
                case "Dần":
                    ZodiacAnimal1.Image = _12ConGiap.Dan;
                    ZodiacAnimal2.Image = _12ConGiap.Dan;
                    break;
                case "Mão":
                    ZodiacAnimal1.Image = _12ConGiap.Mao;
                    ZodiacAnimal2.Image = _12ConGiap.Mao;
                    break;
                case "Thìn":
                    ZodiacAnimal1.Image = _12ConGiap.Thin;
                    ZodiacAnimal2.Image = _12ConGiap.Thin;
                    break;
                case "Tỵ":
                    ZodiacAnimal1.Image = _12ConGiap.Ti;
                    ZodiacAnimal2.Image = _12ConGiap.Ti;
                    break;
                case "Ngọ":
                    ZodiacAnimal1.Image = _12ConGiap.Ngo;
                    ZodiacAnimal2.Image = _12ConGiap.Ngo;
                    break;
                case "Mùi":
                    ZodiacAnimal1.Image = _12ConGiap.Mui;
                    ZodiacAnimal2.Image = _12ConGiap.Mui;
                    break;
                case "Thân":
                    ZodiacAnimal1.Image = _12ConGiap.Than;
                    ZodiacAnimal2.Image = _12ConGiap.Than;
                    break;
                case "Dậu":
                    ZodiacAnimal1.Image = _12ConGiap.Dau;
                    ZodiacAnimal2.Image = _12ConGiap.Dau;
                    break;
                case "Tuất":
                    ZodiacAnimal1.Image = _12ConGiap.Tuat;
                    ZodiacAnimal2.Image = _12ConGiap.Tuat;
                    break;
                case "Hợi":
                    ZodiacAnimal1.Image = _12ConGiap.Hoi;
                    ZodiacAnimal2.Image = _12ConGiap.Hoi;
                    break;
                default:
                    break;
            }
        }



    }
}
