using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 314.159m;
            var sphere = new Sphere(5, _CalcTypes.AreaCalc);

            Assert.AreEqual(sphere.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            var expected = 523.599m;
            var sphere = new Sphere(5, _CalcTypes.VolumeCalc);

            Assert.AreEqual(sphere.Volume, expected);
        }
    }
}
