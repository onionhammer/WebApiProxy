using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using WebApiProxy.Server;
using WebApiProxy.TestServer.Areas.HelpPage;

namespace WebApiProxy.TestServer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
#if DEBUG
            // Enable Web API Proxy
            config.RegisterProxyRoutes();

            // Enable Help Documentation
            config.SetDocumentationProvider(new XmlDocumentationProvider(GetXmlCommentsPath()));
#endif

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static string GetXmlCommentsPath()
        {
            var xmlPath = @"bin\WebApiProxy.TestServer.xml";

            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, xmlPath);
        }
    }
}
