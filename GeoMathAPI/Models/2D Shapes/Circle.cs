using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Circle
    {
        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Circle(decimal radius, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = Math.Round(CalculateArea(radius), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = Math.Round(CalculatePerimeter(radius), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }
        

        public static decimal CalculateArea(decimal r)
        {
            return (decimal)Math.PI * (decimal)Math.Pow((double)r, 2f);
        }

        public static decimal CalculatePerimeter(decimal r)
        {
            return (decimal)Math.PI * (r * 2);
        }
    }
}
