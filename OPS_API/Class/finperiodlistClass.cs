using OPS_API.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPS_API.Class
{
    public class finperiodlistClass
    {
      public string finperiod { get; set; }

      public finperiodlistClass(string _finperiod)
        {
            finperiod = _finperiod;
            
        }
    }
}