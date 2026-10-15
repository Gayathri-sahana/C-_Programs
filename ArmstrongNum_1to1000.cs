public class ArmstrongNum_1to1000
{
    public static void Run()
    {
        Console.WriteLine("\n-------------Armstrong Number (1 to 1000)-------------\n");
        for (int n = 1; n <= 1000; n++)
        {
            int temp = n, sum = 0, rem, count = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }
            temp = n;

            while (temp > 0)
            {
                rem = temp % 10;
                int p = 1;

                for (int i = 1; i <= count; i++)
                {
                    p = p * rem;
                }

                sum = sum + p;
                temp = temp / 10;
            }
            if (sum == n)
            {
                Console.WriteLine(n );
            }
        }
    }
}
