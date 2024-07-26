using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bilotClass
    {

        public string areacode { get; set; }

        public string itemcode { get; set; }
        public string lotno { get; set; }
        public int nobags { get; set; }

        public DateTime dos { get; set; }

        public string prresult { get; set; }
        public bilotClass(string area_code, string item_code, string lot_no, int no_bags, DateTime do_s, string pr_result)
        {
            areacode = area_code;
            itemcode = item_code;
            lotno = lot_no;
            nobags = no_bags;
            dos = do_s;
            prresult = pr_result;

        }
    }
}