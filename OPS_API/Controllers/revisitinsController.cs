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
    public class revisitinsController : ApiController
    {
        [HttpPost]
        public visitorinsClass[] visitorinsClass1(visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
                string filePath = "";
                string filenamenew = "";
                filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
                string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

                byte[] image64 = Convert.FromBase64String(convert);




                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_revisit_details_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@category", vis.category));
                    cmd.Parameters.Add(new SqlParameter("@purpose", vis.purpose));
                    cmd.Parameters.Add(new SqlParameter("@employee_code", vis.employee_code));
                    cmd.Parameters.Add(new SqlParameter("@employee_name", vis.employee_name));
                    cmd.Parameters.Add(new SqlParameter("@company_code", vis.company_code));
                    cmd.Parameters.Add(new SqlParameter("@company_name", vis.company_name));
                    cmd.Parameters.Add(new SqlParameter("@company_address", vis.company_address));
                    cmd.Parameters.Add(new SqlParameter("@phoneno", vis.phoneno));
                    cmd.Parameters.Add(new SqlParameter("@visitor_name", vis.visitor_name));
                    cmd.Parameters.Add(new SqlParameter("@vehcile_type", vis.vehcile_type));
                    cmd.Parameters.Add(new SqlParameter("@vehicle_no", vis.vehicle_no));
                    cmd.Parameters.Add(new SqlParameter("@country", vis.country));
                    cmd.Parameters.Add(new SqlParameter("@materials", vis.materials));
                    cmd.Parameters.Add(new SqlParameter("@remarks", vis.remarks));

                    cmd.Parameters.Add(new SqlParameter("@userid", vis.userid));
                    cmd.Parameters.Add(new SqlParameter("@manuf", vis.manuf));
                    cmd.Parameters.Add(new SqlParameter("@filedetails", vis.filedetails));
                    cmd.Parameters.Add(new SqlParameter("@guidelines", vis.guidelines));
                    //cmd.Parameters.Add(new SqlParameter("@category", category));
                    //cmd.Parameters.Add(new SqlParameter("@purpose", purpose));
                    //cmd.Parameters.Add(new SqlParameter("@employee_code", employee_code));
                    //cmd.Parameters.Add(new SqlParameter("@employee_name", employee_name));
                    //cmd.Parameters.Add(new SqlParameter("@company_code", company_code));
                    //cmd.Parameters.Add(new SqlParameter("@company_name", company_name));
                    //cmd.Parameters.Add(new SqlParameter("@company_address", company_address));
                    //cmd.Parameters.Add(new SqlParameter("@phoneno", phoneno));
                    //cmd.Parameters.Add(new SqlParameter("@visitor_name", visitor_name));
                    //cmd.Parameters.Add(new SqlParameter("@vehcile_type", vehcile_type));
                    //cmd.Parameters.Add(new SqlParameter("@vehicle_no", vehicle_no));
                    //cmd.Parameters.Add(new SqlParameter("@country", country));
                    //cmd.Parameters.Add(new SqlParameter("@materials", materials));
                    //cmd.Parameters.Add(new SqlParameter("@remarks", remarks));

                    //cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    //cmd.Parameters.Add(new SqlParameter("@manuf", manuf));
                    //cmd.Parameters.Add(new SqlParameter("@filedetails", filedetails));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<visitorinsClass> arrayofArray = new List<visitorinsClass>();
                    visitorinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new visitorinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
                        filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
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
    }
}