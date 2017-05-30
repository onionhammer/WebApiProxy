using System;
using System.IO;
using WebApiProxy.Tasks.Infrastructure;

namespace WebApiProxy.TestGenerateClient
{
    public class Program
    {
        static void GenerateCode()
        {
            var projectsPath = Path.Combine(Environment.CurrentDirectory, @"..\..\..\WebApiProxy.TestClient");
            var root         = Path.Combine(projectsPath, "WebApiProxy");

            var config = Tasks.Models.Configuration.Load(root);
            var generator = new CSharpGenerator(config);

            var source = generator.Generate();

            File.WriteAllText(
                Path.Combine(root, "WebApiProxy.generated.cs"),
                source);
        }

        public static void Main(string[] args)
        {
            Console.Write("Regenerating WebApiProxy.generated.cs for TestClient... ");
            GenerateCode();
            Console.WriteLine("Done.");
        }
    }
}
