﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FHIRLight.Library.Spark.Engine.Extensions;
using log4net.Config;

namespace FHIRLight.Server
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        //protected void Application_Start()
        //{
        //    GlobalConfiguration.Configure(WebApiConfig.Register);
        //}

        protected void Application_Start()
        {

            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalConfiguration.Configure(Configure);
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            XmlConfigurator.Configure();
        }

        public void Configure(HttpConfiguration config)
        {
            config.AddFhir();
        }
    }
}
