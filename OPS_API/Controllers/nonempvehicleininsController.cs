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
    public class nonempvehicleininsController : ApiController
    {
        [HttpGet]

        public retaininsClass[] retaininsClass1(string vehicleno, string vehicletype, string drivername, string hostcompany, string purpose,   string remarks, string userid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_nonemp_vehicle_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@vehicleno", vehicleno));
                    cmd.Parameters.Add(new SqlParameter("@vehicletype", vehicletype));
                    cmd.Parameters.Add(new SqlParameter("@drivername", drivername));
                    cmd.Parameters.Add(new SqlParameter("@hostcompany", hostcompany));
                    cmd.Parameters.Add(new SqlParameter("@purpose", purpose));
                    cmd.Parameters.Add(new SqlParameter("@remarks", remarks));
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
         
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