using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class prmrlmstClass
    {
      
   
   public string prmolecule { get; set; }
   public double prvalue { get; set; }
   
   public prmrlmstClass(string pr_molecule, double pr_value)
        {
            
            prmolecule = pr_molecule;
            prvalue = pr_value;
            
        }
    }
}