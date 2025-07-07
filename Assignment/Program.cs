namespace Assignment
{
    class Program
    {
        static void Main()
        {
            Fraction f1 = new Fraction()
            {
                Numerator = 2,
                Denominator = 3,
            };
            Fraction f2 = new Fraction()
            {
                Numerator = 5,
                Denominator = 4,
            };

            Fraction math = new Fraction();
                
            math = math.Add(f1, f2);
            math.Display();
        }
    }
}
