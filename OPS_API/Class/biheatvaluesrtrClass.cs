using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biheatvaluesrtrClass
    {
 public string lotno { get; set; }
 public double shuvalue { get; set; }
 public DateTime shudate { get; set; }
 public string labname { get; set; }
 public biheatvaluesrtrClass(string lot_no, double shu_value, DateTime shu_date, string lab_name)
        {
            lotno = lot_no;
            shuvalue = shu_value;
            shudate = shu_date;
            labname = lab_name;
        }
    }
}