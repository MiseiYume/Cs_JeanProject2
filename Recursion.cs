using System;
using System.Diagnostics;

namespace Recursion

{
    class RecursiveFactorial
    {
        private int processFactorial(int smallNumber, int number)
        /*Recursive method counting the factorial from provided variable smallNumber
        to variable number*/
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
            var isNumeric = int.TryParse(Console.ReadLine(), out smallNumber);
            Console.WriteLine("\nPlease insert the factored number: ");
            var isNumeric2 = int.TryParse(Console.ReadLine(), out number);
            //Once again TryParse method to avoid crashing
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Clear();
            /*Created object stopWatch to measure the time of execution of commands below
            Those are checking both our TryParse results and provided ints afterwards*/
            if (number < 1 && isNumeric == true && isNumeric2 == true)
            {
                Console.WriteLine($"Factorial cannot be smaller than 1 and so the program returned 1");
            }
            else if (isNumeric == false && isNumeric2 == true)
            {
                Console.WriteLine("First input was invalid.\n");
            }
            else if (isNumeric == true && isNumeric2 == false)
            {
                Console.WriteLine("Second input was invalid.\n");
            }
            else if (isNumeric == false && isNumeric2 == false)
            {
                Console.WriteLine("Both inputs were invalid.\n");
            }
            else
            { 
                int factorial = processFactorial(smallNumber, number); //We're counting our factorial here
                Console.WriteLine($"Your factorial from {smallNumber}! to {number} equals {factorial}");
            }
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"\nTime elapsed: {timespan}\n");
            //Writing down the elapsed time
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}