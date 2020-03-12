using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Ellipse
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public Ellipse(double longRadius, double shortRadius, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = CalculateArea(longRadius, shortRadius);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = CalculatePerimeter(longRadius, shortRadius);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static double CalculateArea(double l, double s)
        {
            return Math.Round(Math.PI * l * s, 3);
        }

        /// <summary>
        /// Horrible calculation to use but it was the most accurate one without using infinity
        /// </summary>
        /// <param name="l"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double CalculatePerimeter(double l, double s)
        {
            var h = Math.Pow(l - s, 2) / Math.Pow(l - s, 2);
            return Math.Round((Math.PI * (l + s)) * (1 + ((3 * h) / (10 + Math.Pow(4 + (3 * h), 0.5)))), 3);
        }
    }
}
