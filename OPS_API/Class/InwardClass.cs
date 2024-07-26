using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class InwardClass
    {
        
        public string pono { get; set; }
        public string billno { get; set; }
        public string billdate { get; set; }
        public string vehicleno { get; set; }
        public string remarks { get; set; }
        public string userid { get; set; }

        public string vendorcode { get; set; }
        public string vendorname { get; set; }

        public List<InwardDtlClass> inwarddtlClassList { get; set; }
    }
}