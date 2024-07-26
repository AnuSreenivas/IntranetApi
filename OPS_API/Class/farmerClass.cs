using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerClass
    {
        public string farmername { get; set; }  
        public string farmercode { get; set; }
        public string farmname { get; set; }
        public string base64image { get; set; }

        public string phototag { get; set; }
        public string filename { get; set; }
        public string uuid { get; set; }
        public string manuf { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string season { get; set; }
        public string userid { get; set; }
        public farmerClass(string farmer_name, string farmer_code)
        {
            farmername = farmer_name;
            farmercode = farmer_code;


        }
    }
}