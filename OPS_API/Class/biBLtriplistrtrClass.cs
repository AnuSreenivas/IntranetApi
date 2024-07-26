using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biBLtriplistrtrClass
    {
  public string tripno { get; set; }
        public string fromlocation { get; set; }
        public string tolocation { get; set; }
        public string prno { get; set; }
        public string tyredetails { get; set; }
        public string operatorname { get; set; }
        public double freightvalue { get; set; }
        public double handlingvalue { get; set; }
        public DateTime tripdate { get; set; }
        public string lorryno { get; set; }
        public double nobags { get; set; }
        public string lotno { get; set; }
        public DateTime avtin { get; set; }
        public DateTime avtout { get; set; }
        public DateTime tripin { get; set; }
        public double othervalues { get; set; }
        public double cessamt { get; set; }
        public string amcno { get; set; }
        public DateTime amcdate { get; set; }
        public string grstatus { get; set; }
        public biBLtriplistrtrClass(string trip_no, string from_location, string to_location, string pr_no, string tyre_details, string operator_name, double freight_value, double handling_value, DateTime trip_date, string lorry_no, double no_bags, string lot_no, DateTime avt_in, DateTime avt_out, DateTime trip_in, double other_values, double cess_amt, string amc_no, DateTime amc_date, string gr_status)

        {
            tripno = trip_no;
            fromlocation = from_location;
            tolocation = to_location;
            prno = pr_no;
            tyredetails = tyre_details;
            operatorname = operator_name;
            freightvalue = freight_value;
            handlingvalue = handling_value;
            tripdate = trip_date;
            lorryno = lorry_no;
            nobags = no_bags;
            lotno = lot_no;
            avtin = avt_in;
            avtout = avt_out;
            tripin = trip_in;
            othervalues = other_values;
            cessamt = cess_amt;
            amcno = amc_no;
            amcdate = amc_date;
            grstatus = gr_status;
        }
    }
}