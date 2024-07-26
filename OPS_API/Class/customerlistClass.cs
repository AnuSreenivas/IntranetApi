using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class customerlistClass
    {
      public string companycode { get; set; }

        public string companyname { get; set; }
        public string address { get; set; }
        public string pincode { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public string phone { get; set; }

        public string personname { get; set; }
        public customerlistClass(string _companycode, string _companyname, string _address, string _pincode, string _city, string _country, string _phone, string _personname)
        {
            companycode = _companycode;
            companyname = _companyname;
            address = _address;
            pincode = _pincode;
            city = _city;
            country = _country;
            phone = _phone;
            personname = _personname;
        }
    }
}