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

    public class candidatescreeninsController : ApiController
    {
        [HttpGet]
        public candidatescreeninsClass[] candidatescreeninsClass1(string screened_Id,int postion_id,string position_level,string postion_name,int refernceId,string applicant_name,string applicant_phone,string applicant_email,string dept_code,string dept_name,string userid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_candi_screening_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@screened_Id", screened_Id));
                    cmd.Parameters.Add(new SqlParameter("@postion_id", postion_id));
                    cmd.Parameters.Add(new SqlParameter("@position_level", position_level));
                    cmd.Parameters.Add(new SqlParameter("@postion_name", postion_name));
                    cmd.Parameters.Add(new SqlParameter("@refernceId", refernceId));
                    cmd.Parameters.Add(new SqlParameter("@applicant_name", applicant_name));
                    cmd.Parameters.Add(new SqlParameter("@applicant_phone", applicant_phone));
                    cmd.Parameters.Add(new SqlParameter("@applicant_email", applicant_email));
                    cmd.Parameters.Add(new SqlParameter("@dept_code", dept_code));
                    cmd.Parameters.Add(new SqlParameter("@dept_name", dept_name));
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<candidatescreeninsClass> arrayofArray = new List<candidatescreeninsClass>();
                    candidatescreeninsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new candidatescreeninsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
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
