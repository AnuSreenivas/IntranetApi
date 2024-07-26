using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bankrtrClass
    {
    public string bankname { get; set; }

    public bankrtrClass(string bank_name)
        {
            bankname = bank_name;     
        }
    }
}