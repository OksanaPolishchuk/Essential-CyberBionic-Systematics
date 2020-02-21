using System;
using System.Net.Configuration;
using ConverterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterAppTests
{
    [TestClass()]
    public class ConverterTests
    {
        Converter _target;

        /// <summary>
        /// Checks Converter's constructor
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            _target = new Converter(24.5m, 34.5m, 4.5m, 1m);
            var actual = _target.UAH;
            Assert.AreEqual(1m, actual);
        }

        /// <summary>
        /// Checks Converter's access USD method 
        /// </summary>
        [TestMethod]
        public void ConverterUsdTest()
        {
            var actualUsd = _target.USD;
            Assert.AreEqual(24.5m, actualUsd);
        }

        /// <summary>
        /// Checks Converter's access EUR method 
        /// </summary>
        [TestMethod]
        public void ConverterEurTest()
        {
            var actualEur = _target.EUR;
            Assert.AreEqual(34.5m, actualEur);
        }

        /// <summary>
        /// Checks Converter's access RUB method 
        /// </summary>
        [TestMethod]
        public void ConverterRubTest()
        {
            var actualRub = _target.RUB;
            Assert.AreEqual(4.5m, actualRub);
        }

        /// <summary>
        /// Checks Converter's access UAH method 
        /// </summary>
        [TestMethod]
        public void ConverterUahTest()
        { 
            var actualUah = _target.UAH;
            Assert.AreEqual(1m, actualUah);
        }

        /// <summary>
        /// Checks the ConvertFromUah method
        /// </summary>
        [TestMethod]
        public void ConvertFromUahTest()
        {
            decimal sum = 3000.0m;
            var usd = _target.USD;
            var actual = _target.ConvertFromUah(ref sum, usd );
            Assert.AreEqual(sum, actual);
        }

        /// <summary>
        /// Checks the ConvertFromUah method's expected exception 
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException), "Incorrect amount")]
        public void AreEqualForConvertFromUahTest()
        {
            decimal sum = 0m;
            var usd = _target.USD;
            var actual = _target.ConvertFromUah(ref sum, usd);
        }

        /// <summary>
        /// Checks the ConvertIntoUah method
        /// </summary>
        [TestMethod]
        public void ConvertIntoUahTest()
        {
            decimal sum = 500.0m;
            var usd = _target.USD;
            var actual = _target.ConvertIntoUah(ref sum, usd);
            Assert.AreEqual(sum, actual);
        }

        /// <summary>
        /// Checks the ConvertIntoUah method's expected exception
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException), "Incorrect amount")]
        public void AreEqualForConvertIntoUahTest()
        {
            decimal sum = 0m;
            var usd = _target.USD;
            var actual = _target.ConvertIntoUah(ref sum, usd);
        }
    }
}