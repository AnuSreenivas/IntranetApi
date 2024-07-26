using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Controllers
{
    public class emplistteaClass
    {
  
        public String empcode { get; set; }
        public String empname { get; set; }
        public string empdesign { get; set; }
        public string empdept { get; set; }
        public string empgrade { get; set; }
        public string extn { get; set; }
        public string punch { get; set; }
        public string tea { get; set; }
        public string spice { get; set; }
        public emplistteaClass(String emp_code, string emp_name, string emp_design, string emp_dept, string emp_grade, string _extn, string _punch, string _tea, string _spice)
        {
            empcode = emp_code;
            empname = emp_name;
            empdesign = emp_design;
            empdept = emp_dept;
            empgrade = emp_grade;
            extn = _extn;
            punch = _punch;
            tea = _tea;
            spice = _spice;
        }

    }
}