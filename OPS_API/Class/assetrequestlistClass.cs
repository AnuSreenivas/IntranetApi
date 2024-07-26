using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class assetrequestlistClass
    {
       public string Refno { get; set; }
       public string sys_no { get; set; }
       public string machine { get; set; }
   
        public string system_name { get; set; }
        public string asset_request { get; set; }
    



        public assetrequestlistClass(string _Refno, string _sys_no, string _machine, string _system_name, string _asset_request)
        {
            Refno = _Refno;
            sys_no = _sys_no;
            system_name = _system_name;
            machine = _machine;
            asset_request = _asset_request;
    
            
        }


    }
}