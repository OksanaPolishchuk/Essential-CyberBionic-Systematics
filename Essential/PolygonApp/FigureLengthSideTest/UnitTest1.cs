using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using PolygonApp.Model;

namespace FigureTest
{
    [TestClass]
    public class FigureLengthSideTest
    { 
        [TestClass]
        public class FigureLengthSideTests
        {
            private Figure _target; 

            [TestInitialize]
            public void Init()
            {
                var a = new Point(x: 1, y: 2, name: "a");
                var b = new Point(x: 3, y: 2, name: "b");
                _target = new Figure(points:new Point[] {b, a});
            }

            [TestMethod]
            public void LengthSideTest1(Point b,Point a)
            {
                var actual = _target.LengthSide(b, a);
                Assert.AreEqual(4, actual);
            }
        }
    }
}
