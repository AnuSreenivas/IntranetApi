using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class stocktransfernortrClass
    {
     public string packslipno { get; set; }
        public string vehicleno { get; set; }
        public string stnno { get; set; }

        public stocktransfernortrClass(string _packslipno, string _vehicleno, string _stnno)
        {
            packslipno = _packslipno;
            vehicleno = _vehicleno;
            stnno = _stnno;
            
        }
    }
}