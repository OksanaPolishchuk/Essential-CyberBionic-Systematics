using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PolygonAppTests.Model
{
    [TestClass]
    public class PointTests
    {
        private PolygonApp.Model.Point _target;

        [TestInitialize]
        public void Init()
        {
            int x = 2, y = 4;
            string name = "rectangle";
            _target = new PolygonApp.Model.Point(x, y, name);
        }

        [TestMethod]
        public void PointTest()
        {
            var actual = _target.Name;
            Assert.AreEqual("rectangle", actual);

            var actual2 = _target.X;
            Assert.AreEqual(2, actual2);

            var actual3 = _target.Y;
            Assert.AreEqual(4, actual3);
        }
    }
}