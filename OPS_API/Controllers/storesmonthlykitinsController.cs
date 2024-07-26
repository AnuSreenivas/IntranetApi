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
    public class storesmonthlykitinsController : ApiController
    {
        [HttpGet]
        public birateinsClass[] birateinsClass1(string fin_year, string fin_period, string empcode, string empname, string dept, string designation, string spice, string tea, string welfarekit, string userid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_stores_monthly_kit_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@fin_year", fin_year));
                    cmd.Parameters.Add(new SqlParameter("@fin_period", fin_period));
                    cmd.Parameters.Add(new SqlParameter("@empcode", empcode));
                    cmd.Parameters.Add(new SqlParameter("@empname", empname));
                    cmd.Parameters.Add(new SqlParameter("@dept", dept));
                    cmd.Parameters.Add(new SqlParameter("@designation", designation));
                    cmd.Parameters.Add(new SqlParameter("@spice", spice));
                    cmd.Parameters.Add(new SqlParameter("@tea", tea));
                    cmd.Parameters.Add(new SqlParameter("@welfarekit", welfarekit));
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<birateinsClass> arrayofArray = new List<birateinsClass>();
                    birateinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new birateinsClass(Convert.ToString(reader[0]));
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
