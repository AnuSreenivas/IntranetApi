using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class voucherhdrClass
    {

        public string voucherno { get; set; }
        public string projectname { get; set; }
        public string areacode { get; set; }
        public int empcode { get; set; }
        public string toempcode { get; set; }
        public string paymentdate { get; set; }
        public double totalamount { get; set; }
        //  public DateTime sysdate { get; set; }
        public string userid { get; set; }
        public string manuf { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

        public string uuid { get; set; }

        public List<payvoucherdtlClass> payvoucherdtlClassList { get; set; }
    }
}