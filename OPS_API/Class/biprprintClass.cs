using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprprintClass
    {

        public string prinvno { get; set; }
        public string tolocation { get; set; }
        public string lorryno { get; set; }
        public string ewaybillno { get; set; }
        public DateTime ewaybilldate { get; set; }
        public Double ewaybillamt { get; set; }
        public string transferedby { get; set; }
        public string receivedby { get; set; }
        public string pbno { get; set; }
        public string areacode { get; set; }

        public string fname { get; set; }
        public string lotno { get; set; }
        public double nobags { get; set; }
        public double prqty { get; set; }

        public double prrate { get; set; }
        public double pramount { get; set; }
        public DateTime prdate { get; set; }
        public string areaname { get; set; }

        public biprprintClass(string prinv_no, string to_location, string lorry_no, string ewaybill_no, DateTime ewaybill_date, double ewaybill_amt, string transfered_by, string received_by, string pb_no, string area_code, string f_name, string lot_no, double pr_qty , double pr_rate, double pr_amount, DateTime pr_date,double no_bags, string area_name)
        {
            prinvno = prinv_no;
            tolocation = to_location;
            lorryno = lorry_no;
            ewaybillno = ewaybill_no;
            ewaybilldate = ewaybill_date;
            ewaybillamt = ewaybill_amt;
            transferedby = transfered_by;
            receivedby = received_by;
            pbno = pb_no;
            areacode = area_code;
            fname = f_name;
            lotno = lot_no;
            nobags = no_bags;
            prqty = pr_qty;
            prrate = pr_rate;
            pramount = pr_amount;
            prdate = pr_date;
            areaname = area_name;
        }
    }
}