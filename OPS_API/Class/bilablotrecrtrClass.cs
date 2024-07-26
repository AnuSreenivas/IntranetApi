using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bilablotrecrtrClass
    {
        public string lab { get; set; }
        public string lotno { get; set; }
        public DateTime samplerec { get; set; }
        public DateTime sampledate { get; set; }
        public DateTime resultdate { get; set; }
        public DateTime pbdate { get; set; }
        public string samstatus { get; set; }
        public int samtat { get; set; }
        public int pbtat { get; set; }
        public bilablotrecrtrClass(string l_ab, string lot_no, DateTime sample_rec, DateTime sample_date,DateTime result_date, DateTime pb_date, string sam_status, int sam_tat, int pb_tat)
        {
            lab = l_ab;
            lotno = lot_no;
            samplerec = sample_rec;
            sampledate = sample_date;
            resultdate = result_date;
            pbdate = pb_date;
            samstatus = sam_status;
            samtat = sam_tat;
            pbtat = pb_tat;
        }
    }
}