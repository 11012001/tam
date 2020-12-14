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
        private DateTime date;
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
        void ShowTIHVN()
        {
            date = dtpk.Value;
            DataGridViewVN.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewVN.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DataGridViewVN.DataSource = GetAllVN(date.Day,date.Month,date.Year).Tables[0];
            //DataGridViewVN.DataMember = "EventCalendar";
        }
        void ShowTIHTG()
        {
            date = dtpk.Value;
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
            ShowTIHVN();
            ShowTIHTG();
        }

        private void dtpk_ValueChanged(object sender, EventArgs e)
        {
            date = (sender as Guna.UI2.WinForms.Guna2DateTimePicker).Value;
            ShowTIHVN();
            ShowTIHTG();
        }

        private void ButtonWorld_Click(object sender, EventArgs e)
        {
            PanelVN.BringToFront();
        }

        private void ButtonVN_Click(object sender, EventArgs e)
        {
            PanelWorld.BringToFront();
        }
    }
}
