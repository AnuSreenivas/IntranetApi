using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biareausermapClass
    {
    
        public string areacode { get; set; }
        public string samuser { get; set; }
       
        public biareausermapClass( string area_code, string sam_user)
        {
            
            areacode = area_code;
            samuser = sam_user;
           
        }
    }
}