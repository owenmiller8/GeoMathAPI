using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoMathAPI.Models._3D_Shapes;
using GeoMathAPI.Models;

namespace GeometryUnitTests._3D_Shapes
{
    [TestClass]
    public class PyramidTests
    {
        [TestMethod]
        public void AreaTestSquare()
        {
            var expected = 128.078m;
            var pyramid = new Pyramid(5, 6, 10, _CalcTypes.AreaCalc, _3DBases.Square);

            Assert.AreEqual(pyramid.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTestSquare()
        {
            var expected = 83.333m;
            var pyramid = new Pyramid(5, 6, 10, _CalcTypes.VolumeCalc, _3DBases.Square);

            Assert.AreEqual(pyramid.Volume, expected);
        }

        [TestMethod]
        public void AreaTestTriangle()
        {
            var expected = 119.957m;
            var pyramid= new Pyramid(5, 6, 10, _CalcTypes.AreaCalc, _3DBases.Triangle);

            Assert.AreEqual(pyramid.SurfaceArea, expected);
        }

        [TestMethod]
        public void VolumeTestTriangle()
        {
            var expected = 50m;
            var pyramid = new Pyramid(5, 6, 10, _CalcTypes.VolumeCalc, _3DBases.Triangle);

            Assert.AreEqual(pyramid.Volume, expected);
        }
    }
}
