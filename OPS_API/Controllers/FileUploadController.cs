using Newtonsoft.Json;
using OPS_API.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using Newtonsoft.Json;
using System.Globalization;

namespace OPS_API.Controllers
{
    public class FileUploadController : ApiController
    {
        //     DigitalCardEntities dc = new DigitalCardEntities();
        [HttpPost]
        
        public string UploadJsonFile()
        {

            try
            {
                int iUploadedCnt = 0;
                // DEFINE THE PATH WHERE WE WANT TO SAVE THE FILES.
                string sPath = "";
                sPath = HttpContext.Current.Server.MapPath("~/assets/img/Attachment/202021_Lab_results/");
                System.Web.HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;

                //string filePath = HttpContext.Current.Server.MapPath(path);
                //File.WriteAllBytes(filePath, Convert.FromBase64String(base64string.Split(',')[1]));
                // CHECK THE FILE COUNT.
                for (int iCnt = 0; iCnt <= hfc.Count - 1; iCnt++)
                {
                    System.Web.HttpPostedFile hpf = hfc[iCnt];
                    if (hpf.ContentLength > 0)
                    {
                        //spInsertAboutUsAttachment_Result tm = dc.spInsertAboutUsAttachment(hpf.FileName, Int32.Parse(hpf.FileName.Split('_')[0]), Int32.Parse(hpf.FileName.Split('_')[1])).SingleOrDefault();
                        // CHECK IF THE SELECTED FILE(S) ALREADY EXISTS IN FOLDER. (AVOID DUPLICATE)            
                        // SAVE THE FILES IN THE FOLDER.
                        //  hpf.SaveAs(sPath + Path.GetFileName(tm.Id.ToString() + Path.GetExtension(hpf.FileName)));
                        hpf.SaveAs(sPath + Path.GetFileName(hpf.FileName));
                        iUploadedCnt = iUploadedCnt + 1;
                    }
                }
                // RETURN A MESSAGE (OPTIONAL).
                if (iUploadedCnt > 0)
                {
                    return iUploadedCnt + " Files Uploaded Successfully";
                }
                else
                {
                    return "Upload Failed";
                }
            }
            catch (Exception e)
            {
              //  return e.Message;
                string err = e.Message + "" + e.InnerException + "";
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "uploadlog.txt", sb.ToString());
                sb.Clear();
                return null;
            }
        }

    }
}