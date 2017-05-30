using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiProxy.Server.Templates;

namespace WebApiProxy.Server
{
    public class ProxyHandler : DelegatingHandler
    {
        MetadataProvider _metadataProvider;
        HttpConfiguration _config;

        public ProxyHandler(HttpConfiguration config)
        {
            _metadataProvider = new MetadataProvider(config);
            _config = config;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var metadata = _metadataProvider.GetMetadata(request);

            if (request.Headers.TryGetValues("X-Proxy-Type", out IEnumerable<string> values) &&
                values.Contains("metadata"))
                return Task.FromResult(request.CreateResponse(System.Net.HttpStatusCode.OK, metadata));

            var template = new JsProxyTemplate(metadata);
            var js = new StringContent(template.TransformText());

            js.Headers.ContentType = new MediaTypeHeaderValue("application/javascript");
            js.Headers.Expires = DateTime.Now.AddDays(30).ToUniversalTime();

            var result = new HttpResponseMessage { Content = js };

            result.Headers.CacheControl = CacheControlHeaderValue.Parse("public");

            return Task.FromResult(result);
        }
    }
}
