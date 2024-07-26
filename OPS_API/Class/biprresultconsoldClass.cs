using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprresultconsoldClass
    {
        public double samtotal { get; set; }
        public double samconfirm { get; set; }
        public double saminprogress { get; set; }


        public biprresultconsoldClass(double sam_total, double sam_confirm, double sam_inprogress)
        {
            samtotal = sam_total;
            samconfirm = sam_confirm;
            saminprogress = sam_inprogress;
        }
    }
}