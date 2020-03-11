using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cylinder
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Cylinder(double radius, double length, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(radius, length);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(radius, length);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        private double CalculateArea(double radius, double length)
        {
            return Math.Round(Circle.CalculateArea(radius) + (2 * Math.PI * radius * length), 3);
        }

        private double CalculateVolume(double radius, double length)
        {
            return Math.Round(Circle.CalculateArea(radius) * length, 3);
        }
    }
}
