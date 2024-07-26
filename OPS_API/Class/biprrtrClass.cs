using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprrtrClass
    {
        public string areacode { get; set; } 
        public string itemcode { get; set; }
        public string lotno { get; set; }
        public DateTime sampledate { get; set; }
       
        public string labname { get; set; }
        public string farmercode { get; set; }
        public string farmername { get; set; }
        public double nobags { get; set; }
        public double purchaserate { get; set; }
        public double purchasequantity { get; set; }
        public double purchaseamount { get; set; }


        public biprrtrClass(string area_code, string item_code, string lot_no, DateTime sample_date, string lab_name, string farmer_code, string farmer_name, double no_bags, double purchase_rate, double purchase_quantity, double purchase_amount)
        {
            areacode = area_code;
            itemcode = item_code;        
            lotno = lot_no;
            sampledate = sample_date;
            labname = lab_name;
            farmername = farmer_name;
            farmercode = farmer_code;
            nobags = no_bags;
            purchaserate = purchase_rate;
            purchasequantity = purchase_quantity;
            purchaseamount = purchase_amount;

        }
    }
}