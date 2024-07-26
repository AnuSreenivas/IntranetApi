using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class lineplanrtrClass
    {
      public string processline { get; set; }
   public string linestatus { get; set; }
   

   public string processline2 { get; set; }
      //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

   public lineplanrtrClass(string process_line, string line_status)
        {

            processline = process_line;
            linestatus = line_status;
       
     
        }
    }
}