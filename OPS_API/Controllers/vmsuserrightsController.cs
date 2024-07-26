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
    public class vmsuserrightsController : ApiController
    {
        [HttpGet]
        public vmsuserrightsClass[] vmsuserrightsClass1(string username)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("vms..avt_sp_userright_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));


                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<vmsuserrightsClass> arrayofArray = new List<vmsuserrightsClass>();
                    vmsuserrightsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new vmsuserrightsClass(Convert.ToString(reader[0]));
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
