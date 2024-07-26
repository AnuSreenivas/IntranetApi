using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class cabrequestapprovallistClass
    {
   public string approvalID { get; set; }
   public string requestID { get; set; }
   public string requester_empCode { get; set; }
   public string departmentName { get; set; }
   public string reporting_officerCode { get; set; }
   public string remarks { get; set; }
   public DateTime approval_date { get; set; }
   public string approval_Status { get; set; }
   public cabrequestapprovallistClass(string _approvalID, string _requestID, string _requester_empCode, string _departmentName, string _reporting_officerCode, string _remarks,DateTime _approval_date,string _approval_Status)
        {
           approvalID = _approvalID;     
           requestID = _requestID;
           requester_empCode = _requester_empCode;
           departmentName = _departmentName;
           reporting_officerCode = _reporting_officerCode;
           remarks = _remarks;
           approval_date = _approval_date;
           approval_Status = _approval_Status;
            }
    }
}