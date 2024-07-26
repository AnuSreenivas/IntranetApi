﻿using System;
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
    public class office126comboController : ApiController
    {
        [HttpGet]
        public office126comboClass[] office126comboClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_126_visit_ref_combo", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@item_code", itemcode));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<office126comboClass> arrayofArray = new List<office126comboClass>();
                    office126comboClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new office126comboClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToDateTime(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]));
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