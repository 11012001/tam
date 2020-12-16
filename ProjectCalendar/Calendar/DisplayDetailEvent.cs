using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calendar
{
    public partial class DisplayDetailEvent : UserControl
    {
        private static DisplayDetailEvent detaileventdisplay;
        public static DisplayDetailEvent DetailEventDisplay
        {
            get
            {
                if (detaileventdisplay == null)
                    detaileventdisplay = new DisplayDetailEvent();
                return detaileventdisplay;
            }
        }
        public DisplayDetailEvent()
        {
            InitializeComponent();
        }
        private void SetUpDate()
        {
            #region Set Up Năm
            ComboBoxSolarYear.Items.AddRange(Enumerable.Range(1, 9999).Select(i => (object)i).ToArray());
            int year = DateTime.Now.Year;
            ComboBoxSolarYear.Text = year.ToString();
            #endregion

            #region Set Up Tháng
            ComboBoxSolarMonth.Items.AddRange(Enumerable.Range(1, 12).Select(i => (object)i).ToArray());
            int month = DateTime.Now.Month;
            ComboBoxSolarMonth.Text = month.ToString();
            #endregion

            SetUpDay(month, year);
        }
        #region Set Up Ngày
        private void SetUpDay(int month, int year)
        {
            ComboBoxSolarDay.Items.Clear();
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 31).Select(i => (object)i).ToArray());
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 30).Select(i => (object)i).ToArray());
                    break;
                case 2:
                    if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                        ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 29).Select(i => (object)i).ToArray());
                    else
                        ComboBoxSolarDay.Items.AddRange(Enumerable.Range(1, 28).Select(i => (object)i).ToArray());
                    break;
                default:
                    break;
            }
            ComboBoxSolarDay.Text = DateTime.Now.Day.ToString();
        }
        #endregion
        void ShowTIHVN(DateTime date)
        {
            DataGridViewVN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewVN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewVN.DataSource = GetAllVN(date.Day,date.Month,date.Year).Tables[0];
            //DataGridViewVN.DataMember = "EventCalendar";
        }
        void ShowTIHTG(DateTime date)
        {
            DataGridViewTG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewTG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewTG.DataSource = GetAllTG(date.Day, date.Month,date.Year).Tables[0];
            //DataGridViewTG.DataMember = "EventWorldCalendar";
        }
        // connection string : chuoi ket noi
        public static string connectionstring = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Calendar;Integrated Security=True";
        DataSet GetAllVN(int day,int month,int year)
        {
            DataSet data = new DataSet();

            //Sql Connection
            //sử dụng using để sau khi xài xong tự hủy (không ngốn ram)
            string query = string.Format("select NameEvent from EventCalendar where DAY(DateEvent) = {0} and MONTH(DateEvent) = {1} and YEAR(DateEvent) <= {2}", day, month, year);
            using(SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
                con.Close();
            }
            //Sql Command
            //Sql DataAdapter
            
            return data;
        }
        DataSet GetAllTG(int day, int month,int year)
        {
            DataSet data = new DataSet();

            //Sql Connection
            //sử dụng using để sau khi xài xong tự hủy (không ngốn ram)
            string query = string.Format("select NameEvent from EventWorldCalendar where DAY(DateEvent) = {0} and MONTH(DateEvent) = {1} and YEAR(DateEvent) <= {2}", day, month, year);
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
                con.Close();
            }
            //Sql Command
            //Sql DataAdapter

            return data;
        }
        private void DisplayDetailEvent_Load(object sender, EventArgs e)
        {
            SetUpDate();
            ShowTIHVN(DateTime.Now);
            ShowTIHTG(DateTime.Now);
        }

        private void ButtonWorld_Click(object sender, EventArgs e)
        {
            PanelVN.BringToFront();
        }

        private void ButtonVN_Click(object sender, EventArgs e)
        {
            PanelWorld.BringToFront();
        }

        private void ButtonFind1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(Convert.ToInt32(ComboBoxSolarYear.Text), Convert.ToInt32(ComboBoxSolarMonth.Text), Convert.ToInt32(ComboBoxSolarDay.Text));
            ShowTIHVN(date);
            ShowTIHTG(date);
        }
    }
}
