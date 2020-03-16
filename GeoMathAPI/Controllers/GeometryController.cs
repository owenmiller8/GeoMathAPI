using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeoMathAPI.Models;
using GeoMathAPI.Models._3D_Shapes;

namespace GeoMathAPI.Controllers
{
    [Route("api/geometry")]
    [ApiController]
    public class GeometryController : ControllerBase
    {
        #region 2D Shapes
        [HttpGet]
        [Route("circle")]
        public ActionResult<Circle> Circle(decimal radius, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Circle(radius, calc);
        }

        [HttpGet]
        [Route("ellipse")]
        public ActionResult<Ellipse> Ellipse(decimal longRadius, decimal shortRadius, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Ellipse(longRadius, shortRadius, calc);
        }

        [HttpGet]
        [Route("rectangle")]
        public ActionResult<Rectangle> Rectangle(decimal length, decimal width, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Rectangle(length, width, calc);
        }

        [HttpGet]
        [Route("square")]
        public ActionResult<Square> Square(decimal length, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Square(length, calc);
        }


        [HttpGet]
        [Route("triangle")]
        public ActionResult<Triangle> Triangle(decimal width, decimal height, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Triangle(width, height, calc);
        }
        #endregion

        #region 3D Shapes
        [HttpGet]
        [Route("cone")]
        public ActionResult<Cone> Cone(decimal radius, decimal height, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Cone(radius, height, calc);
        }

        [HttpGet]
        [Route("cube")]
        public ActionResult<Cube> Cube(decimal length, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Cube(length, calc);
        }

        [HttpGet]
        [Route("cuboid")]
        public ActionResult<Cuboid> Cuboid(decimal height, decimal length, decimal width, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Cuboid(height, width, length, calc);
        }

        [HttpGet]
        [Route("cylinder")]
        public ActionResult<Cylinder> Cylinder(decimal radius, decimal length, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Cylinder(radius, length, calc);
        }

        [HttpGet]
        [Route("prism")]
        public ActionResult<Prism> Prism(decimal height, decimal width, decimal length, _CalcTypes calc, _3DBases b)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            //b is used to tell whether the shape has a triangular or square base
            return new Prism(height, width, length, calc, b);
        }
        [HttpGet]
        [Route("pyramid")]
        public ActionResult<Pyramid> Pyramid(decimal height, decimal width, decimal length, _CalcTypes calc, _3DBases b)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            //b is used to tell whether the shape has a triangular or square base
            return new Pyramid(height, width, length, calc, b);
        }
        
        [HttpGet]
        [Route("sphere")]
        public ActionResult<Sphere> Sphere(decimal radius, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Sphere(radius, calc);
        }
        #endregion
    }
}
