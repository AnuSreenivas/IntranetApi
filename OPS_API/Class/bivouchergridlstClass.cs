using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bivouchergridlstClass
    {
         public string expenditure_head { get; set; }

        public string account_no { get; set; }
        public string payment_description { get; set; }
        public double  amount { get; set; }


        public bivouchergridlstClass(string expenditurehead,string paymentdescription, double payamount, string accountno )
        {
            expenditure_head = expenditurehead;
            account_no = accountno;
            payment_description = paymentdescription;
            amount = payamount;
                
        }
    }
}