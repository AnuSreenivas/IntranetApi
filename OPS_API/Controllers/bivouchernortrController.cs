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
    public class bivouchernortrController : ApiController
    {
        [HttpGet]
        public bivouchernortrClass[] bivouchernortrClass1(string username)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("biops..avt_bi_voucherno_toconfirm", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bivouchernortrClass> arrayofArray = new List<bivouchernortrClass>();
                    bivouchernortrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bivouchernortrClass(Convert.ToString(reader[0]), Convert.ToDateTime(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDouble(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]));
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
