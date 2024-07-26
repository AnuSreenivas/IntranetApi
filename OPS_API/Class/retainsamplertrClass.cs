using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class retainsamplertrClass
    {
        // pono,rackno,labname,itemcode,customername,sysdate
  public string pono { get; set; }
  public string rackno { get; set; }
  public string labname { get; set; }
  public string itemcode { get; set; }
  public string customername { get; set; }
  public DateTime retaindate { get; set; }
  public retainsamplertrClass(string po_no, string rack_no, string lab_name, string item_code, string customer_name, DateTime sys_date)
        {
            pono  = po_no;
            rackno = rack_no;
            labname = lab_name;
            itemcode = item_code;
            customername = customer_name;
            retaindate = sys_date;

        }
    }
}