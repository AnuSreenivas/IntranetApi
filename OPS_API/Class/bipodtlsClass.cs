using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipodtlsClass
    {
      public string pono { get; set; }
      public string vendorcode { get; set; }
      public string itemcode { get; set; }
      public double poqty { get; set; }
      public double porate { get; set; }
      public double poamt { get; set; }


      public bipodtlsClass(string po_no, string vendor_code, string item_code, double po_qty, double po_rate, double po_amt)
        {
            pono = po_no;
            vendorcode = vendor_code;
            itemcode = item_code;
            poqty = po_qty;
            porate = po_rate;
            poamt = po_amt;
        }
    }
}