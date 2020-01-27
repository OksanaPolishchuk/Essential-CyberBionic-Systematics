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
                var a = new Point(1, 2);
                var b = new Point(3,2);
                var c = new Point(3,5);
                var d = new Point(1,5);
                _target = new Figure(new[] {a, b, c, d});
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
