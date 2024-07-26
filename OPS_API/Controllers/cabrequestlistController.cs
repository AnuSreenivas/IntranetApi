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
    public class cabrequestlistController : ApiController
    {
        [HttpGet]
        public cabrequestlistClass[] cabrequestlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestlistClass> arrayofArray = new List<cabrequestlistClass>();
                    cabrequestlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]),Convert.ToString(reader[5]), Convert.ToDateTime(reader[6]), Convert.ToString(reader[7]), Convert.ToInt16(reader[8]), Convert.ToDateTime(reader[9]), Convert.ToString(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToInt16(reader[13]), Convert.ToString(reader[14]), Convert.ToString(reader[15]), Convert.ToString(reader[16]), Convert.ToDateTime(reader[17]));
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