using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class nonempvehicleinlistClass
    {
        public string refno { get; set; }
        public string vehicleNumber { get; set; }
        public string driverName { get; set; }
        public DateTime sysdate { get; set; }
       
        public string SelectedHostCmp { get; set; }


        public nonempvehicleinlistClass(string _refno,string _vehicleno,string _drivername, DateTime _sysdate, string _hostcompany)
        {
            refno = _refno;
            vehicleNumber = _vehicleno;
            sysdate = _sysdate;
            driverName = _drivername;
            SelectedHostCmp = _hostcompany;

        }
    }
}