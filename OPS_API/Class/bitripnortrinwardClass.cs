using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitripnortrinwardClass
    {
  public string tripno { get; set; }
        public string fromlocation { get; set; }
        public string tolocation { get; set; }
        public string prno { get; set; }
         public string operatorname { get; set; }
       public string lorryno { get; set; }
         public double totalbags { get; set; }
         public string ewaybillno { get; set; }
         public bitripnortrinwardClass(string trip_no, string from_location, string to_location, string pr_no, string operator_name, string lorry_no, double total_bags, string ewaybill_no)
        {
            tripno = trip_no;
            fromlocation = from_location;
            tolocation = to_location;
            prno = pr_no;
            operatorname = operator_name;
            lorryno = lorry_no;
            totalbags = total_bags;
            ewaybillno = ewaybill_no;
        }
    }
}