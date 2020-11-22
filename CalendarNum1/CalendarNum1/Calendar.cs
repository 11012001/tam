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
    public partial class Calendar : Form
    {
        private string filePath = "data.xml";
        private List<List<Button>> Matrix;
        private List<List<Color>> MatrixColor;
        private List<Button> ListBT;
        private PlanData job;
        private List<string> DateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        internal PlanData Job { get => job; set => job = value; }

        public Calendar()
        {
            InitializeComponent();
            CreateList();
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
            Button OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                MatrixColor.Add(new List<Color>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button()
                    { 
                        Width = Cons.dateButtonWidth,
                        Height = Cons.dateButtonHeight,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        TabStop = false,
                        FlatStyle = FlatStyle.Flat
                        
                    };
                    btn.FlatAppearance.BorderSize = 1;
                    btn.Location = new Point(OldBtn.Location.X + OldBtn.Width + Cons.Margin, OldBtn.Location.Y);
                    MatrixPanel.Controls.Add(btn);
                    MatrixColor[i].Add(btn.BackColor);
                    Matrix[i].Add(btn);
                    OldBtn = btn;
                }
                OldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.Margin, OldBtn.Location.Y + OldBtn.Height + Cons.Margin) };
            }
            setDefaultDate();
        }
        void AddNumberIntoMatrix(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);
            int firstcolumn = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
            LunnarCalendar lunnarCalendar = new LunnarCalendar();
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
                    int[] nums = lunnarCalendar.ConvertSolarDateToLunarDate(useDate.Day, useDate.Month, useDate.Year, 7);
                    Button btn = Matrix[line][column];
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Click += new EventHandler(PreviousBttn_Click);
                    btn.Text = String.Format("{0} \n {1}{2}", useDate.Day.ToString(), (nums[0] == 1) ? "".PadLeft(10) + nums[0].ToString() : "".PadLeft(13) + nums[0].ToString(), (nums[0] == 1) ? "/" + nums[1].ToString() : "");
                    useDate = useDate.AddDays(1);
                    MatrixColor[line][column] = btn.BackColor;
                    num++;
                }
            }
            useDate = new DateTime(date.Year, date.Month, 1);
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                int[] nums = lunnarCalendar.ConvertSolarDateToLunarDate(useDate.Day, useDate.Month, useDate.Year, 7);
                Button btn = Matrix[line][column];

                btn.BackColor = Color.PaleTurquoise;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Text = String.Format("{0} \n {1}{2}", i.ToString(), (nums[0] == 1) ? "".PadLeft(10) + nums[0].ToString() : "".PadLeft(13) + nums[0].ToString(), (nums[0] == 1) ? "/" + nums[1].ToString() : "");
                btn.Click += new EventHandler(btn_click);

                if (IsEqualDate(useDate, DateTime.Now))
                    btn.BackColor = Color.Aqua;
                if ((IsEqualDate(useDate, dtpkDate.Value)) && (btn.BackColor != Color.Aqua))
                    btn.BackColor = Color.LightPink;

                //Những ngày lễ được nghỉ
                Color color = Color.Red;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 1, 1)))
                    btn.ForeColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 4, 30)))
                    btn.ForeColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 5, 1)))
                    btn.ForeColor = color;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 9, 2)))
                    btn.ForeColor = color;
                int[] nums2 = lunnarCalendar.ConvertLunarDateToSolarDate(30, 12, useDate.Year - 1, 0, 7);
                int[] nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, useDate.Year, 0, 7);
                if ((nums1[0] == nums2[0]) && (nums1[1] == nums2[1]) && (nums1[2] == nums2[2]))
                {
                    nums2 = lunnarCalendar.ConvertLunarDateToSolarDate(29, 12, useDate.Year - 1, 0, 7);
                    if (IsEqualDate(useDate, new DateTime(nums2[2], nums2[1], nums2[0])))
                        btn.ForeColor = color;
                } 
                else if (IsEqualDate(useDate, new DateTime(nums2[2], nums2[1], nums2[0])))
                {
                    btn.ForeColor = color;
                }
                if (IsEqualDate(useDate, new DateTime(nums1[2], nums1[1], nums1[0])))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(2, 1, useDate.Year, 0, 7);
                if (IsEqualDate(useDate, new DateTime(nums1[2], nums1[1], nums1[0])))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(3, 1, useDate.Year, 0, 7);
                if (IsEqualDate(useDate, new DateTime(nums1[2], nums1[1], nums1[0])))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(10, 3, useDate.Year, 0, 7);
                if (IsEqualDate(useDate, new DateTime(nums1[2], nums1[1], nums1[0])))
                    btn.ForeColor = color;
                

                //Những ngày lễ không được nghỉ nhưng quan trong
                Color colorLe = Color.BlueViolet;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 3, 8)))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 6, 1)))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 10, 20)))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 11, 20)))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 10, 31)))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(useDate, new DateTime(useDate.Year, 12, 24)))
                    btn.ForeColor = colorLe;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(15, 8, useDate.Year, 0, 7);
                if (IsEqualDate(useDate, new DateTime(nums1[2], nums1[1], nums1[0])))
                    btn.ForeColor = colorLe;


                MatrixColor[line][column] = btn.BackColor;
                if (column >= 6)
                    line++;
                useDate = useDate.AddDays(1);
                num++;
            }
            int MaxMatrix = (line == 4) ?  35 : 42;
            if ( column == 6)
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
                    int[] nums = lunnarCalendar.ConvertSolarDateToLunarDate(useDate.Day, useDate.Month, useDate.Year, 7);
                    Button btn = Matrix[line][column];
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.DarkGray;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Click += new EventHandler(NextBttn_Click);
                    btn.Text = String.Format("{0} \n {1} {2}", i.ToString(), (nums[0] == 1) ? "".PadLeft(10) + nums[0].ToString() : "".PadLeft(13) + nums[0].ToString(), (nums[0] == 1) ? "/" + nums[1].ToString() : "");
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
                    btn.Visible = true;
                    btn.Text = "";
                    btn.BackColor = Color.PaleTurquoise;
                    btn.ForeColor = Color.Black;
                    btn.Click -= new EventHandler(btn_click);
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
        void CreateList()
        {
            ListBT = new List<Button>();
            Button oldbtn = new Button()
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0)
            };
            for (int i = 0; i < Cons.MaxEvent; i++)
            {
                Button btn1 = new Button()
                {
                    Width = Cons.eventButtonWidth,
                    Height = Cons.eventButtonHeigh,
                    Location = new Point(oldbtn.Location.X, oldbtn.Location.Y + oldbtn.Height + Cons.Margin),
                    Font = new Font("Microsoft Sans Serif",10,FontStyle.Bold),
                    TabStop = false,
                    FlatStyle = FlatStyle.Flat
                };
                btn1.FlatAppearance.BorderSize = 0;
                NumEventPanel.Controls.Add(btn1);
                ListBT.Add(btn1);
                oldbtn = btn1;
                
            }
        }
        void ClearList()
        {
            for (int i = 0; i < ListBT.Count; i++)
            {
                Button btn = ListBT[i];
                btn.Text = "";
                btn.Visible = true;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.LightCyan;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Click -= new EventHandler(btnClick);
                btn.Click -= new EventHandler(Buttonevent_Click);
            }
        }
        void AddEventInList(DateTime date)
        {
            ClearList();
            List<string> ls = SolarEvent.GetEventMonth(date);
            List<DateTime> lDT = SolarEvent.GetEventDateMonth(date);
            LunnarCalendar lunnarCalendar = new LunnarCalendar();
            Button btn = new Button();
            int num = 0;
            for (int i = 0; i < ls.Count; i++)
            {
                btn = ListBT[i];
                btn.Text = ls[i];          
                btn.Click += new EventHandler(btnClick);
                

                //Những ngày lễ được nghỉ
                Color color = Color.Red;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 1, 1)) && (ls[i] == "Tết Dương lịch"))
                    btn.ForeColor = color;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 4, 30)) && (ls[i] == "Ngày giải phóng miền Nam"))
                    btn.ForeColor = color;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 5, 1)) && (ls[i] == "Ngày Quốc tế Lao động"))
                    btn.ForeColor = color;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 9, 2)) && (ls[i] == "Ngày Quốc Khánh"))
                    btn.ForeColor = color;
                int[] nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, date.Year, 0, 7);                   
                if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Nguyên Đán - Mùng 1 "))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(2, 1, date.Year, 0, 7);
                if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Nguyên Đán - Mùng 2 "))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(3, 1, date.Year, 0, 7);
                if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Nguyên Đán - Mùng 3 "))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(10, 3, date.Year, 0, 7);
                if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Giỗ Tổ Hùng Vương"))
                    btn.ForeColor = color;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(30, 12, date.Year - 1, 0, 7);
                int[] nums = lunnarCalendar.ConvertLunarDateToSolarDate(1, 1, date.Year, 0, 7);
                if ((nums[0] == nums1[0]) && (nums[1] == nums1[1]) && (nums[2] == nums1[2]))
                {
                    nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(29, 12, date.Year - 1, 0, 7);
                    if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Nguyên Đán - Đêm giao thừa"))
                        btn.ForeColor = color;
                }
                else
                {
                    if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Nguyên Đán - Đêm giao thừa"))
                        btn.ForeColor = color;
                }
                
                //Những ngày lễ không được nghỉ nhưng quan trong
                Color colorLe = Color.BlueViolet;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 3, 8)) && (ls[i] == "Ngày Quốc tế Phụ nữ"))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 6, 1)) && (ls[i] == "Ngày Quốc tế thiếu nhi"))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 10, 20)) && (ls[i] == "Ngày Phụ nữ Việt Nam và cũng là Ngày thành lập Hội Phụ nữ Việt Nam"))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 11, 20)) && (ls[i] == "Ngày Nhà giáo Việt Nam"))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 10, 31)) && (ls[i] == "Ngày Hallowen"))
                    btn.ForeColor = colorLe;
                if (IsEqualDate(lDT[i], new DateTime(date.Year, 12, 24)) && (ls[i] == "Ngày lễ Giáng sinh"))
                    btn.ForeColor = colorLe;
                nums1 = lunnarCalendar.ConvertLunarDateToSolarDate(15, 8, date.Year, 0, 7);
                if (IsEqualDate(lDT[i], new DateTime(nums1[2], nums1[1], nums1[0])) && (ls[i] == "Tết Trung Thu"))
                    btn.ForeColor = colorLe;

                num++;
            }

            btn = ListBT[ls.Count];
            btn.Text = "Add...";
            btn.Click += new EventHandler(Buttonevent_Click);
            for (int i = ls.Count + 1; i < Cons.MaxEvent;i++)
            {
                btn = ListBT[i];
                btn.Visible = false;
            }
            
        }

        void setDefaultDate()
        {
            dtpkDate.Value=DateTime.Now;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = (sender as DateTimePicker).Value;
            AddEventInList(date);
            AddNumberIntoMatrix(date);
        }

        private void NextBttn_Click(object sender , EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void PreviousBttn_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        
        void btnClick(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            List<DateTime> lDT = SolarEvent.GetEventDateMonth(dtpkDate.Value);
            List<string> ls = SolarEvent.GetEventMonth(dtpkDate.Value);
            int num = 0;
            for (int i = 0; i < ls.Count; i++)
            {

                if (btn == ListBT[i])
                {
                    num = i;
                    break;
                }
            }
            DateTime date = lDT[num];
            int firstcolumn = DateOfWeek.IndexOf(new DateTime(date.Year, date.Month, 1).DayOfWeek.ToString()) - 1;
            int column = DateOfWeek.IndexOf(date.DayOfWeek.ToString());
            int line = (date.Day + firstcolumn) / 7;
            if ((btn.BackColor == Color.LightCyan) && (Matrix[line][column].BackColor == Color.PaleTurquoise))
            {
                Matrix[line][column].BackColor = Color.Yellow;
            }
            else if ((btn.BackColor == Color.LightCyan) && (Matrix[line][column].BackColor == Color.Yellow))
            {
                Matrix[line][column].BackColor = Color.PaleTurquoise;
            }
            else
                return;
        }

       
        private void Buttonevent_Click(object sender,EventArgs e)
        {
            Button ttb = sender as Button;
            for(int i = 0; i < ListBT.Count;i++)
            {
                if (ttb == ListBT[i] && ttb.Text == "Add...")
                {
                   
                    ttb.Text = "";
                    try
                    {
                        ListBT[i + 1].Text = "Add...";
                        ListBT[i + 1].Visible = true;
                        ListBT[i + 1].Click += new EventHandler(Buttonevent_Click);
                    }
                    catch
                    {
                        MessageBox.Show("Nothing to add!");
                    }
                }
            }
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToString("T");
        }

        private void buttonDOW(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            int colum;
            switch(btn.Text)
            {
                case "Thứ 2":
                    colum = 0;
                    break;
                case "Thứ 3":
                    colum = 1;
                    break;
                case "Thứ 4":
                    colum = 2;
                    break;
                case "Thứ 5":
                    colum = 3;
                    break;
                case "Thứ 6":
                    colum = 4;
                    break;
                case "Thứ 7":
                    colum = 5;
                    break;
                case "Chủ nhật":
                    colum = 6;
                    break;
                default:
                    return;
            }
            for(int i = 0;i<Matrix.Count;i++)
            {
                if (Matrix[i][colum].BackColor == Color.PaleTurquoise)
                {
                    Matrix[i][colum].BackColor = Color.LightGray;
                }
                else if (Matrix[i][colum].BackColor == Color.Blue)
                {
                    Matrix[i][colum].BackColor = Color.LightGray;
                }
                else if ((Matrix[i][colum].BackColor == Color.LightGray) && (MatrixColor[i][colum] ==Color.PaleTurquoise))
                    Matrix[i][colum].BackColor = Color.PaleTurquoise;
                else if ((Matrix[i][colum].BackColor == Color.LightGray) && (MatrixColor[i][colum] == Color.Blue))
                    Matrix[i][colum].BackColor = Color.Blue;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackToDateBttn_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LichDuong lichDuong = new LichDuong();
            this.Hide();
            lichDuong.ShowDialog();
            Close();
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
            DateTime date = new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, 1);
            int line = 0;
            int column = 0;
            int num = 1;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                column = DateOfWeek.IndexOf(date.DayOfWeek.ToString());
                if (Matrix[line][column].Text == btn.Text)
                {
                    DailyPlan dailyPlan = new DailyPlan(new DateTime(date.Year, date.Month, num), Job);
                    dailyPlan.ShowDialog();
                    return;
                }
                if (column >= 6)
                    line++;
                num++;
                date = date.AddDays(1);
            }
        }
    }
}

