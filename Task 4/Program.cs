using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number C: ");
            double numberC = Convert.ToDouble(Console.ReadLine());
            double x = (numberC - numberB) / numberA;

            Console.WriteLine($"{numberA}x + {numberB} = {numberC}");
            Console.WriteLine($"x = {x}");
        }
    }
}
