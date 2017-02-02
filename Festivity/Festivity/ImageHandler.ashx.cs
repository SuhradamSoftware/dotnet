using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Services;
using BussinessLogic;
using BussinessObject;
using DataAccess;

namespace Festivity
{
    /// <summary>
    /// Summary description for $codebehindclassname$
    /// </summary>
    [WebService(Namespace = "http://festivity.suhradamsoft.in/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class ImageHandler : IHttpHandler
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();
        string strcon = ConfigurationManager.AppSettings["ConnectionString"].ToString();
        public void ProcessRequest(HttpContext context)
        {
            Int32 theID;
            if (context.Request.QueryString["ID"] != null)
                theID = Convert.ToInt32(context.Request.QueryString["ID"]);
            else
                throw new ArgumentException("No parameter specified");

            HttpResponse r = context.Response;
            r.ContentType = "image/jpeg";
            context.Response.ContentType = "image/jpeg";

            objBussinessObj.ID = theID;
            Stream strm = objBussinessLogic.SelectImageByID(theID);
            byte[] buffer = new byte[2048];

            if (strm != null)
            {
                int byteSeq = strm.Read(buffer, 0, 2048);
                while (byteSeq > 0)
                {
                    context.Response.OutputStream.Write(buffer, 0, byteSeq);
                    byteSeq = strm.Read(buffer, 0, 2048);
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}