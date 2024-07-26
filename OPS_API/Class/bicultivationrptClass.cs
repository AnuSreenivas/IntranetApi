using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bicultivationrptClass
    {
   public string areaname { get; set; }
   public string areacode { get; set; }
   public double CHW01106A { get; set; }
   public double CHW01106Q { get; set; }
   public double CHW01106QA { get; set; }
   public double CHW01104A { get; set; }
   public double CHW01104Q { get; set; }
   public double CHW01104QA { get; set; }
   public double CHW01153A { get; set; }
   public double CHW01153Q { get; set; }
   public double CHW01153QA { get; set; }
   public double CHW01107A { get; set; }
   public double CHW01107Q { get; set; }
   public double CHW01107QA { get; set; }
   public double CHW01110A { get; set; }
   public double CHW01110Q { get; set; }
   public double CHW01110QA { get; set; }
   public double CHW01108A { get; set; }
   public double CHW01108Q { get; set; }
   public double CHW01108QA { get; set; }
   public double CHW01117A { get; set; }
   public double CHW01117Q { get; set; }
   public double CHW01117QA { get; set; }
   public double CHW01111A { get; set; }
   public double CHW01111Q { get; set; }
   public double CHW01111QA { get; set; }
   public double CHW01151A { get; set; }
   public double CHW01151Q { get; set; }
   public double CHW01151QA { get; set; }
   public double Atotal { get; set; }
   public double Qtotal { get; set; }
   public double QtotalA { get; set; }
   public string remarks { get; set; }
   public double pbqty { get; set; }
   public bicultivationrptClass(
   string area_code  ,
   double CHW01106_A,
   double CHW01106_Q,
   double CHW01106_QA,
   double CHW01104_A,
   double CHW01104_Q,
   double CHW01104_QA,
   double CHW01153_A,
   double CHW01153_Q,
   double CHW01153_QA,
   double CHW01107_A,
   double CHW01107_Q,
   double CHW01107_QA,
   double CHW01110_A,
   double CHW01110_Q,
   double CHW01110_QA,
   double CHW01108_A,
   double CHW01108_Q,
   double CHW01108_QA,
   double CHW01117_A,
   double CHW01117_Q,
   double CHW01117_QA,
   double CHW01111_A,
   double CHW01111_Q,
   double CHW01111_QA,
   double CHW01151_A,
   double CHW01151_Q,
   double CHW01151_QA,
   double A_total, //33
   double Q_total,
   double Qtotal_A,
   string remark_s, string area_name, double pb_qty)
        
   {
            areacode = area_code;
            areaname = area_name;
            CHW01106A = CHW01106_A;
            CHW01106Q = CHW01106_Q;
            CHW01106QA = CHW01106_QA;
            CHW01104A = CHW01104A;
            CHW01104Q = CHW01104_Q;
            CHW01104QA = CHW01104_QA;
            CHW01153A = CHW01153_A;
            CHW01153Q = CHW01153_Q;
            CHW01153QA = CHW01153_QA;
            CHW01107A = CHW01107_A;
            CHW01107Q = CHW01107_Q;
            CHW01107QA = CHW01107_QA;
            CHW01110A = CHW01110_A;
            CHW01110Q = CHW01110_Q;
            CHW01110QA = CHW01110_QA;
            CHW01108A = CHW01108_A;
            CHW01108Q = CHW01108_Q;
            CHW01108QA = CHW01108_QA;
            CHW01117A = CHW01117_A;
            CHW01117Q = CHW01117_Q;
            CHW01117QA = CHW01117_QA;
            CHW01111A = CHW01111_A;
            CHW01111Q = CHW01111_Q;
            CHW01111QA = CHW01111_QA;
            CHW01151A = CHW01151_A;
            CHW01151Q = CHW01151_Q;
            CHW01151QA = CHW01151_QA;
            Atotal = A_total;
            Qtotal = Q_total;
            QtotalA = Qtotal_A;
            remarks = remark_s;
            pbqty = pb_qty;
   }
    }
}