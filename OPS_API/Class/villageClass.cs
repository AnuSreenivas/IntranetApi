using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class villageClass
    {
        public string villagename { get; set; }

        public villageClass(string village_name)
        {
       villagename = village_name;
      
        }
    }
}