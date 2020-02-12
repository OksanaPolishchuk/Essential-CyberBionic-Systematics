using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using PolygonApp.Model;

namespace PolygonAppTests.Model
{
    [TestClass]
    public class FigureTests
    {
        private Figure _target;
        private const double Tolerance = 0.0000001;

        [TestInitialize]
        public void Init()
        {
            _target = new Figure(points: new Point[] { });
        }

        [TestMethod]
        public void FigureCalculatePerimeterTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");

            _target = new Figure(new[] { a, b, c, d, });

            var actual = _target.CalculatePerimeter();
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void GetNamePointTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");

            _target = new Figure(new[] { a });

          var actual = _target.GetFigureType();
            Assert.AreEqual(FigureType.Point, actual);
        }

        [TestMethod]
        public void GetNameLineTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");

            _target = new Figure(new[] { a, b });

           var actual = _target.GetFigureType();
            Assert.AreEqual(FigureType.Line, actual);
        }

        [TestMethod]
        public void GetNameTriangleTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");

            _target = new Figure(new[] { a, b, c });

            var actual = _target.GetFigureType();
            Assert.AreEqual(FigureType.Triangle, actual);
        }

        [TestMethod]
        public void GetNameSquareTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");

            _target = new Figure(new[] { a, b, c, d });

            var actual = _target.GetFigureType();
            Assert.AreEqual(FigureType.Square, actual);
        }

        [TestMethod]
        public void GetNamePolygonTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");
            var e = new Point(x: 1, y: 5, name: "e");

            _target = new Figure(new[] { a, b, c, d, e });

            var actual = _target.GetFigureType();
            Assert.AreEqual(FigureType.Polygon, actual);
        }

        [TestMethod]
        public void TriangleProperty()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            
            _target = new Figure(points: new[] { a, b, c });

            var actual = _target.TriangleProperty();
            Assert.IsTrue(Math.Abs(actual - 1.3944487) < Tolerance);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetNameFailTest()
        {
           var actual = _target.GetFigureType();
        }
    }
}