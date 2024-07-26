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
    public class contractbalcustomerController : ApiController
    {
        [HttpGet]
        public contractbalanceClass[] contractbalanceClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_mis_BsoSpot_cust", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@month", month));
                    //cmd.Parameters.Add(new SqlParameter("@itemSpice", itemSpice));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<contractbalanceClass> arrayofArray = new List<contractbalanceClass>();
                    contractbalanceClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new contractbalanceClass(Convert.ToString(reader[0]), Convert.ToDouble(reader[1]), Convert.ToDouble(reader[2]), Convert.ToDouble(reader[3]));

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