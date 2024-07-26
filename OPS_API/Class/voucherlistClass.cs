using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class voucherlistClass
    {
    public string voucherno { get; set; }
        public DateTime voucherdate { get; set; }
        public string expensehead { get; set; }
        public string accountno { get; set; }
        public double voucheramt { get; set; }
        public string toperson { get; set; }
        public string projectname { get; set; }

        public string areacode { get; set; }
        public string isconfirm { get; set; }
        public string paydesc { get; set; }

        public voucherlistClass(string voucher_no, DateTime voucher_date, string expense_head, string account_no, double voucher_amt, string to_person, string project_name, string area_code, string is_confirm, string pay_desc)
        {

            voucherno = voucher_no;
            voucherdate = voucher_date;
            expensehead = expense_head;
            accountno = account_no;
            voucheramt = voucher_amt;
            toperson = to_person;
            projectname = project_name;
            areacode = area_code;
            isconfirm = is_confirm;
            paydesc = pay_desc;
        }
    }
}