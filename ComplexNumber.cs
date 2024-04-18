using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct ComplexNumber
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            //(a + bi) * (c + di) = (ac - bd) + (ad + bc)i
            double newReal = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double newImaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new ComplexNumber(newReal, newImaginary);
        }

        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            //(a + bi) / (c + di) = (ac + bd) / (c^2 + d^2) + (bc - ad)i / (c^2 + d^2)
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            double newReal = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator;
            double newImaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator;
            return new ComplexNumber(newReal, newImaginary);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }
}
