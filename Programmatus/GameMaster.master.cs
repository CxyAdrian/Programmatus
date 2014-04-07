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

  
    protected void Page_Load(object sender, EventArgs e)
    {

 
    }
    //Overview -------------------------------------------------------------------------------------------------
    protected void Overview_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false; 
    }
    //Overview END -------------------------------------------------------------------------------------------

    //Market -----------------------------------------------------------------------------------------------------
    protected void Market_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    //Market END --------------------------------------------------------------------------------------------------

    //Train Skills -----------------------------------------------------------------------------------------------
    protected void Skills_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = true;
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void TrainEfficiency_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void TrainSecurity_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void TrainBargaining_clicked(object sender, EventArgs e)
    {
        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    //Train Skills END ----------------------------------------------------------------------------------------------

    //JOB ----------------------------------------------------------------------------------------------------------
    protected void Job_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = true;
        Job2.Visible = true;
        Job3.Visible = true;
    }
    
    protected void Job1_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job2_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    protected void Job3_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    //JOB END ---------------------------------------------------------------------------------------------------

    //Hack ------------------------------------------------------------------------------------------------------
    protected void Hack_clicked(object sender, EventArgs e)
    {
        TrainSkills.Visible = false;

        Job1.Visible = false;
        Job2.Visible = false;
        Job3.Visible = false;
    }
    //Hack END -------------------------------------------------------------------------------------------------
    
}
