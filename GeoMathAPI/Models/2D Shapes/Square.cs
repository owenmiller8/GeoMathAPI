using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Square
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public Square(double length, _CalcTypes calc)
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

        public static double CalculateArea(double length)
        {
            return Math.Round(Math.Pow(length, 2), 3);
        }

        public static double CalculatePerimeter(double length)
        {
            return Math.Round(length * 4, 3);
        }
    }
}
