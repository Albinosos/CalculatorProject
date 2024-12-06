using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EngineeringCalculator : StandardCalculator
    {
        public EngineeringCalculator() : base() { }

        public double Exp()
        {
            if (Operand1 < -5 || Operand1 > 5)
                throw new ArgumentOutOfRangeException("Аргумент операції exp повинен бути в межах від -5 до 5!");
            return Math.Exp(Operand1);
        }

        public double SinInDegrees()
        {
            // Перетворення градусів у радіани
            double radians = DegreesToRadians(Operand1);
            return Math.Sin(radians);
        }

        public double CosInDegrees()
        {
            // Перетворення градусів у радіани
            double radians = DegreesToRadians(Operand1);
            return Math.Cos(radians);
        }

        private double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        private double RadiansToDegrees(double radians)
        {
            return radians * 180 / Math.PI;
        }
    }
}
