using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Rectangle
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public Rectangle(double width, double height, _CalcTypes calc)
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

        public static double CalculateArea(double w, double h)
        {
            return Math.Round(w * h, 3);
        }

        public static double CalculatePerimeter(double w, double h)
        {
            return Math.Round((w * 2) + (h * 2), 3);
        }
    }
}
