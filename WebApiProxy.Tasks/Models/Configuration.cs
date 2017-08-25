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

        public static Configuration Load(string webapiRoot)
        {
            var filename = Path.Combine(webapiRoot, Configuration.ConfigFileName);

            if (!File.Exists(filename))
                return null;

            var serializer = new XmlSerializer(typeof(Configuration), new XmlRootAttribute("proxy"));
            using (var reader = new StreamReader(filename))
                return serializer.Deserialize(reader) as Configuration;
        }

        public static Configuration Create(string webapiRoot, string apiEndpoint, string apiNamespace)
        {
            var filename = Path.Combine(webapiRoot, Configuration.ConfigFileName);

            var newConfig = new Configuration
            {
                Endpoint  = apiEndpoint,
                Namespace = apiNamespace
            };

            if (Directory.Exists(webapiRoot) == false)
                Directory.CreateDirectory(webapiRoot);

            var serializer = new XmlSerializer(typeof(Configuration), new XmlRootAttribute("proxy"));
            using (var writer = new StreamWriter(filename))
                serializer.Serialize(writer, newConfig);

            return newConfig;
        }
    }
}