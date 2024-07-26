using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class employeesuperviormapClass
    {
  public string empcode { get; set; }
     public string empname { get; set; }
     public string supcode { get; set; }
     public string supname { get; set; }
     public employeesuperviormapClass(string _empcode, string _empname,string _supcode, string _supname)
        {
            empcode = _empcode;
            empname = _empname;
            supcode = _supcode;
            supname = _supname;
          
            }
    }
}