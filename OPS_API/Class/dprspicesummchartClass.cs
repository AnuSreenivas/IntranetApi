using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dprspicesummchartClass
    {
        public string product { get; set; }

        public double total { get; set; }

        //  tock.sbl_item_code	,item.loi_itemdesc 	,sbl_lot_no 	,sbl_wh_code 	,sbl_quantity,

        public dprspicesummchartClass(string _product, double _total)
        {
            product = _product;

            total = _total;


        }
    }
}