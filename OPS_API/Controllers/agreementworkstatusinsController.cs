using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OPS_API.Class;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.IO;
namespace OPS_API.Controllers
{
    public class agreementworkstatusinsController : ApiController
    {
        [HttpGet]
        public agreementstatusinsClass[] agreementstatusinsClass1(string requestId, string approvalId, string workStatus, DateTime workStartDate)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_workstatus_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@requestId", requestId));
                    cmd.Parameters.Add(new SqlParameter("@approvalId", approvalId));
                    cmd.Parameters.Add(new SqlParameter("@workStatus", workStatus));
                    cmd.Parameters.Add(new SqlParameter("@workStartDate", workStartDate));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementstatusinsClass> arrayofArray = new List<agreementstatusinsClass>();
                    agreementstatusinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new agreementstatusinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                return null;
            }

        }





        [HttpGet]
        public Inboxrequests[] InboxRequests(string empcode)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..Avt_sp_Get_CabRequestWithEmployeeId", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@EmployeeCode",empcode));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<Inboxrequests> arrayofArray = new List<Inboxrequests>();
                    Inboxrequests objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new Inboxrequests(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToDateTime(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]));
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                return null;
            }

        }



        [HttpPost]
        public cabrequestdriverinsClass[] EnquiryClass1(EnquiryClass vis)
    
        {
            try
            {
               

                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..SendEmailToAdmin", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@subject", vis.Subject));
                    cmd.Parameters.Add(new SqlParameter("@message", vis.Message));
                    cmd.Parameters.Add(new SqlParameter("@mobile", vis.Mobile));
                    cmd.Parameters.Add(new SqlParameter("@email", vis.Email));
                    cmd.Parameters.Add(new SqlParameter("@name", vis.Name));
                   

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestdriverinsClass> arrayofArray = new List<cabrequestdriverinsClass>();
                    cabrequestdriverinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestdriverinsClass(Convert.ToString(reader[0]));
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


