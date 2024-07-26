using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class sprsummviewClass
    {
       
   public string custpo { get; set; }
  public string custcode { get; set; }
  public string custname { get; set; }
  public string shipcustcode { get; set; }
  public string shipcustname { get; set; }
  public DateTime promdate { get; set; }
  public double orderqty { get; set; }
  public double prdqty { get; set; }
  public double shipqty { get; set; }
  public string dsprstatus { get; set; }
  public DateTime shipdate { get; set; }
  public double monthshipped { get; set; }
  public DateTime reqdate { get; set; }
  public DateTime actdate { get; set; }
  public string finaldest { get; set; }
  public string invno { get; set; }
  public sprsummviewClass(string cust_po, string cust_code, string cust_name, string ship_custcode, string ship_custname, DateTime prom_date, double order_qty, double prd_qty, double ship_qty, string dspr_status, DateTime ship_date, double month_shipped, DateTime req_date, DateTime act_date, string final_dest, string inv_no)
        {
            custpo = cust_po;
            custcode = cust_code;
            custname = cust_name;
            shipcustcode = ship_custcode;
            shipcustname = ship_custname;
            promdate = prom_date;
            orderqty = order_qty;
            prdqty = prd_qty;
            shipqty = ship_qty;
            dsprstatus = dspr_status;
            shipdate = ship_date;
            monthshipped = month_shipped;
            reqdate = req_date;
            actdate = act_date;
            finaldest = final_dest;
            invno = inv_no;
        }
    }
}