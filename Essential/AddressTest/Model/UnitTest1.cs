using AddressApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AddressTest.Model
{
    [TestClass]
    public class AddressTests
    {
        private AddressApp.Model.Address _target;

        [TestInitialize]
        public void Init()
        { 
             _target = new Address();
        }

        [TestMethod]
        public void AddressTest()
        {
            var actual = _target.Index;
            Assert.AreEqual("03058", actual);

            var actual1 = _target.Country;
            Assert.AreEqual("Ukraine", actual1);

            var actual2 = _target.City;
            Assert.AreEqual("Kiev", actual2);

            var actual3 = _target.Street;
            Assert.AreEqual("Kreschatik", actual3);

            var actual4 = _target.House;
            Assert.AreEqual("1/1", actual4);

            var actual5 = _target.Apartment;
            Assert.AreEqual("5", actual5);
        }
    }
}
