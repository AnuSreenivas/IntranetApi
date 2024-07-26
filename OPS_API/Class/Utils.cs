using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace INIT.API.Kathirmandapam.Class
{
    public class Utils
    {
        public static string CreateOTP(int length)
        {
            const string valid = "1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //public static bool SendMailPassword(string toMail, string otp)
        //{
        //    try
        //    {
        //        using (MailMessage mm = new MailMessage("support@peacegate.in", toMail))
        //        {
        //            mm.Subject = "Peacegate Account -" + otp + " is your Password for secure access";
        //            mm.Body = "Hi,<br> Greetings! <br> You are just a step away from accessing your Peacegate account. <br> We are sharing a Password to access your account.<br> Your Password : <b>" + otp + "</b><br>Best Regards, <br> Peacegate App";
        //            mm.IsBodyHtml = true;
        //            SmtpClient smtp = new SmtpClient();
        //            smtp.Host = "smtp.zoho.in";
        //            smtp.EnableSsl = true;
        //            NetworkCredential NetworkCred = new NetworkCredential("support@peacegate.in", "PeaceGate@2018");
        //            smtp.UseDefaultCredentials = false;
        //            smtp.Credentials = NetworkCred;
        //            smtp.Port = 587;
        //            smtp.Send(mm);
        //            return true;
        //        }


        //    }
        //    catch (Exception e)
        //    {

        //        return true;
       //     }
      //  }


        public static bool SaveImage(string path, string base64string)
        {
            try
            {
                string filePath = HttpContext.Current.Server.MapPath(path);
                File.WriteAllBytes(filePath, Convert.FromBase64String(base64string.Split(',')[1]));
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public static string StripHTML(string input)
        {
            return Regex.Replace(input, "<.*?>", String.Empty);
        }
    }
}