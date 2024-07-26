using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class cabrequesthdrClass
    {
        public string requester_empCode { get; set; }
        public string requester_empName { get; set; }
        public string pickup_place { get; set; }
        public string destination { get; set; }
        public string travel_purpose { get; set; }
        public DateTime pickup_date { get; set; }
        public string pickup_time { get; set; }
        public string no_of_days { get; set; }
        public DateTime return_date { get; set; }
        public string ApproverempCode { get; set; }
        public string ApproverName { get; set; }
        public string departmentname { get; set; }
        public int no_of_passengers { get; set; }
        public string passengers_name { get; set; }
        public string remarks { get; set; }
        public string Cab_req_Status { get; set; }
     
    }
}