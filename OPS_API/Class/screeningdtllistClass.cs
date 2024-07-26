using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class screeningdtllistClass
    {

    public string screened_Id { get; set; }
        public int postion_id { get; set; }
        public string postion_name { get; set; }
        public int refernceId { get; set; }
        public string applicant_name { get; set; }
         public string dept_code { get; set; }
         public string dept_name { get; set; }




         public screeningdtllistClass(string _screened_Id, int _postion_id, string _postion_name, int _refernceId, string _applicant_name, string _dept_code, string _dept_name)
        {
            screened_Id = _screened_Id;
           postion_id = _postion_id;
            postion_name = _postion_name;
           refernceId = _refernceId;
           applicant_name = _applicant_name;
           dept_code = _dept_code;
           dept_name = _dept_name;
         
        }


    }
}