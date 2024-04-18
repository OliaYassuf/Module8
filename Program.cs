using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|||||||||||||||||||||1||||||||||||||||||||");

            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);

            Fraction sum = fraction1 + fraction2;
            Fraction difference = fraction1 - fraction2;
            Fraction product = fraction1 * fraction2;
            Fraction quotient = fraction1 / fraction2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");

            Console.WriteLine("|||||||||||||||||||||2||||||||||||||||||||");

            ComplexNumber c1 = new ComplexNumber(1, 2);
            ComplexNumber c2 = new ComplexNumber(3, 4);

            ComplexNumber sum2 = c1 + c2;
            ComplexNumber difference2 = c1 - c2;
            ComplexNumber product2 = c1 * c2;
            ComplexNumber quotient2 = c1 / c2;

            Console.WriteLine($"Sum: {sum2}");
            Console.WriteLine($"Difference: {difference2}");
            Console.WriteLine($"Product: {product2}");
            Console.WriteLine($"Quotient: {quotient2}");

            Console.WriteLine("|||||||||||||||||||||3||||||||||||||||||||");

            Birthday birthday = new Birthday(new DateTime(2005, 4, 16));

            //birthday.Birthdate = new DateTime(2005, 4, 16);

            DayOfWeek dayOfWeekOfBirth = birthday.GetDayOfWeekOfBirth();
            Console.WriteLine($"Day of week of birth: {dayOfWeekOfBirth}");

            DayOfWeek dayOfWeekInYear = birthday.GetDayOfWeekInYear(2025);
            Console.WriteLine($"Day of week of birthday in 2025: {dayOfWeekInYear}");

            int daysUntilNextBirthday = birthday.DaysUntilNextBirthday();
            Console.WriteLine($"Days until next birthday: {daysUntilNextBirthday}");

        }
    }
}
