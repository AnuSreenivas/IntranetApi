using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bilabrtrClass
    {
         public int id { get; set; }
        public string name { get; set; }
     

        public bilabrtrClass(int id_lab, string lab_name)
        {
            id = id_lab;
            name = lab_name;
           
        }
    }
}