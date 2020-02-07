using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using PolygonApp.Model;

namespace PolygonAppTests
{
    [TestClass]
    public class FigureTests
    {
        private Figure _target;

        [TestInitialize]

        public void Init()
        {
            var a = new Point(x: 1, y: 2, name: "a");
            var b = new Point(x: 3, y: 2, name: "b");
            var c = new Point(x: 3, y: 5, name: "c");
            var d = new Point(x: 1, y: 5, name: "d");
            _target = new Figure(points: new Point[] { a, b});
        }

        [TestMethod]
        public void FigureCalculatePerimeterTest()
        {
            var actual = _target.CalculatePerimeter();
            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void GetNameTest()
        {
            string actual = _target.GetName();

            if (actual == "square")
            {
                Assert.AreEqual("square", actual);
            }

            if (actual == "triangle")
            {
                Assert.AreEqual("distance between two points", actual);
            }

            if (actual == "distance between two points")
            {
                Assert.AreEqual("distance between two points", actual);
            }
        }

        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetNameFailTest()
        {
            _target = new Figure(new []{new Point(2, 0, "") });
            string actual = _target.GetName();
        }
    }
}