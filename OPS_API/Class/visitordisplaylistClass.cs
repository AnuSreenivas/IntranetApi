using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class visitordisplaylistClass
    {
     public DateTime fromdate { get; set; }
    public DateTime todate { get; set; }
    public string visitorname { get; set; }
    public string  companyname { get; set; }
         public visitordisplaylistClass(DateTime _fromdate, DateTime _todate, string _visitorname, string _companyname )
        {
            fromdate = _fromdate;
            todate = _todate;
 
            visitorname = _visitorname;
            companyname = _companyname;
            
        }

    }
}