using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class samdespcustClass
    {
   public string samreqno { get; set; }

   public double totalsam { get; set; }
   public double activesam { get; set; }
   public double despatchedsam { get; set; }

   public double feedbacksam { get; set; }
   public double assignsam { get; set; }
   public double inprogress { get; set; }

   public double approved { get; set; }
   public samdespcustClass(string _samreqno, double _totalsam, double _activesam, double _despatchedsam, double _feedbacksam, double _assignsam, double _inprogress, double _approved)
        {
            samreqno = _samreqno;
            totalsam = _totalsam;
            activesam = _activesam;
            despatchedsam = _despatchedsam;
            feedbacksam = _feedbacksam;
            assignsam = _assignsam;
            inprogress = _inprogress;
            approved = _approved;
        }
    }
}