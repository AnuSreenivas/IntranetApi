using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class prpbdtlsClass
    {
        public string pbinvno { get; set; }

        public string areacode { get; set; }

        public string fcode { get; set; }
        public string fname { get; set; }
        public string lotno { get; set; }

        public int nobags { get; set; }
        public double pbqty { get; set; }
        public double pbrate { get; set; }
        public double pbamount { get; set; }

        public prpbdtlsClass(string pbinv_no, string area_code, string f_code, string f_name, string lot_no, int no_bags, double pb_qty, double pb_rate, double pb_amount)
        {
               pbinvno = pbinv_no;     
               areacode = area_code;
               fcode = f_code;
               fname = f_name;
               lotno = lot_no;
               nobags = no_bags;
               pbqty = pb_qty;
               pbrate = pb_rate;
               pbamount = pb_amount;

        }
    }
}