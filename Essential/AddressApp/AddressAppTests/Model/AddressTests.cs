using AddressApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace AddressAppTests.Model
{
    [TestClass]
    public class AddressTests
    {
        private Address _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Address(index: "03058", country: "Ukraine", city: "Kiev", street: "Kreschatik", house: "1/1", apartment: "5");
        }

        [TestMethod]
        public void AddressIndexTest()
        {
            var actual = _target.Index;
            AreEqual("03058", actual);
        }

        [TestMethod]
        public void CountryTest()
        {
            var actual = _target.Country;
            AreEqual("Ukraine", actual);
        }

        [TestMethod]
        public void CityTest()
        {
            var actual = _target.City;
            AreEqual("Kiev", actual);
        }

        [TestMethod]
        public void StreetTest()
        {
            var actual = _target.Street;
            AreEqual("Kreschatik", actual);
        }

        [TestMethod]
        public void HouseTest()
        {
            var actual = _target.House;
            AreEqual("1/1", actual);
        }

        [TestMethod]
        public void ApartmentTest()
        {
            var actual = _target.Apartment;
            AreEqual("5", actual);
        }


        [TestMethod]
        public void ToStringTest()
        {
            Address address = new Address(index: "01001", country: "Ukraine", city: "Kiev", street: "Kreschatik", house: "1/1", apartment: "23");
            _target = address;
            var actual = _target.ToString();

            AreEqual("Index: 01001, Country: Ukraine, City: Kiev, Street: Kreschatik, House: 1/1, Apartment: 23", actual);
        }
    }
}