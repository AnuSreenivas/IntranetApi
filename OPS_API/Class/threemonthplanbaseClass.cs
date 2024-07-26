using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class threemonthplanbaseClass
    {
        public string itemspice { get; set; }
        public double currqty { get; set; }
        public double qty1 { get; set; }
        public double qty2 { get; set; }

        public double qty3 { get; set; }
        public double total { get; set; }


        public threemonthplanbaseClass(string _itemspice, double _currqty, double _qty1, double _qty2, double _qty3, double _total)
        {
            itemspice = _itemspice;
            currqty = _currqty;
            qty1 = _qty1;
            qty2 = _qty2;
            qty3 = _qty3;

            total = _total;

        }
    }
}