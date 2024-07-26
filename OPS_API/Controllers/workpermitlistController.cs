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
    public class workpermitlistController : ApiController
    {

        [HttpGet]
        public workpermitlistClass[] workpermitlistClass1(string fromdate, string todate)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_work_permit_rpt_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fromdate", fromdate));
                    cmd.Parameters.Add(new SqlParameter("@todate", todate));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<workpermitlistClass> arrayofArray = new List<workpermitlistClass>();
                    workpermitlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new workpermitlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToDouble(reader[5]), Convert.ToDouble(reader[6]), Convert.ToDouble(reader[7]), Convert.ToDateTime(reader[8]), Convert.ToString(reader[9]), Convert.ToDateTime(reader[10]), Convert.ToString(reader[11]), Convert.ToString(reader[12]), Convert.ToString(reader[13]), Convert.ToString(reader[14]), Convert.ToString(reader[15]), Convert.ToString(reader[16]), Convert.ToDateTime(reader[17]));
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


