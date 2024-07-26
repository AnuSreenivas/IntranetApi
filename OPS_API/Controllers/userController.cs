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
    public class userController : ApiController
    {
        [HttpPost]
        public csinsertreturn InsertUser(csuserClass usr)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["AVT_DATA"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snm..avt_ion_insert_usersrights", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@userid", usr.userid));
                    cmd.Parameters.Add(new SqlParameter("@username", usr.username));
                    cmd.Parameters.Add(new SqlParameter("@password", usr.userpassword));
                    cmd.Parameters.Add(new SqlParameter("@rights", usr.rights));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    csinsertreturn obj = new csinsertreturn(0, 0);
                    while (reader.Read())
                    {
                        obj = new csinsertreturn(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]));
                        //i++;
                    }
                    return obj;
                }
            }
            catch (Exception ex)
            {
                string val = ex.Message;
                return null;
            }
        }

        [HttpGet]
        public cspagesclass[] GetAllPages(int val)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snm..avt_ion_pagelst", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<cspagesclass> arrayofArray = new List<cspagesclass>();
                    cspagesclass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new cspagesclass(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]));
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
        public csuserClass[] GetAllUsers()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snm..avt_ion_userlst", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<csuserClass> arrayofArray = new List<csuserClass>();
                    csuserClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new csuserClass(Convert.ToInt16(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]));
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
        public int[] getuserrights(int userid)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snm..avt_ion_userrightslst", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<int> arrayofArray = new List<int>();
                    while (reader.Read())
                    {
                        arrayofArray.Add(Convert.ToInt32(reader[0]));

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
        public csuserClass userlogin(string username, string password)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("snm..avt_ion_userlogin_dtls", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@username", username));
                    cmd.Parameters.Add(new SqlParameter("@password", password));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    csuserClass obj = new csuserClass(0,"", "");
                    while (reader.Read())
                    {
                        obj = new csuserClass(Convert.ToInt32 (reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]));

                    }
                    return obj;
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
