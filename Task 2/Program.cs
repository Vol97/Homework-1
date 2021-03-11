using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number A: ");
            double numberA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number B: ");
            double numberB = Convert.ToDouble(Console.ReadLine());
            double swapVariable;

            swapVariable = numberA;
            numberA = numberB;
            numberB = swapVariable;
        }
    }
}
