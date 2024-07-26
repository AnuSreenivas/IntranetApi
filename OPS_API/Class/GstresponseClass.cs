using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class GstresponseClass
    {
    public string responsestring { get; set; }
    public string responseirn { get; set; }
    public string qrcode { get; set; }
    public string ackno { get; set; }
    public DateTime ackdate { get; set; }
    public GstresponseClass(string response_string, string response_irn, string qr_code, string ack_no, DateTime ack_date)
        {

            responsestring = response_string;
            responseirn = response_irn;
            qrcode = qr_code;
            ackno = ack_no;
            ackdate = ack_date;
        }
    }
}