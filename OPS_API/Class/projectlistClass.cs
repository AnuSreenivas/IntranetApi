using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class projectlistClass
    {
     public string projectname { get; set; }
        public string projectcode { get; set; }


        public projectlistClass(string project_name, string project_code)
        {
            projectname = project_name;
            projectcode = project_code;
         
        }
    }
}