
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
    public class ImageGallery
    {

        public int Id { get; set; }
        
        public string Caption { get; set; }
        //public string FileDetails { get; set; }
       // public imageData images { get; set; }
        public List< Images> Images { get; set; }


    }
}