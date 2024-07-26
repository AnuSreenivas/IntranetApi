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
    public class weighmentinsController : ApiController
    {
        [HttpGet]

        public bilablotinsClass[] bilablotinsClass1(string refno,string vehicleno,string companycode,string vehicletype,string weighmenttype,double weighedqty,string gatepassno,double emptyweight,double loadedweight,string gatepassitems,double gatepassqty,string userid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_weightment_details_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@refno", refno));
                    cmd.Parameters.Add(new SqlParameter("@vehicleno", vehicleno));
                    cmd.Parameters.Add(new SqlParameter("@companycode", companycode));
                    cmd.Parameters.Add(new SqlParameter("@vehicletype", vehicletype));
                    cmd.Parameters.Add(new SqlParameter("@weighmenttype", weighmenttype));
                    cmd.Parameters.Add(new SqlParameter("@weighedqty", weighedqty));
                    cmd.Parameters.Add(new SqlParameter("@gatepassno", gatepassno));
                    cmd.Parameters.Add(new SqlParameter("@emptyweight", emptyweight));
                    cmd.Parameters.Add(new SqlParameter("@loadedweight", loadedweight));
                    cmd.Parameters.Add(new SqlParameter("@gatepassitems", gatepassitems));
                    cmd.Parameters.Add(new SqlParameter("@gatepassqty", gatepassqty));
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    



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