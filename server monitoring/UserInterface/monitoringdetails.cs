using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserInterface
{
    class monitoringdetails
    {
        public string Monitor { get; set; }
        public string url { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string[] email { get; set; }
        public double polltime { get; set; }
        public DateTime time { get; set; }
        public int counter { get; set; }
        public int countto { get; set; }
    }
}
