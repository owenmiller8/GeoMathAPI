using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;

namespace GeometryUnitTests._2D_Shapes
{
    [TestClass]
    public class EllipseTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 157.080f;
            var ellipse = new Ellipse(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(ellipse.Area, expected);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 31.416f;
            var ellipse = new Ellipse(5, 10, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(ellipse.Perimeter, expected);
        }
    }
}
