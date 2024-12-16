using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int guess = 0;
        int attempts = 0;
        int ComputerNumber = random.Next(1, 101);
        Console.WriteLine("Computer chose a number between 1 and 100: ");

        while (playAgain)
        {
            guess = Convert.ToInt32(Console.ReadLine());
            if(guess == ComputerNumber)
            {
                Console.WriteLine("You win!\nDo you want to play again? (1 for yes, 0 for no)");
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1){
                    playAgain = true;
                } else{
                    playAgain = false;
                }
            }
            else if (guess > ComputerNumber)
            {
                Console.WriteLine("Computer number is lower than {0}. Try again.", guess);
            }
            else
            {
                Console.WriteLine("Computer number is higher than {0}. Try again.", guess);
            }
            
            attempts++;
        }

        Console.WriteLine("Number of attempts: {0}", attempts);
    }
}