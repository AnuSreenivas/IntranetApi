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
    public class htreemonthplansubbaseController : ApiController
    {
        [HttpGet]
        public threemonthplansubbaseClass[] threemonthplansubbaseClass1(string itemSpice)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_3m_plan_subbase_view", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@itemSpice", itemSpice));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<threemonthplansubbaseClass> arrayofArray = new List<threemonthplansubbaseClass>();
                    threemonthplansubbaseClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new threemonthplansubbaseClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToDouble(reader[2]), Convert.ToDouble(reader[3]), Convert.ToDouble(reader[4]), Convert.ToDouble(reader[5]), Convert.ToDouble(reader[6]));
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