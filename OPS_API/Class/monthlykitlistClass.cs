using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class monthlykitlistClass
    {
   public string fin_period { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string spice { get; set; }
        public string tea { get; set; }
        public string welfarekit { get; set; }
        public string dept { get; set; }

        public monthlykitlistClass(string _fin_period, string _empcode, string _empname, string _spice, string _tea, string _welfarekit, string _dept)
        {
            fin_period = _fin_period;
            empcode = _empcode;
            empname = _empname;
            spice = _spice;
            tea = _tea;
            welfarekit = _welfarekit;
            dept = _dept;
        }
    }
}