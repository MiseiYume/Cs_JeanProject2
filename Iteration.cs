using System;
using System.Diagnostics;
namespace Iteration
{
    class IterativeFactorial
    {
        public void iterativeFactorial()
        {
            Console.WriteLine("Please insert the factored number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Clear();
            int factorial = 0;
            if (number < 2)
            {
                factorial = 1;
                Console.WriteLine($"Factorial cannot be smaller than 1 and so your {number}! returned {factorial}");
            }
            else if (number >= 2)
            {
                for (int i = 0; i < number; i++)
                {
                    factorial = (i * (i + 1));
                }
                Console.WriteLine($"Your factorial from {number}! equals {factorial}");
            }
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"\nTime elapsed: {timespan}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}