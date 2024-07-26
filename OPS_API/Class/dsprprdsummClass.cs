using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dsprprdsummClass
    {
  public string itembase { get; set; }
  public double orderqty { get; set; }
  public double prdqty { get; set; }
  public double balprd { get; set; }
  public double shipqty { get; set; }
  public double balship { get; set; }
 
  public dsprprdsummClass(string item_base, double order_qty, double prd_qty, double bal_prd, double ship_qty, double bal_ship)
        {
            itembase = item_base;
            orderqty = order_qty;
            prdqty = prd_qty;
            balprd = bal_prd;
            shipqty = ship_qty;
            balship = bal_ship;
            
        }
    }
}