using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerlistrpthdrClass
    {
       public int totalareas { get; set; }
      public int totalfarmers { get; set; }
      public int totalfarms { get; set; }
      public double totalacreage { get; set; }


      public farmerlistrpthdrClass(int total_areas, int total_farmers, int total_farms, double total_acreage)
        {
            totalareas = total_areas;
            totalfarmers = total_farmers;
            totalfarms = total_farms;
            totalacreage = total_acreage;
                   
        }
    }
}