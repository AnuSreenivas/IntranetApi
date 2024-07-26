using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class itemlookupClass
    {
 
   public string itemcode { get; set; }
   public string itemname { get; set; }
   public string itembase { get; set; }

   public string olditem { get; set; }
   public string itemtype { get; set; }


   public itemlookupClass( string item_code, string item_name, string item_base, string old_item, string item_type)
        {
            
       itemcode = item_code;
       itemname = item_name;
       itembase = item_base;
       olditem = old_item;
       itemtype = item_type;
     
        }
    }
}