﻿using OPS_API.Class;
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
    public class loantbController : ApiController
    {
        [HttpGet]
        public loantbClass[] loantbClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_loan_TrialBalance_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<loantbClass> arrayofArray = new List<loantbClass>();
                    loantbClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new loantbClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToDouble(reader[2]));
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