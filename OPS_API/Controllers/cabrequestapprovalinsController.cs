using OPS_API.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using OPS_API.Class;
using System.IO;
using System.Text;
using System.Web;
using System.Globalization;

namespace OPS_API.Controllers
{
    public class cabrequestapprovalinsController : ApiController

    {
        [HttpPost]
        public visitorinsClass[] visitorinsClass1(cabrequestapprovalhdrClass vis)
        
        {
            try
            {
        
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_approval_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@requestID", vis.requestID));
                    cmd.Parameters.Add(new SqlParameter("@requester_empCode", vis.requester_empCode));
                    cmd.Parameters.Add(new SqlParameter("@departmentName", vis.departmentName));
                    cmd.Parameters.Add(new SqlParameter("@reporting_officerCode", vis.reporting_officerCode));
                    cmd.Parameters.Add(new SqlParameter("@remarks", vis.remarks));
                    cmd.Parameters.Add(new SqlParameter("@approval_Status", vis.approval_Status));
                  
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<visitorinsClass> arrayofArray = new List<visitorinsClass>();
                    visitorinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new visitorinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
                        //     filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    //File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "update.txt", sb.ToString());
                sb.Clear();
                return null;
            }

        }


    }
}
