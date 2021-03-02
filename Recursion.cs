using System;
using System.Diagnostics;

namespace Recursion

{
    class RecursiveFactorial
    {
        private int processFactorial(int smallNumber, int number)
        {
            if (number < smallNumber || number <= 1)
            { 
                return 1;
            }
            else
            {
                return (number * processFactorial(smallNumber, number - 1));
            }
        }

        public void recursiveFactorial()
        {
            int smallNumber;
            int number;
            Console.WriteLine("Please insert the number you want to start with:");
            var isNumeral = int.TryParse(Console.ReadLine(), out smallNumber);
            Console.WriteLine("Please insert the factored number: ");
            var isNumeral2 = int.TryParse(Console.ReadLine(), out number);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Clear();

            if (number < 1)
            {
                Console.WriteLine($"Factorial cannot be smaller than 1 and so your {number}! returned 1");
            }
            else if (isNumeral == false)
            {
                Console.WriteLine("First input was invalid.\n");
            }
            else if (isNumeral2 == false)
            {
                Console.WriteLine("Second input was invalid.\n");
            }
            else
            { 
                int factored = processFactorial(smallNumber, number);
                Console.WriteLine($"Your factorial from {number}! equals {factored}");
            }

            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"\nTime elapsed: {timespan}");
            Console.ReadKey();
            Console.Clear();
        }
    }
}