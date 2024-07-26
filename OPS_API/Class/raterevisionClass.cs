using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class raterevisionClass
    {
        public string itemcode { get; set; }
        public double bieparate { get; set; }
        public double bieurate { get; set; }
        public double biqtyepa { get; set; }
        public double biqtyeu { get; set; }
        public double bival { get; set; } 
        public double biqty { get; set; } 
        public double biavgrate { get; set; }
        public double bleparate { get; set; }
        public double bleurate { get; set; }
        public double blqtyepa { get; set; }
        public double blqtyeu { get; set; }
        public double blval { get; set; }
        public double blqty { get; set; }
        public double blavgrate { get; set; }
        public double avtqty { get; set; }

        public double avtval { get; set; }
        public double avtavgrate { get; set; }

        
        public raterevisionClass(string item_code, double bi_eparate, double bi_eurate, double bi_qtyepa, double bi_qtyeu, double bi_val, double bi_qty, double bi_avgrate, double bl_eparate, double bl_eurate, double bl_qtyepa, double bl_qtyeu, double bl_val, double bl_qty, double bl_avgrate, double avt_val, double avt_qty, double avt_avgrate)
        {
            itemcode = item_code;
            bieparate = bi_eparate;
            bieurate = bi_eurate;
            biqtyepa = bi_qtyepa;
            biqtyeu = bi_qtyeu;
            bival = bi_val;
            biqty = bi_qty;
            biavgrate = bi_avgrate;

            bleparate = bl_eparate;
            bleurate = bl_eurate;
            blqtyepa = bl_qtyepa;
            blqtyeu = bl_qtyeu;
            blval = bl_val;
            blqty = bl_qty;
            blavgrate = bl_avgrate;

            avtval = avt_val;
            avtqty = avt_qty;
            avtavgrate = avt_avgrate;
        }
    }
}