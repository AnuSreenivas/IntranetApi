using OPS_API.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace OPS_API.Controllers
{
    public class tripeditController : ApiController
    {
        [HttpGet]
        public sampleinsClass[] sampleinsClass1(string trip_no, string actual_tolocation, string edited_tolocation, double actual_nobags, double edited_nobags, string lotno, string username)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("biops..avt_bi_trips_edit_bags_tolocation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@trip_no", trip_no));
                    cmd.Parameters.Add(new SqlParameter("@actual_tolocation", actual_tolocation));
                    cmd.Parameters.Add(new SqlParameter("@edited_tolocation", edited_tolocation));
                    cmd.Parameters.Add(new SqlParameter("@actual_nobags", actual_nobags));
                    cmd.Parameters.Add(new SqlParameter("@edited_nobags", edited_nobags));
                    cmd.Parameters.Add(new SqlParameter("@lotno", lotno));
                    cmd.Parameters.Add(new SqlParameter("@username", username));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<sampleinsClass> arrayofArray = new List<sampleinsClass>();
                    sampleinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new sampleinsClass(Convert.ToString(reader[0]));
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
