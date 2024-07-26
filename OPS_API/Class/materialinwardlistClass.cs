using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class materialinwardlistClass
    {        
        public string inwardno { get; set; }
        public string vendorname { get; set; }
         public string pono { get; set; }
        public string billno { get; set; }
        public string itemcode { get; set; }
        public string itemname { get; set; }
        public double quantity { get; set; }
        public DateTime sysdate { get; set; }
        public string vehicleno { get; set; }
        public int slno { get; set; }
        public string dept { get; set; }
        public double qty { get; set; }
        public materialinwardlistClass(string _inwardno, string _vendorname, string _pono, string _billno, string _itemcode, string _itemname, double _quantity, DateTime _sysdate, string _vehicleno, int _slno, string _dept, double _qty)
        {
            inwardno = _inwardno;
            vendorname = _vendorname;
 
            pono = _pono;
            billno = _billno;
            itemcode = _itemcode;
            itemname = _itemname;
            quantity = _quantity;
            sysdate = _sysdate;
            vehicleno = _vehicleno;
            slno = _slno;
            dept = _dept;
            qty = _qty;
        }

    }
}