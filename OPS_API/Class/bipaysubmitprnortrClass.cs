using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipaysubmitprnortrClass
    {
   public string prno { get; set; }
   public string tolocation { get; set; }
   public string transferedby { get; set; }
   public bipaysubmitprnortrClass(string pr_no, string to_location,string transfered_by)
        {
            prno = pr_no;
            tolocation = to_location;
            transferedby = transfered_by;

        }
    }
}