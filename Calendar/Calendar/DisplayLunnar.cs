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
    public partial class DisplayLunnar : UserControl
    {
        private static DisplayLunnar calendardisplay;

        public DateTime Date = DateTime.Now;
        public DisplayLunnar()
        {
            InitializeComponent();
            CreateMatrix();
        }

        public DisplayLunnar(DateTime date)
        {
            InitializeComponent();
            Date = date;
            CreateMatrix();
        }

        public static DisplayLunnar CalendarDisplay
        {
            get
            {
                if (calendardisplay == null)
                    calendardisplay = new DisplayLunnar();
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
                    btn.Click +=PreviousBttn_Click;
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
                btn.Click += ButtonNum_Click;

                if (IsEqualDate(useDate, DateTime.Now))
                    btn.TextColor = Color.Aqua;
                if ((IsEqualDate(useDate, dtpk.Value)) && (btn.BackColor != Color.Aqua))
                    btn.TextColor = Color.Yellow;

                //Những ngày lễ
                int k = IsPublicDay(useDate);
                if (k == 1)
                    btn.TextColor = Color.Red;
                else if (k == 0)
                    btn.TextColor = Color.BlueViolet;
                if (k == -1)
                    btn.TextColor = Color.Red;

                MatrixColor[line][column] = btn.BackColor;
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
                num++;
            }
            {
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
                    LuniSolarDate<VietnameseLocalInfoProvider> lunnardate = LuniSolarCalendar<VietnameseLocalInfoProvider>.LuniSolarDateFromSolarDate(useDate);
                    CustomButton btn = Matrix[line][column];
                    btn.Click += NextBttn_Click;
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
                    btn.Click -= ButtonNum_Click;
                    btn.Click -= PreviousBttn_Click;
                    btn.Click -= NextBttn_Click;
                    btn.BackgroundColor = Color.FromArgb(255, 255, 255);
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

        private event EventHandler Dtpk;
        public event EventHandler DTPK
        {
            add { Dtpk += value; }
            remove { Dtpk -= value; ; }
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            AddNumberIntoMatrix(date);
            ShowEvent(dtpk.Value.Month, dtpk.Value.Year);
            if (Dtpk != null)
                Dtpk(this, new EventArgs());
        }

        private void DisplayCalendar_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dtpk.Value = Date;
            ShowEvent(dtpk.Value.Month, dtpk.Value.Year);
        }
        private void BackToDateBttn_Click(object sender, EventArgs e)
        {
            dtpk.Value = DateTime.Now;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }


        private void ButtonNum_Click(object sender, EventArgs e)
        {
            CustomButton btn = sender as CustomButton;
            Date = new DateTime(dtpk.Value.Year, dtpk.Value.Month, Convert.ToInt32(btn.ButtonText));
            var NoteForm = new GeneralNoteForm();
            NoteForm.Dtpk.Value = Date;
            NoteForm.ShowDialog();
        }
        private int IsPublicDay(DateTime date)
        {
            int[] arrint = PublicDate.IsPublic(date);
            if (arrint[0] == -1)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    return -1;
                }
                else
                {
                    return -2;
                }
            }
            else
            {
                int k = 0;
                for (int i = 0; i < arrint.Length; i++)
                {
                    if (k < arrint[i])
                        k = arrint[i];
                }
                if (k == 1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }


        //Xử lí datagridview sự kiện
        private void ShowEvent(int month,int year)
        {
            dtgv.Rows.Clear();
            dtgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            int day = DayOfMonth(new DateTime(year, month, 1));
            for(int i = 1;i<=day;i++)
            {
                DateTime date = new DateTime(year, month, i);
                IsPublicDate(date);
            }
            int k = 0;
            Color[] colors = ColorPublicMonth(month, year);
            foreach(DataGridViewRow row in dtgv.Rows)
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
                for(int i=0;i<arrstring.Length;i++)
                {
                    DateTime datecount = PublicDate.IsPublicDate(arrstring[i], date.Year);
                    int count = datecount.Day - dtpk.Value.Day;

                    dtgv.Rows.Add(string.Format("{0}{1}",count > 0 ? "+" : "",count),arrstring[i]);
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
                for(int i=0;i<arrint.Length;i++)
                {
                    if (arrint[i] == 1)
                        colors[i] = Color.Red;
                    else
                        colors[i] = Color.Blue;
                }
                return colors;
            }
        }
        private Color[] ColorPublicMonth(int month,int year)
        {
            int day = DayOfMonth(new DateTime(year, month, 1));
            Color[] colors = new Color[20];
            int num = 0;
            for (int i = 1; i <= day; i++)
            {
                DateTime date = new DateTime(year, month, i);
                Color[] colors1 = ColorPublicDate(date);
                if(colors1 != null)
                {
                    for(int j=0;j<colors1.Length;j++)
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
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgv.Rows[e.RowIndex];

                DateTime date = PublicDate.IsPublicDate(row.Cells[1].Value.ToString(), dtpk.Value.Year);
                if ((date.Day == 1) && (date.Month == 1) && (date.Year == 1))
                {
                    return;
                }
                for (int i = 0;i<Cons.DayOfColumn;i++)
                {
                    for(int j=0;j<Cons.DayOfWeek;j++)
                    {
                        if (Matrix[i][j].TextColor != Color.DarkGray)
                        {
                            if (Convert.ToInt32(Matrix[i][j].ButtonText) == date.Day)
                            {
                                if(Matrix[i][j].BackgroundColor != Color.Pink)
                                {
                                    Matrix[i][j].BackgroundColor = Color.Pink;
                                    return;
                                }
                                else
                                {
                                    Matrix[i][j].BackgroundColor = Color.FromArgb(255,255,255);
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
