using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Rectangle
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Rectangle(decimal width, decimal height, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = CalculateArea(width, height);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = CalculatePerimeter(width, height);
                    break;
                default:
                    //Maybe add an issue logger?
                    break;
            }
        }

        public static decimal CalculateArea(decimal w, decimal h)
        {
            return w * h;
        }

        public static decimal CalculatePerimeter(decimal w, decimal h)
        {
            return (w * 2) + (h * 2);
        }
    }
}
