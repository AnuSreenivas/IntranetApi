using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class itassetslistClass
    {
   public string Refno { get; set; }
       public string sys_no { get; set; }
        public string reftype { get; set; }
        public int serial_no { get; set; }
        public string os { get; set; }
        public string asset_location { get; set; }
        public string warranty { get; set; }
        public string make { get; set; }
        public string ip_address { get; set; }
        public string system_name { get; set; }
        public string model_no { get; set; }
        public string department { get; set; }
        public string asset_user { get; set; }
        public string asset_sr_no { get; set; }
        public string machine { get; set; }
     

        public itassetslistClass(string _Refno, string _sys_no, string _reftype, int _serial_no, string _os, string  _asset_location,string _warranty, string _make, string _ip_address, string _system_name, string _model_no, string _department, string _asset_user, string _asset_sr_no, string _machine)
        {
            Refno = _Refno;
            sys_no = _sys_no;
            reftype = _reftype;
            serial_no = _serial_no;
            os = _os;
            asset_location = _asset_location;
            warranty = _warranty;
            make = _make;
            ip_address = _ip_address;
            system_name = _system_name;
            model_no = _model_no;
            department = _department;
            asset_user = _asset_user;
            asset_sr_no = _asset_sr_no;
            machine = _machine;
            
        }


    }
}