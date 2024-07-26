using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dsprdtlcustpoClass
    {
  public string sono { get; set; }
  public string itemcode { get; set; }
  public string itemname { get; set; }
  public double orderqty { get; set; }
  public string prdno { get; set; }
  public double prdqty { get; set; }
  public DateTime prddate { get; set; }
  public double prdbalqty { get; set; }
  public double shipqty { get; set; }
  public DateTime shipdate { get; set; }

  public dsprdtlcustpoClass(string so_no, string item_code, string item_name, double order_qty, string prd_no, double prd_qty, DateTime prd_date,double prdbal_qty, double ship_qty, DateTime ship_date)
        {
            sono = so_no;
            itemcode = item_code;
            itemname = item_name;
            orderqty = order_qty;
            prdno = prd_no;
            prdqty = prd_qty;
            orderqty = order_qty;
            prdqty = prd_qty;
            prddate = prd_date;
            prdbalqty = prdbal_qty;
            shipqty = ship_qty;
            shipdate = ship_date;
            
        }
    }
}