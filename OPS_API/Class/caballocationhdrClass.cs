using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class caballocationhdrClass

    {
        public string approvalID { get; set; }
        public string requestID { get; set; }
        public string driver_name { get; set; }
        public string driver_phone { get; set; }
        public string vehicle_no { get; set; }
        public string requester_empCode { get; set; }
        public string vehicle_type { get; set; }
        public string departmentName { get; set; }
        public int distance { get; set; }
        public string admin_remarks { get; set; }
        public string allocation_Status { get; set; }
        public DateTime pickup_date { get; set; }
        public string pickup_time { get; set; }
        public string pickup_place { get; set; }
        public string destination { get; set; }
        public string no_of_passengers { get; set; }

         public string reportingOfficerCode { get; set; }
         public string reportingOfficerName { get; set; }
         public string requesterEmpName { get; set; }
         public string travelPurpose { get; set; }
        public string allocationType { get; set; }
        public string clubbedRequestId { get; set; }
        public string driverType { get; set; }
        public string companyName { get; set; }
        public float kmRate { get; set; }
        public float totalFare { get; set; }


    }
}