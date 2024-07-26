using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class loandtlClass
    {

        public string compname { get; set; }
        public string voucherno { get; set; }
        public string docno { get; set; }
        public string trantype { get; set; }
        public DateTime trandate { get; set; }

        public DateTime postdate { get; set; }
        public string acccode { get; set; }
        public string crdr { get; set; }
        public string accdesc { get; set; }

        public double amount { get; set; }

        public double exchrate { get; set; }
   public loandtlClass(string _compname, string _voucherno, string _docno,string _trantype, DateTime _trandate, DateTime _postdate, string _acccode, string _crdr, string _accdesc, double _amount, double _exchrate)
        {
            compname = _compname;
            voucherno = _voucherno;
            docno = _docno;
            trantype = _trantype;
            trandate = _trandate;
            postdate = _postdate;
            acccode = _acccode;
            crdr = _crdr;
            accdesc = _accdesc;
            amount = _amount;
            exchrate = _exchrate;
        }
    }
}