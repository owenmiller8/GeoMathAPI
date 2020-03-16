using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Pyramid
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Pyramid(decimal height, decimal width, decimal length, _CalcTypes calc, _3DBases shapeBase)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(height, width, length, shapeBase);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(height, width, length, shapeBase);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        public static decimal CalculateArea(decimal height, decimal width, decimal length, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return Square.CalculateArea(height)  + (0.5m * Square.CalculatePerimeter(length) * Triangle.CalculateHypotenuse(height, 0.5m * width));
                case _3DBases.Triangle:
                    return Triangle.CalculateArea(height, width) + (0.5m * Triangle.CalculatePerimeter(width, length) * Triangle.CalculateHypotenuse(width, height));
                default:
                    return 123456m;
            }
        }

        public static decimal CalculateVolume(decimal height, decimal width, decimal length, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return (1 / 3) * Square.CalculateArea(height) * height;
                case _3DBases.Triangle:
                    return (1 / 3) * Triangle.CalculateArea(length, width) * height;
                default:
                    return 123456m;
            }
        }
    }
}