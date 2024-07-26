
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
   public class Gallery
    {
        public string FileDetails { get; set; }
        public int Id { get; set; }
        public string Caption { get; set; }

        public Gallery(int _Id,string _caption,string _filedetails)
        {
            Id = _Id;
            Caption = _caption;
            FileDetails = _filedetails;

        }
    }
}