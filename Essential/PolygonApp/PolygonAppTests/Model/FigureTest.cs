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

            Figure.FigureType actual = _target.GetName();
            Assert.AreEqual(Figure.FigureType.Point, actual);
        }

        [TestMethod]
        public void GetNameLineTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");

            _target = new Figure(new[] { a, b });

            Figure.FigureType actual = _target.GetName();
            Assert.AreEqual(Figure.FigureType.Line, actual);
        }

        [TestMethod]
        public void GetNameTriangleTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");

            _target = new Figure(new[] { a, b, c });

            Figure.FigureType actual = _target.GetName();
            Assert.AreEqual(Figure.FigureType.Triangle, actual);
        }

        [TestMethod]
        public void GetNameSquareTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");

            _target = new Figure(new[] { a, b, c, d });

            Figure.FigureType actual = _target.GetName();
            Assert.AreEqual(Figure.FigureType.Square, actual);
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

            Figure.FigureType actual = _target.GetName();
            Assert.AreEqual(Figure.FigureType.Polygon, actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetNameFailTest()
        {
            Figure.FigureType actual = _target.GetName();
        }
    }
}