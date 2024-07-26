using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class materialinwardponoClass
    {
        public String pono { get; set; }
        public String vendorcode { get; set; }
        public String vendorname { get; set; }
        
        public string address { get; set; }
        public string empname { get; set; }
        public string empdtls { get; set; }
        public string empcode { get; set; }
       
        public materialinwardponoClass(string _pono, string _vendorcode, string _vendorname, string _address, string _empname, string _empdtls, string _empcode)
        {
            pono = _pono;
            vendorcode = _vendorcode;
            vendorname = _vendorname;

            address = _address;
            empname = _empname;
            empdtls = _empdtls;
            empcode = _empcode;
          
        }

    }
}