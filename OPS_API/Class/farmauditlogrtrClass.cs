using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmauditlogrtrClass
    {
     public string areacode { get; set; }
      public string farmname { get; set; }
      public double acre { get; set; }
      public DateTime sysdate { get; set; }
      public string farmercode { get; set; }
      public double farmlatitude { get; set; }
      public double farmlongitude { get; set; }
      public string audittag { get; set; }
      public farmauditlogrtrClass(string area_code, string farm_name, double _acre, DateTime sys_date, string farmer_code, double farm_latitude,double farm_longitude,string audit_tag)
        {
            areacode = area_code;
            farmname = farm_name;
            acre = _acre;
            sysdate = sys_date;
          farmercode = farmer_code;
          farmlatitude = farm_latitude;
          farmlongitude = farm_longitude;
          audittag = audit_tag;
           
        }
    }
}