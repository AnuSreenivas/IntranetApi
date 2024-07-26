using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class lotagewarehouseClass
    {
        public string warehouse { get; set; }
        public double a30 { get; set; }
        public double a60 { get; set; }
        public double a120 { get; set; }

        public double a180 { get; set; }
        public double a360 { get; set; }
        public double above360 { get; set; }

        public double grandtotal { get; set; }

        public lotagewarehouseClass(string _warehouse, double _a30, double _a60, double _a120, double _a180, double _a360, double _above360, double _grandtotal)
        {
            warehouse = _warehouse;
            a30 = _a30;
            a60 = _a60;
            a120 = _a120;

            a180 = _a180;
            a360 = _a360;
            above360 = _above360;

            grandtotal = _grandtotal;

        }
    }
}