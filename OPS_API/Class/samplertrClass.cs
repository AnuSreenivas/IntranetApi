using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class samplertrClass
    {
        public string itemcode { get; set; }
        public string Lotnosf { get; set; }
        public string lotno { get; set; }
        public string sublotno { get; set; }
        public double nobags { get; set; }

        public double purchaserate { get; set; }
        public string samplelab { get; set; }
        public string areacode { get; set; }
        public string farmername { get; set; }
        public DateTime sampledate { get; set; }
        public string samplequality { get; set; }

        public double epapurchaserate { get; set; }
        public samplertrClass(string item_code, string Lot_nosf, string lot_no, string sublot_no, double no_bags, double purchase_rate, string sample_lab, string area_code, string farmer_name, DateTime sample_date, string sample_quality, double epapurchase_rate)
        {
            itemcode = item_code;
            Lotnosf = Lot_nosf;
            lotno = lot_no;
            sublotno = sublot_no;
            nobags = no_bags;
            purchaserate = purchase_rate;
            samplelab = sample_lab;
            areacode = area_code;
            farmername = farmer_name;
            sampledate = sample_date;
            samplequality = sample_quality;
            epapurchaserate = epapurchase_rate;

        }
    }
}