using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class agreementrequestrtrClass
    {
        public string requestid { get; set; }
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
        public DateTime sysdate { get; set; }

        public agreementrequestrtrClass(string _requestid, string _modeOfRequest, string _typeOfRequest, string _noOfParties, string _partiesNames, DateTime _valdityFrom, DateTime _valdityTo, DateTime _exectionDate, string _place, string _stampPaper, string _stampPaperState, string _stampPaperValue, string _otherPapers, string _requesterName, string _RequesterEmpcode, string _approverName, string _approverEmpcode, string _synopsis, string _noticePeriod, string _identificationName, string _identificationNumber, string _agreementDocNew, string _agreementDocDraft, string _statusOfRequest, DateTime _sysdate)
        {
            requestid = _requestid;
            modeOfRequest = _modeOfRequest;
            typeOfRequest = _typeOfRequest;
            noOfParties = _noOfParties;
            partiesNames = _partiesNames;
            valdityFrom = _valdityFrom;
            valdityTo = _valdityTo;
            exectionDate = _exectionDate;
            place = _place;
            stampPaper = _stampPaper;
            stampPaperState = _stampPaperState;
            stampPaperValue = _stampPaperValue;
            otherPapers = _otherPapers;
            requesterName = _requesterName;
            RequesterEmpcode = _RequesterEmpcode;
            approverName = _approverName;
            approverEmpcode = _approverEmpcode;
            synopsis = _synopsis;
            noticePeriod = _noticePeriod;
            identificationName = _identificationName;
            identificationNumber = _identificationNumber;
            agreementDocNew = _agreementDocNew;
            agreementDocDraft = _agreementDocDraft;
            statusOfRequest = _statusOfRequest;
            sysdate = _sysdate;
        }


    }
}