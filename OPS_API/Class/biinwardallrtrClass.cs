using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biinwardallrtrClass
    {
        
  public string tripno { get; set; }
        public string prno { get; set; }
        public string tolocation { get; set; }
        public double haltingchg { get; set; }
         public DateTime inwarddate { get; set; }
       public DateTime unloaddate { get; set; }
         public double grossweight { get; set; }
         public double tareweight { get; set; }
        public double bagweight { get; set; }
        public double netweight { get; set; }
        public string inwardconf { get; set; }
        public string fromlocation { get; set; }
       


         public biinwardallrtrClass(string trip_no, string pr_no, double halting_chg, DateTime inward_date, DateTime unload_date, double gross_weight, double tare_weight, double bag_weight, double net_weight, string inward_conf, string from_location, string to_location)
        {
            tripno = trip_no;
            prno = pr_no;
            haltingchg = halting_chg;
            inwarddate = inward_date;
            unloaddate = unload_date;
            grossweight = gross_weight;
            tareweight = tare_weight;
            bagweight = bag_weight;
            netweight = net_weight;
            inwardconf = inward_conf;
            fromlocation = from_location;
            tolocation = to_location;
        }
    }
}