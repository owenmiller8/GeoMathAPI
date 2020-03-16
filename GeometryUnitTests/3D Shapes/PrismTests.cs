using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class PrismTests
    {
        [TestMethod]
        public void AreaTestSquare()
        {
            var expected = 250m;
            var prism = new Prism(5, 6, 10, _CalcTypes.AreaCalc, _3DBases.Square);

            Assert.AreEqual(prism.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTestSquare()
        {
            var expected = 250m;
            var prism = new Prism(5, 6, 10, _CalcTypes.VolumeCalc, _3DBases.Square);

            Assert.AreEqual(prism.Volume, expected);
        }

        [TestMethod]
        public void AreaTestTriangle()
        {
            var expected = 210m;
            var prism = new Prism(5, 6, 10, _CalcTypes.AreaCalc, _3DBases.Triangle);

            Assert.AreEqual(prism.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTestTriangle()
        {
            var expected = 150m;
            var prism = new Prism(5, 6, 10, _CalcTypes.VolumeCalc, _3DBases.Triangle);

            Assert.AreEqual(prism.Volume, expected);
        }
    }
}
