using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OPS_API.Class;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.IO;

namespace OPS_API.Controllers
{
    public class candidatepositioninsController : ApiController
    {
        [HttpGet]
        public candidatepositioninsClass[] candidatepositioninsClass1(string position_name,string position_level,string dept_code,string dept_name ,string job_description,string pos_remarks )
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {

                    SqlCommand cmd = new SqlCommand("HCMDB..avt_spl_position_mst_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@position_name", position_name));
                    cmd.Parameters.Add(new SqlParameter("@position_level", position_level));
                    cmd.Parameters.Add(new SqlParameter("@dept_code", dept_code));
                    cmd.Parameters.Add(new SqlParameter("@dept_name", dept_name));
                    cmd.Parameters.Add(new SqlParameter("@job_description", job_description));
                    cmd.Parameters.Add(new SqlParameter("@pos_remarks", pos_remarks));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<candidatepositioninsClass> arrayofArray = new List<candidatepositioninsClass>();
                    candidatepositioninsClass objArray;
                    //int i = 0;
                    while (reader.Read())
                    {

                        objArray = new candidatepositioninsClass(Convert.ToString(reader[0]));
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






        //news and events




        [HttpPost]
        public newsAndEventsIn[] newsAndEventsInClass1(newsAndEvents vis)
        {
            try
            {
                string filePath = HttpContext.Current.Server.MapPath("~/assets/NewsAndEvents/");

                // Initialize byte arrays for images
                byte[] image1Data = null;
                byte[] image2Data = null;
                byte[] image3Data = null;
                byte[] image4Data = null;
                byte[] image5Data = null;

                // Decode base64 images if they are provided
                if (!string.IsNullOrEmpty(vis.images.image1))
                {
                    string imageData1 = vis.images.image1.Replace("data:image/jpeg;base64,", String.Empty);
                    image1Data = Convert.FromBase64String(imageData1);
                }
                if (!string.IsNullOrEmpty(vis.images.image2))
                {
                    string imageData2 = vis.images.image2.Replace("data:image/jpeg;base64,", String.Empty);
                    image2Data = Convert.FromBase64String(imageData2);
                }
                if (!string.IsNullOrEmpty(vis.images.image3))
                {
                    string imageData3 = vis.images.image3.Replace("data:image/jpeg;base64,", String.Empty);
                    image3Data = Convert.FromBase64String(imageData3);
                }
                if (!string.IsNullOrEmpty(vis.images.image4))
                {
                    string imageData4 = vis.images.image4.Replace("data:image/jpeg;base64,", String.Empty);
                    image4Data = Convert.FromBase64String(imageData4);
                }
                if (!string.IsNullOrEmpty(vis.images.image5))
                {
                    string imageData5 = vis.images.image5.Replace("data:image/jpeg;base64,", String.Empty);
                    image5Data = Convert.FromBase64String(imageData5);
                }

                // Insert data into database using stored procedure
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_insert_newsAndEvents", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@id", vis.Id));
                    cmd.Parameters.Add(new SqlParameter("@title", vis.title));
                    cmd.Parameters.Add(new SqlParameter("@subheading", vis.subHeading));
                    cmd.Parameters.Add(new SqlParameter("@content", vis.content));
                    // Pass image file paths or base64 strings to your stored procedure parameters
                    if (!string.IsNullOrEmpty(vis.images.image1))
                    {
                        cmd.Parameters.Add(new SqlParameter("@image1", filePath + vis.title.Trim() + "_image1.jpg"));

                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@image1", ""));

                    }
                    if (!string.IsNullOrEmpty(vis.images.image2))
                    {
                        cmd.Parameters.Add(new SqlParameter("@image2", filePath + vis.title.Trim() + "_image2.jpg"));

                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@image2", ""));

                    }
                    if (!string.IsNullOrEmpty(vis.images.image3))
                    {
                        cmd.Parameters.Add(new SqlParameter("@image3", filePath + vis.title.Trim() + "_image3.jpg"));

                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@image3", ""));

                    }
                    if (!string.IsNullOrEmpty(vis.images.image4))
                    {
                        cmd.Parameters.Add(new SqlParameter("@image4", filePath + vis.title.Trim() + "_image4.jpg"));

                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@image4", ""));

                    }
                    if (!string.IsNullOrEmpty(vis.images.image5))
                    {
                        cmd.Parameters.Add(new SqlParameter("@image5", filePath + vis.title.Trim() + "_image5.jpg"));

                    }
                    else
                    {
                        cmd.Parameters.Add(new SqlParameter("@image5", ""));

                    }
                    cmd.Parameters.Add(new SqlParameter("@empid", vis.empcode));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<newsAndEventsIn> arrayofArray = new List<newsAndEventsIn>();

                    while (reader.Read())
                    {
                        if (reader.FieldCount >= 2)
                        {
                            string value0 = reader.IsDBNull(0) ? null : reader.GetString(0);
                            string value1 = reader.IsDBNull(1) ? null : reader.GetString(1);
                            newsAndEventsIn objArray = new newsAndEventsIn(value0, value1);
                            arrayofArray.Add(objArray);
                        }
                    }

                    // Save images to server if they are not null
                    if (image1Data != null)
                    {
                        File.WriteAllBytes(filePath + vis.title.Trim() + "_image1.jpg", image1Data);
                    }
                    if (image2Data != null)
                    {
                        File.WriteAllBytes(filePath + vis.title.Trim() + "_image2.jpg", image2Data);
                    }
                    if (image3Data != null)
                    {
                        File.WriteAllBytes(filePath + vis.title.Trim() + "_image3.jpg", image3Data);
                    }
                    if (image4Data != null)
                    {
                        File.WriteAllBytes(filePath + vis.title.Trim() + "_image4.jpg", image4Data);
                    }
                    if (image5Data != null)
                    {
                        File.WriteAllBytes(filePath + vis.title.Trim() + "_image5.jpg", image5Data);
                    }

                    return arrayofArray.ToArray();
                }
            }
            catch (Exception e)
            {
                // Handle exceptions
                string err = e.Message;
                StringBuilder sb = new StringBuilder();
                sb.Append(err);
                File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "update.txt", sb.ToString());
                sb.Clear();
                return null;
            }
        }




        //Delete News
        [HttpGet]
        public InsertReturn DeleteGallery(int DeleteId)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_Delete_NewsAndEvents_Images", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", DeleteId));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    InsertReturn insertReturn = new InsertReturn();

                    if (reader.Read())
                    {
                        insertReturn = new InsertReturn(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]));
                    }
                    //int i = 0;
                    return insertReturn;

                }
            }
            catch (Exception e)
            {
                string err = e.Message;
                return null;
            }

        }






        [HttpGet]
        public newsAndEvents[] newsAndEventsClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..Avt_sp_Get_NewsAndEvents", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    //cmd.Parameters.Add(new SqlParameter("@username", username));
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<newsAndEvents> arrayofArray = new List<newsAndEvents>();
                    newsAndEvents objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new newsAndEvents(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]), Convert.ToString(reader[3]), Convert.ToString(reader[4]), Convert.ToString(reader[5]), Convert.ToString(reader[6]), Convert.ToString(reader[7]), Convert.ToString(reader[8]), Convert.ToString(reader[9]));
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
        //newsandevents


















    }
}
