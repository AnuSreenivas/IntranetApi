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
    public class nonemployeeheadcountController : ApiController
    {
        [HttpGet]
        public nonemployeeheadcountClass[] nonemployeeheadcountClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_visitors_headcount_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@fromdate", fromdate));
                    //cmd.Parameters.Add(new SqlParameter("@todate", todate));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<nonemployeeheadcountClass> arrayofArray = new List<nonemployeeheadcountClass>();
                    nonemployeeheadcountClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new nonemployeeheadcountClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToDateTime(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]));
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

