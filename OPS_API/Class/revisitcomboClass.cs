using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class revisitcomboClass
    {

        public string refno { get; set; }
        public string purpose { get; set; }
        public string empname { get; set; }
        public string companyname { get; set; }
        public string phoneno { get; set; }
        public string visitorname { get; set; }
        
        public revisitcomboClass(String _refno, string _purpose, string _empname, string _companyname, string _phoneno, string _visitorname)
        {
            refno = _refno;
            purpose = _purpose;
            empname = _empname;
            companyname = _companyname;
            phoneno = _phoneno;
            visitorname = _visitorname;
        
        }

    }
}