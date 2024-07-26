using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class manpowerhdrClass
    {
        public string shiftdtls { get; set; }
        public string shiftdate { get; set; }
        
        //public DateTime amcdate { get; set; }
        public string userid { get; set; }
        public string manuf { get; set; }
        //public string latitude { get; set; }
        //public string longitude { get; set; }
        public string uuid { get; set; }

        public List<manpowerdtlClass> manpowerdtlClassList { get; set; }
    }
}