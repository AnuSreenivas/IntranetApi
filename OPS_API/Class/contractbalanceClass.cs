using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class contractbalanceClass
    {
        public string zone { get; set; }
        public double contractamt { get; set; }
        public double calloffqty { get; set; }

        public double pendqty { get; set; }

        public contractbalanceClass(string _zone, double _contractamt, double _calloffqty, double _pendqty)
        {
            zone = _zone;
            contractamt = _contractamt;
            calloffqty = _calloffqty;

            pendqty = _pendqty;

        }

    }
}