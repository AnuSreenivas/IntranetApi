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
    public class companyinsController : ApiController
    {
        [HttpGet]
        public bilablotinsClass[] bilablotinsClass1(string company_name, string company_address, string pincode, string city, string country, string phone)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_company_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@company_name", @company_name));
                    cmd.Parameters.Add(new SqlParameter("@company_address", company_address));
                    cmd.Parameters.Add(new SqlParameter("@pincode", pincode));
                    cmd.Parameters.Add(new SqlParameter("@city", city));
                    cmd.Parameters.Add(new SqlParameter("@country", country));
                    cmd.Parameters.Add(new SqlParameter("@phone", phone));
                               
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