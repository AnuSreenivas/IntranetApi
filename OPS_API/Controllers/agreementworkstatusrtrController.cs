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
    public class agreementworkstatusrtrController : ApiController
    {
        [HttpGet]
        public agreementworkstatusrtrClass[] agreementworkstatusrtrClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_work_Status_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@requestId", requestId));
                   
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementworkstatusrtrClass> arrayofArray = new List<agreementworkstatusrtrClass>();
                    agreementworkstatusrtrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new agreementworkstatusrtrClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]), Convert.ToDateTime(reader[5]), Convert.ToDateTime(reader[6]), Convert.ToDateTime(reader[7]), Convert.ToDateTime(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10]));
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


