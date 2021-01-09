using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class DeadlineClass
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int HoursEnd { get; set; }
        public int MinutesEnd { get; set; }
        public int Priorities { get; set; }
        public int Urgent { get; set; }
        public bool CheckImportant { get; set; }
    }
}
