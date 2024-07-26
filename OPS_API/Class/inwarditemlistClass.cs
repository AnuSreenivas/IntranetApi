using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class inwarditemlistClass
    {
      public string itemcode { get; set; }
        public string itemname { get; set; }
        public string uom { get; set; }
        
        public double quantity { get; set; }

        public double slno { get; set; }
        public inwarditemlistClass(string _itemcode, string _itemname, string _uom, double _quantity, double _slno)
        {
            itemcode = _itemcode;
            itemname = _itemname;
            uom = _uom;
            quantity=_quantity;
            slno = _slno;
          
        }

    }
}