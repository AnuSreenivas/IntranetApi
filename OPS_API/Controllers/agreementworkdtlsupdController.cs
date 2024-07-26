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
    public class agreementworkdtlsupdController : ApiController
    {
        [HttpPost]
        public agreementworkupdClass[] agreementworkupdClass1(agreementworkdtlsupdClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
            //    string filePath = "";
                //string filenamenew = "";
               // filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
              //  string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

               // byte[] image64 = Convert.FromBase64String(convert);




                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_work_status_upd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@workId", vis.workId));
                    cmd.Parameters.Add(new SqlParameter("@requestId", vis.requestId));
                    cmd.Parameters.Add(new SqlParameter("@approvalId", vis.approvalId));
                    cmd.Parameters.Add(new SqlParameter("@workStatus", vis.workStatus));
                    cmd.Parameters.Add(new SqlParameter("@workStartDate", vis.workStartDate));
                    cmd.Parameters.Add(new SqlParameter("@workCompletedDate", vis.workCompletedDate));
                    cmd.Parameters.Add(new SqlParameter("@ValidFrom", vis.ValidFrom));
                    cmd.Parameters.Add(new SqlParameter("@ValidTo", vis.ValidTo));
                    cmd.Parameters.Add(new SqlParameter("@ExectuionDate", vis.ExectuionDate));
                    cmd.Parameters.Add(new SqlParameter("@remarksFromlegal", vis.remarksFromlegal));
                    cmd.Parameters.Add(new SqlParameter("@finalDocument", vis.finalDocument));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementworkupdClass> arrayofArray = new List<agreementworkupdClass>();
                    agreementworkupdClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new agreementworkupdClass(Convert.ToString(reader[0]));
                      //  filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                   // File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
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
