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
        public ActionResult<Circle> Circle(double radius, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Circle(radius, calc);
        }

        [HttpGet]
        [Route("ellipse")]
        public ActionResult<Ellipse> Ellipse(double longRadius, double shortRadius, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Ellipse(longRadius, shortRadius, calc);
        }

        [HttpGet]
        [Route("rectangle")]
        public ActionResult<Rectangle> Rectangle(double length, double width, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Rectangle(length, width, calc);
        }

        [HttpGet]
        [Route("square")]
        public ActionResult<Square> Square(double length, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Square(length, calc);
        }


        [HttpGet]
        [Route("triangle")]
        public ActionResult<Triangle> Triangle(double width, double height, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Triangle(width, height, calc);
        }
        #endregion

        #region 3D Shapes
        [HttpGet]
        [Route("cube")]
        public ActionResult<Cube> Cube(double length, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Cube(length, calc);
        }

        [HttpGet]
        [Route("cuboid")]
        public ActionResult<Cuboid> Cuboid(double height, double length, double width, CalcTypes calc)
        {
            //calc is used for an Enum to tell the constructor what method to use
            return new Cuboid(height, width, length, calc);
        }

        [HttpGet]
        [Route("sphere")]
        public ActionResult<Sphere> Sphere(double radius, CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Sphere(radius, calc);
        }
        #endregion
    }
}
