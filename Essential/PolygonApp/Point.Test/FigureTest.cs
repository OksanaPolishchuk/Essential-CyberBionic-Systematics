using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using PolygonApp.Model;

namespace PointTest
{
    [TestClass]
    public class FigureTest
    {
        [TestClass]
        public class FigureTests
        {
            private Figure _target;

            [TestInitialize]
            public void Init()
            {
                var a = new Point(1, 2, "a");
                var b = new Point(3,2, "b");
                var c = new Point(3,5, "c");
                var d = new Point(1,5, "d");
                _target = new Figure(new Point[] {a, b, c, d});
            }

            [TestMethod]
            public void FigureCalculatePerimeterTest()
            {
                var actual = _target.CalculatePerimeter();
                Assert.AreEqual(10, actual);
            }
        }
    }
}