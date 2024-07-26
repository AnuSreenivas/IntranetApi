using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class moisturelotnoClass
    {
     public string lotno { get; set; }

       public moisturelotnoClass(string lot_no)
        {
            lotno = lot_no;
            
        }
    }
}