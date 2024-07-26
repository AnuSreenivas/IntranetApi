using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class orderbookprdClass
    {
        public string baseprd { get; set; }
        public double month1 { get; set; }
        public double month2 { get; set; }
        public double month3 { get; set; }
        public double month4 { get; set; }

        public double month5 { get; set; }
        public double month6 { get; set; }
        public double month7 { get; set; }
        public double month8 { get; set; }

        public double month9 { get; set; }
        public double month10 { get; set; }
        public double month11 { get; set; }
        public double month12 { get; set; }
        public double totalorders { get; set; }

        public orderbookprdClass(string base_prd, double _month1, double _month2, double _month3, double _month4, double _month5, double _month6, double _month7, double _month8, double _month9, double _month10, double _month11, double _month12, double total_orders)
        {
            baseprd = base_prd;
            month1 = _month1;
            month2 = _month2;
            month3 = _month3;
            month4 = _month4;

            month5 = _month5;
            month6 = _month6;
            month7 = _month7;
            month8 = _month8;

            month9 = _month9;
            month10 = _month10;
            month11 = _month11;
            month12 = _month12;

            totalorders = total_orders;

        }
    }
}