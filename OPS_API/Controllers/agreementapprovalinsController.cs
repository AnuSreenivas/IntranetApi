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

namespace OPS_API.Controllers
{
     public class agreementapprovalinsController : ApiController
    {
        [HttpGet]
         public agreementapprovalinsClass[] agreementapprovalinsClass1(string requestId, string approverEmpcode, string approvalStatus, string remarks)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_approval_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@requestId", requestId));
                    cmd.Parameters.Add(new SqlParameter("@approverEmpcode", approverEmpcode));
                    cmd.Parameters.Add(new SqlParameter("@approvalStatus", approvalStatus));
                    cmd.Parameters.Add(new SqlParameter("@remarks", remarks));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementapprovalinsClass> arrayofArray = new List<agreementapprovalinsClass>();
                    agreementapprovalinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new agreementapprovalinsClass(Convert.ToString(reader[0]));
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
    }
}


