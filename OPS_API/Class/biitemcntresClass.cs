using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class biitemcntresClass
    {
    public string alcode { get; set; }

        public int samplecnt { get; set; }
        public int sampleres { get; set; }

        public biitemcntresClass(string al_code, int sample_cnt, int sample_res)
        {
            alcode = al_code;
            samplecnt = sample_cnt;
            sampleres = sample_res;
           

        }
    }
}