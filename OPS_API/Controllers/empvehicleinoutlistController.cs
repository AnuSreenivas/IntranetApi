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
    public class empvehicleinoutlistController : ApiController
    {
        

        [HttpGet]
        public empvehicleinoutrptlistClass[] empvehicleinoutrptlistClass1(string fromdate, string todate)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_emp_vehicle_rpt_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fromdate", fromdate));
                    cmd.Parameters.Add(new SqlParameter("@todate", todate));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<empvehicleinoutrptlistClass> arrayofArray = new List<empvehicleinoutrptlistClass>();
                    empvehicleinoutrptlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new empvehicleinoutrptlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]), Convert.ToString(reader[5]), Convert.ToDateTime(reader[6]));

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

