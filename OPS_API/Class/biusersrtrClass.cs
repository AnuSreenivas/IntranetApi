using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biusersrtrClass
    {
    public string username { get; set; }
  public string biuser { get; set; }

  public biusersrtrClass(string user_name, string bi_user)
        {
            username = user_name;
            biuser = bi_user;
          
        }
    }
}