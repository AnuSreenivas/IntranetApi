using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class agreementstatusinsClass
    {
       public string lotno { get; set; }
        public string refno { get; set; }
      

        public agreementstatusinsClass(string _lotno, string _refno)
        {
            lotno = _lotno;
            refno = _refno;
          
        }


    }
}