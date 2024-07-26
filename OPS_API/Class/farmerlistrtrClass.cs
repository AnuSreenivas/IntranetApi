using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerlistrtrClass
    {
  public string farmercode { get; set; }

   public string areacode { get; set; }

   public string farmername { get; set; }
   public string fathersname { get; set; }
   public string aadharno { get; set; }

   public string farmerstate { get; set; }
   public string accountno { get; set; }
   public string bankname { get; set; }
   public string confirmedstatus { get; set; }
   public string saeson { get; set; }
 
   public farmerlistrtrClass(string farmer_code, string area_code, string farmer_name, string fathers_name, string aadhar_no, string farmer_state, string account_no, string bank_name, string confirmed_status, string _season)
        {
       farmercode = farmer_code;     
       areacode = area_code;
       farmername = farmer_name;
       fathersname = fathers_name;
       aadharno = aadhar_no;
       farmerstate = farmer_state;
       accountno = account_no;
       bankname = bank_name;
       confirmedstatus = confirmed_status;
       saeson = _season;
        }
    }
}