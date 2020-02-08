using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp.Model;
using PolygonApp.Service;

namespace PolygonAppTests.Service
{
    [TestClass]
    public class DistanceTest
    { 
        [TestMethod]
        public void LengthSideTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var actual = Distance.LengthSide(a, b);
            Assert.AreEqual(2, actual);
        }
    }
}