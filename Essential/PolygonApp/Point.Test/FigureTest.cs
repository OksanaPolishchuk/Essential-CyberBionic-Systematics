using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using Point = PolygonApp.Point;

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
                Point[] points = new []{new Point(2, 3)};
                _target = new Figure(points);
            }

            [TestMethod]
            public void FigureCalculatePerimeterTest()
            {
                var actual = _target.CalculatePerimeter();
                Assert.AreEqual(6, actual);
            }

        }
    }
}
