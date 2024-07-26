using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class cabrequestdriverlistClass
    {
     public string drivername { get; set; }
     public string phoneno { get; set; }
     public cabrequestdriverlistClass(string _drivername, string _phoneno)
        {
            drivername = _drivername;
            phoneno = _phoneno;
          
            }
    }
}