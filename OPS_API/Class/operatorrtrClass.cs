using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class operatorrtrClass
    {
     public string operatorname { get; set; }

     public operatorrtrClass(string operator_name)
        {
            operatorname = operator_name;     
       
        }
    }
}