using System.Linq;
using System.Web.Http.Controllers;

namespace WebApiProxy.Server
{
    public static class HttpActionDescriptorExtensions
    {
        public static bool IsExcluded(this HttpActionDescriptor self) =>
            self.GetCustomAttributes<ExcludeProxy>(true).Any();
    }
}