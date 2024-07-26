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
    public class deptlistController : ApiController
    {
        [HttpGet]
        public deptlistClass[] deptlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_hr_dept_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@empcode", empcode));
                    //cmd.Parameters.Add(new SqlParameter("@toempcode", toempcode));
                    //cmd.Parameters.Add(new SqlParameter("@fromdate", fromdate));
                    //cmd.Parameters.Add(new SqlParameter("@todate", todate));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<deptlistClass> arrayofArray = new List<deptlistClass>();
                    deptlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new deptlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
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
