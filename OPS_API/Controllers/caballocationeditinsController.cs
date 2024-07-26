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
using Newtonsoft.Json;
using OPS_API.Class;
using System.IO;
using System.Text;
using System.Web;
using System.Globalization;

namespace OPS_API.Controllers
{
    public class caballocationeditinsController : ApiController
    {
     [HttpGet]
        public cabrequestdriverinsClass[] cabrequestdriverinsClass1(string allocationid,string driver_name, string driver_phone,string vehicle_no,string vehicle_type, int distance,string editedBy,float kmRate,float totalFare,string companyName)
        {

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_allocation_edit_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.Add(new SqlParameter("@allocationid", allocationid));
                    cmd.Parameters.Add(new SqlParameter("@driver_name", driver_name));
                    cmd.Parameters.Add(new SqlParameter("@driver_phone", driver_phone));
                    cmd.Parameters.Add(new SqlParameter("@vehicle_no", vehicle_no));
                    cmd.Parameters.Add(new SqlParameter("@vehicle_type", vehicle_type));
                    cmd.Parameters.Add(new SqlParameter("@distance", distance));
                    cmd.Parameters.Add(new SqlParameter("@editedBy", editedBy));
                    cmd.Parameters.Add(new SqlParameter("@kmRate", kmRate));
                    cmd.Parameters.Add(new SqlParameter("@totalFare",totalFare));
                    cmd.Parameters.Add(new SqlParameter("@companyName",companyName));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestdriverinsClass> arrayofArray = new List<cabrequestdriverinsClass>();
                    cabrequestdriverinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestdriverinsClass(Convert.ToString(reader[0]));
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

        [HttpGet]
        public cabrequestdriverinsClass[] cabrequestdriveriTariffClass1(float tariffRate)
        {

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_TariffRate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@tariffRate", tariffRate));
                   

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cabrequestdriverinsClass> arrayofArray = new List<cabrequestdriverinsClass>();
                    cabrequestdriverinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cabrequestdriverinsClass(Convert.ToString(reader[0]));
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

