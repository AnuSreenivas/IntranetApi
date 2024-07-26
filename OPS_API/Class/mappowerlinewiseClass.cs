using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class mappowerlinewiseClass
    {
        public DateTime shiftdate { get; set; }
        public string shiftdtls { get; set; }
   public string processline { get; set; }
   public string linestatus { get; set; }

   public int regular { get; set; }
   public int appr { get; set; }

   public int total { get; set; }
      //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

   public mappowerlinewiseClass(DateTime shift_date, string shift_dtls, string process_line, string line_status, int _regular, int _appr, int _total)
        {
            shiftdate = shift_date;
            shiftdtls = shift_dtls;
            processline = process_line;
            linestatus = line_status;
            regular = _regular;
            appr = _appr;
            total = _total;
        }
    }
}