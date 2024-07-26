using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmlistrptClass
    {
      public string farmercode { get; set; }
      public string areacode { get; set; }
      public string farmername { get; set; }
      public string farmname { get; set; }
      public string farmtag { get; set; }
      public double totalarea { get; set; }
      public DateTime farmdate { get; set; }
      public farmlistrptClass(string farmer_code, string area_code, string farmer_name, string farm_name, string farm_tag, double total_area, DateTime farm_date)
        {
            areacode = area_code;
            farmername = farmer_name;
            farmname = farm_name;
            farmtag = farm_tag;
            farmercode = farmer_code;
            totalarea = total_area;
            farmdate = farm_date;
           
        }
    }
}