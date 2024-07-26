using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biprareawisemoleculeClass
    {
        public string areacode { get; set; }
        public string nfc { get; set; }
        public string molecule { get; set; }
        public int samcnt { get; set; }


        public biprareawisemoleculeClass(string area_code, string n_fc, string m_olecule, int sam_cnt)
        {
            areacode = area_code;
            nfc = n_fc;
            molecule = m_olecule;
            samcnt = sam_cnt;
                   
        }
    }
}