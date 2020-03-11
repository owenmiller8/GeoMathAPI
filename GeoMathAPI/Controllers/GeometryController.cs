using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeoMathAPI.Models;

namespace GeoMathAPI.Controllers
{
    [Route("api/geometry")]
    [ApiController]
    public class GeometryController : ControllerBase
    {
        /// <summary>
        /// Based on calc parameter, returns area or perimeter of a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="calc"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("circle")]
        public ActionResult<Circle> Circle(double radius, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Circle(radius, calc);
        }

        [HttpGet]
        [Route("triangle")]
        public ActionResult<Triangle> Triangle(double width, double height, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Triangle(width, height, calc);
        }

        [HttpGet]
        [Route("ellipse")]
        public ActionResult<Ellipse> Ellipse(double longRadius, double shortRadius, _CalcTypes calc)
        {
            //calc is used for an Enum to tell the Circle constructor what method to use
            return new Ellipse(longRadius, shortRadius, calc);
        }
    }
}
