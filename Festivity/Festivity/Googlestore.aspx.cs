using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Google.API.Search;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;
using BussinessLogic;
using BussinessObject;
using DataAccess;

namespace Festivity
{
    public partial class Googlestore : System.Web.UI.Page
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                dlSearch.DataSource = null;
                dlSearch.DataBind();
            }
            CategoryList.DataSource = objBussinessLogic.SearchAllCategory(objBussinessObj);
            CategoryList.DataBind();
        }

        protected void List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            objBussinessObj.Search = e.CommandArgument.ToString();
            dlSearch.DataSource = objBussinessLogic.SearchImageByGoogle(objBussinessObj);
            dlSearch.DataBind();
        }

        protected void GenerateThumbnail(object sender, EventArgs e)
        {
            objBussinessObj.SenderArgument = (sender as LinkButton).CommandArgument;
            objBussinessLogic.ImagesGenerateThumbnail(objBussinessObj);
            Response.ContentType = ContentType;
            Response.AppendHeader("Content-Disposition", "attachment; filename=" + objBussinessObj.FileName);
            Response.ContentType = "image/JPEG";
            Response.OutputStream.Write(objBussinessObj.Bytes, 0, objBussinessObj.Bytes.Length);
            Response.End();
        }
    }
}