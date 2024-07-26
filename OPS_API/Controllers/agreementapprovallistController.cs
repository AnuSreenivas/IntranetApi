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
    public class agreementapprovallistController : ApiController
    {
        [HttpGet]
        public agreementapprovallistClass[] agreementapprovallistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_approval_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.Add(new SqlParameter("@requestId", requestId));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementapprovallistClass> arrayofArray = new List<agreementapprovallistClass>();
                    agreementapprovallistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new agreementapprovallistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]), Convert.ToString(reader[5]));
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


