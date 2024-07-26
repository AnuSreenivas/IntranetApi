using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipbconsolidrptClass
    {
   
         public string areacode { get; set; }
         public int totalpb { get; set; }
         public int totalconf { get; set; }
         public int totalopen { get; set; }


         public bipbconsolidrptClass(string area_code, int total_pb, int total_conf, int total_open)
        {
            areacode  = area_code;
            totalpb   = total_pb;
            totalconf = total_conf;
            totalopen = total_open;
            
        }
    }
}