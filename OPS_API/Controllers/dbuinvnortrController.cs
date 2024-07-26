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
    public class dbuinvnortrController : ApiController
    {
      
            [HttpGet]
            public einvoicenortrClass[] einvoicenortrClass1()
            {
                try
                {
                    string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                    SqlConnection con = new SqlConnection(cs);
                    using (con)
                    {
                        SqlCommand cmd = new SqlCommand("ARDB..avt_DBUInvoice_combo", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        // cmd.Parameters.Add(new SqlParameter("@lab", lab));
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        //cmd.ExecuteScalar();

                        List<einvoicenortrClass> arrayofArray = new List<einvoicenortrClass>();
                        einvoicenortrClass objArray;
                        //int i = 0;
                        while (reader.Read())
                        {
                            objArray = new einvoicenortrClass(Convert.ToString(reader[0]));
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

