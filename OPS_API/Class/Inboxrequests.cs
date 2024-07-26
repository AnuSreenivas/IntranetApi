
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
 public class Inboxrequests
    {
        public string RequestName { get; set; }
        public DateTime sysdate { get; set; }
        public string requestID { get; set; }
        public string SupervisorApprovalStatus { get; set; }
        public string AdminApprovalStatus { get; set; }
        public Inboxrequests(string requstname,string reqid,DateTime sysd,string suprstatus,string admstatus)
        {
            RequestName = requstname;
            requestID = reqid;
            sysdate = sysd;
            SupervisorApprovalStatus = suprstatus;
            AdminApprovalStatus = admstatus;
        }
    }




}