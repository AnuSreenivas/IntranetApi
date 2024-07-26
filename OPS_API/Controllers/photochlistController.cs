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
    public class photochlistController : ApiController
    {
        [HttpGet]
        public photochlistClass[] photochlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("warehouse..avt_sp_photoch_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@item_code", itemcode));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<photochlistClass> arrayofArray = new List<photochlistClass>();
                    photochlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new photochlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]));
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
