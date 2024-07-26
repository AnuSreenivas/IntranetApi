using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biblbillssubmittedrtrClass
    {
     
  public string prno { get; set; }
  public DateTime submitteddate { get; set; }
  public string paymentset { get; set; }
  public double pbamt { get; set; }
  public double pbqty { get; set; }
  public string paymentstatus { get; set; }
  public DateTime paymentdate { get; set; }
  public double paidamt { get; set; }
  public string vendorcode { get; set; }
  public string vendorname { get; set; }
  public DateTime moveddate { get; set; }
  public biblbillssubmittedrtrClass(string pr_no, DateTime submitted_date, string payment_set, double pb_amt, double pb_qty, string payment_status, DateTime payment_date, double paid_amt, string vendor_code, string vendor_name, DateTime moved_date)
        {
            prno = pr_no;     
            submitteddate = submitted_date;
            paymentset = payment_set;
            pbamt = pb_amt;
            pbqty = pb_qty;
            paymentstatus = payment_status;
            paymentdate = payment_date;
            paidamt = paid_amt;
            vendorcode = vendor_code;
            vendorname  = vendor_name;
            moveddate = moved_date;

        }
    }
}