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
    public class biusersController : ApiController
    {
        [HttpGet]
        public biusersrtrClass[] biusersrtrClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snop..avt_bi_userlist_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                   

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<biusersrtrClass> arrayofArray = new List<biusersrtrClass>();
                    biusersrtrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new biusersrtrClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
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
