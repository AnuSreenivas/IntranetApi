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

namespace OPS_API.Controllers
{
    public class candidateresumelistController : ApiController
    {
        [HttpGet]
        public candidateresumelistClass[] candidateresumelistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_candidate_resume_mst_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<candidateresumelistClass> arrayofArray = new List<candidateresumelistClass>();
                    candidateresumelistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new candidateresumelistClass(Convert.ToInt16(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToDateTime(reader[13]), Convert.ToString(reader[14]), Convert.ToInt16(reader[15]), Convert.ToString(reader[16]), Convert.ToString(reader[17]), Convert.ToString(reader[18]), Convert.ToString(reader[19]), Convert.ToString(reader[20]));
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