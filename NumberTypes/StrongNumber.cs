public class StrongNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int temp = n, sum = 0, rem;

        while (temp > 0)
        {
            rem = temp % 10;
            int fact = 1;
            for (int i = 1; i <= rem; i++)
                fact = fact * i;

            sum = sum + fact;
            temp = temp / 10;
        }

        if (sum == n)
            Console.WriteLine("Strong Number");
        else
            Console.WriteLine("Not Strong Number");
    }
}