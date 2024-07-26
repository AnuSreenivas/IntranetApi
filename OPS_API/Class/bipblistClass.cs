using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipblistClass
    {
       public string pbinvno { get; set; }
        public string areacode { get; set; }
        public string fname { get; set; }
        public string lotno { get; set; }
        public double nobags { get; set; }
        public double pbqty { get; set; }
        public double pbrate { get; set; }

        public double pbamount { get; set; }
        public DateTime pbdate { get; set; }
        public string pbconfirmed { get; set; }
        public string fcode { get; set; }
        public string farmerbank { get; set; }
        public string farmeraccno { get; set; }

        public string farmername { get; set; }
        public string itemcode { get; set; }
        public double bagrecoverycharge { get; set; }
        public bipblistClass(string pb_invno, string area_code, string f_name, string lot_no, double no_bags, double pb_qty, double pb_rate, double pb_amount, DateTime sys_date, string pb_confirmed, string f_code, string farmer_bank, string farmer_accno, string farmer_name, string item_code, double bag_recoverycharge)
        {

            pbinvno = pb_invno;
            areacode = area_code;
            fname = f_name;
            lotno = lot_no;
            nobags = no_bags;
            pbqty = pb_qty;
            pbrate = pb_rate;
            pbamount = pb_amount;
            pbdate = sys_date;
            pbconfirmed = pb_confirmed;
            fcode = f_code;
            farmerbank = farmer_bank;
            farmeraccno = farmer_accno;
            farmername = farmer_name;
            itemcode = item_code;
            bagrecoverycharge = bag_recoverycharge;
        }
    }
}