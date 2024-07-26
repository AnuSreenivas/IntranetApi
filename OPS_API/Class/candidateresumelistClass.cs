using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class candidateresumelistClass
    {
 
    public int refernceId { get; set; }

   public string dept_code { get; set; }
        public string dept_name { get; set; }

   public string job_level { get; set; }
   public string applicant_name { get; set; }
   public string applicant_phone { get; set; }

   public string applicant_email { get; set; }
        public string applicant_location { get; set; }
   
        public string cv_source { get; set; }
        public string referred_employee_code { get; set; }
        public string referred_employee { get; set; }
        public string cv_doc { get; set; }
        public string cv_status { get; set; }
        public DateTime upload_date { get; set; }

    public string gender { get; set; }
        public int experience { get; set; }
        public string qualification { get; set; }
        public string remarks { get; set; }
        public string Position_name { get; set; }
        public string Position_id { get; set; }

        public string userid { get; set; }

        public candidateresumelistClass(int _refernceId, string _dept_code, string _dept_name, string _job_level, string _applicant_name, string _applicant_phone, string _applicant_email, string _applicant_location, string _cv_source, string _referred_employee_code, string _referred_employee, string _cv_doc, string _cv_status, DateTime _upload_date, string _gender, int _experience, string _qualification, string _remarks, string _Position_name, string _Position_id, string _userid)
        {
       refernceId = _refernceId;     
       dept_code = _dept_code;
       dept_name  = _dept_name;
       job_level = _job_level;

       applicant_name = _applicant_name;
       applicant_phone = _applicant_phone;
       applicant_email = _applicant_email;
       applicant_location = _applicant_location;
       cv_source = _cv_source;
       referred_employee_code = _referred_employee_code;
       referred_employee = _referred_employee;
       cv_doc = _cv_doc;
       cv_status = _cv_status;
       upload_date = _upload_date;
       gender = _gender;
       experience = _experience;
       qualification = _qualification;
       remarks = _remarks;
       Position_name = _Position_name;
       Position_id = _Position_id;
       userid = _userid;
        }
    }
}