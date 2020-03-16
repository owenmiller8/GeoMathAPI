using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models
{
    public class Sphere
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Sphere(decimal radius, _CalcTypes calc)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(radius), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(radius), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }


        public static decimal CalculateArea(decimal r)
        {
            return 4 * ((decimal)Math.PI * (decimal)Math.Pow((double)r, 2));
        }

        public static decimal CalculateVolume(decimal r)
        {
            return (4m / 3m) * ((decimal)Math.PI * (decimal)Math.Pow((double)r, 3));
        }
    }
}
