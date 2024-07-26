using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.Http;


namespace OPS_API.Controllers
{
    public class weighbridgertrController : ApiController
    {
        [HttpGet]
        public dynamic ReadWeightBridge()
        {
            string Ip = "10.1.248.207";
            int Port = 3002;

            string filePath = HttpContext.Current.Server.MapPath("~/assets/Log/");
            if (Directory.Exists(filePath) == false)
            {
                DirectoryInfo di = Directory.CreateDirectory(filePath);
            }
            try
            {
                using (TcpClient client = new TcpClient(Ip, Port))
                {
                    NetworkStream stream = client.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    if (data != null)
                    {

                        using (StreamWriter writer = new StreamWriter(filePath + "\\" + "log.txt", true))
                        {
                            writer.WriteLine("Systime : " + DateTime.Now.ToString() + " " + data);
                        }
                        return data;

                    }
                    else
                    {
                        using (StreamWriter writer = new StreamWriter(filePath + "\\" + "log.txt", true))
                        {
                            writer.WriteLine("Systime : " + DateTime.Now.ToString() + " " + "Data not received");
                        }
                        return Json(new
                        {
                            status = 300,
                            message = "Data not received"
                        });
                    }
                }
            }
            catch (Exception ex)
            {

                using (StreamWriter writer = new StreamWriter(filePath + "\\" + "log.txt", true))
                {
                    writer.WriteLine("Systime : " + DateTime.Now.ToString() + " " + ex.Message);
                }
                return Json(new
                {
                    status = 400,
                    message = ex.Message
                });
            }

        }

    }
}