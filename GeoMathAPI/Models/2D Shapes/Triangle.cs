using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Triangle
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public Triangle(double width, double height, _CalcTypes calc)
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
                    break;
            }
        }

        public static double CalculateArea(double w, double h)
        {
            return Math.Round((w * h)/2, 3);
        }

        private double CalculatePerimeter(double w, double h)
        {
            double hypotenuse = Math.Pow(Math.Pow(w, 2) + Math.Pow(h, 2), 0.5);
            return Math.Round(hypotenuse + w + h, 3);
        }
    }
}
