using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class poinfoClass
    {
        public string prdord { get; set; }

   public string itemcode { get; set; }
   public string sono { get; set; }
   public string customername { get; set; }

   public string packtype { get; set; }
   public string poremarks1 { get; set; }

   public string poremarks2 { get; set; }
   public string remarks { get; set; }
   public string custnotes { get; set; }
   public string qcremarks { get; set; }
   public DateTime sysdate { get; set; }

   public poinfoClass(string prd_ord, string item_code, string so_no, string customer_name, string pack_type, string _poremarks1, string _poremarks2, string _remarks, string cust_notes, string qc_remarks, DateTime sys_date)
        {
            prdord = prd_ord;
       itemcode = item_code;
       packtype = pack_type;
       customername = customer_name;
       poremarks1 = _poremarks1;
       poremarks2 = _poremarks2;
       sono = so_no;
       remarks = _remarks;
       custnotes = cust_notes;
       qcremarks = qc_remarks;
       sysdate = sys_date;
        }
    }
}