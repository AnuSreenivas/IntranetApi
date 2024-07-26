using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class csinsertreturn
    {
        public int Id { get; set; }
        public int Error { get; set; }
        public csinsertreturn(int id, int error)
        {
            Id = id;
            Error = error;
        }
    }
}