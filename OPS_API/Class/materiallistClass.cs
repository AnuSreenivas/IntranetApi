using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class materiallistClass
    {
    public string materialtype { get; set; }

    public materiallistClass(string _materialtype)
        {
            materialtype = _materialtype;
            
            
        }

    }
}