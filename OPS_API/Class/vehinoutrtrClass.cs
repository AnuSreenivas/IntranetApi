using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class vehinoutrtrClass
    {
    public string empcode { get; set; }

   public string empname { get; set; }

   public string intime { get; set; }
   public string vehno { get; set; }
   public string vehtype { get; set; }

   public string vehno1 { get; set; }
   public string vehno2 { get; set; }
   public DateTime sysdate { get; set; }
   public string vehno3 { get; set; }
   public string vehno4 { get; set; }
   public vehinoutrtrClass(string _empcode, string _empname, string _intime, string _vehno, string _vehtype, string _vehno1, string _vehno2, DateTime _sysdate, string _vehno3, string _vehno4)
        {
       empcode = _empcode;     
       empname = _empname;
       intime = _intime;
       vehno = _vehno;
       vehtype = _vehtype;
       vehno1 = _vehno1;
       vehno2 = _vehno2;
       sysdate = _sysdate;
       vehno3 = _vehno3;
       vehno4 = _vehno4;
        }
    }
}