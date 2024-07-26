using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class empvehicleinoutrptlistClass
    {
   public string refno { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string vehno { get; set; }
        public DateTime intime { get; set; }
        public string status { get; set; }
        public DateTime outtime { get; set; }
        public empvehicleinoutrptlistClass(string _refno, string emp_code, string emp_name, string _vehno, DateTime in_time, string _status, DateTime out_time)
        {
            refno = _refno;
            empcode = emp_code;
            empname = emp_name;
            vehno = _vehno;
            intime = in_time;
            status = _status;
            outtime = out_time;

        }
    }
}