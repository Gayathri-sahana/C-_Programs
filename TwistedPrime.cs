public class TwistedPrime
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
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
            int temp = n;
            int rev = 0;

            while (temp > 0)
            {
                int rem = temp % 10;
                rev = rev * 10 + rem;
                temp = temp / 10;
            }
            count = 0;

            for (int i = 1; i <= rev; i++)
            {
                if (rev % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Twisted Prime");
            }
            else
            {
                Console.WriteLine("Not a Twisted Prime");
            }
        }
        else
        {
            Console.WriteLine("Not a Twisted Prime");
        }
    }
}