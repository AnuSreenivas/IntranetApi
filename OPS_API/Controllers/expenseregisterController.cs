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
    public class expenseregisterController : ApiController
    {
        [HttpGet]
        public ExpenseregisterClass[] ExpenseregisterClass1(string FinYear, string FinPeriod)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_expense_state_Trial_Balance_with_Dril", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@FinYear", FinYear));
                    cmd.Parameters.Add(new SqlParameter("@FinPeriod", FinPeriod));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<ExpenseregisterClass> arrayofArray = new List<ExpenseregisterClass>();
                    ExpenseregisterClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new ExpenseregisterClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]), Convert.ToDouble(reader[2]), Convert.ToDouble(reader[3]));
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