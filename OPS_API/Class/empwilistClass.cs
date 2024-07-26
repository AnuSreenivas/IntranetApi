using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class empwilistClass
    {
 
        public String empcode { get; set; }
        public String empname { get; set; }
        public string empdesign { get; set; }
        public string empdept { get; set; }
        public string empgrade { get; set; }
        public string extn { get; set; }
        public string punch { get; set; }
        public string filedetails { get; set; }
        public empwilistClass(String emp_code, string emp_name, string emp_design, string emp_dept, string emp_grade, string _extn, string _punch, string _filedetails)
        {
            empcode = emp_code;
            empname = emp_name;
            empdesign = emp_design;
            empdept = emp_dept;
            empgrade = emp_grade;
            extn = _extn;
            punch = _punch;
            filedetails = _filedetails;
        }

    }
}