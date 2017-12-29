using System;
using System.Collections.Generic;
using System.Text;

namespace ca_core.Yobit
{
    public class YobitResponse
    {
        public string high { get; set; }
        public string low { get; set; }
        public string avg { get; set; }
        public string vol { get; set; }
        public string vol_cur { get; set; }
        public string last { get; set; }
        public string buy { get; set; }
        public string sell { get; set; }
        public string updated { get; set; }

        public YobitResponse()
        {
        }
    }
}
