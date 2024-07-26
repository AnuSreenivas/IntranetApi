using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class cspagesclass
    {
    public int userid { get; set; }
        public int pageid { get; set; }
        public cspagesclass(int uid, int pid)
        {
            userid = uid;
            pageid = pid;

        }
    }
}