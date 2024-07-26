using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class nonemployeeheadcountClass
    {
    public String gate { get; set; }
        public String companyname { get; set; }
        public string visitorname { get; set; }
        public DateTime sysdate { get; set; }
        public string visitcode { get; set; }
        public string employee { get; set; }
        //public string filedetails { get; set; }
        //public DateTime checoutdate { get; set; }

        public nonemployeeheadcountClass(String _gate, string _companyname, string _visitorname, DateTime _sysdate, string _visitcode, string _employee)
        {
            gate = _gate;
            companyname = _companyname;
            visitorname = _visitorname;
           
            sysdate = _sysdate;
            visitcode = _visitcode;
            employee = _employee;
            
        }

    }
}