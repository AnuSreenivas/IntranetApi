using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farminspectionrtrClass
    {
   public string farmercode { get; set; }
   public DateTime doa { get; set; }
   public string apptype { get; set; }
   public string product { get; set; }
   public double recdoasge { get; set; }
   public double appdoasge { get; set; }
   public string farmname { get; set; }
   public string moa { get; set; }
   public string product1 { get; set; }
   public double recdoasge1 { get; set; }
   public double appdoasge1 { get; set; }
   public farminspectionrtrClass(string farmer_code, DateTime _doa, string app_type, string _product, double rec_doasge, double app_doasge, string farm_name, string _moa, string _product1, double rec_doasge1, double app_doasge1)
        {
            farmercode = farmer_code;
            doa = _doa;
            apptype = app_type;
            product = _product;
            recdoasge = rec_doasge;
            appdoasge = app_doasge;
            farmname = farm_name;
            moa = _moa;
            product1 = _product1;
            recdoasge1 = rec_doasge1;
            appdoasge1 = app_doasge1;
        }
    }
}