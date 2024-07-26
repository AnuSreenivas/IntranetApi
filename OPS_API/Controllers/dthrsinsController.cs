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

namespace OPS_API.Controllers
{
    public class dthrsinsController : ApiController
    {
        [HttpGet]
        public retaininsClass[] retaininsClass1(string pono, string itemcode, string itemname, string puname, string prddate, string remarks,string dtcode, string dtdesc, double dthrs, string userid, string uuid, string manuf)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_downtime_hrs_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@pono", pono));
                    cmd.Parameters.Add(new SqlParameter("@itemcode", itemcode));
                    cmd.Parameters.Add(new SqlParameter("@itemname", itemname));
                    cmd.Parameters.Add(new SqlParameter("@puname", puname));
                    cmd.Parameters.Add(new SqlParameter("@prddate", prddate));
                    cmd.Parameters.Add(new SqlParameter("@remarks", remarks));
                    cmd.Parameters.Add(new SqlParameter("@dtcode", dtcode));
                    cmd.Parameters.Add(new SqlParameter("@dtdesc", dtdesc));
                    cmd.Parameters.Add(new SqlParameter("@dthrs", dthrs));

                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    cmd.Parameters.Add(new SqlParameter("@uuid", uuid));
                    cmd.Parameters.Add(new SqlParameter("@manuf", manuf));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<retaininsClass> arrayofArray = new List<retaininsClass>();
                    retaininsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new retaininsClass(Convert.ToString(reader[0]));
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