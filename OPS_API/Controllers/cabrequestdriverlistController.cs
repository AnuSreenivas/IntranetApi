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
    public class cabrequestdriverlistController : ApiController
    {
        [HttpGet]
        public cabrequestdriverlistClass[] cabrequestdriverlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_driver_dtls", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   // cmd.Parameters.Add(new SqlParameter("@drivername", drivername));
                    //cmd.Parameters.Add(new SqlParameter("@phoneno", phoneno));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestdriverlistClass> arrayofArray = new List<cabrequestdriverlistClass>();
                    cabrequestdriverlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestdriverlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
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

