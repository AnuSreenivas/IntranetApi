using System;
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
    public class shiftwiseemplistController : ApiController
    {
        [HttpGet]
        public emplistshiftwiseClass[] emplistshiftwiseClass1(string shift, string shift_date)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_emp_shift_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@shift", shift));
                    cmd.Parameters.Add(new SqlParameter("@shift_date", shift_date));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<emplistshiftwiseClass> arrayofArray = new List<emplistshiftwiseClass>();
                    emplistshiftwiseClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new emplistshiftwiseClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]));
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