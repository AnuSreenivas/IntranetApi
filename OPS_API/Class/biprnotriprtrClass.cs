using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprnotriprtrClass
    {
         
        public string prinvno { get; set; }

        public string tolocation { get; set; }

        public string lorryno { get; set; }
        public string ewaybillno { get; set; }
        public double ewaybillamt { get; set; }

       public string pbinvno { get; set; }
    public string areacode { get; set; }
    public string farmercode { get; set; }
    public string farmername { get; set; }
    public string lotno { get; set; }
    public double nobags { get; set; }
    public double prqty { get; set; }
    public double  prrate { get; set; }
    public double pramount { get; set; }
    public DateTime invdate { get; set; }
    public double tripcess { get; set; }
    public double haltingchg { get; set; }
    public string amcrefno { get; set; }
    public string amcdate { get; set; }
    public double totalbags { get; set; }
    public double cessamt { get; set; }
    public string inwarddate { get; set; }
    public string unloaddate { get; set; }
    public double grosswt { get; set; }
    public double tarewt { get; set; }
    public double bagwt { get; set; }
    public double netwt { get; set; }
    public double randwt { get; set; }
    public string recby { get; set; }
 //       cess , haltingchg ,
        //amcrefno , amcdate , totalbags ,
 //cessamt , inwarddate , unloaddate , grosswt ,
 //tarewt , bagwt , netwt , randavgwt ,


 //recby 
    public biprnotriprtrClass(string prinv_no, string to_location, string lorry_no, string ewaybill_no, double ewaybill_amt, string pbinv_no, string area_code, string farmer_code, string farmer_name, string lot_no, double no_bags, double pr_qty, double pr_rate, double pr_amount, DateTime inv_date,double trip_cess, double halting_chg, string amcref_no, string amc_date, double total_bags, double cess_amt, string inward_date, string unload_date, double gross_wt, double tare_wt , double bag_wt, double net_wt,double rand_wt, string rec_by )
        {
            prinvno = prinv_no;
            tolocation = to_location;
            lorryno = lorry_no;
            ewaybillno = ewaybill_no;
            ewaybillamt = ewaybill_amt;

            pbinvno = pbinv_no;
            areacode = area_code;
            farmercode = farmer_code;
            farmername = farmer_name;
            lotno = lot_no;

            nobags = no_bags;
            prqty = pr_qty;
            prrate = pr_rate;
            pramount = pr_amount;
            invdate = inv_date;
       tripcess = trip_cess;
       haltingchg = halting_chg;
            //amcrefno , amcdate , totalbags ,
       amcrefno = amcref_no;
       amcdate = amc_date;
       totalbags = total_bags;
            //cessamt , inwarddate , unloaddate , grosswt ,
       cessamt = cess_amt;
       inwarddate = inward_date;
       unloaddate = unload_date;
       grosswt = gross_wt;

       tarewt = tare_wt;
       bagwt = bag_wt;
       netwt = net_wt;
       randwt = rand_wt;
       recby = rec_by;
        }
    }
}