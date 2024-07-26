using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class G4GFamRollHdrClass
    {
        public string areacode { get; set; }
        public string areaname { get; set; }
        public string farmercode { get; set; }
        public string farmername { get; set; }
        public string interviewer { get; set; }

        public string ismanager { get; set; }
        public string ismobileaccess { get; set; }
      
        
         public double contactno { get; set; }
         public string emailid { get; set; }
         public string g4gcomments { get; set; }
         public string gender { get; set; }
         public string dob { get; set; }
         public string education { get; set; }
         public string marital { get; set; }
         public int noofChildren { get; set; }
        public int childrenToSchool { get; set; }

        public string isMemberInvolved { get;  set;}
        public string userid { get; set; }
        public string manuf { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string uuid { get; set; }

        public List<G4GFamRollDtlClass> G4GFamRollDtlClassList { get; set; }
    }
}