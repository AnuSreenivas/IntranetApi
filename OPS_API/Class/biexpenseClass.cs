using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biexpenseClass
    {
        public string expense_head { get; set; }
        public string account_no { get; set; }


        public biexpenseClass(string expensehead, string accountno)
        {
            expense_head = expensehead;
            account_no = accountno;
         
        }
    }
}