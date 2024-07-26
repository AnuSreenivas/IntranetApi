using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprlistClass
    {
    public string prinvno { get; set; }
        public string areacode { get; set; }
        public string fname { get; set; }
        public string lotno { get; set; }
        public double nobags { get; set; }
        public double prqty { get; set; }
        public double prrate { get; set; }

        public double pramount { get; set; }
        public DateTime prdate { get; set; }
        public string pbno { get; set; }
        public string tolocation { get; set; }
        public string lorryno { get; set; }
        public string ewaybillno { get; set; }

        public string grno { get; set; }
        public string tripno { get; set; }
        public double itemvalue { get; set; }
        public biprlistClass(string pr_invno, string area_code, string f_name, string lot_no, double no_bags, double pr_qty, double pr_rate, double pr_amount, DateTime sys_date, string pb_no, string to_location, string lorry_no, string ewaybill_no, string gr_no , string trip_no, double item_value)
        {

            prinvno = pr_invno;
            areacode = area_code;
            fname = f_name;
            lotno = lot_no;
            nobags = no_bags;
            prqty = pr_qty;
            prrate = pr_rate;
            pramount = pr_amount;
            prdate = sys_date;
            pbno = pb_no;
            tolocation = to_location;
            lorryno = lorry_no;
            ewaybillno = ewaybill_no;
            grno = gr_no;
            tripno = trip_no;
            itemvalue = item_value;
        }
    }
}