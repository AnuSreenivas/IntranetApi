using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dthrslistClass
    {
      
  public string pono { get; set; }

  public string puname { get; set; }
  public double phrs { get; set; }
  public DateTime prddate { get; set; }
  public string itemcode { get; set; }
  public string dtdesc { get; set; }
  public string dtcode { get; set; }
  public string remarks { get; set; }
  public dthrslistClass(string po_no, string pu_name, double p_hrs, DateTime prd_date, string item_code, string dt_desc, string dt_code, string _remarks)
        {
            pono = po_no;
            puname = pu_name;
            phrs = p_hrs;
            prddate = prd_date;
            itemcode = item_code;
            dtdesc = dt_desc;
            dtcode = dt_code;
            remarks = _remarks;
        }
    }
}