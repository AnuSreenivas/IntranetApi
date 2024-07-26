using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class prhdrClass
    {
        public string prinvno { get; set; }
        public string tolocation { get; set; }
        public string lorryno { get; set; }
        public string ewaybillno { get; set; }
        public DateTime ewaybilldate { get; set; }
        public double ewaybillamt { get; set; }
        public string transferedby { get; set; }
        public string receivedby { get; set; }
      //  public DateTime sysdate { get; set; }
        public string userid { get; set; }
        public string manuf { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string uuid { get; set; }
        public List<prdtlClass> prdtlClassList { get; set;}
    }
}