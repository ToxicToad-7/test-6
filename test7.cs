using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Generates a number between 1 and 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 100.");
            Console.WriteLine("Try to guess it!");

            while (guess != targetNumber)
            {
                Console.Write("Enter your guess: ");
                
                // Error handling for non-integer input
                if (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
        }
    }
}
