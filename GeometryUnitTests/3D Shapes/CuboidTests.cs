using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class CuboidTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 280m;
            var cuboid = new Cuboid(5, 6, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(cuboid.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            var expected = 300m;
            var cuboid = new Cuboid(5, 6, 10, _CalcTypes.VolumeCalc);

            Assert.AreEqual(cuboid.Volume, expected);
        }
    }
}
