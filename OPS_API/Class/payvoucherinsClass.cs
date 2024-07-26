using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class payvoucherinsClass
    {
     public string lotno { get; set; }
        public string voucherno { get; set; }
        public string areacode { get; set; }
        public string farmercode { get; set; }

        public payvoucherinsClass(string lot_no, string voucher_no, string area_code, string farmer_code)
        {
     
            lotno = lot_no;
            voucherno = voucher_no;
            areacode = area_code;
            farmercode = farmer_code;
        }
    }
}