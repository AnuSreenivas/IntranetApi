using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bibillssubmittedrtrClass
    {
      
  public string prno { get; set; }
  public DateTime submitteddate { get; set; }
  public string paymentset { get; set; }
  public double pbamt { get; set; }
  public double pbqty { get; set; }
  public string paymentstatus { get; set; }
  public DateTime paymentdate { get; set; }
  public double paidamt { get; set; }
  public bibillssubmittedrtrClass(string pr_no, DateTime submitted_date, string payment_set, double pb_amt, double pb_qty, string payment_status, DateTime payment_date, double paid_amt)
        {
            prno = pr_no;     
            submitteddate = submitted_date;
            paymentset = payment_set;
            pbamt = pb_amt;
            pbqty = pb_qty;
            paymentstatus = payment_status;
            paymentdate = payment_date;
            paidamt = paid_amt;

        }
    }
}