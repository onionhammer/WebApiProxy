using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiProxy.TestClient.Clients;

namespace WebApiProxy.TestClient
{
    /// <summary>
    /// Summary description for TestService
    /// </summary>
    [TestClass]
    public class TestService
    {
        [TestMethod]
        public async Task TestClient()
        {
            var clients = new WebApiClients();
            var all     = await clients.Values.GetAsync();
            var first   = await clients.Values.GetAsync(all[0].Value);
            Assert.IsNotNull(first);
            Assert.AreEqual(Models.ItemTestEnum.One, first.Value);

            var fourth  = await clients.Values.GetAsync(Models.ItemTestEnum.Four);
            Assert.IsNull(fourth);
        }
    }
}
