using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PolygonApp;
using Point = PolygonApp.Model.Point;

namespace Point.Test
{
    [TestClass]
    public class FigureTests
    {
        private Figure _target;

        [TestInitialize]
        public void Init()
        {
            var a = new PolygonApp.Model.Point(x: 1, y: 2, name: "a");
            var b = new PolygonApp.Model.Point(x: 3, y: 2, name: "b");
            var c = new PolygonApp.Model.Point(x: 3, y: 5, name: "c");
            var d = new PolygonApp.Model.Point(x: 1, y: 5, name: "d");
            _target = new Figure(points: new PolygonApp.Model.Point[] { a, b, c, d });
        }

        [TestMethod]
        public void FigureCalculatePerimeterTest()
        {
            var actual = _target.CalculatePerimeter();
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void LengthSideTest()
        {
            var a = new PolygonApp.Model.Point(x: 1, y: 2, name: "a");
            var b = new PolygonApp.Model.Point(x: 3, y: 2, name: "b");
            var actual = _target.LengthSide(a, b);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void GetNameTest()
        { 
            string actual = _target.GetName(); 
            Assert.AreEqual("square", actual);

            if (actual != _target.GetName())
            {
                string actual1 = _target.GetName();
                Assert.AreEqual("triangle", actual1);
            }
        }
        
        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetNameFailTest()
        {
            _target = new Figure(new []{new PolygonApp.Model.Point(2, 0, "") });
            string actual = _target.GetName();
        }

        [TestMethod, ExpectedException(typeof(ArgumentException), "Фигура не определена")]
        public void GetName2FailTest()
        {
            _target = new Figure(new[] { new PolygonApp.Model.Point(2, 0, "") });
            string actual = _target.GetName();
        }
    }
}