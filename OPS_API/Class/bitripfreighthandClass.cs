using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitripfreighthandClass
    {
        public double areafreight { get; set; }
        public double areahandling { get; set; }

        public bitripfreighthandClass(double area_freight, double area_handling)
        {

            areafreight = area_freight;
            areahandling = area_handling;
           
        }
    }
}