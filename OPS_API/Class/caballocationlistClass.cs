using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class caballocationlistClass
    {
        
    public string allocationID { get; set; }
   public string approvalID { get; set; }
   public string requestID { get; set; }
   public string driver_name { get; set; }
   public string driver_phone { get; set; }
   public string vehicle_no { get; set; }
   public string requester_empCode { get; set; }
   public string vehicle_type { get; set; }
        public DateTime vehicle_allocated_date { get; set; }
        public string departmentName { get; set; }
        public int distance { get; set; }
        public string admin_remarks { get; set; }
        public string allocation_Status { get; set; }

        public string reportingOfficerCode { get; set; }
        public string reportingOfficerName { get; set; }
        public string requesterEmpName { get; set; }
        public string travelPurpose { get; set; }
        public string clubbedRequestId { get; set; }
        public string allocationType { get; set; }
        public string driverType { get; set; }
        public string companyName { get; set; }
        public float kmRate { get; set; }
        public float totalFare { get; set; }

        public caballocationlistClass(string _allocationID, string _approvalID, string _requestID, string _driver_name, string _driver_phone, string _vehicle_no, string _requester_empCode, string _vehicle_type,DateTime _vehicle_allocated_date,string _departmentName,int _distance,string _admin_remarks,string _allocation_Status,string _reportingOfficerCode,string _reportingOfficerName, string _requesterEmpName,string _travelPurpose,string _clubbedRequestId,string _allocationType,string _driverType,string _companyName,float _kmRate,float _totalFare)
        {
           allocationID = _allocationID;     
           approvalID = _approvalID;
           requestID = _requestID;
           driver_name = _driver_name;
           driver_phone = _driver_phone;
           vehicle_no = _vehicle_no;
           requester_empCode = _requester_empCode;
           vehicle_type = _vehicle_type;
       vehicle_allocated_date = _vehicle_allocated_date;
       departmentName = _departmentName;
       distance = _distance;
       admin_remarks = _admin_remarks;
       allocation_Status = _allocation_Status;

            reportingOfficerCode = _reportingOfficerCode;
            reportingOfficerName = _reportingOfficerName;
            requesterEmpName = _requesterEmpName;
            travelPurpose = _travelPurpose;
            clubbedRequestId = _clubbedRequestId;
            allocationType = _allocationType;
            driverType = _driverType;
            companyName = _companyName;
            kmRate = _kmRate;
            totalFare = _totalFare;


            }
    }
}