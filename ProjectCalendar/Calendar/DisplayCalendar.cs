using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LunnarSample;
using Augustine.VietnameseCalendar.Core.LuniSolarCalendar;
namespace Calendar
{
    public partial class DisplayCalendar : UserControl
    {
        private static DisplayCalendar calendardisplay;
        public DisplayCalendar()
        {
            InitializeComponent();
            CreateMatrix();
        }
        public static DisplayCalendar CalendarDisplay
        {
            get
            {
                if (calendardisplay == null)
                    calendardisplay = new DisplayCalendar();
                return calendardisplay;
            }
        }
        private List<List<CustomButton>> Matrix;
        private List<List<Color>> MatrixColor;
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        void CreateMatrix()
        {
            Matrix = new List<List<CustomButton>>();
            MatrixColor = new List<List<Color>>();
            CustomButton OldBtn = new CustomButton() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<CustomButton>());
                MatrixColor.Add(new List<Color>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    CustomButton btn = new CustomButton()
                    {
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight,
                        Horizontal_Alignment = StringAlignment.Near,
                        Font = new Font("Arial", 25, FontStyle.Bold),
                        ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded,
                        ButtonImage = null,

                    };
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.Margin, OldBtn.Location.Y);
                    PanelMatrix.Controls.Add(btn);
                    MatrixColor[i].Add(btn.BackColor);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new CustomButton() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, OldBtn.Location.Y + OldBtn.Height + Cons.Margin) };

            }
            setDefaultDate();
        }
        void AddNumberIntoMatrix(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int firstcolumn = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
            LunnarSample.LunnarCalendar lunnarCalendar = new LunnarSample.LunnarCalendar();
            int line = 0;
            int column = 0;
            int num = 0;
            if (firstcolumn != 0)
            {
                if (date.Month == 1)
                {
                    useDate = new DateTime(date.Year - 1, 12, 31 - firstcolumn + 1);
                }
                else
                {
                    useDate = new DateTime(date.Year, date.Month - 1, DayOfMonth(new DateTime(date.Year, date.Month - 1, 1)) - firstcolumn + 1);
                }
                for (int i = 0; i < firstcolumn; i++)
                {
                    LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(useDate);
                    column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                    CustomButton btn = Matrix[line][column];
                    btn.TextColor = Color.DarkGray;
                    btn.Horizontal_Alignment = StringAlignment.Near;
                    btn.ButtonText = useDate.Day.ToString();
                    btn.SLunnarDay = lunnardate.Day;
                    btn.SLunnarMonth = lunnardate.Month;
                    btn.ZodiacDay = lunnarCalendar.IsZodiacDay(useDate, lunnardate.Month);
                    btn.LunnarDayColor = Color.DarkGray;
                    btn.Click += new EventHandler(PreviousBttn_Click);
                    useDate = useDate.AddDays(1);
                    MatrixColor[line][column] = btn.BackColor;
                    num++;
                }
            }
            useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(useDate);
                CustomButton btn = Matrix[line][column];

                //btn.BackColor = Color.PaleTurquoise;
                btn.Horizontal_Alignment = StringAlignment.Near;
                btn.ButtonText = i.ToString();
                btn.SLunnarDay = lunnardate.Day;
                btn.SLunnarMonth = lunnardate.Month;
                btn.ZodiacDay = lunnarCalendar.IsZodiacDay(useDate, lunnardate.Month);
                btn.LunnarDayColor = Color.Red;

                if (IsEqualDate(useDate, DateTime.Now))
                    btn.TextColor = Color.Aqua;
                if ((IsEqualDate(useDate, dtpk.Value)) && (btn.BackColor != Color.Aqua))
                    btn.TextColor = Color.LightPink;

                //Những ngày lễ được nghỉ
                Color color = Color.Red;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 1, 1)))
                    btn.TextColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 4, 30)))
                    btn.TextColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 5, 1)))
                    btn.TextColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 9, 2)))
                    btn.TextColor = color;
                LuniSolarDate<VietnameseLocalInfoProvider> lunnardatetemp = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(useDate.Year, 1, false, 1);
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate))
                {
                    btn.TextColor = color;
                }
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate.AddDays(-1)))
                {
                    btn.TextColor = color;
                }
                lunnardatetemp = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(useDate.Year, 1, false, 2);
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate))
                {
                    btn.TextColor = color;
                }
                lunnardatetemp = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(useDate.Year, 1, false, 3);
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate))
                {
                    btn.TextColor = color;
                }
                lunnardatetemp = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(useDate.Year, 3, false, 10);
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate))
                {
                    btn.TextColor = color;
                }

                //Những ngày lễ không được nghỉ nhưng quan trong
                Color colorLe = Color.BlueViolet;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 3, 8)))
                    btn.TextColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 6, 1)))
                    btn.TextColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 10, 20)))
                    btn.TextColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 11, 20)))
                    btn.TextColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 10, 31)))
                    btn.TextColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 12, 24)))
                    btn.TextColor = colorLe;
                lunnardatetemp = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromLunarInfo(useDate.Year, 8, false, 15);
                if (IsEqualDate(useDate, lunnardatetemp.SolarDate))
                {
                    btn.TextColor = colorLe;
                }

                MatrixColor[line][column] = btn.BackColor;
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
                num++;
            }
            int MaxMatrix = (line == 4) ? 35 : 42;
            if (column == 6)
            {
                for (int i = line; i < Cons.DayOfColumn; i++)
                {
                    for (int j = 0; j < Cons.DayOfWeek; j++)
                    {
                        CustomButton btn = Matrix[i][j];
                        MatrixColor[i][j] = btn.BackColor;
                        btn.Visible = false;
                    }
                }
            }
            else
            {
                if (date.Month == 12)
                {
                    useDate = new DateTime(date.Year + 1, 1, 1);
                }
                else
                {
                    useDate = new DateTime(date.Year, date.Month + 1, 1);
                }
                for (int i = 1; i <= (MaxMatrix - num); i++)
                {
                    column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                    LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(useDate);
                    CustomButton btn = Matrix[line][column];
                    btn.Click += new EventHandler(NextBttn_Click);
                    btn.Horizontal_Alignment = StringAlignment.Near;
                    btn.ButtonText = useDate.Day.ToString();
                    btn.SLunnarDay = lunnardate.Day;
                    btn.SLunnarMonth = lunnardate.Month;
                    btn.ZodiacDay = lunnarCalendar.IsZodiacDay(useDate, lunnardate.Month);
                    btn.LunnarDayColor = Color.DarkGray;
                    btn.TextColor = Color.DarkGray;
                    MatrixColor[line][column] = btn.BackColor;
                    if (column >= 6)
                        line++;
                    useDate = useDate.AddDays(1);
                }
                if (MaxMatrix == 35)
                {
                    for (int i = 0; i < Cons.DayOfWeek; i++)
                    {
                        CustomButton btn = Matrix[line][i];
                        MatrixColor[line][i] = btn.BackColor;
                        btn.Visible = false;
                    }
                }
            }
        }
        bool IsEqualDate(DateTime DateA, DateTime DateB)
        {
            return DateA.Year == DateB.Year && DateA.Month == DateB.Month && DateA.Day == DateB.Day;
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    CustomButton btn = Matrix[i][j];
                    btn.Visible = true;
                    btn.Text = "";
                    btn.TextColor = Color.Black;
                    btn.Click -= new EventHandler(PreviousBttn_Click);
                    btn.Click -= new EventHandler(NextBttn_Click);
                }
            }
        }
        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
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
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    return 28;
                default:
                    return 30;
            }
        }
        void setDefaultDate()
        {
            dtpk.Value = DateTime.Now;
        }
        private void NextBttn_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(1);
        }

        private void PreviousBttn_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(-1);
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            AddNumberIntoMatrix(date);
        }

        private void DisplayCalendar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void BackToDateBttn_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
