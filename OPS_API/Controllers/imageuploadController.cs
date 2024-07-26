using INIT.API.Kathirmandapam.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OPS_API.Controllers
{
    public class imageuploadController : ApiController
    {
        //[HttpPost]
        //public int UploadProfileImage(UserProfile up)
        //{
        //    try
        //    {
        //        if (!String.IsNullOrEmpty(up.ProfileImage))
        //        {
        //            if (up.ProfileImage.Length > 1)
        //            {
        //                Utils.SaveImage("~/assets/img/ProfileImages/" + up.UserId.ToString() + ".jpg", up.ProfileImage);
        //                string imageurl = up.UserId.ToString() + ".jpg" + "" + "?timeStamp=" + DateTime.Now.ToString();
        //                et.spUpdateUserImageUrl(imageurl, up.UserId);
        //            }

        //        }
        //        return 1;
        //    }
        //    catch (Exception e)
        //    {
        //        string err = e.Message;
        //        return 0;
        //    }
        //}
    }
}