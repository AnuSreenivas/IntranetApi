using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class purtrClass
    {
  public string puname { get; set; }


  public purtrClass(string pu_name)//, string customer_name)//, string prd_date, string exp_date, string so_no, string cust_code)
        {
            puname = pu_name;
        
        }
    }
}