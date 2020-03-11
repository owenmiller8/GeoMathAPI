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

        public Cube(double length, CalcTypes calc)
        {
            switch (calc)
            {
                case CalcTypes.AreaCalc:
                    SurfaceArea = CalculateArea(length);
                    break;
                case CalcTypes.VolumeCalc:
                    Volume = CalculateVolume(length);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        private double CalculateArea(double l)
        {
            return Math.Round(Math.Pow(l, 2) * 6, 3);
        }

        private double CalculateVolume(double l)
        {
            return Math.Round(Math.Pow(l, 3), 3);
        }
    }
}
