using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmproductdosageClass
    {
    
  public string product { get; set; }
  public double dosage { get; set; }
  public string dosageuom { get; set; }

  public farmproductdosageClass(string _product, double _dosage, string dosage_uom)
        {
            product = _product;
            dosage = _dosage;
            dosageuom = dosage_uom;

        }
    }
}