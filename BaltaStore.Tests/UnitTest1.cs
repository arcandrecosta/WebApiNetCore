using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.ValuesObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Name name = new Name(firstName: "André", lastName: "Costa");
            Document document = new Document("12345678");
            Email email = new Email( "andre.costa@email.com");
            
            var c = new Custumer(name:name, document: document, email:email, phone: "119989878", address: "Rua dadisney");

           
        }
    }
}
