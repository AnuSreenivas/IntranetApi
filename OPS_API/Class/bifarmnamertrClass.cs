using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bifarmnamertrClass
    {
  public string lotno { get; set; }
  public string address { get; set; }

  public bifarmnamertrClass(string lot_no, string address_)
        {
            lotno = lot_no;
            address = address_;

        }
    }
}