using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class headcountClass
    {
        public string empdept { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public DateTime intime { get; set; }


        public headcountClass(string emp_dept, string emp_code, string emp_name, DateTime in_time)
        {
            empdept = emp_dept;
            empcode = emp_code;
            empname = emp_name;
            intime = in_time;


        }
    }
}