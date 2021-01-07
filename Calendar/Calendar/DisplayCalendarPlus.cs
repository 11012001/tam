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
using Guna.UI2.WinForms;

namespace Calendar
{
    public partial class DisplayCalendarPlus : UserControl
    {
        private List<List<Guna2Button>> Matrix;
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private static DisplayCalendarPlus calendarPlusDisplay;
        public static DisplayCalendarPlus CalendarPlusDisplay
        {
            get
            {
                if (calendarPlusDisplay == null)
                    calendarPlusDisplay = new DisplayCalendarPlus();
                return calendarPlusDisplay;
            }
        }

        //https://holidayapi.com/dashboard
        private const string API_KEY = "";

        public DisplayCalendarPlus()
        {
            InitializeComponent();
            CreateMatrix();
        }
        void CreateMatrix()
        {
            Matrix = new List<List<Guna2Button>>();
            Guna2Button OldBtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Guna2Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Guna2Button btn = new Guna2Button()
                    {
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight,
                        Font = new Font("Segoe UI", 20, FontStyle.Bold),
                        TabStop = false,
                        BorderThickness = 0,
                        FillColor = Color.Transparent,
                        BorderRadius = 15

                    };
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.Margin, OldBtn.Location.Y);
                    PanelMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, OldBtn.Location.Y + OldBtn.Height + Cons.Margin) };
            }
            SetDefaultDate();
        }
        void AddNumberIntoMatrix(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int firstcolumn = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
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
                    column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                    Guna2Button btn = Matrix[line][column];
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = HorizontalAlignment.Center;
                    btn.Click += new EventHandler(PreviousBtn_Click);
                    btn.Text = useDate.Day.ToString();
                    useDate = useDate.AddDays(1);
                    num++;
                }
            }




            useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Guna2Button btn = Matrix[line][column];

                btn.BackColor = Color.Transparent;
                btn.TextAlign = HorizontalAlignment.Center;
                btn.Text = i.ToString();

                if (IsEqualDate(useDate, DateTime.Now))
                    btn.BackColor = Color.Transparent;
                if ((IsEqualDate(useDate, dtpk.Value)) && (btn.BackColor != Color.Aqua))
                    btn.BackColor = Color.Transparent;
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
                        Guna2Button btn = Matrix[i][j];
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
                    Guna2Button btn = Matrix[line][column];
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = HorizontalAlignment.Center;
                    btn.Text = i.ToString();
                    btn.Click += new EventHandler(Nextbtn_Click);
                    if (column >= 6)
                        line++;
                    useDate = useDate.AddDays(1);
                }
                if (MaxMatrix == 35)
                {
                    for (int i = 0; i < Cons.DayOfWeek; i++)
                    {
                        Guna2Button btn = Matrix[line][i];
                        btn.Visible = false;
                    }
                }
            }
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Guna2Button btn = Matrix[i][j];
                    btn.Visible = true;
                    btn.Text = "";
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.Black;
                    btn.Click -= new EventHandler(PreviousBtn_Click);
                    btn.Click -= new EventHandler(Nextbtn_Click);
                }
            }
        }

        void SetDefaultDate()
        {
            dtpk.Value = DateTime.Now;
        }
        bool IsEqualDate(DateTime DateA, DateTime DateB)
        {
            return DateA.Year == DateB.Year && DateA.Month == DateB.Month && DateA.Day == DateB.Day;
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
        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(-1);
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            dtpk.Value = dtpk.Value.AddMonths(1);
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            AddNumberIntoMatrix(date);
        }

        private void TodayBtn_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void LichDuong_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToString("T");
        }
    }
}
