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
    public class screeningdtllistController : ApiController
    {
        [HttpGet]
        public screeningdtllistClass[] screeningdtllistClass1(string screenid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_candi_screening_id_dtls_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@screenid", screenid));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<screeningdtllistClass> arrayofArray = new List<screeningdtllistClass>();
                    screeningdtllistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new screeningdtllistClass(Convert.ToString(reader[0]), Convert.ToInt16(reader[1]), Convert.ToString(reader[2]), Convert.ToInt16(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]));
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
