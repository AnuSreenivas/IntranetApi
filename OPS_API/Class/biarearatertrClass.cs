using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biarearatertrClass
    {
      
  public string itemcode { get; set; }
  public string itemquality { get; set; }
  public double purchaserate { get; set; }
  public DateTime fromdate { get; set; }
  public DateTime todate { get; set; }
  public string ratestatus { get; set; }

  public double epapurchaserate { get; set; }
  public string areacode { get; set; }
  public biarearatertrClass(string item_code, string item_quality, double purchase_rate, DateTime from_date, DateTime to_date, string rate_status, double epapurchase_rate, string area_code)
        {
            itemcode = item_code;
            itemquality = item_quality;
            purchaserate = purchase_rate;
            fromdate = from_date;
            todate = to_date;

            epapurchaserate = epapurchase_rate;

            ratestatus = rate_status;
            areacode = area_code;
        }
    }
}