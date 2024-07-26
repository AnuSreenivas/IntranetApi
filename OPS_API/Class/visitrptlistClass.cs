using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class visitrptlistClass
    {
     public String visitcode { get; set; }
        public String companyname { get; set; }
        public string visitorname { get; set; }
        public string empname { get; set; }
        public DateTime sysdate { get; set; }
        public string purpose { get; set; }
        public string filedetails { get; set; }
        public DateTime checoutdate { get; set; }

        public visitrptlistClass(String _visitcode, string _companyname, string _visitorname, string _empname, DateTime _sysdate, string _purpose, string _filedetails, DateTime _checoutdate)
        {
            visitcode = _visitcode;
            companyname = _companyname;
            visitorname = _visitorname;
            empname = _empname;
            sysdate = _sysdate;
            purpose = _purpose;
            filedetails = _filedetails;
            checoutdate = _checoutdate;
        }

    }
}