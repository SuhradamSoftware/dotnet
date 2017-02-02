using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Web.Script.Services;

namespace Festivity
{
    public partial class Main : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Festivity_Click(object sender, EventArgs e)
        {
            Response.Redirect("Festivitystore.aspx");
        }
        protected void Google_Click(object sender, EventArgs e)
        {
            Response.Redirect("Googlestore.aspx");
        }       
    }
}