
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
    public class EmployeeSupervisor
    {

        //public string emp_code { get; set; }
        //public string emp_name { get; set; }
        //public string sup_code { get; set; }
        //public string sup_name { get; set; }
        //public string hod_code { get; set;}
        //public string hod_name { get; set; }
        //public string dept_name { get; set; }
        public string Status { get; set; }
      


            public EmployeeSupervisor(string status)
            {
            Status = status;


            }
        

    }
}