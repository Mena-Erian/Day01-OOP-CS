using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Car
    {
        // Member Variables
        public double Price;
        string Number;

        public void MoveForward()
        {
            Price = 10;
            Number = "123";
        }

        void Stop()
        {
        
        }

        public void Display()
        {
            Console.WriteLine("Number: {0}\t Price: {1}", Number, Price);
            Console.WriteLine($"Number: {Number} \t Price: {Price}");
        }

    }
}
