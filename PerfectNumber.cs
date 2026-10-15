public class PerfectNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                Console.Write(i + " + ");
                sum += i;
            }
        }
        Console.WriteLine("= " + sum);
        if (sum == n)
        {
            Console.WriteLine(n + " is a Perfect Number");
        }
        if (sum > n)
        {
            Console.WriteLine(n + " is Abundant Number");
        }
        else
        {
            Console.WriteLine(n + " is Deficient Number");
        }
    }
}
