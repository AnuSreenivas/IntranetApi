using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class canteenHeadCountClass
    {
        public string deptname { get; set; }
        public int hccnt { get; set; }

        public canteenHeadCountClass(string dept_name, int hc_cnt)
        {

            deptname = dept_name;
            hccnt = hc_cnt;


        }
    }
}