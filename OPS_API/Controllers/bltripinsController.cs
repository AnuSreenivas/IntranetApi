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
    public class bltripinsController : ApiController
    {
        [HttpPost]
        //public bipbinsClass[] bipbinsClass1(string prinvno, string tolocation, string lorryno, string ewaybillno, DateTime ewaybilldate, double ewaybillamt, string transferedby, string receivedby, string pbno, string areacode, string fcode, string fname, string lotno, double nobags, double qty, double rate, double amount, string userid, string uuid, string manuf, string latitude, string longitude)
        public bitripinsClass[] bitripinsClass1(bltriphdrClass prd)
        {
            try
            {
                //StringBuilder sb = new StringBuilder();
                //sb.Append(JsonConvert.SerializeObject(prd));
                //File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "dat.txt", sb.ToString());
                //sb.Clear();
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                var table = new DataTable();
                table.Columns.Add("pono", typeof(string));
                table.Columns.Add("poline", typeof(double));
                table.Columns.Add("poqty", typeof(double));
                table.Columns.Add("porate", typeof(double));
                table.Columns.Add("areacode", typeof(string));
                table.Columns.Add("fcode", typeof(string));
                table.Columns.Add("fname", typeof(string));
                table.Columns.Add("lotno", typeof(string));
                table.Columns.Add("nobags", typeof(double));
                table.Columns.Add("qty", typeof(double));
                table.Columns.Add("recbags", typeof(double));
                table.Columns.Add("recqty", typeof(double));
                table.Columns.Add("rate", typeof(double));
                table.Columns.Add("amount", typeof(double));

                for (int i = 0; i < prd.bltripdtlClassList.Count; i++)
                {
                    table.Rows.Add(prd.bltripdtlClassList[i].pono, prd.bltripdtlClassList[i].poline, prd.bltripdtlClassList[i].poqty, prd.bltripdtlClassList[i].porate, prd.bltripdtlClassList[i].areacode, prd.bltripdtlClassList[i].fcode, prd.bltripdtlClassList[i].fname, prd.bltripdtlClassList[i].lotno, prd.bltripdtlClassList[i].nobags, prd.bltripdtlClassList[i].qty, prd.bltripdtlClassList[i].recbags, prd.bltripdtlClassList[i].recqty, prd.bltripdtlClassList[i].rate, prd.bltripdtlClassList[i].amount);
                }
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("biops..avt_bi_bltrip_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tripno", prd.tripno));
                 //   cmd.Parameters.Add(new SqlParameter("@prinvno", prd.prinvno));
                    cmd.Parameters.Add(new SqlParameter("@fromlocation", prd.fromlocation));
                    cmd.Parameters.Add(new SqlParameter("@tolocation", prd.tolocation));
                    cmd.Parameters.Add(new SqlParameter("@tyredetails", prd.tyredetails));
                    cmd.Parameters.Add(new SqlParameter("@operatorname", prd.operatorname));
                    cmd.Parameters.Add(new SqlParameter("@totalbags", prd.totalbags));
                    cmd.Parameters.Add(new SqlParameter("@lorryno", prd.lorryno));
                    cmd.Parameters.Add(new SqlParameter("@ewaybillno", prd.ewaybillno));
                    // cmd.Parameters.Add(new SqlParameter("@ewaybilldate", prd.ewaybilldate));
                    cmd.Parameters.Add(new SqlParameter("@ewaybillamt", prd.ewaybillamt));
                    cmd.Parameters.Add(new SqlParameter("@transferedby", prd.transferedby));
                    //cmd.Parameters.Add(new SqlParameter("@receivedby", prd.receivedby));
                    cmd.Parameters.Add(new SqlParameter("@freightvalue", prd.freightvalue));
                    cmd.Parameters.Add(new SqlParameter("@handlingvalue", prd.handlingvalue));
                    cmd.Parameters.Add(new SqlParameter("@cessvalue", prd.cessvalue));
                   // cmd.Parameters.Add(new SqlParameter("@haltingvalue", prd.haltingvalue));
                    cmd.Parameters.Add(new SqlParameter("@othervalue", prd.othervalue));
                    //cmd.Parameters.Add(new SqlParameter("@amcrefno", prd.amcrefno));
                    //cmd.Parameters.Add(new SqlParameter("@amcdate", prd.amcdate));

                    cmd.Parameters.Add(new SqlParameter("@userid", prd.userid));
                    cmd.Parameters.Add(new SqlParameter("@uuid", prd.uuid));
                    cmd.Parameters.Add(new SqlParameter("@manuf", prd.manuf));
                    cmd.Parameters.Add(new SqlParameter("@latitude", prd.latitude));
                    cmd.Parameters.Add(new SqlParameter("@longitude", prd.longitude));

                    cmd.Parameters.Add(new SqlParameter("@avt_bi_bltrip_mst_list", table));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bitripinsClass> arrayofArray = new List<bitripinsClass>();
                    bitripinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bitripinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]));
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

