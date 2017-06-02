using System.Net.Http;
using Newtonsoft.Json;
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
            config.Metadata = GetProxy();

            return new CSharpProxyTemplate(config).TransformText();
        }

        private Metadata GetProxy()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Proxy-Type", "metadata");
                var response = client.GetAsync(config.Endpoint).Result;
                response.EnsureSuccessStatusCode();

                var jsonData = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<Metadata>(jsonData);
            }
        }
    }
}
