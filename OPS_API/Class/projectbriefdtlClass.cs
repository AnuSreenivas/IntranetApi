using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class projectbriefdtlClass
    {
    public string projectcode { get; set; }
    public string projectdesc { get; set; }
    public string itemcode { get; set; }
    public string itemdesc { get; set; }

    public string customer { get; set; }
    public string status { get; set; }
    public string productcategory { get; set; }

    public DateTime targetdate { get; set; }
    public string basetype { get; set; }
        public string techname { get; set; }
    public projectbriefdtlClass(string _projectcode, string _projectdesc, string _itemcode, string _itemdesc, string _customer, string _status, string _productcategory,DateTime _targetdate,string _basetype, string _techname)
        {
            projectcode = _projectcode;
            projectdesc = _projectdesc;
            itemcode = _itemcode;
            itemdesc = _itemdesc;
            customer = _customer;
            status = _status;
            productcategory = _productcategory;
            targetdate = _targetdate;
            basetype = _basetype;
            techname = _techname;
        }
    }
}