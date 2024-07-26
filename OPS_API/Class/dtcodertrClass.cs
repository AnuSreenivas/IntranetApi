using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class dtcodertrClass
    {
      
  public string dtcode { get; set; }

  public string dtdesc { get; set; }

  public dtcodertrClass(string dt_code, string dt_desc)
        {
            dtcode = dt_code;
            dtdesc = dt_desc;
        
        }
    }
}