﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RegisterHyperLink.NavigateUrl = "Register";
        var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        if (!String.IsNullOrEmpty(returnUrl))
        {
            RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
        }
    }
    protected void Unnamed6_Click(object sender, EventArgs e)
    {

    }
    protected void UserName_TextChanged(object sender, EventArgs e)
    {

    }
}