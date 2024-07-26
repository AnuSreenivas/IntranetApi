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
    public class caballocationinsController : ApiController
    {
        [HttpPost]
        public visitorinsClass[] visitorinsClass1(caballocationhdrClass vis)
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
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_allocation_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@approvalID", vis.approvalID));
                    cmd.Parameters.Add(new SqlParameter("@requestID", vis.requestID));
                    cmd.Parameters.Add(new SqlParameter("@driver_name", vis.driver_name));
                    cmd.Parameters.Add(new SqlParameter("@driver_phone", vis.driver_phone));
                    cmd.Parameters.Add(new SqlParameter("@vehicle_no", vis.vehicle_no));
                    cmd.Parameters.Add(new SqlParameter("@requester_empCode", vis.requester_empCode));
                    cmd.Parameters.Add(new SqlParameter("@vehicle_type", vis.vehicle_type));
                    cmd.Parameters.Add(new SqlParameter("@departmentName", vis.departmentName));
                    cmd.Parameters.Add(new SqlParameter("@distance", vis.distance));
                    cmd.Parameters.Add(new SqlParameter("@admin_remarks", vis.admin_remarks));
                    cmd.Parameters.Add(new SqlParameter("@allocation_Status", vis.allocation_Status));
                    cmd.Parameters.Add(new SqlParameter("@pickup_date", vis.pickup_date));
                    cmd.Parameters.Add(new SqlParameter("@pickup_time", vis.pickup_time));
                    cmd.Parameters.Add(new SqlParameter("@pickup_place", vis.pickup_place));
                    cmd.Parameters.Add(new SqlParameter("@destination", vis.destination));
                    cmd.Parameters.Add(new SqlParameter("@no_of_passengers", vis.no_of_passengers));

                    cmd.Parameters.Add(new SqlParameter("@reportingOfficerCode", vis.reportingOfficerCode));
                    cmd.Parameters.Add(new SqlParameter("@reportingOfficerName", vis.reportingOfficerName));
                    cmd.Parameters.Add(new SqlParameter("@requesterEmpName", vis.requesterEmpName));
                    cmd.Parameters.Add(new SqlParameter("@travelPurpose", vis.travelPurpose));
                    cmd.Parameters.Add(new SqlParameter("@allocationType", vis.allocationType));
                    cmd.Parameters.Add(new SqlParameter("@clubbedRequestId", vis.clubbedRequestId));

                    cmd.Parameters.Add(new SqlParameter("@driverType", vis.driverType));
                    cmd.Parameters.Add(new SqlParameter("@companyName", vis.companyName));
                    cmd.Parameters.Add(new SqlParameter("@kmRate", vis.kmRate));
                    cmd.Parameters.Add(new SqlParameter("@totalFare", vis.totalFare));



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
