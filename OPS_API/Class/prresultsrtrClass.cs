using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class prresultsrtrClass
    {
   public string lotno { get; set; }
   public string prmolecule { get; set; }
   public double prresult { get; set; }
   public string EUResult { get; set; }
   public string EPAResult { get; set; }

   public prresultsrtrClass(string lot_no, string pr_molecule, double pr_result, string EU_Result, string EPA_Result)
        {
            lotno = lot_no;
            prmolecule = pr_molecule;
            prresult = pr_result;
            EUResult = EU_Result;
            EPAResult = EPA_Result;
        }
    }
}