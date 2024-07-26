using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biexpClass
    {
    public string prdcode { get; set; }
    public double apr { get; set; }
    public double may { get; set; }
    public double jun { get; set; }
    public double jul { get; set; }
    public double aug { get; set; }
        public double sep { get; set; }
        public double oct { get; set; }
        public double nov { get; set; }
        public double dece { get; set; }
        public double jan { get; set; }
        public double feb { get; set; }
        public double mar { get; set; }
        public double total { get; set; }
        public biexpClass(string _prdcode, double _apr, double _may, double _jun, double _jul, double _aug, double _sep, double _oct, double _nov, double _dece, double _jan, double _feb,double _mar, double _total)
        {
            prdcode = _prdcode;
            apr = _apr;
 
            may = _may;
            jun = _jun;
            jul = _jul;
            aug = _aug;
            sep = _sep;
            oct = _oct;
            nov = _nov;
            dece = _dece;
            jan = _jan;
            feb = _feb;
            mar = _mar;
            total = _total;
        }

    }
}