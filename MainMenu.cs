using System;
using Iteration;
using Recursion;
namespace Menu
{
    public class MainMenu           //Function introducing a main menu of the program
    {
        public static void MakeDecision()
        {
            int decision = 42;
            while (decision != 0)
            {
                Console.WriteLine("Please tell me what you'd like to do:\n1 for iterative factorial\n2 for recursive factorial\n0 to stop the program");
                var isNumber = int.TryParse(Console.ReadLine(), out decision);
                /*While Convert didn't work as good as expected 
                (program breaking down after providing input like
                [Enter] or literal char) we're now first checking 
                if the input can get parsed into int.
                And then basing on our input we're calling out our methods*/
                if (isNumber == true)
                {
                    switch(decision)
                {
                    case 1:     //Iterative variant 
                        Console.Clear();
                        IterativeFactorial Iteration = new IterativeFactorial();
                        Iteration.iterativeFactorial();
                        break;
                    case 2:     //Recursive variant 
                            Console.Clear();
                        RecursiveFactorial Recursion = new RecursiveFactorial();
                        Recursion.recursiveFactorial();
                        break;
                    case 0:     //Closing the program
                        Console.WriteLine("Stopping the program...\n");
                        break;
                    default:    //Telling our user that selected option was not on the list
                        Console.Clear();
                        Console.WriteLine("Select the proper menu option.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
                else
                {               //Telling our user that the input was incorrect
                    decision = 42;
                    Console.Clear();
                    Console.WriteLine("Provide a proper input or get out of here.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}