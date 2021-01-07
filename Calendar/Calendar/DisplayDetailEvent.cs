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
using System.Data.OleDb;

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
            int year = DateTime.Now.Year;
            ComboBoxSolarYear.Items.AddRange(Enumerable.Range(1, year).Select(i => (object)i).ToArray());
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
            DataGridViewVN.DataSource = GetAllVN(date.Day, date.Month, date.Year);
        }
        void ShowTIHTG(DateTime date)
        {
            DataGridViewTG.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewTG.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewTG.DataSource = GetAllTG(date.Day, date.Month,date.Year);
        }
        // connection string : chuoi ket noi
        private static OleDbConnection cn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|TodayInHistory.accdb");

        public static void Connect()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public static bool ExecuteQuery(string sql)
        {
            Connect();
            OleDbCommand cmd = new OleDbCommand(sql, cn);
            return cmd.ExecuteNonQuery() > 0;
        }
        public static DataTable GetAllVN(int day, int month,int year)
        {
            string query = string.Format("select NameEvent from EventCalendar where DAY(DateEvent) = {0} and MONTH(DateEvent) = {1} and YEAR(DateEvent) <= {2} order by YEAR(DateEvent)", day, month, year);
            OleDbDataAdapter da = new OleDbDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
        }
        public static DataTable GetAllTG(int day, int month, int year)
        {
            string query = string.Format("select NameEvent from EventWorldCalendar where DAY(DateEvent) = {0} and MONTH(DateEvent) = {1} and YEAR(DateEvent) <= {2} order by YEAR(DateEvent)", day, month, year);
            OleDbDataAdapter da = new OleDbDataAdapter(query, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
        }

        private void DisplayDetailEvent_Load(object sender, EventArgs e)
        {
            SetUpDate();
            ShowTIHVN(DateTime.Now);
            ShowTIHTG(DateTime.Now);
        }

        private void ButtonFind1_Click(object sender, EventArgs e)
        {
            DateTime date = new DateTime(Convert.ToInt32(ComboBoxSolarYear.Text), Convert.ToInt32(ComboBoxSolarMonth.Text), Convert.ToInt32(ComboBoxSolarDay.Text));
            ShowTIHVN(date);
            ShowTIHTG(date);
        }

    }
}
