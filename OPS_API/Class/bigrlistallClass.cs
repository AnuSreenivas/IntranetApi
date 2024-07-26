using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bigrlistallClass
    {
   public string gino { get; set; }
   public string pono { get; set; }
   public string itemcode { get; set; }
   public double grqty { get; set; }
   public double grrate { get; set; }
   public double gramount { get; set; }
   public DateTime grdate { get; set; }
   public string vendorcode { get; set; }
   public string vendorname { get; set; }
   public bigrlistallClass(string gi_no,string po_no, string item_code,double gr_qty,double gr_rate,double gr_amount, DateTime gr_date, string vendor_code, string vendor_name)
        {
            gino = gi_no;
            pono = po_no;
            itemcode = item_code;
            grqty = gr_qty;
            grrate = gr_rate;
            gramount = gr_amount;
            grdate = gr_date;
            vendorcode = vendor_code;
            vendorname = vendor_name;

        }
    }
}