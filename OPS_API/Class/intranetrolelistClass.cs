using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class intranetrolelistClass
    {
      public string empcode { get; set; }
        public string empname { get; set; }
        public string empdesign { get; set; }
        public string empgrade { get; set; }
        public string empdept { get; set; }
        public DateTime dob { get; set; }
        public int intrarole { get; set; }


        public intranetrolelistClass(string _empcode, string _empname, string _empdesign, string _empgrade, string _empdept, DateTime _dob, int _intrarole)
        {
            empcode = _empcode;     
          empname = _empname;
       empdesign = _empdesign;
          empgrade = _empgrade;
          empdept = _empdept;
          dob = _dob;
          intrarole = _intrarole;

        }
    }
}