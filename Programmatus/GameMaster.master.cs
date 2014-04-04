﻿using System;
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
    protected void Overview_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false; 
    }
    protected void Market_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Skills_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job_clicked(object sender, EventArgs e)
    {
        Job1.Visible = true;
        Job2.Visible = true;
        Job3.Visible = true;
    }
    protected void Hack_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job1_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job2_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job3_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
}
