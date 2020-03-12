using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cube
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Cube(double length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(length);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(length);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static double CalculateArea(double l)
        {
            return Math.Round(Math.Pow(l, 2) * 6, 3);
        }

        public static double CalculateVolume(double l)
        {
            return Math.Round(Math.Pow(l, 3), 3);
        }
    }
}
