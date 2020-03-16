using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cuboid
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Cuboid(decimal height, decimal width, decimal length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(height, width, length);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(height, width, length);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static decimal CalculateArea(decimal height, decimal width, decimal length)
        {
            return (height * width * 2) + (width * length * 2) + (height * length * 2);
        }

        public static decimal CalculateVolume(decimal height, decimal width, decimal length)
        {
            return height * width * length;
        }
    }
}
