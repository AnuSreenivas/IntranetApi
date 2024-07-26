using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class itemstklistClass
    {
    
   public string itemcode { get; set; }
   public string itemname { get; set; }
   public string lotno { get; set; }

   public string whcode { get; set; }
   public double stkqty { get; set; }
      //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

   public itemstklistClass(string item_code, string item_name, string lot_no, string wh_code, double stk_qty)
        {
            
       itemcode = item_code;
       itemname = item_name;
       lotno = lot_no;
       whcode = wh_code;
       stkqty = stk_qty;
     
        }
    }
}