using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;
using GeoMathAPI.Models._2D_Shapes.Triangles;

namespace GeometryUnitTests._2D_Shapes
{
    [TestClass]
    public class Right_AngledTriangleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 25.000m;
            var triangle = new Right_AngledTriangle(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(triangle.Area, expected);
        }

        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 26.18m;
            var triangle = new Right_AngledTriangle(5, 10, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(triangle.Perimeter, expected);
        }
    }
}
