using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class loantbClass
    {
  public string acccode { get; set; }

   public string accdesc { get; set; }

   public double amount { get; set; }
 
   public loantbClass(string _acccode, string _accdesc, double _amount)
        {
            acccode = _acccode;
            accdesc = _accdesc;
            amount = _amount;
        }
    }
}