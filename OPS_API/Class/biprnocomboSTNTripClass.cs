using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprnocomboSTNTripClass
    {
            public string prinvno { get; set; }

        public string tolocation { get; set; }

        public string lorryno { get; set; }
        public string ewaybillno { get; set; }
        public double ewaybillamt { get; set; }


        public biprnocomboSTNTripClass(string prinv_no, string to_location, string lorry_no, string ewaybill_no, double ewaybill_amt)
        {
            prinvno = prinv_no;
            tolocation = to_location;
            lorryno = lorry_no;
            ewaybillno = ewaybill_no;
            ewaybillamt = ewaybill_amt;

          
        }
    }
}