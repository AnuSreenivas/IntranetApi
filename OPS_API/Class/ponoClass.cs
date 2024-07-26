using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class ponoClass
    {
   public string pono { get; set; }

   public string itemcode { get; set; }

   public string itemname { get; set; }
   //public string customername { get; set; }

   //public string prddate { get; set; }
   //public string expdate { get; set; }
   //public string sono { get; set; }
   //public string custcode { get; set; }

   public ponoClass(string po_no, string item_code, string item_name)//, string customer_name)//, string prd_date, string exp_date, string so_no, string cust_code)
        {
            pono = po_no;
           itemcode = item_code;
           itemname = item_name;
       //customername = customer_name;
       //prddate = prd_date;
       //expdate = exp_date;
       //sono = so_no;
       //custcode = cust_code;
        }
    }
}