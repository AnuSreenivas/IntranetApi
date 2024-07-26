using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitotalpassbagsqtyClass
    {
        public string areacode { get; set; }
        public double nobags { get; set; }
        public double samqty { get; set; }

        public bitotalpassbagsqtyClass(string area_code, double no_bags, double sam_qty)
        {
            areacode = area_code;
            nobags = no_bags;
            samqty = sam_qty;
           
        }
    }
}