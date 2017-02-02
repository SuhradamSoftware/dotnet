using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using BussinessLogic;
using BussinessObject;
using DataAccess;

namespace Festivity
{
    public partial class InsertImage : System.Web.UI.Page
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProductNameDropdown();
            }
        }

        protected void InsertImage_Click(object sender, EventArgs e)
        {            
            string filePath = string.Empty;
            string contenttype = string.Empty;
            string filename = string.Empty;
            Byte[] imgByte = null;
            if (FileUpload1.HasFile && FileUpload1.PostedFile != null)
            {
                HttpPostedFile File = FileUpload1.PostedFile;
                imgByte = new Byte[File.ContentLength];
                File.InputStream.Read(imgByte, 0, File.ContentLength);
            }
            objBussinessObj.ID = Convert.ToInt32(CategoryName.SelectedValue);
            objBussinessObj.Image = imgByte;
            objBussinessLogic.InsertImage(objBussinessObj);
        }

        protected void BindProductNameDropdown()
        {
            CategoryName.DataSource = objBussinessLogic.SelectCategory(objBussinessObj);
            CategoryName.DataTextField = "Category";
            CategoryName.DataValueField = "ID";
            CategoryName.DataBind();
        }
    }
}