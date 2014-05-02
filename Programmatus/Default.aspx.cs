using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Context.User.Identity.Name != null && Context.User.Identity.Name.Length > 0)
        {
            string uID = Membership.GetUser(Context.User.Identity.Name).ProviderUserKey.ToString();
            Session["userID"] = uID;
        }
    }
}