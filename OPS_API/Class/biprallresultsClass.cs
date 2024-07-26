using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprallresultsClass
    {
        public string lotno { get; set; }
   
        public string eures { get; set; }
        public string epares { get; set; }
      
        public string preures { get; set; }
        public string prepares { get; set; }
        public string bothres { get; set; }
        public string afla { get; set; }
        public string pr { get; set; }
        public string areacode { get; set; }

        public double heatvalue { get; set; }
        public string buyrej { get; set; }
        public biprallresultsClass(string lot_no, string preu_res, string prepa_res, string p_r, string eu_res, string epa_res, string a_fla, string both_res, string area_code, double heat_value, string buy_rej)
        {
            lotno = lot_no;
            eures = eu_res;
            epares = epa_res;
           
            preures = preu_res;
            prepares = prepa_res;
            bothres = both_res;
            afla = a_fla;
            pr = p_r;
            areacode = area_code;
            heatvalue = heat_value;
            buyrej = buy_rej;
        }
    }
}