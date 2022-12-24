// See https://aka.ms/new-console-template for more information

using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int count = 0;
            int random = randNum.Next(100);
            Console.WriteLine("Guess a number between 0 and 100, in 10 guesses");
            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < random)
                {
                    Console.WriteLine("Too low, guess again!");
                }
                else if(guess > random)
                {
                    Console.WriteLine("Too High, guess again!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That is the right Guess. You Win!!!");
                    break;
                }
                count++;
                if(count > 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("You're out of guesses. You lose!!!");
                    break;
                }
                Console.WriteLine();
            }
            Console.Write($"After {count} invalid guesses, Random Number was: {random}");
        }
    }
}