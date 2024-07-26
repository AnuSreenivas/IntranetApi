using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class VisitorDisplayClass
    {

        public string fromdate { get; set; }
        public string todate { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string userid { get; set; }

        public List<VisitorDisplayDtlClass> visitordisplaydtlClassList { get; set; }
    }
}