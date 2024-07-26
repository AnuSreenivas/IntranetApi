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
    public class addassetinsController : ApiController
    {

        [HttpPost]
        public visitorinsClass[] visitorinsClass1(assetdtslClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
                string filePath = "";
                string filenamenew = "";
                //filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
                //string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

                //byte[] image64 = Convert.FromBase64String(convert);

                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_asset_details_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@sys_no", vis.sys_no));
                    cmd.Parameters.Add(new SqlParameter("@reftype", vis.reftype));
                    cmd.Parameters.Add(new SqlParameter("@serial_no", vis.serial_no));
                    cmd.Parameters.Add(new SqlParameter("@os", vis.os));
                    cmd.Parameters.Add(new SqlParameter("@asset_location", vis.asset_location));
                    cmd.Parameters.Add(new SqlParameter("@warranty", vis.warranty));
                    cmd.Parameters.Add(new SqlParameter("@make", vis.make));
                    cmd.Parameters.Add(new SqlParameter("@ip_address", vis.ip_address));
                    cmd.Parameters.Add(new SqlParameter("@system_name", vis.system_name));
                    cmd.Parameters.Add(new SqlParameter("@model_no", vis.model_no));
                    cmd.Parameters.Add(new SqlParameter("@department", vis.department));
                    cmd.Parameters.Add(new SqlParameter("@asset_user", vis.asset_user));
                    cmd.Parameters.Add(new SqlParameter("@asset_sr_no", vis.asset_sr_no));
                    cmd.Parameters.Add(new SqlParameter("@machine", vis.machine));
                    cmd.Parameters.Add(new SqlParameter("@asset_request", vis.asset_request));
                    
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
                  //  File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
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
