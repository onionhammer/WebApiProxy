using System.IO;
using System.Xml;
using System.Xml.Serialization;
using WebApiProxy.Core.Models;

namespace WebApiProxy.Tasks.Models
{
    [XmlRoot("proxy")]
    public class Configuration
    {
        public const string ConfigFileName = "WebApiProxy.config";
        public const string CacheFile = "WebApiProxy.generated.cache";

        [XmlAttribute("generateOnBuild")]
        public bool GenerateOnBuild { get; set; } = false;

        string _clientSuffix = "Client";
        [XmlAttribute("clientSuffix")]
        public string ClientSuffix
        {
            get => _clientSuffix.DefaultIfEmpty("Client");
            set => _clientSuffix = value;
        }

        [XmlAttribute("namespace")]
        public string Namespace { get; set; } = "WebApi.Proxies";

        [XmlAttribute("name")]
        public string Name { get; set; } = "ApiProxy";

        [XmlAttribute("endpoint")]
        public string Endpoint { get; set; }
        
        [XmlIgnore]
        public Metadata Metadata { get; set; }

        public static Configuration Load(string root)
        {
            var fileName = root + Configuration.ConfigFileName;

            if (!File.Exists(fileName))
                throw new ConfigFileNotFoundException(fileName);

            var serializer = new XmlSerializer(typeof(Configuration), new XmlRootAttribute("proxy"));

            using (var reader = new StreamReader(fileName))
                return serializer.Deserialize(reader) as Configuration;
        }
    }
}