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
using System.Xml.Serialization;

namespace CalendarNum1
{
    public partial class LichDuong : Form
    {
        private string filePath = "data.xml";
        private PlanData job;
        private List<List<Button>> Matrix;
        private List<List<Color>> MatrixColor;
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        internal PlanData Job { get => job; set => job = value; }

        public LichDuong()
        {
            InitializeComponent();
            CreateMatrix();
            try
            {
                DeserializeFromXML(filePath);
            }
            catch
            {
                SetDefaultJob();
            }
        }
        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,
                FromTime = new Point(4, 0),
                ToTime = new Point(5, 0),
                Job = "Thử nghiệm",
                Status = PlanItem.ListStatus[(int)EPlanItem.COMING]
            });
        }
        void CreateMatrix()
        {
            Matrix = new List<List<Button>>();
            MatrixColor = new List<List<Color>>();
            Button OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.SmallMargin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                MatrixColor.Add(new List<Color>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.SmallDateButtonWidth,
                        Height = Cons.SmallDateButtonHeight,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        TabStop = false,
                        FlatStyle = FlatStyle.Flat

                    };
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.SmallMargin, OldBtn.Location.Y);
                    MatrixPanel.Controls.Add(btn);
                    MatrixColor[i].Add(btn.BackColor);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.SmallMargin, OldBtn.Location.Y + OldBtn.Height + Cons.SmallMargin) };
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
                    Button btn = Matrix[line][column];
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Click += new EventHandler(PreviousBtn_Click);
                    btn.Text = useDate.Day.ToString();
                    useDate = useDate.AddDays(1);
                    MatrixColor[line][column] = btn.BackColor;
                    num++;
                }
            }

           


            useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];

                btn.BackColor = Color.PaleTurquoise;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Text = i.ToString();
                btn.Click += new EventHandler(btn_click);

                if (IsEqualDate(useDate, DateTime.Now))
                    btn.BackColor = Color.Aqua;
                if ((IsEqualDate(useDate, dtpk.Value)) && (btn.BackColor != Color.Aqua))
                    btn.BackColor = Color.LightPink;

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
                        Button btn = Matrix[i][j];
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
                    Button btn = Matrix[line][column];
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Text = i.ToString();
                    btn.Click += new EventHandler(Nextbtn_Click);
                    MatrixColor[line][column] = btn.BackColor;
                    if (column >= 6)
                        line++;
                    useDate = useDate.AddDays(1);
                }
                if (MaxMatrix == 35)
                {
                    for (int i = 0; i < Cons.DayOfWeek; i++)
                    {
                        Button btn = Matrix[line][i];
                        MatrixColor[line][i] = btn.BackColor;
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
                    Button btn = Matrix[i][j];
                    btn.Visible = true;
                    btn.Text = "";
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.Black;
                    btn.Click -= new EventHandler(btn_click);
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
        private void fullViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            this.Hide();
            calendar.ShowDialog();
            Close();
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
            DateTime date = (sender as DateTimePicker).Value;
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
            Clock.Text = DateTime.Now.ToString("T");
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }

        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                object result = sr.Deserialize(fs);
                fs.Close();
                return result;
            }
            catch
            {
                fs.Close();
                throw new NotImplementedException();
            }
        }

        private void Calendar_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(Job, filePath);
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            DailyPlan dailyPlan = new DailyPlan(new DateTime(dtpk.Value.Year, dtpk.Value.Month, int.Parse(btn.Text)), Job);
            dailyPlan.ShowDialog();
        }
    }
}
