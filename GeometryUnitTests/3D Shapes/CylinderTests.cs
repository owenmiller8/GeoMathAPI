using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class CylinderTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 471.239m;
            var cylinder = new Cylinder(5, 10, _CalcTypes.AreaCalc);

            Assert.AreEqual(cylinder.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            var expected = 785.398m;
            var cylinder = new Cylinder(5, 10, _CalcTypes.VolumeCalc);

            Assert.AreEqual(cylinder.Volume, expected);
        }
    }
}
