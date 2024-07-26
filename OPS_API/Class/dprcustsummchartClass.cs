using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dprcustsummchartClass
    {
     public string customer { get; set; }
 
   public double total { get; set; }
  
      //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

   public dprcustsummchartClass(string _customer, double _total)
        {
            customer = _customer;
           
            total = _total;

       
        }
    }
}