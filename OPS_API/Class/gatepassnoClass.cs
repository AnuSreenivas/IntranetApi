using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class gatepassnoClass
    {
   public string gatepassno { get; set; }

   public string items { get; set; }

   public double qty { get; set; }

   public gatepassnoClass(string _gatepassno, string _items, double _qty)
        {
       gatepassno = _gatepassno;     
       items = _items;
       qty = _qty;
   
        }
    }
}