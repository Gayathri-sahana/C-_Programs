public class PerfectNum_1to100
{
    public static void Run()
    {
        Console.WriteLine("\n-------------Perfect Number (1 to 100)-------------\n");
        for (int n = 1; n <= 100; n++)
        {
            int sum = 0;

            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine(n + " ");
            }
        }
    }
}