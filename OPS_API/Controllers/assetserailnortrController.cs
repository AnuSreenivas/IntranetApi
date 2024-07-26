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
    public class assetserailnortrController : ApiController
    {
        [HttpGet]
        public assetserialnortrClass[] assetserialnortrClass1(string reftype)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_asset_serial_no_rtr", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@reftype", reftype));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<assetserialnortrClass> arrayofArray = new List<assetserialnortrClass>();
                    assetserialnortrClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new assetserialnortrClass(Convert.ToInt16(reader[0]));
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



