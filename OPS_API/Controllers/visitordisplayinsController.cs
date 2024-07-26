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
    public class visitordisplayinsController : ApiController
    {
        [HttpPost]
        //public bipbinsClass[] bipbinsClass1(string prinvno, string tolocation, string lorryno, string ewaybillno, DateTime ewaybilldate, double ewaybillamt, string transferedby, string receivedby, string pbno, string areacode, string fcode, string fname, string lotno, double nobags, double qty, double rate, double amount, string userid, string uuid, string manuf, string latitude, string longitude)
        public visitordisplayinsClass[] visitordisplayinsClass1(VisitorDisplayClass prd)
        {
            try
            {
                //StringBuilder sb = new StringBuilder();
                //sb.Append(JsonConvert.SerializeObject(prd));
                //File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "dat.txt", sb.ToString());
                //sb.Clear();
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                var table = new DataTable();

                table.Columns.Add("slno", typeof(int));
                table.Columns.Add("visitorname", typeof(string));
                table.Columns.Add("companyname", typeof(string));
                table.Columns.Add("designation", typeof(string));

                for (int i = 0; i < prd.visitordisplaydtlClassList.Count; i++)
                {
                    table.Rows.Add(prd.visitordisplaydtlClassList[i].slno, prd.visitordisplaydtlClassList[i].visitorname, prd.visitordisplaydtlClassList[i].companyname, prd.visitordisplaydtlClassList[i].designation);
                }
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_visitor_display_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@fromdate", prd.fromdate));
                    cmd.Parameters.Add(new SqlParameter("@todate", prd.todate));
                    cmd.Parameters.Add(new SqlParameter("@empcode", prd.empcode));
                    cmd.Parameters.Add(new SqlParameter("@empname", prd.empname));
                    cmd.Parameters.Add(new SqlParameter("@userid", prd.userid));

                    cmd.Parameters.Add(new SqlParameter("@avt_visit_dtls_mst", table));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<visitordisplayinsClass> arrayofArray = new List<visitordisplayinsClass>();
                    visitordisplayinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new visitordisplayinsClass(Convert.ToString(reader[0]));
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "log.txt", sb.ToString());
                sb.Clear();
                return null;
            }

        }
    }
}

