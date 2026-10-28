using System;

public class SecretCodeBreaker
{
    public static void Run()
    {
        Random random = new Random();
        string choice = "yes";

        while (choice == "yes")
        {
            string secret = random.Next(0, 10000).ToString("D4");
            int score = 0;
            int attempts = 0;

            Console.WriteLine("Guess the 4-digit secret code");

            while (attempts < 10)
            {
                Console.Write("Enter code: ");
                string guess = Console.ReadLine();

                if (guess.Length != 4 || !int.TryParse(guess, out _))
                {
                    Console.WriteLine("Enter exactly 4 digits.");
                    continue;
                }

                attempts++;
                int correct = 0;

                for (int i = 0; i < 4; i++)
                {
                    if (guess[i] == secret[i])
                        correct++;
                }

                Console.WriteLine("Correct positions: " + correct);
                Console.WriteLine("Remaining attempts: " + (10 - attempts));

                if (guess == secret)
                {
                    Console.WriteLine("Code Cracked!");
                    score = (11 - attempts) * 10;
                    break;
                }
            }

            if (score == 0)
                Console.WriteLine("Attempts over! Secret code: " + secret);

            Console.WriteLine("Score: " + score);

            Console.Write("Try another code? (yes/no): ");
            choice = Console.ReadLine().ToLower();
        }
    }
}