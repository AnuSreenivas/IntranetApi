using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprconfpatternClass
    {
        public double nolots { get; set; }
        public double eupass { get; set; }
        public double eufail { get; set; }
        public double epapass { get; set; }
        public double epafail { get; set; }

        public biprconfpatternClass(double no_lots, double eu_pass, double eu_fail, double epa_pass, double epa_fail)
        {
            nolots = no_lots;
            eupass = eu_pass;
            eufail = eu_fail;
            epapass = epa_pass;
            epafail = epa_fail;
        }
    }
}