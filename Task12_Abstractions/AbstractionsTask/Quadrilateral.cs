using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AbstractionsTask
{
    public class Quadrilateral
    {
        public double sideA = 10;
        public double sideB = 10;
        public double sideC = 10;
        public double sideD = 10;
        public double angleA = 30;
        public double angleC = 30;

        public virtual double Perimeter => sideA + sideB + sideC + sideD;

        public virtual double Area
        {
            get
            {
                double semiPerimeter = Perimeter / 2;
                double semiPerimeterSidesMultiplied = 
                    SubtractFromSemiPerimeter(sideA) *
                    SubtractFromSemiPerimeter(sideB) *
                    SubtractFromSemiPerimeter(sideC) *
                    SubtractFromSemiPerimeter(sideD);

                double sidesMultiplied = sideA * sideB * sideC * sideD;
                double angleAYCos = Math.Cos((angleA + angleC) / 2);
                return Math.Sqrt(semiPerimeterSidesMultiplied - sidesMultiplied * angleAYCos * angleAYCos);

                double SubtractFromSemiPerimeter(double num) => semiPerimeter - num;
            }
        }
    }
}