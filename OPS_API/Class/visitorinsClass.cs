using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class visitorinsClass
    {
   
        public string lotno { get; set; }
        public string visitid { get; set; }
       // public string visitormsg { get; set; }

        public visitorinsClass(string lot_no, string _visitid)
        {
     
            lotno = lot_no;
            visitid = _visitid;
        }
    }
}