using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitripinsClass
    {
     public string lotno { get; set; }
        public string tripno { get; set; }
        public string areacode { get; set; }
        public string farmercode { get; set; }

        public bitripinsClass(string lot_no, string trip_no, string area_code, string farmer_code)
        {
     
            lotno = lot_no;
            tripno = trip_no;
            areacode = area_code;
            farmercode = farmer_code;
        }
    }
}