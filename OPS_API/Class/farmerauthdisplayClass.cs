using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class farmerauthdisplayClass
    {
        public string areacode { get; set; }
        public string farmername { get; set; }
        public string fathersname { get; set; }
        public string gender { get; set; }
        public DateTime dob { get; set; }
        public string aadharno { get; set; }
        public string country { get; set; }
        public string farmerstate { get; set; }
        public string district { get; set; }
        public string taluk { get; set; }
        public string village { get; set; }
        public string education { get; set; }
        public string marital { get; set; }
        public string mobileno { get; set; }
        public string accounttype { get; set; }
        public string accountno { get; set; }
        public string bankname { get; set; }
        public string branchname { get; set; }
        public string ifsccode { get; set; }

        public farmerauthdisplayClass(string area_code, string farmer_name, string fathers_name, string _gender, DateTime _dob, string _aadharno, string _country, string _farmerstate, string _district, string _taluk, string _village, string _education, string _marital, string _mobileno, string _accounttype, string _accountno, string _bankname, string _branchname, string _ifsccode )
        {
            areacode = area_code;
            farmername = farmer_name;
            fathersname = fathers_name;
            gender = _gender;
            dob = _dob;
            aadharno = _aadharno;
            country = _country;
            farmerstate = _farmerstate;
            district = _district;
            taluk = _taluk;
            village = _village;
            education = _education;
            marital = _marital;
            mobileno = _mobileno;
            accounttype = _accounttype;
            accountno = _accountno;
            bankname = _bankname;
            branchname = _branchname;
            ifsccode = _ifsccode;

        }
    }
}