using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprresultconfirmlotsClass
    {
        public string lotno { get; set; }
        public string euresult { get; set; }
        public string eparesult { get; set; }


        public biprresultconfirmlotsClass(string lot_no, string eu_result, string epa_result)
        {
            lotno = lot_no;
            euresult = eu_result;
            eparesult = epa_result;
        }
    }
}