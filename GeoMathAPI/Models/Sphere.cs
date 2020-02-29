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

        public Sphere(double radius, CalcTypes calc)
        {
            switch (calc)
            {
                case CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(radius);
                    break;
                case CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(radius);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        private double CalculateArea(double r)
        {
            return Math.Round(4 * (Math.PI * Math.Pow(r, 2)), 3);
        }

        private double CalculateVolume(double r)
        {
            return Math.Round(Math.PI * (r * 2), 3);
        }
    }
}
