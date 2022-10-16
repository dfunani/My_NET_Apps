using System;
using CalculatorLibrary;

namespace Calculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int lhs = 0;
            int rhs = 0;
            string op = "";

            // Display title as the C# console calculator app.
            Console.WriteLine("-------------Console Calculator in C#-----------\n");
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("---------------Author: Delali Funani------------\n");
            bool play = true;
            CalculatorOperations calculator = new CalculatorOperations();
            while (play)
            {
                Console.WriteLine("Type a number, and then press Enter>>>");

                try
                {
                    lhs = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    lhs = Convert.ToInt32(new Random().Next());
                }
                Console.WriteLine("Type a number, and then press Enter>>>");
                try
                {
                    rhs = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    rhs = Convert.ToInt32(new Random().Next());
                }
                // Ask the user to choose an option.
                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\t+ - Add");
                Console.WriteLine("\t- - Subtract");
                Console.WriteLine("\t* - Multiply");
                Console.WriteLine("\t/ - Divide");
                Console.Write("Your option? ");

                op = Console.ReadLine().ToLower();
                Console.WriteLine($"{lhs} {op} {rhs} = {calculator.Arithmetic(lhs, rhs, op)}");
                Console.WriteLine("Press 'n' and enter to continue");
                if(Console.ReadLine().ToLower() != "n")
                {
                    calculator.CleanUp();
                    break;
                }
            }

        }
    }
}
