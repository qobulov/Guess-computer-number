using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int guess = 0;
            int attempts = 0;
            int computerNumber = random.Next(1, 101);
            Console.WriteLine("Computer chose a number between 1 and 100: ");

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                try
                {
                    guess = Convert.ToInt32(input);

                    if (guess < 1 || guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100.");
                        continue;
                    }

                    attempts++;

                    if (guess == computerNumber)
                    {
                        Console.WriteLine("You win!");
                        guessedCorrectly = true;
                    }
                    else if (guess > computerNumber)
                    {
                        Console.WriteLine("Computer number is lower than {0}. Try again.", guess);
                    }
                    else
                    {
                        Console.WriteLine("Computer number is higher than {0}. Try again.", guess);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            Console.WriteLine("Number of attempts: {0}", attempts);
            Console.Write("Do you want to play again? (1 for yes, 0 for no): ");
            
            string playAgainInput = Console.ReadLine();

            try
            {
                int ans = Convert.ToInt32(playAgainInput);
                if (ans == 1)
                {
                    playAgain = true;
                }
                else if (ans == 0)
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input! Exiting the game.");
                    playAgain = false;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Exiting the game.");
                playAgain = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
