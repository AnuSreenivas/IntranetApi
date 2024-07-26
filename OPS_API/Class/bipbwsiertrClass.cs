using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipbwsiertrClass
    {
        public string pbinvno { get; set; }
        public string areacode { get; set; }
        public string farmercode { get; set; }

        public string farmername{ get; set; }
        public string lotno { get; set; }

        public double nobags {get; set;}

        public double pbqty {get; set;}
        public double pbrate {get; set;}
        public double pbamount {get; set;}
        public DateTime invdate { get; set; }
        public string farmerbank { get; set; }
        public string farmeraccno { get; set; }
        public bipbwsiertrClass(string pbinv_no, string area_code, string farmer_code, string farmer_name, string lot_no, double no_bags, double pb_qty, double pb_rate, double pb_amount, DateTime inv_date, string farmer_accno, string farmer_bank)
        {
            pbinvno = pbinv_no;
            areacode = area_code;
            farmercode = farmer_code;
            farmername = farmername;
            lotno = lot_no;
            nobags = no_bags;
            pbqty = pb_qty;
            pbrate = pb_rate;
            pbamount = pb_amount;
            invdate = inv_date;
            farmerbank = farmer_bank;
            farmeraccno = farmer_accno;
        }
    }
}