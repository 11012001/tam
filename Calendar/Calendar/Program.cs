using LunnarSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    static class Program
    {
        static void ThreadProject()
        {
            _12ConGiap.DrawImage();
            VanKhanString.ReadVK();
            LunnarCalendar.ReadFileStar();
            StringText.GetQuote();
            StringText.DrawImage();
            StringText.GetHDSD();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread thd = new Thread(ThreadProject);
            thd.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalendarProject());
        }
    }
}
