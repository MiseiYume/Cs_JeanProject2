using System;
using System.Diagnostics;
namespace Iteration
{
    class IterativeFactorial
    {
        public void iterativeFactorial()
        {
            int smallNumber;
            int number;
            Console.WriteLine("Please insert the number you want to start with:");
            var isNumeric = int.TryParse(Console.ReadLine(), out smallNumber);
            Console.WriteLine("Please insert the factored number:");
            var isNumeric2 = int.TryParse(Console.ReadLine(), out number);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Clear();
            if (isNumeric == true && isNumeric2 == true)
            {
                int factorial = 1;
                if (number == 1)
                {
                    Console.WriteLine($"Factorial cannot be smaller than 1 and so your {number}! returned {factorial}");
                }
                else 
                {
                    for (int i = number; i >= smallNumber; i--)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Your factorial from {number}! equals {factorial}");
                }
            }
            else
            {
                if (isNumeric == false)
                {
                    Console.WriteLine("First input was invalid.\n");
                }
                else if (isNumeric2 == false)
                    {
                    Console.WriteLine("Second input was invalid.\n");
                }
                TimeSpan timespan = stopWatch.Elapsed;
                Console.WriteLine($"\nTime elapsed: {timespan}");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}