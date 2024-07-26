using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class key_listClass
    {
        public string key_number { get; set; }
        public string keyname { get; set; }
        public string key_dept { get; set; }
        
        public string key_type { get; set; }
        public string key_desc { get; set; }
        public string key_in_charge { get; set; }
        public string keyInChargeDept { get; set; }
        public int no_of_keys { get; set; }
        public key_listClass(string _key_number, string _keyname, string _key_dept, string _key_type, string _key_desc, string _key_in_charge, string _keyInChargeDept, int _no_of_keys)
        {
            key_number = _key_number;
            keyname = _keyname;
            key_dept = _key_dept;
            
            key_type = _key_type;
            key_desc = _key_desc;
            key_in_charge = _key_in_charge;
            keyInChargeDept = _keyInChargeDept;
            no_of_keys = _no_of_keys;
        }

    }
}