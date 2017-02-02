using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BussinessLogic;
using BussinessObject;

namespace Festivity
{
    public partial class Festivitystore : System.Web.UI.Page
    {
        BussinessObj objBussinessObj = new BussinessObj();
        BussinessLgc objBussinessLogic = new BussinessLgc();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["ID"] != null)
            {
                objBussinessObj.ID = Convert.ToInt32(Request.QueryString["ID"]);
                DataList1.DataSource = objBussinessLogic.SearchImageByDatabase(objBussinessObj);
                DataList1.DataBind();
            }
            else
            {
                DataList1.DataSource = objBussinessLogic.SelectAllImage(objBussinessObj);
                DataList1.DataBind();
            }

            CategoryList.DataSource = objBussinessLogic.SearchAllCategory(objBussinessObj);
            CategoryList.DataBind();
        }

        protected void AllImage_Click(object sender, EventArgs e)
        {
            DataList1.DataSource = objBussinessLogic.SelectAllImage(objBussinessObj);
            DataList1.DataBind();
        }

        protected void List_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Search" && e.CommandArgument.ToString() != "")
            {
                Response.Redirect("Festivitystore.aspx?ID=" + e.CommandArgument.ToString());
            }
        }
    }
}