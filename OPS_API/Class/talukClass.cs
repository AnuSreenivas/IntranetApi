using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class talukClass
    {
         public string talukname { get; set; }
     
      public talukClass(string taluk_name)
        {
       talukname = taluk_name;
      
        }
    }
}