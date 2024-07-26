using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class GPSListrptClass
    {
  public string farmercode { get; set; }
      public string areacode { get; set; }
      public string farmername { get; set; }
      public string farmname { get; set; }
      public string farmlatitude { get; set; }
      public string farmlongitude { get; set; }
      public DateTime gpsdate { get; set; }
      public GPSListrptClass(string farmer_code, string area_code, string farmer_name, string farm_name, string farm_latitude, string farm_longitude, DateTime gps_date)
        {
            areacode = area_code;
            farmername = farmer_name;
            farmname = farm_name;
            farmlatitude = farm_latitude;
            farmercode = farmer_code;
            farmlongitude = farm_longitude;
            gpsdate = gps_date;
          
           
        }
    }
}