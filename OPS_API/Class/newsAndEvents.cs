
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OPS_API.Class
{
    public class newsAndEvents
    {
        public string title { get; set; }
        public int Id { get; set; }
        public string subHeading { get; set; }
        public string content { get; set;}
        public imageData images { get; set; }
        public string image1 { get; set; }
        public string image2 { get; set; }
        public string image3 { get; set; }
        public string image4 { get; set; }
        public string image5 { get; set; }
        public string empcode { get; set; }

        public newsAndEvents(int _Id,string _title,string _subheading,string _content,string _image1,string _image2,string _image3,string _image4,string _image5,string _empcode)
        {
            Id = _Id;
            title = _title;
            subHeading = _subheading;
            content = _content;
            image1 = _image1;
            image2 = _image2;
            image3 = _image3;
            image4 = _image4;
            image5 = _image5;
            empcode = _empcode;
        }
    }
}