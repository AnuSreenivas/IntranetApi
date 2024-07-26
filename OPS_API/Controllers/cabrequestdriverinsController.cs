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
using INIT.API.Kathirmandapam.Class;


namespace OPS_API.Controllers
{
    public class cabrequestdriverinsController : ApiController
    {
        [HttpGet]
        public cabrequestdriverinsClass[] cabrequestdriverinsClass1(string drivername, string phoneno)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_cab_request_driver_ins", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@drivername", drivername));
                    cmd.Parameters.Add(new SqlParameter("@phoneno", phoneno));
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







        //[HttpPost]
        //public visitorinsClass[] visitorinsClass1(ImageGallery vis)
        //{
        //    try
        //    {
        //        string filePath = "";
        //        string filenamenew = "";
        //        filePath = HttpContext.Current.Server.MapPath("~/assets/AVTGallery/");
        //        string convert = vis.FileDetails.Replace("data:image/jpeg;base64,", String.Empty);

        //        byte[] image64 = Convert.FromBase64String(convert);

        //        string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
        //        SqlConnection con = new SqlConnection(cs);
        //        using (con)
        //        {
        //            SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_Gallery_image_ins", con);
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.Parameters.Add(new SqlParameter("@Id", vis.Id));

        //            cmd.Parameters.Add(new SqlParameter("@caption", vis.Caption));
        //            cmd.Parameters.Add(new SqlParameter("@filedetails", vis.FileDetails));
        //            con.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();
        //            //cmd.ExecuteScalar();

        //            List<visitorinsClass> arrayofArray = new List<visitorinsClass>();
        //            visitorinsClass objArray;
        //            //int i = 0;
        //            while (reader.Read())
        //            {
        //                objArray = new visitorinsClass(Convert.ToString(reader[0]), Convert.ToString(reader[1]));
        //                filenamenew = Convert.ToString(reader[1]);
        //                arrayofArray.Add(objArray);
        //                //i++;
        //            }
        //            File.WriteAllBytes(filePath + vis.Caption.Trim() + ".jpg", image64);
        //            return arrayofArray.ToArray();



        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        string err = e.Message;
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append(err);
        //        File.AppendAllText(HttpContext.Current.Server.MapPath("~/") + "update.txt", sb.ToString());
        //        sb.Clear();
        //        return null;
        //    }

        //}




        [HttpPost]
        public InsertReturn InsertGallery(ImageGallery o)
        {
            try
            {
                string filePath = HttpContext.Current.Server.MapPath("~/assets/AVTGallery/");
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..spInsertImages", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 120;

                    // Create a DataTable to hold the images
                    var table = new DataTable();
                    table.Columns.Add("GalleryId", typeof (int));
                    table.Columns.Add("FileDetails", typeof(string));

                    for (int j = 0; j < o.Images.Count; j++)
                    {
                        // Remove base64 prefix if needed
                        string convert = o.Images[j].FileDetails.Replace("data:image/jpeg;base64,", String.Empty);
                        table.Rows.Add(0,convert);
                       // table.Rows.Add(o.UserRights[j].UserId, o.UserRights[j].PageId);
                    }

                    // Add other parameters
                    cmd.Parameters.Add(new SqlParameter("@Id", o.Id));
                    cmd.Parameters.Add(new SqlParameter("@caption", o.Caption));
                    cmd.Parameters.Add(new SqlParameter("@images", table));

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    InsertReturn insertReturn = new InsertReturn();

                    if (reader.Read())
                    {
                        insertReturn = new InsertReturn(Convert.ToInt32(reader[0]), Convert.ToInt32(reader[1]));
                    }

                    // Save each image file
                    for (int j = 0; j < o.Images.Count; j++)
                    {
                        string convert = o.Images[j].FileDetails.Replace("data:image/jpeg;base64,", String.Empty);
                        byte[] image64 = Convert.FromBase64String(convert);
                        File.WriteAllBytes(filePath + o.Caption.Trim() + "_" + j + ".jpg", image64);
                    }

                    return insertReturn;
                }
            }
            catch (Exception ex)
            {
                string val = ex.Message;
                return null;
            }
        }
        //delete gallery

        [HttpGet]
        public InsertReturn DeleteGallery(int DeleteId)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_Delete_Gallery_Images", con);
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






        //GetImageGallery
        [HttpGet]
        public Gallery[] GalleryClass1()
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["avt_data2"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("HCMDB..avt_sp_GetGalleryImages", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    //cmd.ExecuteScalar();

                    List<Gallery> arrayofArray = new List<Gallery>();
                    Gallery objArray;
                    //int i = 0;
                    while (reader.Read())
                    {
                        objArray = new Gallery(Convert.ToInt32(reader[0]), Convert.ToString(reader[1]), Convert.ToString(reader[2]));
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

        //GetImageGallery







    }


}

