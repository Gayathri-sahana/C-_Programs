public class NeonNumber
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int sq = n * n, sum = 0, rem;

        while (sq > 0)
        {
            rem = sq % 10;
            sum = sum + rem;
            sq = sq / 10;
        }

        if (sum == n)
            Console.WriteLine("Neon Number");
        else
            Console.WriteLine("Not Neon Number");
    }
}