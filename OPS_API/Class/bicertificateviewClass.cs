using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OPS_API.Class
{
    public class bicertificateviewClass
    {
   public string lotno { get; set; }

   public string labname { get; set; }

   public string filepath { get; set; }
   public DateTime uploaddate { get; set; }
   public string filenamePR { get; set; }
   public string filenameaflaA { get; set; }
   public string filenameaflaB { get; set; }
   public string filenameaflaC { get; set; }
   public string filenameaflaD { get; set; }
   public string filenameheat { get; set; }
   public string filenameochra { get; set; }

   public bicertificateviewClass(string lot_no, string lab_name, string file_path, DateTime upload_date, string filename_PR, string filename_aflaA, string filename_aflaB, string filename_aflaC, string filename_aflaD, string filename_heat, string filename_ochra)
        {
       lotno = lot_no;
       labname = lab_name;
       filepath = file_path;
       uploaddate = upload_date;
       filenamePR = filename_PR;
       filenameaflaA = filename_aflaA;
       filenameaflaB = filename_aflaB;
       filenameaflaC = filename_aflaC;
       filenameaflaD = filename_aflaD;
       filenameheat = filename_heat;
       filenameochra = filename_ochra;
      
        }
    }
}