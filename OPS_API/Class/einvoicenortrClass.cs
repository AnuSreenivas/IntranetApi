using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class einvoicenortrClass
    {
   public string invoiceno { get; set; }


   public einvoicenortrClass(string invoice_no)
        {
            invoiceno = invoice_no;     
     

        }
    }
}