using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    public partial class DisplayDay : UserControl
    {
        public DisplayDay()
        {
            InitializeComponent();
        }

        private static DisplayDay daydisplay;

        public static DisplayDay DayDisplay
        {
            get
            {
                if (daydisplay == null)
                    daydisplay = new DisplayDay();
                return daydisplay;
            }
        }

        private void displayChangeDate1_Load(object sender, EventArgs e)
        {

        }
    }
}
