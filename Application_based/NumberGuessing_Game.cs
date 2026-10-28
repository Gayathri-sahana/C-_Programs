public class NumberGuessingGame
{
    public static void Run()
    {
        Random random = new Random();
        string choice = "yes";

        while (choice == "yes")
        {
            int number = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            int score = 0;

            Console.WriteLine("Guess a number between 1 and 100");

            while (attempts < 5)
            {
                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;

                if (guess == number)
                {
                    Console.WriteLine("Correct Guess!");
                    score = (6 - attempts) * 20;
                    break;
                }
                else if (guess > number)
                    Console.WriteLine("Too High!");
                else
                    Console.WriteLine("Too Low!");
            }

            if (attempts == 5 && guess != number)
                Console.WriteLine("The number was " + number);

            Console.WriteLine("Attempts: " + attempts);
            Console.WriteLine("Score: " + score);

            Console.Write("Play again? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}