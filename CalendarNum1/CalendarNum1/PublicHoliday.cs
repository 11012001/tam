using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarNum1
{
    public partial class PublicHoliday : UserControl
    {
        //https://app.abstractapi.com/#/holidays
        private const string API_Key = "c0016c5df2934319becd3605f3341dbc";
        public PublicHoliday()
        {
            InitializeComponent();
        }
        public void LoadHoliday(DateTime Date)
        {
            string url = "";
            url = $""
        }

    }
}
