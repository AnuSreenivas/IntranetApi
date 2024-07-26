using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprresultslookupClass
    {
    public string prmolecule { get; set; }
  
        public double prresult { get; set; }
        public string euresult { get; set; } 
        public string eparesult { get; set; }
        public string mnfc { get; set; } 
        
        public biprresultslookupClass(string pr_molecule, double pr_result, string eu_result, string epa_result, string m_nfc)
        {
            prmolecule = pr_molecule;
            prresult = pr_result;
            euresult = eu_result;
            eparesult = epa_result;
            mnfc = m_nfc;
        }
    }
}