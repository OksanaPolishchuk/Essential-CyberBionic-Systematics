using System;
using System.Linq;
using DocumentFormat.OpenXml.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Classes.Tests
{
    [TestClass]
    public class ClassesTests
    {
        private Rectangle _target;

        [TestInitialize]
        public void Init()
        {
            _target = new Rectangle();
        }

        [TestMethod]
        public void Rectangle_5and2_10returnedTest()
        {
            double actual = _target.Area;
            Assert.AreEqual(10.0, actual);
        }
    }
}
