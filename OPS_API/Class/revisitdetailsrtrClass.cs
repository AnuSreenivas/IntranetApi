using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class revisitdetailsrtrClass
    {
        
        public string category { get; set; }
        public string purpose { get; set; }
        public string employee_code { get; set; }
        public string employee_name { get; set; }
        public string company_code { get; set; }
        public string company_name { get; set; }
        public string company_address { get; set; }
        public string phoneno { get; set; }
        public string visitor_name { get; set; }
        public string filedetails { get; set; }

        public revisitdetailsrtrClass(String _category, string _purpose, string _employee_code, string _employee_name, string _company_code, string _company_name,string _company_address,string _phoneno,string _visitor_name,string _filedetails)
        {
            category = _category;
            purpose = _purpose;
            employee_code = _employee_code;
            employee_name = _employee_name;
            company_code = _company_code;
            company_name = _company_name;
            company_address = _company_address;
            phoneno = _phoneno;
            visitor_name = _visitor_name;
            filedetails = _filedetails;
        }

    }
}