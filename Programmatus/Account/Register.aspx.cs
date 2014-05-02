using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Membership.OpenAuth;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class Account_Register : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        Label1.Text = RegisterUser.UniqueID;
    }



    protected void RegisterUser_CreatedUser(object sender, EventArgs e)
    {
        bool success = false;
        SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        string uID = Membership.GetUser(RegisterUser.UserName).ProviderUserKey.ToString();
        SqlCommand ConnectuID = new SqlCommand("INSERT into Player VALUES (@UID, @LEVEL, @ENERGY, @GOLD, @EXPERIENCE, @HACKING, @SECURITY, @EFFICIENCY, @GOLDINCOME, @LUCK, @BARGAINING)", connection);
        try
        {
            connection.Open();
            ConnectuID.Parameters.AddWithValue("@UID", uID);
            ConnectuID.Parameters.AddWithValue("@LEVEL", 1);
            ConnectuID.Parameters.AddWithValue("@ENERGY", 15);
            ConnectuID.Parameters.AddWithValue("@GOLD", 100);
            ConnectuID.Parameters.AddWithValue("@EXPERIENCE", 0);
            ConnectuID.Parameters.AddWithValue("@HACKING", 5);
            ConnectuID.Parameters.AddWithValue("@SECURITY", 5);
            ConnectuID.Parameters.AddWithValue("@EFFICIENCY", 5);
            ConnectuID.Parameters.AddWithValue("@GOLDINCOME", 0);
            ConnectuID.Parameters.AddWithValue("@LUCK", 5);
            ConnectuID.Parameters.AddWithValue("@BARGAINING", 5);
            ConnectuID.ExecuteNonQuery();
            success = true;
            Session["userID"] = uID;
        }
        catch (Exception errorMessage)
        {
            // Error handling
            Label1.Text = errorMessage.GetBaseException().ToString();
        }
        finally
        {
            connection.Close();
        }

        if (success)
        {
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie: false);
            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (!OpenAuth.IsLocalUrl(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);
        }
    }
}