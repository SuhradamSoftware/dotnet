using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.API.Search;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using BussinessLogic;
using BussinessObject;
using DataAccess;

namespace Festivity
{
    public partial class GetImage : System.Web.UI.Page
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();
        protected void Page_Load(object sender, EventArgs e)
        {
            objBussinessObj.ID = Convert.ToInt16(Request.QueryString["ID"]);
            objBussinessLogic.ImagesGenerateThumbnailFromDatabase(objBussinessObj);
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[4];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(4);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            objBussinessObj.FileName= result.ToString();
            Response.AppendHeader("Content-Disposition", "attachment; filename=Festivity" + objBussinessObj.FileName + ".jpg");
            Response.ContentType = "image/JPEG";
            Response.OutputStream.Write(objBussinessObj.Bytes, 0, objBussinessObj.Bytes.Length);
            Response.End();
        }
    }
}