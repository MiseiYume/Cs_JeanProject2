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
            Console.WriteLine("\nPlease insert the factored number:");
            var isNumeric2 = int.TryParse(Console.ReadLine(), out number);
            //Checking if the provided input is numeric or if it's provided at all
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            //Starting the counter to check elapsed time at the end of the execution of our commands
            Console.Clear();
            if (isNumeric == true && isNumeric2 == true)
            //Our variant of perfectly fine working input
            {
                int factorial = 1;
                if (number == 1)
                {
                    Console.WriteLine($"Factorial cannot be smaller than 1 and so the program returned {factorial}");
                }
                else 
                {
                    for (int i = number; i >= smallNumber; i--)
                    {
                        //We count our factorial here
                        factorial *= i; 
                    }
                    Console.WriteLine($"Your factorial from {smallNumber}! to {number} equals {factorial}\n");
                }
            }
            else
            //Variant of providing wrong input anywhere
            {
                if (isNumeric == false && isNumeric2 == true)
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
            }
            TimeSpan timespan = stopWatch.Elapsed;
            Console.WriteLine($"Time elapsed: {timespan}\n");
            //Read and wrote out our elapsed time 
            Console.WriteLine("Press any button to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}