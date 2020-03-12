using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Cone
    {
        public double SurfaceArea { get; set; }

        public double Volume { get; set; }

        public Cone(double radius, double height, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(radius, height);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(radius, height);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        public static double CalculateArea(double radius, double height)
        {
            return Math.Round(Math.PI * radius * (radius + Triangle.CalculateHypotenuse(radius, height)), 3);
        }

        public static double CalculateVolume(double radius, double length)
        {
            return Math.Round((1 / 3) * Circle.CalculateArea(radius) * length, 3);
        }
    }
}
