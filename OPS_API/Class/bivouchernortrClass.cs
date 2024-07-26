using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bivouchernortrClass
    {
        public string voucherno { get; set; }
        public DateTime voucherdate { get; set; }
        public string toperson { get; set; }
        public string projectname { get; set; }
        public double totalamt { get; set; }
        public string areacode { get; set; }
        public string empcode { get; set; }
       
        public bivouchernortrClass(string voucher_no, DateTime voucher_date,  string to_person, string project_name,double total_amt, string area_code, string emp_code)
        {
            voucherno = voucher_no;
            voucherdate = voucher_date;
            totalamt = total_amt;
            toperson = to_person;
            projectname = project_name;
            areacode = area_code;
            empcode = emp_code;        
        }
    }
}