using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipngrlnkpbnortrClass
    {
    public string pbinvno { get; set; }
 public string areacode { get; set; }

 public bipngrlnkpbnortrClass(string pb_no, string area_code)
        {
            pbinvno = pb_no;
            areacode = area_code;
            
        }
    }
}