using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class office126logClass
    {
        public String refno { get; set; }
    public String visitcode { get; set; }
        public String purpose { get; set; }
        
        public string empname { get; set; }
        public string companyname { get; set; }
        public string visitorname { get; set; }
        public DateTime visitdate { get; set; }
        public DateTime checkout { get; set; }
        public office126logClass(string _refno, string _visitcode, string _visitorname, string _companyname, string _empname, string _purpose, DateTime _visitdate, DateTime _checkout)
        {
            refno = _refno;
            visitcode = _visitcode;
            purpose = _purpose;
            
            empname = _empname;
            companyname = _companyname;
            visitorname = _visitorname;
            visitdate = _visitdate;
            checkout = _checkout;
        }

    }
}