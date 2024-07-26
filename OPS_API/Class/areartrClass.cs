using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
   public class areartrClass
    {
   public string areaname { get; set; }

   public string areacode { get; set; }

   public string isrfa { get; set; }
   public string isdryer { get; set; }
   public string areastate { get; set; }

   public string stateimg { get; set; }
  public areartrClass(string area_name, string area_code, string is_rfa, string is_dryer, string area_state, string state_img)
        {
       areaname = area_name;     
       areacode = area_code;
       isrfa = is_rfa;
       isdryer = is_dryer;
       areastate = area_state;
       stateimg = state_img;
        }
    }
}