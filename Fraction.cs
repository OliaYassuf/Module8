using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    struct Fraction
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction frac1, Fraction frac2)
        {
            int newDenominator = frac1.Denominator * frac2.Denominator;
            int newNumerator = frac1.Numerator * frac2.Denominator + frac2.Numerator * frac1.Denominator;
            return Simplify(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction frac1, Fraction frac2)
        {
            int newDenominator = frac1.Denominator * frac2.Denominator;
            int newNumerator = frac1.Numerator * frac2.Denominator - frac2.Numerator * frac1.Denominator;
            return Simplify(newNumerator, newDenominator);
        }

        public static Fraction operator *(Fraction frac1, Fraction frac2)
        {
            int newNumerator = frac1.Numerator * frac2.Numerator;
            int newDenominator = frac1.Denominator * frac2.Denominator;
            return Simplify(newNumerator, newDenominator);
        }

        public static Fraction operator /(Fraction frac1, Fraction frac2)
        {
            if (frac2.Numerator == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            int newNumerator = frac1.Numerator * frac2.Denominator;
            int newDenominator = frac1.Denominator * frac2.Numerator;
            return Simplify(newNumerator, newDenominator);
        }

        private static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private static Fraction Simplify(int numerator, int denominator)
        {
            int gcd = GCD(numerator, denominator);
            return new Fraction(numerator / gcd, denominator / gcd);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
