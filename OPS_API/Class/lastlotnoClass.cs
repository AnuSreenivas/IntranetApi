using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class lastlotnoClass
    {
        public string lastlotno { get; set; }
        public string lastlotnumber { get; set; }

        public lastlotnoClass(string lastlot_no, string lastlot_number)
        {
            lastlotno = lastlot_no;
            lastlotnumber = lastlot_number;

        }
    }
}