using System;
using System.Diagnostics;
namespace Recursion
{
    class RecursiveFactorial
    {
        private int processFactorial(int number)
        {
            if (number == 1)
            { 
                return 1;
            }
            else
            {
                return (number * processFactorial(number - 1));
            }
        }
        public void recursiveFactorial()
        {
            Console.WriteLine("Please insert the factored number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Clear();
            if (number < 1)
            {
                Console.WriteLine($"Factorial cannot be smaller than 1 and so your {number}! returned 1");
            }
            else
            { 
                int factored = processFactorial(number);
                Console.WriteLine($"Your factorial from {number}! equals {factored}");
            }
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"\nTime elapsed: {timespan}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}