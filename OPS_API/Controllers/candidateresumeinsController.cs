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
using Newtonsoft.Json;
using OPS_API.Class;
using System.IO;
using System.Text;
using System.Web;
using System.Globalization;

namespace OPS_API.Controllers
{
    public class candidateresumeinsController : ApiController
    {
        [HttpPost]
        public candidateresinsClass[] candidateresinsClass1(candidateresumeinsClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
                string filePath = "";
                string filenamenew = "";
              //  filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
            //    string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

             //   byte[] image64 = Convert.FromBase64String(convert);

                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_candidate_resume_mst_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@dept_code", vis.dept_code));
                    cmd.Parameters.Add(new SqlParameter("@dept_name", vis.dept_name));
                    cmd.Parameters.Add(new SqlParameter("@job_level", vis.job_level));
                    cmd.Parameters.Add(new SqlParameter("@applicant_name", vis.applicant_name));
                    cmd.Parameters.Add(new SqlParameter("@applicant_phone", vis.applicant_phone));
                    cmd.Parameters.Add(new SqlParameter("@applicant_email", vis.applicant_email));
                    cmd.Parameters.Add(new SqlParameter("@applicant_location", vis.applicant_location));
                    cmd.Parameters.Add(new SqlParameter("@cv_source", vis.cv_source));
                    cmd.Parameters.Add(new SqlParameter("@referred_employee_code", vis.referred_employee_code));
                    cmd.Parameters.Add(new SqlParameter("@referred_employee", vis.referred_employee));
                    cmd.Parameters.Add(new SqlParameter("@cv_doc", vis.cv_doc));
                    cmd.Parameters.Add(new SqlParameter("@cv_status", vis.cv_status));
                    cmd.Parameters.Add(new SqlParameter("@userid", vis.userid));
                    cmd.Parameters.Add(new SqlParameter("@gender", vis.gender));
                    cmd.Parameters.Add(new SqlParameter("@experience", vis.experience));
                    cmd.Parameters.Add(new SqlParameter("@qualification", vis.qualification));
                    cmd.Parameters.Add(new SqlParameter("@remarks", vis.remarks));
                    cmd.Parameters.Add(new SqlParameter("@Position_name", vis.Position_name));
                    cmd.Parameters.Add(new SqlParameter("@Position_id", vis.Position_id));


                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<candidateresinsClass> arrayofArray = new List<candidateresinsClass>();
                    candidateresinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new candidateresinsClass(Convert.ToString(reader[0]));
                        filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
               //     File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "update.txt", sb.ToString());
                sb.Clear();
                return null;
            }

        }

        [HttpGet]
        public cabrequestTariffClass[] cabTariffClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_allocation_TariffRate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestTariffClass> arrayofArray = new List<cabrequestTariffClass>();
                    cabrequestTariffClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestTariffClass(Convert.ToInt32(reader[0]));
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
