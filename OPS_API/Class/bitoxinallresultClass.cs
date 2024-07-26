using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitoxinallresultClass
    {
   public string lotno { get; set; }
        public double AflaB1 { get; set; }
        public double Aflatoxin { get; set; }
        public double ochratoxin { get; set; }

        public string eures { get; set; }
        public string epares { get; set; }
        public string ochraeures { get; set; }
        public string ochraepares { get; set; }
        public string preures { get; set; }
        public string prepares { get; set; }
        public string bothres { get; set; }
        public string afla { get; set; }
        public string pr { get; set; }
        public bitoxinallresultClass(string lot_no, double Afla_B1, double Afla_toxin, double ochra_toxin, string eu_res, string epa_res, string ochraeu_res, string ochraepa_res, string preu_res, string prepa_res, string both_res, string a_fla, string p_r)
        {
            lotno = lot_no;
           AflaB1 = Afla_B1;
            Aflatoxin = Afla_toxin;
            ochratoxin = ochra_toxin;
            eures = eu_res;
            epares = epa_res;
            ochraeures = ochraeu_res;
            ochraepares = ochraepa_res;
            preures = preu_res;
            prepares = prepa_res;
            bothres = both_res;
            afla = a_fla;
            pr = p_r;
        }
    }
}