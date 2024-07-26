using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class agreementrequestinsClass
    {

        public string modeOfRequest { get; set; }
        public string typeOfRequest { get; set; }
        public string noOfParties { get; set; }
        public string partiesNames { get; set; }
        public DateTime valdityFrom { get; set; }
        public DateTime valdityTo { get; set; }
        public DateTime exectionDate { get; set; }
        public string place { get; set; }
        public string stampPaper { get; set; }
        public string stampPaperState { get; set; }
        public string stampPaperValue { get; set; }
        public string otherPapers { get; set; }
        public string requesterName { get; set; }
        public string RequesterEmpcode { get; set; }
        public string approverName { get; set; }
        public string approverEmpcode { get; set; }
        public string synopsis { get; set; }
        public string noticePeriod { get; set; }

        public string identificationName { get; set; }
        public string identificationNumber { get; set; }
        public string agreementDocNew { get; set; }
        public string agreementDocDraft { get; set; }
        public string statusOfRequest { get; set; }

        public List<Particulars> particulars { get; set; }

    }
}