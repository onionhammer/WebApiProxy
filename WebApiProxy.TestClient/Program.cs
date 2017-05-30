using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiProxy.TestClient
{
    public static class Program
    {
        public static int Main(string[] args)
        {
            // Generate code
            new CodeGenerationTests().GenerateCode();

            return 0;
        }
    }
}
