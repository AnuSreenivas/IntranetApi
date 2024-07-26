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
    public class bl2farmerinsController : ApiController
    {
        [HttpGet]
        public sampleinsClass[] sampleinsClass1(string FarmerCode, string AreaCode, string FarmerName, string FathersName,
        string Gender, string DOB, string AadharNo, string Country, string Farmer_State, string District, string Taluk,
        string Village, string Education, string Maritalstatus, string MobileNo,
        //    string Accounttype, string AccountNo,
        //string BankName, string BranchName, string IFSCCode, 
            string userid, string uuid, string manuf, string latitude, string longitude,
            string agrvendorcode, string agrvendorname)
          
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data1"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("AVTFarm..avt_bi_BL2_farmermst_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FarmerCode", FarmerCode));
                    cmd.Parameters.Add(new SqlParameter("@AreaCode", AreaCode));
                    cmd.Parameters.Add(new SqlParameter("@FarmerName", FarmerName));
                    cmd.Parameters.Add(new SqlParameter("@FathersName", FathersName));
                    cmd.Parameters.Add(new SqlParameter("@Gender", Gender));
                    cmd.Parameters.Add(new SqlParameter("@DOB", DOB));
                    cmd.Parameters.Add(new SqlParameter("@AadharNo", AadharNo));
                    cmd.Parameters.Add(new SqlParameter("@Country", Country));
                    cmd.Parameters.Add(new SqlParameter("@Farmer_State", Farmer_State));
                    cmd.Parameters.Add(new SqlParameter("@District", District));
                    cmd.Parameters.Add(new SqlParameter("@Taluk", Taluk));

                    cmd.Parameters.Add(new SqlParameter("@Village", Village));
                    cmd.Parameters.Add(new SqlParameter("@Education", Education));
                    cmd.Parameters.Add(new SqlParameter("@Maritalstatus", Maritalstatus));
                    cmd.Parameters.Add(new SqlParameter("@MobileNo", MobileNo));
                
                    //cmd.Parameters.Add(new SqlParameter("@Accounttype", Accounttype));
                    //cmd.Parameters.Add(new SqlParameter("@AccountNo", AccountNo));
                    //cmd.Parameters.Add(new SqlParameter("@BankName", BankName));
                    //cmd.Parameters.Add(new SqlParameter("@BranchName", BranchName));
                    //cmd.Parameters.Add(new SqlParameter("@IFSCCode", IFSCCode));

                    cmd.Parameters.Add(new SqlParameter("@userid", userid));
                    cmd.Parameters.Add(new SqlParameter("@uuid", uuid));
                    cmd.Parameters.Add(new SqlParameter("@manuf", manuf));
                    cmd.Parameters.Add(new SqlParameter("@latitude", latitude));
                    cmd.Parameters.Add(new SqlParameter("@longitude", longitude));

                    cmd.Parameters.Add(new SqlParameter("@agrvendorcode", agrvendorcode));
                    cmd.Parameters.Add(new SqlParameter("@agrvendorname", agrvendorname));


                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<sampleinsClass> arrayofArray = new List<sampleinsClass>();
                    sampleinsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new sampleinsClass(Convert.ToString(reader[0]));
                        arrayofArray.Add(objArray);
                        if (arrayofArray[0].lotno == "hello")
                        {

                        }
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