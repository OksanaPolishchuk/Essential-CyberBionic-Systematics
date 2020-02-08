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
        public void GetNamePolygonTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");
            var e = new Point(x: 1, y: 5, name: "e");

            _target = new Figure(new[] {a, b, c, d, e});

            string actual = _target.GetName();
            Assert.AreEqual("polygon", actual);
        }

        public void GetNameSquareTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");

            _target = new Figure(new[] { a, b, c, d });

            string actual = _target.GetName();
            Assert.AreEqual("square", actual);
        }

        public void GetNameTriangleTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");

            _target = new Figure(new[] { a, b, c });

            string actual = _target.GetName();
            Assert.AreEqual("triangle", actual);
        }

        public void GetNameLineTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");

            _target = new Figure(new[] { a, b });

            string actual = _target.GetName();
            Assert.AreEqual("line", actual);
        }

        public void GetNamePointTest()
        {
            var a = new Point(x: 1, y: 2, name: "a");

            _target = new Figure(new[] { a });

            string actual = _target.GetName();
            Assert.AreEqual("point", actual);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetNameFailTest()
        {
            string actual = _target.GetName();
        }
    }
}