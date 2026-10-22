public class Prime_1to100
{
    public static void Run()
    {
        Console.WriteLine("\n-------------Prime Number (1 to 100)-------------\n");
        for (int n = 1; n <= 100; n++)
        {
            int count = 0;
            
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.Write(n + " ");
            }
        }
    }
}