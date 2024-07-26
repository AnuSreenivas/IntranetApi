using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprstrikerrateClass
    {
        public string areaname { get; set; }
        public string areacode { get; set; }
        public int nosamples { get; set; }
        public int prresults { get; set; }
        public int sampass { get; set; }
        public int samepa { get; set; }
        public int sameu { get; set; }
        public int samfail { get; set; }
        public double epapercent { get; set; }
        public double eupercent { get; set; }
        public double overall { get; set; }
        public string zone { get; set; }

        public biprstrikerrateClass(string area_name, string area_code, int no_samples, int pr_results, int sam_pass, int sam_epa, int sam_eu, int sam_fail, double epa_percent, double eu_percent, double over_all, string przone)
        {
            areaname = area_name;
            areacode = area_code;
            nosamples = no_samples;
            prresults = pr_results;
            sampass = sam_pass;
            samepa = sam_epa;
            sameu = sam_eu;
            samfail = sam_fail;
            epapercent = epa_percent;
            eupercent = eu_percent;
            overall = over_all;
            zone = przone;
        }
    }
}