using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cuboid
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Cuboid(double height, double width, double length, _CalcTypes calc)
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


        public static double CalculateArea(double height, double width, double length)
        {
            return Math.Round((height * width * 2) + (width * length * 2) + (height * length * 2), 3);
        }

        public static double CalculateVolume(double height, double width, double length)
        {
            return Math.Round(height * width * length, 3);
        }
    }
}
