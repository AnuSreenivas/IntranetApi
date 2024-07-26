using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class sampledtlrtrClass
    {
    public string itemcode { get; set; }
        public string Lotnosf { get; set; }
        public string lotno { get; set; }
        public string sublotno { get; set; }
        public double nobags { get; set; }
        public string labname { get; set; } 
        public string areacode { get; set; } 
        public string farmername { get; set; }
        public string samresults { get; set; }
        public string preuresults { get; set; }
        public string preparesults { get; set; }
        public string toxineuresults { get; set; }
        public string toxineparesults { get; set; }

        public double heatvalue { get; set; }
        public string buyrej { get; set; }

        public DateTime samdate { get; set; }
        public sampledtlrtrClass(string item_code, string Lot_nosf, string lot_no, string sublot_no, double no_bags, string lab_name, string area_code, string farmer_name, string sam_results, string preu_results, string prepa_results, string toxineu_results, string toxinepa_results, double heat_value, string buy_rej, DateTime sam_date)
        {
            itemcode = item_code;
            Lotnosf = Lot_nosf;
            lotno = lot_no;
            sublotno = sublot_no;
            nobags = no_bags;
            labname = lab_name;
            areacode = area_code;
            farmername = farmer_name;
            samresults = sam_results;
            preuresults = preu_results;
            preparesults = prepa_results;
            toxineuresults = toxineu_results;
            toxineparesults = toxinepa_results;
            heatvalue = heat_value;
            buyrej = buy_rej;
            samdate = sam_date;
        }
    }
}