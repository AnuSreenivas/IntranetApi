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
    public class poinfolookupController : ApiController
    {
        [HttpGet]
        public poinfoClass[] poinfoClass1(string item_code, string cust_code)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("PMSDB..avt_magna_POINfo_lookup", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@item_code", item_code));
                    cmd.Parameters.Add(new SqlParameter("@cust_code", cust_code));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<poinfoClass> arrayofArray = new List<poinfoClass>();
                    poinfoClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new poinfoClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToDateTime(reader[10]));
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