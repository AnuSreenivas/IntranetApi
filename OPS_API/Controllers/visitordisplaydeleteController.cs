using Newtonsoft.Json;
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
    public class visitordisplaydeleteController : ApiController
    {
        [HttpGet]
        public bilablotinsClass[] bilablotinsClass1(string fromdate, string todate, string visitorname, string companyname)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_visitor_display_del", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fromdate", fromdate));
                    cmd.Parameters.Add(new SqlParameter("@todate", todate));
                    cmd.Parameters.Add(new SqlParameter("@visitorname", visitorname));
                    cmd.Parameters.Add(new SqlParameter("@companyname", companyname));
                    
                    ;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bilablotinsClass> arrayofArray = new List<bilablotinsClass>();
                    bilablotinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bilablotinsClass(Convert.ToString(reader[0]));
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