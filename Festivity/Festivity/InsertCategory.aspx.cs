using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using BussinessLogic;
using BussinessObject;
using DataAccess;

namespace Festivity
{
    public partial class InsertCategory : System.Web.UI.Page
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                lblMessage.Visible = true;
            }
            else
            {
                lblMessage.Visible = false;
            }
            GetCategory();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            objBussinessObj.ImageCategory = Category.Text.Trim();
            objBussinessLogic.InsertCategory(objBussinessObj);
            lblMessage.Text = objBussinessObj.Message.ToString();
            GetCategory();
        }

        private void GetCategory()
        {
            CategoryList.DataSource = objBussinessLogic.SelectAllCategory(objBussinessObj);
            CategoryList.DataBind();
        }

        protected void List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete" && e.CommandArgument.ToString() != "")
            {
                objBussinessObj.ID = Convert.ToInt32(e.CommandArgument.ToString());
                objBussinessLogic.DeleteCategory(objBussinessObj);
                lblMessage.Text = objBussinessObj.Message.ToString();
                GetCategory();
            }
        }
    }
}