using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models;

namespace GeometryUnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 78.540f;
            var circle = new Circle(5, _CalcTypes.AreaCalc);

            Assert.AreEqual(circle.Area, expected);
        }
        
        [TestMethod]
        public void PerimeterTest()
        {
            var expected = 31.416f;
            var circle = new Circle(5, _CalcTypes.PerimeterCalc);

            Assert.AreEqual(circle.Perimeter, expected);
        }
    }
}
