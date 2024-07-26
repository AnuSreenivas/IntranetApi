using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class office126comboClass
    {
  
        public String visitcode { get; set; }
        public String purpose { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string companyname { get; set; }
        public string visitorname { get; set; }
        public DateTime visitdate { get; set; }
        public string empdtls { get; set; }
        public string filedetails { get; set; }
        public office126comboClass(String _visitcode, string _purpose, string _empcode, string _empname, string _companyname, string _visitorname, DateTime _visitdate, string _empdtls, string _filedetails)
        {
            visitcode = _visitcode;
            purpose = _purpose;
            empcode = _empcode;
            empname = _empname;
            companyname = _companyname;
            visitorname = _visitorname;
            visitdate = _visitdate;
            empdtls = _empdtls;
            filedetails = _filedetails;
        }

    }
}