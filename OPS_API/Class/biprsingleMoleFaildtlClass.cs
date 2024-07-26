using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprsingleMoleFaildtlClass
    {
      public string lotno { get; set; }
      public string prmolecule { get; set; }
      public Double prresult { get; set; }
      public string username { get; set; }
      public Double mrlvalue { get; set; }
      public string nfcmole { get; set; }
      public string preures { get; set; }
      public string prepares { get; set; }
      public string bothres { get; set; }
      public Double nobags { get; set; }
      public Double samqty { get; set; }
      public string areacode { get; set; }
      public string eutoxin { get; set; }
      public string epatoxin { get; set; }
      public int molecnt { get; set; }
      public double mrldiff { get; set; }

      public biprsingleMoleFaildtlClass(string lot_no, string pr_molecule, Double pr_result, string user_name, Double mrl_value, string nfc_mole, string pr_eures, string pr_epares, string both_res, Double no_bags, Double sam_qty, string area_code, string eu_toxin, string epa_toxin, int mole_cnt, double mrl_diff)
        {
            lotno = lot_no;
            prmolecule = pr_molecule;
            prresult = pr_result;
            username = user_name;
            mrlvalue = mrl_value;
            nfcmole = nfc_mole;
            preures = pr_eures;
            prepares = pr_epares;
            bothres = both_res;
            nobags = no_bags;
            samqty = sam_qty;
            areacode = area_code;
            eutoxin = eu_toxin;
            epatoxin = epa_toxin;
            molecnt = mole_cnt;
            mrldiff = mrl_diff;


        }
    }
}