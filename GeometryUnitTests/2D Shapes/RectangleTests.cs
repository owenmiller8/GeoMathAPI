using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;

namespace GeometryUnitTests._2D_Shapes
{
    [TestClass]
    public class RectamgleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 50.000m;
            var rectangle = new Rectangle(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(rectangle.Area, expected);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 30.000m;
            var rectangle = new Rectangle(5, 10, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(rectangle.Perimeter, expected);
        }
    }
}
