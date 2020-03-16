using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Triangle
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Triangle(decimal width, decimal height, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = Math.Round(CalculateArea(width, height), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = Math.Round(CalculatePerimeter(width), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    break;
            }
        }

        public static decimal CalculateArea(decimal w, decimal h)
        {
            return (w * h)/2;
        }

        public static decimal CalculatePerimeter(decimal w)
        {
            return w * 3;
        }

        public static decimal CalculateHypotenuse(decimal w, decimal h)
        {
            return (decimal)Math.Pow(Math.Pow((double)w, 2) + Math.Pow((double)h, 2), 0.5);
        }
    }
}
