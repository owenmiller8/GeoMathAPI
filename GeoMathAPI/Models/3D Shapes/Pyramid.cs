﻿using GeoMathAPI.Models._2D_Shapes.Triangles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeoMathAPI.Models._3D_Shapes
{
    public class Pyramid
    {
        public decimal SurfaceArea { get; set; }

        public decimal Volume { get; set; }

        public Pyramid(decimal length, decimal width, decimal height, _CalcTypes calc, _3DBases shapeBase)
        {
            switch (calc)
            {
                case _CalcTypes.AreaCalc:
                    SurfaceArea = Math.Round(CalculateArea(length, width, height, shapeBase), 3, MidpointRounding.AwayFromZero);
                    break;
                case _CalcTypes.VolumeCalc:
                    Volume = Math.Round(CalculateVolume(length, width, height, shapeBase), 3, MidpointRounding.AwayFromZero);
                    break;
                default:
                    //Perhaps log an issue here?
                    break;
            }
        }

        public static decimal CalculateArea(decimal length, decimal width, decimal height, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return Square.CalculateArea(length) + (0.5m * Square.CalculatePerimeter(length) * Right_AngledTriangle.CalculateHypotenuse(height, 0.5m * length));
                case _3DBases.Triangle:
                    return EquilateralTriangle.CalculateArea(length, width) + (0.5m * EquilateralTriangle.CalculatePerimeter(width) * Right_AngledTriangle.CalculateHypotenuse(width, height));
                default:
                    return 123456m;
            }
        }

        public static decimal CalculateVolume(decimal length, decimal width, decimal height, _3DBases b)
        {
            switch (b)
            {
                case _3DBases.Square:
                    return (1m / 3m) * Square.CalculateArea(length) * height;
                case _3DBases.Triangle:
                    return (1m / 3m) * EquilateralTriangle.CalculateArea(length, width) * height;
                default:
                    return 123456m;
            }
        }
    }
}