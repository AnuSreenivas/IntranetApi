using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class candidatescreeninsClass
    {
       public string result { get; set; }
        public string keyvalue { get; set; }


        public candidatescreeninsClass(string _result, string _keyvalue)
        {
            result = _result;
            keyvalue = _keyvalue;
         
        }


    }
}