using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class agreementworkstatusrtrClass
    {
        public string workId { get; set; }
        public string requestId { get; set; }
        public string approvalId { get; set; }
        public string workStatus { get; set; }
        public DateTime workStartDate { get; set; }
        public DateTime workCompletedDate { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public DateTime ExectuionDate { get; set; }
        public string remarksFromlegal { get; set; }
        public string finalDocument { get; set; }

        public agreementworkstatusrtrClass(string _workId, string _requestId,string _approvalId,string _workStatus,DateTime _workStartDate,DateTime _workCompletedDate,DateTime _ValidFrom,DateTime _ValidTo,DateTime _ExectuionDate,string _remarksFromlegal,string _finalDocument)
        {
            workId = _workId;
            requestId = _requestId;
            approvalId = _approvalId;
            workStatus = _workStatus;
            workStartDate = _workStartDate;
            workCompletedDate = _workCompletedDate;
            ValidFrom = _ValidFrom;
            ValidTo = _ValidTo;
            ExectuionDate = _ExectuionDate;
            remarksFromlegal = _remarksFromlegal;
            finalDocument = _finalDocument;
          
        }


    }
}