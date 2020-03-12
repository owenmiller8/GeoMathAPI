using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Pyramid
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Pyramid(double height, double width, double length, _CalcTypes calc, _3DBases shapeBase)
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

        public static double CalculateArea(double height, double width, double length, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return Math.Round(Square.CalculateArea(height)  + (0.5 * Square.CalculatePerimeter(length) * Triangle.CalculateHypotenuse(height, 0.5f * width)), 3);
                case _3DBases.Triangle:
                    return Math.Round(Triangle.CalculateArea(height, width) + (0.5 * Triangle.CalculatePerimeter(width, length) * Triangle.CalculateHypotenuse(width, height)), 3);
                default:
                    return 123456f;
            }
        }

        public static double CalculateVolume(double height, double width, double length, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return Math.Round((1 / 3) * Square.CalculateArea(height) * height, 3);
                case _3DBases.Triangle:
                    return Math.Round((1 / 3) * Triangle.CalculateArea(length, width) * height, 3);
                default:
                    return 123456f;
            }
        }
    }
}