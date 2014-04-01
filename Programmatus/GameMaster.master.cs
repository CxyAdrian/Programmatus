using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.Security;

public partial class GameMaster : System.Web.UI.MasterPage
{

    /*SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Data Source=(LocalDb)\v11.0;Initial Catalog=aspnet-Programatus-20140318115845;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\aspnet-Programatus-20140318115845.mdf"].ConnectionString);
    String sqlcommand = "SELECT Username FROM Player";*/
    protected void Page_Load(object sender, EventArgs e)
    {
        
        String username = HttpContext.Current.User.Identity.Name;
        Label usernamelabel = new Label();
        usernamelabel.Text = username;
        /*con.Open();
        SqlCommand getUsername = new SqlCommand(sqlcommand, con);
        SqlDataReader reader = getUsername.ExecuteReader();
        reader.Read();
        Label1.Text = reader["Username"].ToString();
        reader.Close();
        con.Close();*/

    }
}
