using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class photochinsClass
    {
        public string lotno { get; set; }
        public string visitid { get; set; }


        public photochinsClass(string lot_no, string _visitid)
        {

            lotno = lot_no;
            visitid = _visitid;
        }
    }
}