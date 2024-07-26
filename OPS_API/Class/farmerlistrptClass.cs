using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerlistrptClass
    {
      public string farmercode { get; set; }
      public string areacode { get; set; }
      public string farmername { get; set; }
      public string fathersname { get; set; }
      public string farmerstate { get; set; }
      
      public farmerlistrptClass(string farmer_code,string area_code, string farmer_name, string fathers_name, string farmer_state)
        {
            areacode = area_code;
            farmername = farmer_name;
            fathersname = fathers_name;
            farmerstate = farmer_state;
          farmercode = farmer_code;
          
           
        }
    }
}