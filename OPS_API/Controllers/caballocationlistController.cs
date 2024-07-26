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
using System.Diagnostics;

namespace OPS_API.Controllers
{
    public class caballocationlistController : ApiController
    {


        [HttpGet]
        public caballocationlistClass[] caballocationlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_allocation_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<caballocationlistClass> arrayofArray = new List<caballocationlistClass>();
                    caballocationlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new caballocationlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToDateTime(reader[8]), Convert.ToString(reader[9]), Convert.ToInt16(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToString(reader[13]), Convert.ToString(reader[14]), Convert.ToString(reader[15]), Convert.ToString(reader[16]), Convert.ToString(reader[17]), Convert.ToString(reader[18]), Convert.ToString(reader[19]), Convert.ToString(reader[20]), Convert.ToSingle(reader[21]), Convert.ToSingle(reader[22]));
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
