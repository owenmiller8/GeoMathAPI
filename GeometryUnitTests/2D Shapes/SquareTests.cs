using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;

namespace GeometryUnitTests._2D_Shapes
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 25.000m;
            var square = new Square(5, _CalcTypes.AreaCalc);

            Assert.AreEqual(square.Area, expected);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 20.000m;
            var square = new Square(5, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(square.Perimeter, expected);
        }
    }
}
