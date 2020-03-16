﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;

namespace GeometryUnitTests._2D_Shapes
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 25.000m;
            var triangle = new Triangle(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(triangle.Area, expected);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 26.180m;
            var triangle = new Triangle(5, 10, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(triangle.Perimeter, expected);
        }
    }
}