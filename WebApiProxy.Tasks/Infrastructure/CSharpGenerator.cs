using System.Net.Http;
using System.Threading.Tasks;
using WebApiProxy.Core.Models;
using WebApiProxy.Tasks.Models;
using WebApiProxy.Tasks.Templates;

namespace WebApiProxy.Tasks.Infrastructure
{
    public class CSharpGenerator
    {
        readonly Configuration config;

        public CSharpGenerator(Configuration config)
        {
            this.config = config;
        }

        public string Generate()
        {
            config.Metadata = GetProxy().Result;

            return new CSharpProxyTemplate(config).TransformText();
        }

        private async Task<Metadata> GetProxy()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Proxy-Type", "metadata");
                var response = await client.GetAsync(config.Endpoint);
                response.EnsureSuccessStatusCode();
                
                return await response.Content.ReadAsAsync<Metadata>();
            }
        }
    }
}
