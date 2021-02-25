using System;
using Iteration;
using Recursion;
namespace menu
{
    public class MainMenu
    {
        public static void MakeDecision()
        {
            int decision = 42;
            while (decision != 0)
            {
                Console.WriteLine("Please tell me what you'd like to do:\n1 for iterative factorial\n2 for recursive factorial\n0 to stop the program");
                decision = Convert.ToInt32(Console.ReadLine());
                switch (decision)
                {
                    case 1:
                        Console.Clear();
                        IterativeFactorial Iteration = new IterativeFactorial();
                        Iteration.iterativeFactorial();
                        break;
                    case 2:
                        Console.Clear();
                        RecursiveFactorial Recursion = new RecursiveFactorial();
                        Recursion.recursiveFactorial();
                        break;
                    case 0:
                        Console.WriteLine("Stopping the program...\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select the proper option or get out of here.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}