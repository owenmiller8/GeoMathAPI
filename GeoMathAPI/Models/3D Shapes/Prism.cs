using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Prism
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Prism(decimal height, decimal width, decimal length, _CalcTypes calc, _3DBases shapeBase)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(height, width, length, shapeBase), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(height, width, length, shapeBase), 3, MidpointRounding.AwayFromZero);
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
                    return (Square.CalculateArea(height) * 2) + (Rectangle.CalculateArea(height, length) * 4);
                case _3DBases.Triangle:
                    return (Triangle.CalculateArea(height, width) * 2) + (Rectangle.CalculateArea(width, length) * 3);
                default:
                    return 123456m;
            }
        }

        public static decimal CalculateVolume(decimal height, decimal width,  decimal length, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return Math.Round(Square.CalculateArea(height) * length, 3);
                case _3DBases.Triangle:
                    return Math.Round(Triangle.CalculateArea(height, width) * length, 3);
                default:
                    return 123456m;
            }
        }
    }
}
