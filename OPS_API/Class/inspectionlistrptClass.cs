using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class inspectionlistrptClass
    {
     public string farmercode { get; set; }
      public string areacode { get; set; }
      public string farmername { get; set; }
      public string farmname { get; set; }
      public DateTime doa { get; set; }
      public string apptype { get; set; }
      public string producttech { get; set; }
      public double dosage { get; set; }
      public inspectionlistrptClass(string farmer_code, string area_code, string farmer_name, string farm_name, DateTime _doa, string app_type, string product_tech, double _dosage)
        {
            areacode = area_code;
            farmername = farmer_name;
            farmname = farm_name;
            doa = _doa;
            farmercode = farmer_code;
            apptype = app_type;
            producttech = product_tech;
            dosage = _dosage;
        }
    }
}