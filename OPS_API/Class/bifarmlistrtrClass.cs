using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bifarmlistrtrClass
    {
         public string areacode { get; set; }
         public string farmercode { get; set; }
         public string farmname { get; set; }
         public string farmername { get; set; }
         public string farmtag { get; set; }
         public string itemcode { get; set; }
         public double totalarea { get; set; }
        public bifarmlistrtrClass(string area_code,string farmer_code, string farm_name,string farmer_name, string farm_tag,string item_code, double total_area)
        {
            areacode = area_code;
            farmercode = farmer_code;
            farmname = farm_name;
            farmername = farmer_name;
            farmtag = farm_tag;
            itemcode = item_code;
            totalarea = total_area;
        }
    }
}