using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class SpeechJSon
    {
        public class root
        {
            public int error { get; set; }
            public string async { get; set; }
            public string request_id { get; set; }
            public string message { get; set; }
        }
    }
}
