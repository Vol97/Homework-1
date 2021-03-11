using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter X1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter X2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"y = {(y2-y1)/(x2-x1)}x + ({-(x1*y2 - x1*y1)/(x2-x1) + y1})");
        }
    }
}
