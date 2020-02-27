using System;
using System.Net.Configuration;
using ConverterApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConverterAppTests
{
    /// <summary>
    /// Checks the Converter class
    /// </summary>
    [TestClass()]
    public class ConverterTest
    {
        Converter _target;
        private const decimal Tolerance = 0.01m;

        /// <summary>
        /// Checks Converter's constructor
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            _target = new Converter(24.5m, 34.5m, 4.5m, 1m, 300m, "EUR");
        }

        /// <summary>
        ///  Checks the Convert method
        /// </summary>

        [TestMethod]
        public void ConvertTest()
        {
            var actual = _target.Convert("USD");
            Assert.IsTrue(Math.Abs(actual - 422.44M) < Tolerance);
        }

        /// <summary>
        /// Checks the Convert method's expected exception
        /// </summary>
        [TestMethod, ExpectedException(typeof(ArgumentException), "Incorrect amount")]
        public void AreEqualForConvertIntoUahTest()
        {
            _target = new Converter(24.5m, 34.5m, 4.5m, 1m, 0m, "EUR");
            var actual = _target.Convert("USD");
            Assert.IsTrue(Math.Abs(actual - 422.44M) < Tolerance);
        }
    }
}
