using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class vehicleoutrtrClass
    {
        public string vehicleno { get; set; }
        public string vehicletype { get; set; }
        public DateTime vehiclein { get; set; }
        public string drivername { get; set; }
        public string hostcompanycode { get; set; }
        public string refno { get; set; }

        public string hostcompany { get; set; }
        public double emptyweight { get; set; }
        public double loadedweight { get; set; }
        public string refdocno { get; set; }
        public string gatepassno { get; set; }

        public double gatepasswt { get; set; }
        public double refnowt { get; set; }
        
        public string gatepassitems { get; set; }
        public string materialtype { get; set; }
        public string remarks { get; set; }
        public DateTime loadtime { get; set; }
        public DateTime emptytime { get; set; }
        public vehicleoutrtrClass(string _vehicleno, string _vehicletype, DateTime _vehiclein, string _drivername, string _hostcompanycode, string _refno, string _hostcompany, double _emptyweight, double _loadedweight, string _refdocno, string _gatepassno, double _gatepasswt, double _refnowt, string _gatepassitems, string _materialtype, string _remarks, DateTime _loadtime, DateTime _emptytime)//, string _companycode)
        {
            vehicleno = _vehicleno;
            vehicletype = _vehicletype;
            vehiclein = _vehiclein;
            drivername = _drivername;
            hostcompanycode = _hostcompanycode;
            refno = _refno;
            hostcompany = _hostcompany;
            emptyweight = _emptyweight;
            loadedweight = _loadedweight;
            refdocno = _refdocno;
            gatepassno = _gatepassno;
            gatepasswt = _gatepasswt;
            refnowt = _refnowt;
            gatepassitems = _gatepassitems;
            materialtype = _materialtype;
            remarks = _remarks;
            loadtime = _loadtime;
            emptytime = _emptytime;
           // companycode = _companycode;
        }
    }
}