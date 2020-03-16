using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Ellipse
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Ellipse(decimal longRadius, decimal shortRadius, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = Math.Round(CalculateArea(longRadius, shortRadius), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = Math.Round(CalculatePerimeter(longRadius, shortRadius), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static decimal CalculateArea(decimal l, decimal s)
        {
            return (decimal)Math.PI * l * s;
        }

        /// <summary>
        /// Horrible calculation to use but it was the most accurate one without using infinity
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static decimal CalculatePerimeter(decimal l, decimal s)
        {
            var h = (decimal)Math.Pow((double)(l - s), 2) / (decimal)Math.Pow((double)(l - s), 2);
            return (decimal)Math.PI * (l + s) * (1 + ((3 * h) / (10 + (decimal)Math.Pow((double)(4 + (3 * h)), 0.5))));
        }
    }
}
