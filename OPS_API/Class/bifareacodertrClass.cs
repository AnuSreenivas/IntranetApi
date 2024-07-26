using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bifareacodertrClass
    {
   public string areaname { get; set; }

   public string areacode { get; set; }
   public string farmercode { get; set; }

   public bifareacodertrClass(string area_name, string area_code, string farmer_code)
        {
       areaname = area_name;     
       areacode = area_code;
       farmercode = farmer_code;
        }
    }
}