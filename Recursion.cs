using System;
using System.Diagnostics;
namespace Recursion
{
    class RecursiveFactorial
    {
        public void recursiveFactorial()
        {
            Console.WriteLine("Please insert the factored number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            int firstNumber = number;
            int processFactorial(int number)
            {
                if (number > 2)
                {
                    return (number * processFactorial(number - 1));
                }
                else return 1;
            }
            int lastNumber = processFactorial(number);
            Console.WriteLine($"Your factorial from {firstNumber}! equals {lastNumber}");
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"\nTime elapsed: {timespan}");
        }
    }
}