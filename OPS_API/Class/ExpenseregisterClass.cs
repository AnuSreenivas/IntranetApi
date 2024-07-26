using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class ExpenseregisterClass
    {
   public string slno { get; set; }
   public string accdesc { get; set; }
   public double debit { get; set; }
   public double credit { get; set; }
   public ExpenseregisterClass(string _slno, string _accdesc, double _debit, double _credit)
        {
            slno = _slno;
            accdesc = _accdesc;
            debit = _debit;
            credit = _credit;

        }
    }
}