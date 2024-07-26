using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class districtClass
    {
      public string districtname { get; set; }
      public string bifstate { get; set; }

      public districtClass(string district_name, string bif_state)
        {
       districtname = district_name;
       bifstate = bif_state;
        }
    }
}