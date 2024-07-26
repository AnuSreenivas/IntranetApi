using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class agreementapprovallistClass
    {
 
      public string approvalsId { get; set; }
        public string requestId { get; set; }
        public string approverEmpcode { get; set; }
        public string approvalStatus { get; set; }
        public DateTime approvalDate { get; set; }
        public string remarks { get; set; }



      public agreementapprovallistClass(string _approvalsId,string _requestId,string _approverEmpcode,string _approvalStatus,DateTime _approvalDate,string _remarks)
        {
            approvalsId = _approvalsId;
           requestId = _requestId;
          approverEmpcode = _approverEmpcode;
          approvalStatus = _approvalStatus;
          approvalDate = _approvalDate;
          remarks = _remarks;
        }


    }
}