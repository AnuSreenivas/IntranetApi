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
    public class einvoiceresponseController : ApiController
    {
        [HttpPost]
        public List<GstresponseClass> InsetEInvoiceReponse(GstInvoice eInv)
        {
             try
            {
                DataTable dt = new DataTable();
                //Add Columns
                dt.Columns.Add("ID");
                dt.Columns.Add("Product");
                dt.Columns.Add("Description");
                //Add rows
                dt.Rows.Add("7J9P", "Soda", "2000ml bottle");

                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("shp..avt_einvoice_postdata_return", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Status", eInv.status));
                    cmd.Parameters.Add(new SqlParameter("@Irnnumber", eInv.data.irn.data.irn));
                    cmd.Parameters.Add(new SqlParameter("@ackno", eInv.data.irn.data.ack_no));
                    cmd.Parameters.Add(new SqlParameter("@ackdate", DateTime.ParseExact( eInv.data.irn.data.ack_dt,"dd/MM/yyyy HH:mm:ss",null)));
                    cmd.Parameters.Add(new SqlParameter("@signedinv", eInv.data.irn.data.signed_invoice));
                    cmd.Parameters.Add(new SqlParameter("@signedqrcode", eInv.data.irn.data.signed_qrcode));
                    cmd.Parameters.Add(new SqlParameter("@docno", eInv.docno));
                    cmd.Parameters.Add(new SqlParameter("@doctype", eInv.document_type));
                    cmd.Parameters.Add(new SqlParameter("@response", JsonConvert.SerializeObject(eInv)));
                   
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<GstresponseClass> arrayofArray = new List<GstresponseClass>();
                    GstresponseClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new GstresponseClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToDateTime(reader[4]));
                        arrayofArray.Add(objArray);
                        //i++;
                    }
                    return arrayofArray.ToList();//"Success";
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

    