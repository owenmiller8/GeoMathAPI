using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class ConeTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 254.16m;
            var cone = new Cone(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(cone.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            var expected = 261.799m;
            var cone = new Cone(5, 10, _CalcTypes.VolumeCalc);

            Assert.AreEqual(cone.Volume, expected);
        }
    }
}
