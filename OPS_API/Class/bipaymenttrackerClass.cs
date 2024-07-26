using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bipaymenttrackerClass
    {
       public string lab { get; set; }
        public string lotno { get; set; }
        public DateTime samplerec { get; set; }
        public DateTime sampledate { get; set; }
        public DateTime pbdate { get; set; }
        public DateTime resultdate { get; set; }    
        public string pbno { get; set; }
        public string grno { get; set; }
        public DateTime grdate { get; set; }
        public DateTime movedate { get; set; }
        public string payno { get; set; }
        public DateTime paydate { get; set; }
        public string voucherno { get; set; }
        public DateTime voucherdate { get; set; }
        public string bankcode { get; set; }
        public DateTime checkdate { get; set; }
        public string remitname { get; set; }
        public DateTime paymentdate { get; set; }
        public string status { get; set; }
        public string farmer { get; set; }
        public string areacode { get; set; }
        public double nobags { get; set; }
        public double pbqty { get; set; }
        public double pbrate { get; set; }
        public double pbamount { get; set; }
        public string prno { get; set; }
        public DateTime submitdate { get; set; }
       
        public bipaymenttrackerClass(string l_ab, string lot_no, DateTime sample_rec, DateTime sample_date, DateTime pb_date, DateTime result_date, string pb_no, string gr_no, DateTime gr_date, DateTime move_date, string pay_no, DateTime pay_date, string voucher_no, DateTime voucher_date, string bank_code, DateTime check_date, string remit_name, DateTime payment_date, string payment_paid, string farmer_name, string area_code, double no_bags, double pb_qty, double pb_rate, double pb_amount, string pr_no, DateTime submit_date)
        {
            lab = l_ab;
            lotno = lot_no;
            samplerec = sample_rec;
            sampledate = sample_date;
            pbdate = pb_date;
            resultdate = result_date;
            pbno = pb_no;
            grno = gr_no;
            grdate = gr_date;
            movedate = move_date;
            payno = pay_no;
            paydate = pay_date;
            voucherno = voucher_no;
            voucherdate = voucher_date;
            bankcode = bank_code;
            checkdate = check_date;
            remitname = remit_name;
            paymentdate = payment_date;
            status = payment_paid;
            farmer = farmer_name;
            areacode = area_code;
            nobags = no_bags;
            pbqty = pb_qty;
            pbrate = pb_rate;
            pbamount = pb_amount;
            prno = pr_no;
            submitdate = submit_date;
        }
    }
}