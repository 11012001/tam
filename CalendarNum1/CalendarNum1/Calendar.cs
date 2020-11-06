using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNum1
{
    public partial class Calendar : Form
    {
        #region
        private List<List<Button>> Matrix;
        private List<string> DateOfWeek = new List<string>() { "Sunday","Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        #endregion

        public Calendar()
        {
            InitializeComponent();
            CreateMatrix();
        }
        void CreateMatrix()
        {
            Matrix = new List<List<Button>>();
            Button OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.Margin, OldBtn.Location.Y);
                    MatrixPanel.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, OldBtn.Location.Y+OldBtn.Height+Cons.Margin) };
            }
            setDefaultDate();
        }
        void AddNumberIntoMatrix(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                if (IsEqualDate(useDate, DateTime.Now))
                    btn.BackColor = Color.Red;
                if (IsEqualDate(useDate, date))
                    btn.BackColor = Color.Yellow;
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
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
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
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

        private void Clock1_Click(object sender, EventArgs e)
        {

        }

        private void Date1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Paint(object sender, PaintEventArgs e)
        {

        }
        void setDefaultDate()
        {
            dtpkDate.Value=DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrix((sender as DateTimePicker).Value);
        }

        private void NextBttn_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void PreviousBttn_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void DigitalClock_Click(object sender, EventArgs e)
        {
           
        }
        private void Calendar_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToString("T");
        }

        private void MatrixPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
