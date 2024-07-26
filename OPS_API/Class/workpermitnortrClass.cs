using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class workpermitnortrClass
    {
   public string workpermitno { get; set; }
   public string vendorname { get; set; }
   public string phoneno { get; set; }
   public string workdesc { get; set; }
   public string vendoraddress { get; set; }
   public string esitype { get; set; }
   public double noofpersons { get; set; }
   public DateTime startdate { get; set; }
   public DateTime enddate { get; set; }

   public string vendorcode { get; set; }
   public workpermitnortrClass(string _workpermitno, string _vendorname, string _phoneno, string _workdesc, string _vendoraddress, string _esitype, double _noofpersons, DateTime _startdate, DateTime _enddate, string _vendorcode)
        {
            workpermitno = _workpermitno;
            vendorname = _vendorname;
            phoneno = _phoneno;
            workdesc = _workdesc;
            vendoraddress = _vendoraddress;
            esitype = _esitype;
            noofpersons = _noofpersons;
            startdate = _startdate;
            enddate = _enddate;
            vendorcode = _vendorcode;
        }
    }
}