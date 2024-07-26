using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bilabcntresClass
    {
    
        public string alcode { get; set; }

        public int samplecnt { get; set; }
        public int sampleres { get; set; }
        public double percentcompleted { get; set; }
        public bilabcntresClass(string al_code, int sample_cnt, int sample_res, double percent_completed)
        {
            alcode = al_code;
            samplecnt = sample_cnt;
            sampleres = sample_res;
            percentcompleted = percent_completed;

        }
    }
}