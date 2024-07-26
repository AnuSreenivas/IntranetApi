using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprmoleculefailcntClass
    {
        public string molecule { get; set; }
        public string nfc { get; set; }
       
        public int samcnt { get; set; }


        public biprmoleculefailcntClass(  string m_olecule,string n_fc, int sam_cnt)
        {
         
            nfc = n_fc;
            molecule = m_olecule;
            samcnt = sam_cnt;
                   
        }
    }
}