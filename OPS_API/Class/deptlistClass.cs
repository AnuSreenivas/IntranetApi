using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class deptlistClass
    {
        public string dept { get; set; }
        public string deptcode { get; set; }
        public deptlistClass(string _dept, string _deptcode)
        {
            dept = _dept;
            deptcode = _deptcode;

        }


    }
}