using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cone
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Cone(decimal radius, decimal height, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(radius, height), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(radius, height), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        public static decimal CalculateArea(decimal radius, decimal height)
        {
            return (decimal)Math.PI * radius * (radius + Triangle.CalculateHypotenuse(radius, height));
        }

        public static decimal CalculateVolume(decimal radius, decimal height)
        {
            return Circle.CalculateArea(radius) * (height / 3);
        }
    }
}
