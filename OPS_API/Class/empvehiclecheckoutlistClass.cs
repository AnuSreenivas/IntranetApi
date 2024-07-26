using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class empvehiclecheckoutlistClass
    {
   public string refno { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string vehno { get; set; }
        public DateTime intime { get; set; }


        public empvehiclecheckoutlistClass(string _refno, string emp_code, string emp_name, string _vehno, DateTime in_time)
        {
            refno = _refno;
            empcode = emp_code;
            empname = emp_name;
            vehno = _vehno;
            intime = in_time;


        }
    }
}