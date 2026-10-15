public class PrimeComposite
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int c = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                c++;
                if (c > 2)
                {
                    break;
                }
            }
        }

        if (c > 2)
        {
            Console.WriteLine("Composite Number");
        }
        else
        {
            Console.WriteLine("Prime Number");
        }
    }
}
