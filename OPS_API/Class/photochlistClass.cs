using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    //emp_code,emp_name,emp_department,photo_caption,photo_details
    public class photochlistClass
    {
        public string emp_code { get; set; }
        public string emp_name { get; set; }

        public string emp_department { get; set; }
        public string photo_caption { get; set; }
        public string photo_details { get; set; }
        public string photo_description { get; set; }


        public photochlistClass(string _emp_code, string _emp_name, string _emp_department, string _photo_caption, string _photo_details, string _photo_description)
        {

            emp_code = _emp_code;
            emp_name = _emp_name;
            emp_department = _emp_department;
            photo_caption = _photo_caption;
            photo_details = _photo_details;
            photo_description = _photo_description;
        }
    }
}