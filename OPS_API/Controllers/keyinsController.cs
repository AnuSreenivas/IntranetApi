using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OPS_API.Class;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OPS_API.Controllers
{
    public class keyinsController : ApiController
    {
        [HttpGet]
        public bilablotinsClass[] bilablotinsClass1(string key_number,string keyname, string key_dept, string key_type, string key_desc, string key_in_charge, string keyInChargeDept, int no_of_keys, string remarks)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_key_master_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@key_number", key_number));
                    cmd.Parameters.Add(new SqlParameter("@keyname", keyname));
                    cmd.Parameters.Add(new SqlParameter("@key_dept", key_dept));
                    cmd.Parameters.Add(new SqlParameter("@key_type", key_type));
                    cmd.Parameters.Add(new SqlParameter("@key_desc", key_desc));
                    cmd.Parameters.Add(new SqlParameter("@key_in_charge", key_in_charge));
                    cmd.Parameters.Add(new SqlParameter("@keyInChargeDept", keyInChargeDept));
                    cmd.Parameters.Add(new SqlParameter("@no_of_keys", no_of_keys));
                    cmd.Parameters.Add(new SqlParameter("@remarks", remarks));

                    ;
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<bilablotinsClass> arrayofArray = new List<bilablotinsClass>();
                    bilablotinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new bilablotinsClass(Convert.ToString(reader[0]));
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