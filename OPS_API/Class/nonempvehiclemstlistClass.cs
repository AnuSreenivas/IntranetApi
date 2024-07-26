using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class nonempvehiclemstlistClass
    {
        public string vehicleNumber { get; set; }
        public string SelectedVehicleType { get; set; }
        public string driverName { get; set; }
        public string SelectedHostCmp { get; set; }


  public nonempvehiclemstlistClass(string _vehicleno,string _vehicletype,string _drivername, string _hostcompany)
        {
            vehicleNumber = _vehicleno;
            SelectedVehicleType = _vehicletype;
            driverName = _drivername;
            SelectedHostCmp = _hostcompany;

        }
    }
}