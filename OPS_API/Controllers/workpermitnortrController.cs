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
    public class workpermitnortrController : ApiController
    {
        [HttpGet]
        public workpermitnortrClass[] workpermitnortrClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["AVT_DATA2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_visit_workpermit_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@minu", minu));
                    //cmd.Parameters.Add(new SqlParameter("@veh_type", veh_type));
                    //cmd.Parameters.Add(new SqlParameter("@in_out", in_out));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<workpermitnortrClass> arrayofArray = new List<workpermitnortrClass>();
                    workpermitnortrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new workpermitnortrClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToDouble(reader[6]), Convert.ToDateTime(reader[7]), Convert.ToDateTime(reader[8]), Convert.ToString(reader[9]));
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

