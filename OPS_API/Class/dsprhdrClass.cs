using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dsprhdrClass
    {
        public String custpo { get; set; }
        public String custname { get; set; }
        public DateTime reqdate { get; set; }

        public DateTime plandate { get; set; }

        public DateTime promdate { get; set; }

        public String portname { get; set; }

        public DateTime contin { get; set; }

        public DateTime contout { get; set; }

        public double orderqty { get; set; }

        public double shipqty { get; set; }

        public double prodqty { get; set; }




        public dsprhdrClass(String cust_po, string cust_name, DateTime req_date, DateTime plan_date, DateTime prom_date, string port_name, DateTime cont_in, DateTime cont_out, double order_qty, double ship_qty, double prod_qty)
        {
            custpo = cust_po;
            custname = cust_name;
            reqdate = req_date;
            plandate = plan_date;
            promdate = prom_date;
            portname = port_name;

            orderqty = order_qty;
            shipqty = ship_qty;
            prodqty = prod_qty;
        }

    }
}