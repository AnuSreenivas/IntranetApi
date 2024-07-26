using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class emplistshiftwiseClass
    {
     public string empcode { get; set; }
   public string empname { get; set; }
   public string punchtime { get; set; }
   public string processline { get; set; }
   public string roletype { get; set; }
   public string coc { get; set; }
   public string category { get; set; }
   public double stkqty { get; set; }

   public string processline2 { get; set; }
      //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

   public emplistshiftwiseClass(string emp_code, string emp_name, string punch_time, string process_line, string _role, string _coc, string _category, string process_line2)
        {
            
       empcode = emp_code;
       empname = emp_name;
       punchtime = punch_time;
       processline = process_line;
       roletype = _role;
       coc = _coc;
       category = _category;
       processline2 = process_line2;
     
        }
    }
}