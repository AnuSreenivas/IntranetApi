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
    public class agreementrequestrtrController : ApiController
    {
        [HttpGet]
        public agreementrequestrtrClass[] agreementrequestrtrClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_agreement_request_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                   // cmd.Parameters.Add(new SqlParameter("@screenid", screenid));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<agreementrequestrtrClass> arrayofArray = new List<agreementrequestrtrClass>();
                    agreementrequestrtrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new agreementrequestrtrClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToDateTime(reader[5]), Convert.ToDateTime(reader[6]), Convert.ToDateTime(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToString(reader[13]), Convert.ToString(reader[14]), Convert.ToString(reader[15]), Convert.ToString(reader[16]), Convert.ToString(reader[17]), Convert.ToString(reader[18]), Convert.ToString(reader[19]), Convert.ToString(reader[20]), Convert.ToString(reader[21]), Convert.ToString(reader[22]), Convert.ToString(reader[23]), Convert.ToDateTime(reader[24]));
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

