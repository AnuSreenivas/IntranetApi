using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class nonempvehiclerptClass
    {
      public string refno { get; set; }
      public string vehicleno { get; set; }
      public string drivername { get; set; }
      public DateTime sysdate { get; set; }
      public DateTime checkoutdate { get; set; }

      public nonempvehiclerptClass(string _refno, string _vehicleno, string _drivername, DateTime _sysdate, DateTime _checkoutdate)
        {

            refno = _refno;
            vehicleno = _vehicleno;
            drivername = _drivername;
            sysdate = _sysdate;
            checkoutdate = _checkoutdate;
           
        }
    }
}