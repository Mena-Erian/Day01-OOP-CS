namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car();

            c1.Price = 1000;
            c2.Price = 2000;

            c1.MoveForward();

            c1.Display();
            c2.Display();

        }
    }
}
