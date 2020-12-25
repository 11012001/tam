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
    public partial class DisplaySolar : UserControl
    {
        private List<List<Guna2Button>> Matrix;
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private static DisplaySolar calendarPlusDisplay;
        public static DisplaySolar CalendarPlusDisplay
        {
            get
            {
                if (calendarPlusDisplay == null)
                    calendarPlusDisplay = new DisplaySolar();
                return calendarPlusDisplay;
            }
        }

        //https://holidayapi.com/dashboard
        private const string API_KEY = "";

        public DisplaySolar()
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

            //Thêm ngày của tháng trước
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

            //Thêm ngày của tháng hiện tại
            useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Guna2Button btn = Matrix[line][column];

                btn.BackColor = Color.Transparent;
                btn.TextAlign = HorizontalAlignment.Center;
                btn.Text = i.ToString();
                btn.Click += ButtonNum_Click;

                if (column == 6)
                {
                    btn.ForeColor = Color.Red;
                }
                if (IsEqualDate(useDate, DateTime.Now))
                    btn.BackColor = Color.Transparent;
                if ((IsEqualDate(useDate, dtpk.Value)) && (btn.BackColor != Color.Aqua))
                    btn.BackColor = Color.Transparent;
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
                num++;
            }

            // Thêm ngày của tháng sau
            if (date.Month == 12)
            {
                useDate = new DateTime(date.Year + 1, 1, 1);
            }
            else
            {
                useDate = new DateTime(date.Year, date.Month + 1, 1);
            }
            for (int i = 1; i <= (42 - num); i++)
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
                    btn.Click -= ButtonNum_Click;
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
            ShowEvent(dtpk.Value.Month, dtpk.Value.Year);
        }

        private void TodayBtn_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }

        private void LichDuong_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ShowEvent(dtpk.Value.Month, dtpk.Value.Year);
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            DateTime Date = new DateTime(dtpk.Value.Year, dtpk.Value.Month, Convert.ToInt32(btn.Text));
            var NoteForm = new GeneralNoteForm();
            NoteForm.Dtpk.Value = Date;
            NoteForm.ShowDialog();
        }


        //Xử lí datagridview sự kiện
        private void ShowEvent(int month, int year)
        {
            dtgv.Rows.Clear();
            dtgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int day = DayOfMonth(new DateTime(year, month, 1));
            for (int i = 1; i <= day; i++)
            {
                DateTime date = new DateTime(year, month, i);
                IsPublicDate(date);
            }
            int k = 0;
            Color[] colors = ColorPublicMonth(month, year);
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.DefaultCellStyle.ForeColor = colors[k];
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
                    DateTime datecount = PublicDate.IsPublicDate(arrstring[i], date.Year);
                    int count = datecount.Day - dtpk.Value.Day;

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
            int day = DayOfMonth(new DateTime(year, month, 1));
            Color[] colors = new Color[20];
            int num = 0;
            for (int i = 1; i <= day; i++)
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

                DateTime date = PublicDate.IsPublicDate(row.Cells[1].Value.ToString(), dtpk.Value.Year);
                if ((date.Day == 1) && (date.Month == 1) && (date.Year == 1))
                {
                    return;
                }
                for (int i = 0; i < Cons.DayOfColumn; i++)
                {
                    for (int j = 0; j < Cons.DayOfWeek; j++)
                    {
                        if (Matrix[i][j].ForeColor != Color.DarkGray)
                        {
                            if (Convert.ToInt32(Matrix[i][j].Text) == date.Day)
                            {
                                if (Matrix[i][j].BackColor != Color.Pink)
                                {
                                    Matrix[i][j].BackColor = Color.Pink;
                                    return;
                                }
                                else
                                {
                                    Matrix[i][j].BackColor = Color.FromArgb(255, 255, 255);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
