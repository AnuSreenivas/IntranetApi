using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bitoxinarearesultsClass
    {
         public string areacode { get; set; }
         public int total { get; set; }
         public int eu { get; set; }
         public int epa { get; set; }

         public int euepa { get; set; }
         public int aflarejected { get; set; }

         public int passpercent { get; set; }
         public bitoxinarearesultsClass(string area_code, int t_otal, int e_u, int e_pa, int eu_epa, int afla_rejected, int pass_percent)
        {
            total = t_otal;
            eu = e_u;
            epa = e_pa;

            euepa = eu_epa;
            aflarejected = afla_rejected;
            passpercent = pass_percent;
            areacode = area_code;
        }
    }
}