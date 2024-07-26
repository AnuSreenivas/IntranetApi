using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class gate3visithdr
    {
        public string workpermitno { get; set; }
        public string vendorcode { get; set; }
        public string vendorname { get; set; }
        public string empcode { get; set; }
        public string empname { get; set; }
        public string dept { get; set; }
        public string purpose { get; set; }
        public string tools { get; set; }
        public string phone { get; set; }
        public string remarks { get; set; }
        public int totalpersons { get; set; }
        public int wppersons { get; set; }
        public string userid { get; set; }

        public List<gate3visitdtl> gate3visitdtlClassList { get; set; }
    }
}