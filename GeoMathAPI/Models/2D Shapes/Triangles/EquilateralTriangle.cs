using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class EquilateralTriangle
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public EquilateralTriangle(decimal width, decimal height, _CalcTypes calc)
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
    }
}
