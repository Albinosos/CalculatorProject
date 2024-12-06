using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StandardCalculator
    {
        protected double Operand1 { get; set; }
        protected double Operand2 { get; set; }

        public StandardCalculator()
        {
            Operand1 = 0;
            Operand2 = 0;
        }

        public double Add() => Operand1 + Operand2;
        public double Subtract() => Operand1 - Operand2;
        public double Multiply() => Operand1 * Operand2;
        public double Divide()
        {
            if (Operand2 == 0)
                throw new DivideByZeroException("Ділення на нуль!");
            return Operand1 / Operand2;
        }

        public void SetOperands(double operand1, double operand2)
        {
            Operand1 = operand1;
            Operand2 = operand2;
        }
    }
}