using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprinsClass
    {
         public string lotno { get; set; }
        public string pbinvno { get; set; }
        public string areacode { get; set; }
        public string farmercode { get; set; }

        public biprinsClass(string lot_no, string pbinv_no, string area_code, string farmer_code)
        {
     
            lotno = lot_no;
            pbinvno = pbinv_no;
            areacode = area_code;
            farmercode = farmer_code;
        }
    }
}