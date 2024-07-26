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
    public class getdbuinvdtlsController : ApiController
    {
        [HttpGet]
        public getdbuinvdtlsClass[] getdbuinvdtlsClass1(string invoiceno)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("ardb..avt_DBUTax_invoice_rpt_GST_Einv", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@invoice_no", invoiceno));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<getdbuinvdtlsClass> arrayofArray = new List<getdbuinvdtlsClass>();
                    getdbuinvdtlsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new getdbuinvdtlsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]), Convert.ToString(reader[10]), Convert.ToString(reader[11]), Convert.ToDateTime(reader[12])
                        , Convert.ToString(reader[13]), Convert.ToDouble(reader[14]), Convert.ToString(reader[15]), Convert.ToString(reader[16]), Convert.ToString(reader[17]), Convert.ToDouble(reader[18]), Convert.ToString(reader[19]), Convert.ToString(reader[20]),
                         Convert.ToDateTime(reader[21])//);
                        , Convert.ToString(reader[22]), Convert.ToString(reader[23]), Convert.ToString(reader[24]), Convert.ToString(reader[25]), Convert.ToString(reader[26]), 
                        Convert.ToString(reader[27]), Convert.ToString(reader[28]), Convert.ToString(reader[29]), Convert.ToString(reader[30]), Convert.ToString(reader[31]), 
                        Convert.ToString(reader[32]), Convert.ToString(reader[33]), Convert.ToString(reader[34]), Convert.ToString(reader[35]), Convert.ToString(reader[36]),
                        Convert.ToString(reader[37]), Convert.ToString(reader[38]), Convert.ToString(reader[39]), Convert.ToString(reader[40]), Convert.ToString(reader[41]),
                        Convert.ToString(reader[42]), Convert.ToString(reader[43]), Convert.ToString(reader[44]), Convert.ToString(reader[45]), Convert.ToString(reader[46])
                      
                        , Convert.ToString(reader[47]), Convert.ToString(reader[48]), Convert.ToDouble(reader[49]), Convert.ToString(reader[50]), Convert.ToDouble(reader[51]), 
                       Convert.ToDouble(reader[52]), Convert.ToDouble(reader[53]),

                       Convert.ToString(reader[54]), Convert.ToDouble(reader[55])
                        , Convert.ToDouble(reader[56]), Convert.ToDouble(reader[57]), Convert.ToDouble(reader[58]),
                        Convert.ToDouble(reader[59]), Convert.ToDouble(reader[60]), Convert.ToDouble(reader[61]), Convert.ToDouble(reader[62]), Convert.ToDouble(reader[63]), 
                        Convert.ToDouble(reader[64]), Convert.ToDouble(reader[65]), Convert.ToDouble(reader[66])//);

                        , Convert.ToDouble(reader[67]), Convert.ToDouble(reader[68]),
                        Convert.ToDouble(reader[69]), Convert.ToDouble(reader[70]), Convert.ToDouble(reader[71]), Convert.ToDouble(reader[72]), Convert.ToDouble(reader[73]), 
                        Convert.ToDouble(reader[74]), Convert.ToString(reader[75]), Convert.ToString(reader[76]), Convert.ToString(reader[77]), Convert.ToString(reader[78]),
                        Convert.ToString(reader[79]), Convert.ToString(reader[80]),//);
                         Convert.ToDateTime(reader[81]), Convert.ToString(reader[82]), Convert.ToString(reader[83]));
                        
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
