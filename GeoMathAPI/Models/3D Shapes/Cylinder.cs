using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cylinder
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Cylinder(decimal radius, decimal length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(radius, length), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(radius, length), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        public static decimal CalculateArea(decimal radius, decimal length)
        {
            return (2*Circle.CalculateArea(radius)) + (2 * (decimal)Math.PI * radius * length);
        }

        public static decimal CalculateVolume(decimal radius, decimal length)
        {
            return Circle.CalculateArea(radius) * length;
        }
    }
}
