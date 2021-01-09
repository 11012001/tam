using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class ToDoClass
    {
        public int Id { get; set; }
        public bool CheckImportant { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public int FHours { get; set; }
        public int FMinutes { get; set; }
        public int THours { get; set; }
        public int TMinutes { get; set; }
        public string Notes { get; set; }
    }
}
