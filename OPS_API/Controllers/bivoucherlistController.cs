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
    public class bivoucherlistController : ApiController
    {
        [HttpGet]
        public voucherlistClass[] voucherlistClass1(string username, string fromvoucher, string tovoucher)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("biops..avt_bi_voucher_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@fromvoucher", fromvoucher));
                    cmd.Parameters.Add(new SqlParameter("@tovoucher", tovoucher));
                    
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<voucherlistClass> arrayofArray = new List<voucherlistClass>();
                    voucherlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new voucherlistClass(Convert.ToString(reader[0]), Convert.ToDateTime(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDouble(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]));
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

