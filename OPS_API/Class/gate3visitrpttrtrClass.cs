using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class gate3visitrpttrtrClass
    {
    public string refno { get; set; }
   public int slno { get; set; }
   public string workername { get; set; }
   public string vendorname { get; set; }
   public string workpermitno { get; set; }
   public DateTime intime { get; set; }

   public string vendorcode { get; set; }
   public DateTime outtime { get; set; }
   public gate3visitrpttrtrClass(string _refno, int _slno, string _workername, string _vendorname, string _workpermitno, DateTime _intime, DateTime _outtime)
        {
            refno = _refno;
            slno = _slno;
            workername = _workername;
            vendorname = _vendorname;
            workpermitno = _workpermitno;
            intime = _intime;
            outtime = _outtime;
        }
    }
}