using BaltaStore.Domain.StoreContext.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Custumer(firstName: "André", lastName: "Costa", document: "12345678", email: "andre.costa@email.com", phone: "119989878", address: "Rua dadisney");

           
        }
    }
}
