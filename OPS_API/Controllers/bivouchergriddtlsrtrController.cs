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
    public class bivouchergriddtlsrtrController : ApiController
    {
        [HttpGet]
        public bivouchergridlstClass[] bivouchergridlstClass1(string voucher_no)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("biops..avt_bi_payvoucher_grid_dtls_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@voucher_no", voucher_no));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bivouchergridlstClass> arrayofArray = new List<bivouchergridlstClass>();
                    bivouchergridlstClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bivouchergridlstClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToDouble(reader[2]), Convert.ToString(reader[3]));
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
