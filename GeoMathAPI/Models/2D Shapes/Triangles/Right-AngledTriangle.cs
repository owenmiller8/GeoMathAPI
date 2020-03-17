using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._2D_Shapes.Triangles
{
    public class Right_AngledTriangle
    {

        public decimal Area { get; set; }

        public decimal Perimeter { get; set; }

        public Right_AngledTriangle(decimal width, decimal height, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    Area = Math.Round(CalculateArea(width, height), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.PerimeterCalc:
                    Perimeter = Math.Round(CalculatePerimeter(width, height), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    break;
            }
        }

        public static decimal CalculateArea(decimal w, decimal h)
        {
            return (w * h) / 2;
        }

        public static decimal CalculatePerimeter(decimal w, decimal h)
        {
            return w + h + CalculateHypotenuse(w, h);
        }

        public static decimal CalculateHypotenuse(decimal a, decimal b)
        {
            return (decimal)Math.Pow(Math.Pow((double)a, 2f) + Math.Pow((double)b, 2f), 0.5);
        }
    }
}
