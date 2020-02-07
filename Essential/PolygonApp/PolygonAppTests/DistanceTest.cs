using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using PolygonApp.Model;

namespace PolygonAppTests
{
    [TestClass]
    public class DistanceTest
    {
        private  Distance _target;

        [TestInitialize]
        public void Init()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            _target = new Distance (points: new Point[] { a, b});
        }

        [TestMethod]
        public void LengthSideTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var actual = _target.LengthSide(a, b);
            Assert.AreEqual(2, actual);
        }
    }
}
