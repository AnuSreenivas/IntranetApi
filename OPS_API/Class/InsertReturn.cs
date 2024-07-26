
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
    public class InsertReturn
    {
        public int Id { get; set; }
        public int Error { get; set; }
        public int Number { get; set; }
        public string Message { get; set; }
        public InsertReturn(int id, int error)
        {
            Id = id;
            Error = error;
        }
        public InsertReturn()
        {
            Id = 0;
            Error = 0;
            Number = 0;
            Message = "";
        }

    }
}