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
    public class empvehiclecheckoutlistController : ApiController
    {
        [HttpGet]
        public empvehiclecheckoutlistClass[] empvehiclecheckoutlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_emp_vehicle_checkout_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@month", month));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<empvehiclecheckoutlistClass> arrayofArray = new List<empvehiclecheckoutlistClass>();
                    empvehiclecheckoutlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new empvehiclecheckoutlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]));

                        //objArray = new headcountClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToDateTime(reader[5]), Convert.ToDouble(reader[6]), Convert.ToDouble(reader[7]), Convert.ToDouble(reader[8]), Convert.ToString(reader[9]), Convert.ToDateTime(reader[10]), Convert.ToDouble(reader[11]), Convert.ToDateTime(reader[12]), Convert.ToDateTime(reader[13]), Convert.ToString(reader[14]), Convert.ToString(reader[15]), Convert.ToDateTime(reader[16]));
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
