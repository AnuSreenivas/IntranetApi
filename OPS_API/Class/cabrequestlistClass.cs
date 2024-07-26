using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class cabrequestlistClass
    {
       public string requestid { get; set; }

   public string requester_empCode { get; set; }

   public string requester_empName { get; set; }
   public string pickup_place { get; set; }
   public string destination { get; set; }
    public string travel_purpose { get; set; }
    public DateTime pickup_date { get; set; }
    public string pickup_time { get; set; }
    public int no_of_days { get; set; }
    public DateTime return_date { get; set; }
    public string ApproverempCode { get; set; }
    public string ApproverName { get; set; }
    public string departmentname { get; set; }
    public int no_of_passengers { get; set; }

        public string passengers_name { get; set; }
        public string remarks { get; set; }
        public string Cab_req_Status { get; set; }
        public DateTime sysdate { get; set; }
   public cabrequestlistClass(string _requestid, string _requester_empCode, string _requester_empName, string _pickup_place, string _destination, string _travel_purpose,DateTime _pickup_date, string  _pickup_time,int _no_of_days,DateTime _return_date,string _ApproverempCode,string _ApproverName,string _departmentname,int _no_of_passengers,string _passengers_name,string _remarks,string _Cab_req_Status,DateTime _sysdate)
        {
       requestid = _requestid;     
       requester_empCode = _requester_empCode;
       requester_empName = _requester_empName;
       pickup_place = _pickup_place;
       destination = _destination;
       travel_purpose = _travel_purpose;
       pickup_date = _pickup_date;
   pickup_time = _pickup_time;
       no_of_days = _no_of_days;
       return_date = _return_date;
       ApproverempCode = _ApproverempCode;
       ApproverName = _ApproverName;
       departmentname = _departmentname;
       no_of_passengers = _no_of_passengers;
       passengers_name = _passengers_name;
       remarks = _remarks;
       Cab_req_Status = _Cab_req_Status;
       sysdate = _sysdate;
        }



       

    }
}