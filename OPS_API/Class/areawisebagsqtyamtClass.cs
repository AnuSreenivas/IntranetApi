using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class areawisebagsqtyamtClass
    {
      public string alcode { get; set; }

      public double samplecnt { get; set; }
      public double sampleres { get; set; }
      public double sampleamount { get; set; }

      public areawisebagsqtyamtClass(string al_code, double sample_bags, double sample_quantity, double sample_amount)
        {
            alcode = al_code;
            samplecnt = sample_bags;
            sampleres = sample_quantity;
            sampleamount = sample_amount;

        }
    }
}