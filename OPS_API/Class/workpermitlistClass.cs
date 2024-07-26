using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class workpermitlistClass
    {
        public string ref_no { get; set; }
        public string vendor_name { get; set; }
        public string vendor_address { get; set; }
        public string Work_description { get; set; }
        public string esi_type { get; set; }
        public double noofdays { get; set; }
        public double noofpersons { get; set; }
        public double noofhours { get; set; }
        public DateTime workstartdate { get; set; }
        public string workstarttime { get; set; }
        public DateTime workfinishdate { get; set; }
        public string workfinishtime { get; set; }
        public string safetyprecaution { get; set; }
        public string connectedsystems { get; set; }
        public string safetybelts { get; set; }
        public string deptinformed { get; set; }
        public string empname { get; set; }
        public DateTime wpdate { get; set; }

        public workpermitlistClass(string _ref_no, string _vendor_name, string _vendor_address, string _Work_description, string _esi_type, double _noofdays, double _noofpersons, double _noofhours, DateTime _workstartdate, string _workstarttime, DateTime _workfinishdate, string _workfinishtime, string _safetyprecaution, string _connectedsystems, string _safetybelts, string _deptinformed, string _empname, DateTime _wpdate)
        {
            ref_no = _ref_no;
            vendor_name = _vendor_name;
            Work_description = _Work_description;
            vendor_address = _vendor_address;
            esi_type = _esi_type;
            noofdays = _noofdays;
            noofpersons = _noofpersons;
            noofhours = _noofhours;
            workstartdate = _workstartdate;
            workstarttime = _workstarttime;
            workfinishdate = _workfinishdate;
            workfinishtime = _workfinishtime;
            safetyprecaution = _safetyprecaution;
            connectedsystems = _connectedsystems;
            safetybelts = _safetybelts;
            deptinformed = _deptinformed;
            empname = _empname;
            wpdate = _wpdate;
        }
    }
}