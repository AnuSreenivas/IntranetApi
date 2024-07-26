using Newtonsoft.Json;
using OPS_API.Class;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace OPS_API.Controllers
{
    public class auditfarminsController : ApiController
    {
        [HttpPost]
        //public bipbinsClass[] bipbinsClass1(string prinvno, string tolocation, string lorryno, string ewaybillno, DateTime ewaybilldate, double ewaybillamt, string transferedby, string receivedby, string pbno, string areacode, string fcode, string fname, string lotno, double nobags, double qty, double rate, double amount, string userid, string uuid, string manuf, string latitude, string longitude)
        public bipbinsClass[] bipbinsClass1(audithdrClass audit)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(JsonConvert.SerializeObject(audit));
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "dat.txt", sb.ToString());
                sb.Clear();
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                var table = new DataTable();
                table.Columns.Add("audittag", typeof(string));
                table.Columns.Add("farmlatitude", typeof(double));
                table.Columns.Add("farmlongitude", typeof(double));
               
                if (audit.auditdtlClassList != null)
                {
                    for (int i = 0; i < audit.auditdtlClassList.Count; i++)
                    {
                        table.Rows.Add(audit.auditdtlClassList[i].audittag, audit.auditdtlClassList[i].farmlatitude, audit.auditdtlClassList[i].farmlongitude);
                    }
                }
                
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("avtfarm..avt_bi_farm_audit_tag_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    string uuid="";
                    string manuf = "";
                   
                    if (!String.IsNullOrEmpty(audit.uuid)) {uuid=audit.uuid;}
                    cmd.Parameters.Add(new SqlParameter("@areacode", audit.areacode));
                    cmd.Parameters.Add(new SqlParameter("@areaname", audit.areaname));
                    cmd.Parameters.Add(new SqlParameter("@farmercode", audit.farmercode));
                    cmd.Parameters.Add(new SqlParameter("@farmername", audit.farmername));
                    cmd.Parameters.Add(new SqlParameter("@farmname", audit.farmname));
                    cmd.Parameters.Add(new SqlParameter("@acre", audit.acre));
                    cmd.Parameters.Add(new SqlParameter("@hectre", audit.hectre));
                    cmd.Parameters.Add(new SqlParameter("@sqmtr", audit.sqmtr));

                    cmd.Parameters.Add(new SqlParameter("@userid", audit.userid));
                    cmd.Parameters.Add(new SqlParameter("@uuid", audit.uuid)); 
                    cmd.Parameters.Add(new SqlParameter("@manuf", audit.manuf));
                    cmd.Parameters.Add(new SqlParameter("@latitude", audit.latitude));
                    cmd.Parameters.Add(new SqlParameter("@longitude", audit.longitude));

                    cmd.Parameters.Add(new SqlParameter("@avt_farm_aud_list", table));
                    con.Open();                           
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bipbinsClass> arrayofArray = new List<bipbinsClass>();
                    bipbinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bipbinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]));
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message +e.InnerException;
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "log.txt", sb.ToString());
                sb.Clear();
                return null;
            }

        }
    }
}
