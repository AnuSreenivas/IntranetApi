using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class sampledespdtlviewClass
    {
       // sampReqNo	sampReqDesc	CustName	sampReqStatus	sampReqDate	sampReqDispDate	noOfSampl	samplReqQty	sampReqType	SR_CreatedBy
//SR/22-23/10790	Cheese Seasoning	Ghodawat Consumer Limited	Feedback Received	2022-08-29	2022-09-17	1	100.00000000	Sample	R10256
  public string samreqno { get; set; }

   public string samreqdesc { get; set; }
   public string custname { get; set; }
   public string samstatus { get; set; }

   public DateTime samreqdate { get; set; }
   public DateTime samdisdate { get; set; }
   public double  nosamples { get; set; }

   public double samreqqty { get; set; }
   public string samtype { get; set; }
   public string createcode { get; set; }
   public string assignedto { get; set; }
   public string createdby { get; set; }
   public string feedbackreason { get; set; }
   public sampledespdtlviewClass(string _samreqno, string _samreqdesc, string _custname, string _samstatus, DateTime _samreqdate, DateTime _samdisdate, double _nosamples, double _samreqqty, string _samtype, string _createcode, string _assignedto, string _createdby, string _feedbackreason)
        {
            samreqno = _samreqno;
            samreqdesc = _samreqdesc;
            samreqdate = _samreqdate;
            custname = _custname;
            samstatus = _samstatus;
            samdisdate = _samdisdate;
       nosamples = _nosamples;
       samreqqty = _samreqqty;
       samtype = _samtype;
       createcode = _createcode;
       assignedto = _assignedto;
       createdby = _createdby;
       feedbackreason = _feedbackreason;
        }
    }
}