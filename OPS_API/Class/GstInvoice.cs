using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public partial class GstInvoice
    {
        
    public string status{get;set;}
    public data data{get;set;}
    public List <error> error{get;set;}
    public string docno{get;set;}
    public string self_gstin{get;set;}
    public string document_type{get;set;}
    public string docdt{get;set;}
    public string info{get;set;}
}

public partial class data{
public irn irn{get;set;}
public ewb ewb{get;set;}
}

public partial  class irn{
    public string status{get;set;}
    public irndata data{get;set;}
    public List <error> error{get;set;}
}
public partial  class irndata{
    public string irn{get;set;}
    public string status{get;set;}
    public string gen_status{get;set;}
    public string document_type{get;set;}
    public string signed_qrcode{get;set;}
    public string signed_invoice{get;set;}
    public string ack_dt{get;set;}
    public string ack_no{get;set;}
    }
public partial class ewb{
    public string status{get;set;}
    public ewbdata data{get;set;}
   public List <error> error{get;set;}
}
public partial class ewbdata{
    public string eway_bill_no{get;set;}
    public string eway_bill_date{get;set;}
    }
public partial class error{
    public string error_code{get;set;}
    public string error_desc{get;set;}
}

    }
