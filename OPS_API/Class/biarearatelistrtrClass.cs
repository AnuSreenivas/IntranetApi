using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biarearatelistrtrClass
    {
      public string itemcode { get; set; }
        public string itemquality { get; set; }
        public double eurate { get; set; }
        public double eparate { get; set; }
        public DateTime fromdate { get; set; }
        public DateTime todate { get; set; }
        public string ratestatus { get; set; }
        public string areacode { get; set; }

        public biarearatelistrtrClass(string item_code, string item_quality, double eu_rate, double epa_rate, DateTime from_date, DateTime to_date, string rate_status,string area_code)
        {
            itemcode = item_code;
            itemquality = item_quality;
            eurate = eu_rate;
            eparate = epa_rate;
            fromdate = from_date;
            todate = to_date;
            ratestatus = rate_status;
            areacode = area_code;
        }
    }
}