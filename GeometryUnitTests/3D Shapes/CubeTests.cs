using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        public void AreaTest()
        {
            var expected = 150m;
            var cube = new Cube(5, _CalcTypes.AreaCalc);

            Assert.AreEqual(cube.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTest()
        {
            var expected = 125m;
            var cube = new Cube(5, _CalcTypes.VolumeCalc);

            Assert.AreEqual(cube.Volume, expected);
        }
    }
}
