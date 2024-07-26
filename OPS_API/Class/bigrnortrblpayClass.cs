using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bigrnortrblpayClass
    {
   public string grno { get; set; }
   public string vendorcode { get; set; }
   public bigrnortrblpayClass(   string gr_no  ,   string vendor_code)
        
   {
       grno = gr_no;
       vendorcode = vendor_code;
   
   }
    }
}