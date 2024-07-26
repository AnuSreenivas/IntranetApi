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
    public class employeesupervisormapController : ApiController
    {
        [HttpGet]
        public employeesuperviormapClass[] employeesuperviormapClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_superivor_list", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.Add(new SqlParameter("@drivername", drivername));
                    //cmd.Parameters.Add(new SqlParameter("@phoneno", phoneno));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<employeesuperviormapClass> arrayofArray = new List<employeesuperviormapClass>();
                    employeesuperviormapClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new employeesuperviormapClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]));
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
        public EmployeeSupervisor[] EmployeeSupervisor1(string emp_code,string emp_name,string sup_code,string sup_name,string hod_code,string hod_name,string dept_name)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_insert_navt_tbl_jd_auth_mst", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@emp_code", emp_code));
                    cmd.Parameters.Add(new SqlParameter("@emp_name", emp_name));
                    cmd.Parameters.Add(new SqlParameter("@sup_code", sup_code));
                    cmd.Parameters.Add(new SqlParameter("@sup_name", sup_name));
                    cmd.Parameters.Add(new SqlParameter("@hod_code", hod_code));
                    cmd.Parameters.Add(new SqlParameter("@hod_name", hod_name));
                    cmd.Parameters.Add(new SqlParameter("@dept_name", dept_name));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();


                    List<EmployeeSupervisor> arrayofArray = new List<EmployeeSupervisor>();
                    EmployeeSupervisor objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new EmployeeSupervisor(Convert.ToString(reader[0]));
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


