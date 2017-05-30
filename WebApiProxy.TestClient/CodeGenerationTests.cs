using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiProxy.Tasks.Infrastructure;

namespace WebApiProxy.TestClient
{
    [TestClass]
    public class CodeGenerationTests
    {
        [TestMethod]
        public void GenerateCode()
        {
            var projectsPath = Path.Combine(Environment.CurrentDirectory, @"..\..\");
            var root         = Path.Combine(projectsPath, "WebApiProxy");

            var config = Tasks.Models.Configuration.Load(root);
            var generator = new CSharpGenerator(config);

            var source = generator.Generate();

            File.WriteAllText(
                Path.Combine(root, "WebApiProxy.generated.cs"),
                source);
            
        }
    }
}
