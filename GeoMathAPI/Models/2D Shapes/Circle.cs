using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Circle
    {
        public double Area { get; set; }

        public double Perimeter { get; set; }

        public Circle(double radius, CalcTypes calc)
        {
            switch (calc)
            {
                case CalcTypes.AreaCalc:
                    Area = CalculateArea(radius);
                    break;
                case CalcTypes.PerimeterCalc:
                    Perimeter = CalculatePerimeter(radius);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }
        

        private double CalculateArea(double r)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2), 3);
        }

        private double CalculatePerimeter(double r)
        {
            return Math.Round(Math.PI * (r * 2), 3);
        }
    }
}
