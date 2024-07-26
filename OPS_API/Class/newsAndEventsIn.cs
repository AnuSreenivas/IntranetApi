
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Antlr.Runtime.Tree.TreeWizard;

namespace OPS_API.Class
{
    public class newsAndEventsIn
    {

        public string Id { get; set; }
        public string newsStatus { get; set; }
        public newsAndEventsIn(string _newsStatus, string _id)
        {

            Id = _id;
            newsStatus = _newsStatus;
        }
    }
}