using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biitemrtrClass
    {
    public string itemcode { get; set; }
        public string itemname { get; set; }
        public string itemgroup{ get; set; }

        public biitemrtrClass(string item_code, string item_name, string item_group)
        {
            itemcode = item_code;
            itemname = item_name;
            itemgroup = itemgroup;
        }
    }
}