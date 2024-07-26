using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public partial class csuserClass
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string userpassword { get; set; }
        public List<int> rights { get; set; }

        public csuserClass(int id,string user_name, string password)
        {
            userid = id;
            username = user_name;
            userpassword = password;
        }
    }
}