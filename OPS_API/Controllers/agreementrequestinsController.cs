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
    public class agreementrequestinsController : ApiController
    {
        [HttpPost]
        public visitorinsClass[] visitorinsClass1(agreementrequestinsClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        //visitorClass vis)
        //string category, string purpose, string employee_code, string employee_name, string company_code, string company_name, string company_address, string phoneno, string visitor_name, string vehcile_type, string vehicle_no, string country, string materials, string remarks, string userid, string manuf, string filedetails)
        {
            try
            {
                //string filePath = "";
                //string filenamenew = "";
               // filePath = HttpContext.Current.Server.MapPath("~/assets/visitor/");
               // string convert = vis.filedetails.Replace("data:image/jpeg;base64,", String.Empty);

                //byte[] image64 = Convert.FromBase64String(convert);




                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);


                using (con)
                {

                   
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_Agreement_request_Mgt_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;



                    var table = new DataTable();
                    table.Columns.Add("requestId", typeof(string));
                    table.Columns.Add("particular", typeof(string));
                    table.Columns.Add("newrate", typeof(float));
                    table.Columns.Add("old", typeof(float));
                    table.Columns.Add("difference", typeof(float));
                    table.Columns.Add("percentage", typeof(float));
                

                    for (int j = 0; j < vis.particulars.Count; j++)
                    {

                        table.Rows.Add(vis.particulars[j].requestId, vis.particulars[j].particular, vis.particulars[j].newrate, vis.particulars[j].old, vis.particulars[j].difference, vis.particulars[j].percentage);
                        
                    }



                    cmd.Parameters.Add(new SqlParameter("@modeOfRequest", vis.modeOfRequest));
                    cmd.Parameters.Add(new SqlParameter("@typeOfRequest", vis.typeOfRequest));
                    cmd.Parameters.Add(new SqlParameter("@noOfParties", vis.noOfParties));
                    cmd.Parameters.Add(new SqlParameter("@partiesNames", vis.partiesNames));
                    cmd.Parameters.Add(new SqlParameter("@valdityFrom", vis.valdityFrom)); 
                    cmd.Parameters.Add(new SqlParameter("@valdityTo", vis.valdityTo));

                    cmd.Parameters.Add(new SqlParameter("@exectionDate", vis.exectionDate));
                    cmd.Parameters.Add(new SqlParameter("@place", vis.place));
                    cmd.Parameters.Add(new SqlParameter("@stampPaper", vis.stampPaper));
                    cmd.Parameters.Add(new SqlParameter("@stampPaperState", vis.stampPaperState));
                    cmd.Parameters.Add(new SqlParameter("@stampPaperValue", vis.stampPaperValue));
                    cmd.Parameters.Add(new SqlParameter("@otherPapers", vis.otherPapers));
                    cmd.Parameters.Add(new SqlParameter("@requesterName", vis.requesterName));
                    cmd.Parameters.Add(new SqlParameter("@RequesterEmpcode", vis.RequesterEmpcode));
                    cmd.Parameters.Add(new SqlParameter("@approverName", vis.approverName));

                    cmd.Parameters.Add(new SqlParameter("@approverEmpcode", vis.approverEmpcode));
                    cmd.Parameters.Add(new SqlParameter("@synopsis", vis.synopsis));
                    cmd.Parameters.Add(new SqlParameter("@noticePeriod", vis.noticePeriod));
                    cmd.Parameters.Add(new SqlParameter("@identificationName", vis.identificationName));
                    cmd.Parameters.Add(new SqlParameter("@identificationNumber", vis.identificationNumber));
                    cmd.Parameters.Add(new SqlParameter("@agreementDocNew", vis.agreementDocNew));
                    cmd.Parameters.Add(new SqlParameter("@agreementDocDraft", vis.agreementDocDraft));
                    cmd.Parameters.Add(new SqlParameter("@statusOfRequest", vis.statusOfRequest));


                    cmd.Parameters.Add(new SqlParameter("@particulars", table));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<visitorinsClass> arrayofArray = new List<visitorinsClass>();
                    visitorinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new visitorinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
                  //      filenamenew = Convert.ToString(reader[1]);
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                   // File.WriteAllBytes(filePath + filenamenew + ".jpg", image64);
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
