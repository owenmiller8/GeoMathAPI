using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cube
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Cube(decimal length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(length), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(length), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static decimal CalculateArea(decimal l)
        {
            return (decimal)Math.Pow((double)l, 2) * 6;
        }

        public static decimal CalculateVolume(decimal l)
        {
            return (decimal)Math.Pow((double)l, 3);
        }
    }
}
