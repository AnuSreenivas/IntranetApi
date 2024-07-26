using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class candidateprofilelistClass
    {
       
     public string position_name { get; set; }
        public string position_level { get; set; }
        public string dept_code { get; set; }
        public string dept_name { get; set; }
        public string job_description { get; set; }
        public DateTime created_date { get; set; }
        public string pos_remarks { get; set; }
        public int positionid { get; set; }

     public candidateprofilelistClass(string _position_name,string _position_level,string _dept_code,string _dept_name,string _job_description, DateTime _created_date,string  _pos_remarks,int _positionid)
        {
            position_name = _position_name;
         position_level = _position_level;
         dept_code = _dept_code;
         dept_name = _dept_name;
         job_description = _job_description;
         created_date = _created_date;
         pos_remarks = _pos_remarks;
         positionid = _positionid;
        }


    }
}