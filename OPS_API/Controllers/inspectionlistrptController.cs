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
    public class inspectionlistrptController : ApiController
    {
        [HttpGet]
        public inspectionlistrptClass[] inspectionlistrptClass1(string username, string areacode, string farmercode)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("AVTFarm..avt_inspection_list_rpt", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@areacode", areacode));
                    cmd.Parameters.Add(new SqlParameter("@farmercode", farmercode));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<inspectionlistrptClass> arrayofArray = new List<inspectionlistrptClass>();
                    inspectionlistrptClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new inspectionlistrptClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToDouble(reader[6]));
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
