using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerpbClass
    {
       public string farmername { get; set; }

        public string farmercode { get; set; }

        public string farmerbags { get; set; }
        public farmerpbClass(string farmer_name, string farmer_code, string farmer_bags)
        {
            farmername = farmer_name;
            farmercode = farmer_code;
            farmerbags = farmer_bags;


        }
    }
}