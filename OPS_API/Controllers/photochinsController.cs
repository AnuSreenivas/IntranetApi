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
    public class photochinsController : ApiController
    {
        [HttpPost]
        public photochinsClass[] photochinsClass1(photchClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
                string filePath = "";
                string filenamenew = "";
                filePath = HttpContext.Current.Server.MapPath("~/assets/photoch/");
                string convert = vis.photo_details.Replace("data:image/jpeg;base64,", String.Empty);

                byte[] image64 = Convert.FromBase64String(convert);


                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("warehouse..avt_sp_photo_ch_details_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@emp_code", vis.emp_code));
                    cmd.Parameters.Add(new SqlParameter("@emp_name", vis.emp_name));
                    cmd.Parameters.Add(new SqlParameter("@emp_phoneno", vis.emp_phoneno));
                    cmd.Parameters.Add(new SqlParameter("@emp_department", vis.emp_department));
                    cmd.Parameters.Add(new SqlParameter("@photo_caption", vis.photo_caption));
                    cmd.Parameters.Add(new SqlParameter("@photo_description", vis.photo_description));
                    cmd.Parameters.Add(new SqlParameter("@photo_details", vis.photo_details));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<photochinsClass> arrayofArray = new List<photochinsClass>();
                    photochinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new photochinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
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