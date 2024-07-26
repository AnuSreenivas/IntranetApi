using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OPS_API.Class;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OPS_API.Controllers
{
    public class intranetroleinsController : ApiController
    {
        [HttpGet]
        public intranetroleinsClass[] intranetroleinsClass1(string empcode, string empname, string empdesign,string empgrade, string empdept, int intrarole )
        {
            try
                
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_intranet_role_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@empcode", empcode));
                    cmd.Parameters.Add(new SqlParameter("@empname", empname));
                    cmd.Parameters.Add(new SqlParameter("@empdesign", empdesign));
                    cmd.Parameters.Add(new SqlParameter("@empgrade", empgrade));
                    cmd.Parameters.Add(new SqlParameter("@empdept", empdept));
                   // cmd.Parameters.Add(new SqlParameter("@dob", dob));
                    cmd.Parameters.Add(new SqlParameter("@intrarole", intrarole));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<intranetroleinsClass> arrayofArray = new List<intranetroleinsClass>();
                    intranetroleinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new intranetroleinsClass(Convert.ToString(reader[0]));
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