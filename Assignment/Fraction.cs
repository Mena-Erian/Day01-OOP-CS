using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Fraction
    {
        public decimal Numerator;
        public decimal Denominator;

        
        public void Display()
        {
            decimal Result = (Numerator / Denominator);
            Console.WriteLine($"{Numerator}/{Denominator} = {Result}");
        }
        public Fraction Add(Fraction f1, Fraction f2)
        {
            //double results = ((f1.Numerator * f2.Denominator) + (f1.Denominator * f2.Numerator)) /
            //                                  f1.Denominator * f2.Denominator;

            Fraction result = new Fraction()
            {
                Numerator = f1.Numerator * f2.Denominator + f1.Denominator * f2.Numerator,
                Denominator = f1.Denominator * f2.Denominator,
            };
            return result;
        }

    }
}
