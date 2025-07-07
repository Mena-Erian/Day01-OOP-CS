using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Point
    {
        public int X;
        public int Y;
        public int Z;

        public int CalculateDistance(Point p1,Point p2)
        {
            return p2.X - p1.X;
        }
        public void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Z = {Z}");
        } 
    }
}
