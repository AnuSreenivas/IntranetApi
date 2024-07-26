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
    public class nonempvehilcemstlistController : ApiController
    {
        [HttpGet]

        public nonempvehiclemstlistClass[] nonempvehiclemstlistClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_nonemp_vehicle_mst_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<nonempvehiclemstlistClass> arrayofArray = new List<nonempvehiclemstlistClass>();
                    nonempvehiclemstlistClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new nonempvehiclemstlistClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]));
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
