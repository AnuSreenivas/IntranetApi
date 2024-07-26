using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{	
    public class agreementworkdtlsupdClass
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
       
    }
}