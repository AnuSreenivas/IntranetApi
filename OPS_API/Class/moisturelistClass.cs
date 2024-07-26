using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class moisturelistClass
    {

        public string areacode { get; set; }
        public string lotno { get; set; }
        public double sampleweight { get; set; }
        public double moisture { get; set; }
        public string moiststatus { get; set; }
        public string remarks { get; set; }
        public DateTime moisturedate { get; set; }

        public moisturelistClass(string area_code, string lot_no, double sample_weight, double moist_ure, string moist_status, string remark_s, DateTime moisture_date)
        {
            areacode = area_code;
            lotno = lot_no;
            sampleweight = sample_weight;
            moisture = moist_ure;
            moiststatus = moist_status;
            remarks = remark_s;
            moisturedate = moisture_date;
        }
    }
}