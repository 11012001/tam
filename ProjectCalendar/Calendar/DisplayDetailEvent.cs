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
        private SqlConnection sqlcon;
        private DataTable dt = new DataTable();
        private SqlDataAdapter sqlda = new SqlDataAdapter();
        private string  scon = "Data Source=MSI/SQLEXPRESS;Initial Catalog=Calendar;Integrated Security=True";
        public DisplayDetailEvent()
        {
            InitializeComponent();
        }
    }
}
