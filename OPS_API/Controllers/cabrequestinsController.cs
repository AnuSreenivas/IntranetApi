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
    public class cabrequestinsController : ApiController
    {
        [HttpPost]
        public visitorinsClass[] visitorinsClass1(cabrequesthdrClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
               // string filePath = "";
                //string filenamenew = "";
                //filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
                //string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

                //byte[] image64 = Convert.FromBase64String(convert);

                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@requester_empCode", vis.requester_empCode));
                    cmd.Parameters.Add(new SqlParameter("@requester_empName", vis.requester_empName));
                    cmd.Parameters.Add(new SqlParameter("@pickup_place", vis.pickup_place));
                    cmd.Parameters.Add(new SqlParameter("@destination", vis.destination));
                    cmd.Parameters.Add(new SqlParameter("@travel_purpose", vis.travel_purpose));
                    cmd.Parameters.Add(new SqlParameter("@pickup_date", vis.pickup_date));
                    cmd.Parameters.Add(new SqlParameter("@pickup_time", vis.pickup_time));
                    cmd.Parameters.Add(new SqlParameter("@no_of_days", vis.no_of_days));
                    cmd.Parameters.Add(new SqlParameter("@return_date", vis.return_date));
                    cmd.Parameters.Add(new SqlParameter("@ApproverempCode", vis.ApproverempCode));
                    cmd.Parameters.Add(new SqlParameter("@ApproverName", vis.ApproverName));
                    cmd.Parameters.Add(new SqlParameter("@departmentname", vis.departmentname));
                    cmd.Parameters.Add(new SqlParameter("@no_of_passengers", vis.no_of_passengers));
                    cmd.Parameters.Add(new SqlParameter("@passengers_name", vis.passengers_name));
                    cmd.Parameters.Add(new SqlParameter("@remarks", vis.remarks));
                    cmd.Parameters.Add(new SqlParameter("@Cab_req_Status", vis.Cab_req_Status));
                   
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<visitorinsClass> arrayofArray = new List<visitorinsClass>();
                    visitorinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new visitorinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
                   //     filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    //File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
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
