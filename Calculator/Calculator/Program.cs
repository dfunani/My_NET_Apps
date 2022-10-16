using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lhs = 0;
            int rhs = 0;


            // Display title as the C# console calculator app.
            Console.WriteLine("-------------Console Calculator in C#-----------\n");
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("---------------Author: Delali Funani------------\n");


            Console.WriteLine("Type a number, and then press Enter\n>");

            try
            {
                lhs = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                lhs = Convert.ToInt32(new Random().Next());
            }

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
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            Console.WriteLine($"{lhs} {rhs}");
            switch (Console.ReadLine().ToLower())
            {
                case "a":
                    Console.WriteLine(lhs + rhs);
                    break;
                case "s":
                    Console.WriteLine(lhs - rhs);
                    break;
                case "m":
                    Console.WriteLine(lhs* rhs);
                    break;
                case "d":
                    if (rhs == 0)
                    {
                        Console.WriteLine("Undefined");
                    }
                    else
                    {
                        Console.WriteLine(lhs / rhs);
                    }
                    break;
            }

        }
    }
}
