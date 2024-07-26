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
    public class itassetslistController : ApiController
    {
        [HttpGet]
        public itassetslistClass[] itassetslistClass1(string reftype)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_it_assets_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                     cmd.Parameters.Add(new SqlParameter("@reftype", reftype));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<itassetslistClass> arrayofArray = new List<itassetslistClass>();
                    itassetslistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new itassetslistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToInt16(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToString(reader[13]), Convert.ToString(reader[14]));
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

