using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Sphere
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Sphere(double radius, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(radius);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(radius);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static double CalculateArea(double r)
        {
            return Math.Round(4 * (Math.PI * Math.Pow(r, 2)), 3);
        }

        public static double CalculateVolume(double r)
        {
            return Math.Round((4 / 3) * (Math.PI * Math.Pow(r, 3)), 3);
        }
    }
}
