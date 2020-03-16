using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Square
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Square(decimal length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = CalculateArea(length);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = CalculatePerimeter(length);
                    break;
                default:
                    break;
            }
        }

        public static decimal CalculateArea(decimal length)
        {
            return (decimal)Math.Pow((double)length, 2);
        }

        public static decimal CalculatePerimeter(decimal length)
        {
            return length * 4;
        }
    }
}
