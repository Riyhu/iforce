using System;
using System.Web;
using IForce.WebFormsTest.Configurations;

namespace IForce.WebFormsTest
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            ServiceConfiguration.Initialize();
            DatabaseConfiguration.ConfigureDatabase(ServiceConfiguration.ServiceProvider);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            ServiceConfiguration.BeginRequest();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            ServiceConfiguration.EndRequest();
        }
    }
}
