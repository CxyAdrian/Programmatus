<%@ Application Language="C#" %>
<%@ Import Namespace="Programatus" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.Timers.Timer" %>

<script runat="server">


    
    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        AuthConfig.RegisterOpenAuth();
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        
        //Create the database connection for updating energy
        
        //timer
        Timer aTimer = new Timer();
        aTimer.Interval = 10000;
        aTimer.Tick += aTimer_Tick;
        aTimer.Enabled = true;

    }

    void aTimer_Tick(object sender, EventArgs e)
    {
        // Update Data
        
    }
    
    void Application_End(object sender, EventArgs e)
    {
        //  Code that runs on application shutdown

    }

    void Application_Error(object sender, EventArgs e)
    {
        // Code that runs when an unhandled error occurs

    }

</script>
