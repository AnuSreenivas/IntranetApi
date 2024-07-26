using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class audithdrClass
    {
        public string areacode { get; set; }
        public string areaname { get; set; }
        public string farmercode { get; set; }
        public string farmername { get; set; }
        public string farmname { get; set; }
        public double acre { get; set; }
        public double hectre { get; set; }
        public double sqmtr { get; set; }
        //  public DateTime sysdate { get; set; }
        public string userid { get; set; }
        public string manuf { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string uuid { get; set; }

        public List<auditdtlClass> auditdtlClassList { get; set; }
    }
}