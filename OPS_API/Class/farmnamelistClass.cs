using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmnamelistClass
    {
         public string farmname { get; set; }
         public string farmtag { get; set; }
         public string photoserial { get; set; }
         public farmnamelistClass(string farm_name, string farm_tag, string photo_serial)
        {
            farmname = farm_name;
            farmtag = farm_tag;
            photoserial = photo_serial;
        }
    }
}