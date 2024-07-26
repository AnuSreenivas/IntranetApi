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
    public class cabrequestapprovallistController : ApiController
    {
        [HttpGet]
        public cabrequestapprovallistClass[] cabrequestapprovallistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_approval_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestapprovallistClass> arrayofArray = new List<cabrequestapprovallistClass>();
                    cabrequestapprovallistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestapprovallistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToDateTime(reader[6]), Convert.ToString(reader[7]));
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
