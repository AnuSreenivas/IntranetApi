using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biblponortrClass
    {
       public string pono { get; set; }
       public string itemcode { get; set; }
       public double qty  { get; set; }
       public double rate { get; set; }
       public double line { get; set; }

       public biblponortrClass(string po_no, string item_code, double po_qty, double po_rate, double po_line)
        {
            pono = po_no;
            itemcode = item_code;
            qty = po_qty;
            rate = po_rate;
            line = po_line;
        }
    }
}